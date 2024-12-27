using System;
using System.Security.Cryptography.X509Certificates;
using Jakub_Minorczyk.Models;

namespace Jakub_Minorczyk.Services
{
    public class MemoryService
{
    private readonly ushort[] memory = new ushort[65536];

    public ushort[] GetMemory() => memory;
}
    public class CpuService
    {
        
        public CpuModel ExecuteMov(ushort AX, ushort BX, ushort CX, ushort DX, string Register){
            switch (Register)
            {
                case "AX AX":
                    break;
                case "AX BX":
                    AX = BX; 
                    break;
                case "AX CX":
                    AX = CX; 
                    break;
                case "AX DX":
                    AX = DX; 
                    break;
                case "BX AX":
                    BX = AX; 
                    break;
                case "BX BX": 
                    break;
                case "BX CX":
                    BX = CX; 
                    break;
                case "BX DX":
                    BX = DX; 
                    break;
                case "CX AX":
                    CX = AX; 
                    break;
                case "CX BX":
                    CX = BX; 
                    break;
                case "CX CX": 
                    break;
                case "CX DX":
                    CX = DX; 
                    break;
                case "DX AX":
                    DX = AX; 
                    break;
                case "DX BX":
                    DX = BX; 
                    break;
                case "DX CX":
                    DX = CX; 
                    break;
                case "DX DX":

                    break;
            }

    // Zwracamy zaktualizowany model
    return new CpuModel
    {
        AX = AX,
        BX = BX,
        CX = CX,
        DX = DX,
    };
            

            
        }
        public CpuModel ExecuteXchg( ushort AX,  ushort BX,  ushort CX, ushort DX, string Register)
{
    ushort temp; 

    switch (Register)
    {
        case "AX BX":
            temp = AX;
            AX = BX;
            BX = temp;
            break;
        case "AX CX":
            temp = AX;
            AX = CX;
            CX = temp;
            break;
        case "AX DX":
            temp = AX;
            AX = DX;
            DX = temp;
            break;
        case "BX CX":
            temp = BX;
            BX = CX;
            CX = temp;
            break;
        case "BX DX":
            temp = BX;
            BX = DX;
            DX = temp;
            break;
        case "CX DX":
            temp = CX;
            CX = DX;
            DX = temp;
            break;
        default:
            break; 
    }

    return new CpuModel { 
        AX = AX, 
        BX = BX, 
        CX = CX, 
        DX = DX
    };
}

    public CpuModel ExecuteMovMem(ushort AX, ushort BX, ushort CX, ushort DX, string RegisterMem, ushort[] memory, int address = 0, string addressingMode = "base",string baseRegister = "BP", string indexRegister = "SI", ushort BP = 0, ushort DI = 0, ushort SI = 0, ushort Offset = 0)
{
    int computedAddress = address;

    switch (addressingMode)
    {
        case "base":
            if (baseRegister == "BP")
            {
            computedAddress = BP + Offset;  
            
            }
            else if (baseRegister == "BX")
            {
                computedAddress = BX + Offset;  
            }
            break;
        case "index":
            
            if (indexRegister == "SI")
            {
                computedAddress = SI + Offset;  
            }
            else if (indexRegister == "DI")
            {
                computedAddress = DI + Offset;  
            }
            break;
        case "indexed_base":
            
            if (baseRegister == "BP")
            {
                if (indexRegister == "SI")
                {
                    computedAddress = BP + SI + Offset;  
                }
                else if (indexRegister == "DI")
                {
                    computedAddress = BP + DI + Offset;  
                }
            }
            else if (baseRegister == "BX")
            {
                if (indexRegister == "SI")
                {
                    computedAddress = BX + SI + Offset;  
                }
                else if (indexRegister == "DI")
                {
                    computedAddress = BX + DI + Offset;  
                }
            }
            break;
        default:
            throw new InvalidOperationException("Unknown addressing mode.");
    }
    if (computedAddress < 0 || computedAddress >= memory.Length)
    {
        throw new IndexOutOfRangeException($"Computed address {computedAddress} is out of memory bounds.");
    }

    
    switch (RegisterMem)
    {
        case "AX MEM":
            AX = memory[computedAddress];
            break;
        case "BX MEM":
            BX = memory[computedAddress];
            break;
        case "CX MEM":
            CX = memory[computedAddress];
            break;
        case "DX MEM":
            DX = memory[computedAddress];
            break;
        case "MEM AX":
            memory[computedAddress] = AX;
            break;
        case "MEM BX":
            memory[computedAddress] = BX;
            break;
        case "MEM CX":
            memory[computedAddress] = CX;
            break;
        case "MEM DX":
            memory[computedAddress] = DX;
            break;
        default:
            throw new InvalidOperationException("Unknown register for memory operation.");
    }
                
    
    return new CpuModel
    {
        AX = AX,
        BX = BX,
        CX = CX,
        DX = DX,
        memory = memory,
        memoryAddress = (ushort)computedAddress, 
        memoryValue = memory[computedAddress],
        Command = "MOV_MEM"
    };
}
public CpuModel ExecuteXchgMem(ushort AX, ushort BX, ushort CX, ushort DX, string RegisterMem, ushort[] memory, int address = 0, string addressingMode = "base",string baseRegister = "BP", string indexRegister = "SI", ushort BP = 0, ushort DI = 0, ushort SI = 0, ushort Offset = 0)
{
    int computedAddress = address;
    switch (addressingMode)
    {
        case "base":
            if (baseRegister == "BP")
            {
            computedAddress = BP + Offset;  
            
            }
            else if (baseRegister == "BX")
            {
                computedAddress = BX + Offset;  
            }
            break;
        case "index":
            
            if (indexRegister == "SI")
            {
                computedAddress = SI + Offset;  
            }
            else if (indexRegister == "DI")
            {
                computedAddress = DI + Offset;  
            }
            break;
        case "indexed_base":
            
            if (baseRegister == "BP")
            {
                if (indexRegister == "SI")
                {
                    computedAddress = BP + SI + Offset;  
                }
                else if (indexRegister == "DI")
                {
                    computedAddress = BP + DI + Offset;  
                }
            }
            else if (baseRegister == "BX")
            {
                if (indexRegister == "SI")
                {
                    computedAddress = BX + SI + Offset;  
                }
                else if (indexRegister == "DI")
                {
                    computedAddress = BX + DI + Offset;  
                }
            }
            break;
        default:
            throw new InvalidOperationException("Unknown addressing mode.");
    }

   if (computedAddress < 0 || computedAddress >= memory.Length)
    {
        throw new IndexOutOfRangeException($"Computed address {computedAddress} is out of memory bounds.");
    }

    switch (RegisterMem)
    {
        case "AX MEM":
            ushort tempAX = AX;
            AX = memory[computedAddress];
            memory[computedAddress] = tempAX;
            break;
        case "BX MEM":
            ushort tempBX = BX;
            BX = memory[computedAddress];
            memory[computedAddress] = tempBX;
            break;
        case "CX MEM":
            ushort tempCX = CX;
            CX = memory[computedAddress];
            memory[computedAddress] = tempCX;
            break;
        case "DX MEM":
            ushort tempDX = DX;
            DX = memory[computedAddress];
            memory[computedAddress] = tempDX;
            break;
        case "MEM AX":
            ushort tempMemAX = memory[computedAddress];
            memory[computedAddress] = AX;
            AX = tempMemAX;
            break;
        case "MEM BX":
            ushort tempMemBX = memory[computedAddress];
            memory[computedAddress] = BX;
            BX = tempMemBX;
            break;
        case "MEM CX":
            ushort tempMemCX = memory[computedAddress];
            memory[computedAddress] = CX;
            CX = tempMemCX;
            break;
        case "MEM DX":
            ushort tempMemDX = memory[computedAddress];
            memory[computedAddress] = DX;
            DX = tempMemDX;
            break;
        default:
            throw new InvalidOperationException("Unknown register for XCHG operation.");
    }

    return new CpuModel
    {
        AX = AX,
        BX = BX,
        CX = CX,
        DX = DX,
        memoryAddress = (ushort)computedAddress,
        memory = memory,
        Command = "XCHG_MEM"
    };
}
public CpuModel ExecutePush(ushort AX, ushort BX, ushort CX, ushort DX, ushort[] memory, ushort SP, string RegisterToPush)
{
    ushort ValueToPush = 0;

    switch (RegisterToPush)
    {
        case "AX":
            ValueToPush = AX;
            break;
        case "BX":
            ValueToPush = BX;
            break;
        case "CX":
            ValueToPush = CX;
            break;
        case "DX":
            ValueToPush = DX;
            break;
        default:
            throw new InvalidOperationException("Invalid register for PUSH");
    }

    if (SP > 0)
    {
        memory[SP] = ValueToPush;
        SP--;
    }
    else
    {
        throw new InvalidOperationException("Stack overflow.");
    }

    return new CpuModel
    {
        AX = AX,
        BX = BX,
        CX = CX,
        DX = DX,
        SP = SP,
        memory = memory,
        Command = "PUSH"
    };
}



public CpuModel ExecutePop(ushort[] memory, ushort SP, string RegisterToPop)
{
    ushort ValuePopped = 0;

    if (SP < 65535)
    {
        SP++;
        ValuePopped = memory[SP];
    }
    else
    {
        throw new InvalidOperationException("Stack underflow.");
    }

    switch (RegisterToPop)
    {
        case "AX":
            return new CpuModel { AX = ValuePopped, SP = SP , Command = "POP"};
        case "BX":
            return new CpuModel { BX = ValuePopped, SP = SP, Command = "POP" };
        case "CX":
            return new CpuModel { CX = ValuePopped, SP = SP, Command = "POP" };
        case "DX":
            return new CpuModel { DX = ValuePopped, SP = SP, Command = "POP" };
        default:
            throw new InvalidOperationException("Invalid register for POP");
    }
    
}


}
}