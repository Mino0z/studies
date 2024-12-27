using Microsoft.AspNetCore.Mvc;
using Jakub_Minorczyk.Services;
using Jakub_Minorczyk.Models;

namespace Jakub_Minorczyk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
     public class CpuController : ControllerBase
    {
        private readonly MemoryService _memoryService;

        public CpuController(MemoryService memoryService)
        {
            _memoryService = memoryService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] CpuModel formData)
        {
            ushort[] memory = _memoryService.GetMemory();
            
            CpuModel cpu = new CpuModel();
            cpu.AX = formData.AX;
            cpu.BX = formData.BX;
            cpu.CX = formData.CX;
            cpu.DX = formData.DX;
            cpu.BP = formData.BP;
            cpu.DI = formData.DI;
            cpu.SI = formData.SI;
            cpu.SP = formData.SP;
            cpu.Offset = formData.Offset;
            cpu.Command = formData.Command;
            cpu.Register = formData.Register;
            cpu.RegisterMem = formData.RegisterMem;
            cpu.RegisterPushPop = formData.RegisterPushPop;
            cpu.addressingMode = formData.addressingMode;
            cpu.memory = memory;
            cpu.memoryAddress = formData.memoryAddress;
            
            
            string? result = string.Empty;
            CpuService cpuService = new CpuService();
            CpuModel? resultCpu = new CpuModel();
            resultCpu = null;
            
            if(cpu.Command == "MOV")
            {
                resultCpu = cpuService.ExecuteMov(cpu.AX, cpu.BX, cpu.CX, cpu.DX, cpu.Register ?? "AX AX") ?? new CpuModel();  
            }
            if (cpu.Command == "XCHG")
            {
                resultCpu = cpuService.ExecuteXchg(cpu.AX, cpu.BX, cpu.CX,  cpu.DX, cpu.Register ?? "AX AX") ?? new CpuModel();
            }
            if (cpu.Command == "MOV_MEM"){
                resultCpu = cpuService.ExecuteMovMem(cpu.AX, cpu.BX, cpu.CX, cpu.DX, cpu.RegisterMem ?? "AX MEM", memory, 0x1000, cpu.addressingMode ?? "base",cpu.baseRegister ?? "BP",cpu.indexRegister ?? "SI", cpu.BP, cpu.DI, cpu.SI, cpu.Offset);    
                memory = resultCpu?.memory;

            }
            if (cpu.Command == "XCHG_MEM"){
                resultCpu = cpuService.ExecuteXchgMem(cpu.AX, cpu.BX, cpu.CX, cpu.DX, cpu.RegisterMem ?? "AX MEM", memory, 0x1000, cpu.addressingMode ?? "base",cpu.baseRegister ?? "BP",cpu.indexRegister ?? "SI", cpu.BP, cpu.DI, cpu.SI, cpu.Offset);
                memory = resultCpu?.memory;

            }
              if (cpu.Command == "PUSH")
    {
        resultCpu = cpuService.ExecutePush(cpu.AX, cpu.BX, cpu.CX, cpu.DX, memory, cpu.SP, cpu.RegisterPushPop ?? "AX");
    }

    if (cpu.Command == "POP")
    {
        cpu = cpuService.ExecutePop(memory, cpu.SP, cpu.RegisterPushPop ?? "AX");
    }
            return Ok(new 
            {
                message = "Data received successfully",
                receivedData = formData,
                result = resultCpu,
                processedValue1 = resultCpu?.AX.ToString("X"),  
                processedValue2 = resultCpu?.BX.ToString("X"),  
                processedValue3 = resultCpu?.CX.ToString("X"),  
                processedValue4 = resultCpu?.DX.ToString("X"), 
                processedStack = resultCpu?.memory?.Skip(resultCpu.SP != 0 ? resultCpu.SP : 0).Take(10).ToList(),

                processedSP = resultCpu?.SP.ToString("X"),
                memory = resultCpu?.memory,
                calculatedAddress = resultCpu?.memoryAddress?.ToString("X"),
                calculatedValue = resultCpu?.memory?[resultCpu.memoryAddress ?? 0].ToString("X"),
                processMethod = cpu?.Command, 
                memoryValue2 = resultCpu?.memoryValue?.ToString("X")
            });
    }

    
}
}
