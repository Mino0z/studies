using Xunit;
using Jakub_Minorczyk.Services;
using Jakub_Minorczyk.Models;

namespace ServiceTest1{
public class ServiceTests
{
    
    [Fact]
    public void ExecuteMov_AX_BX_WorksCorrectly()
    {
        // Arrange
        ushort AX = 0;
        ushort BX = 1234;
        ushort CX = 0;
        ushort DX = 0;

        var cpuService = new CpuService();

        // Act
        var result = cpuService.ExecuteMov(AX, BX, CX, DX, "AX BX");

        // Assert
        Assert.Equal(1234, result.AX);
        Assert.Equal(1234, result.BX);
    }

    [Fact]
    public void ExecuteMov_BX_CX_WorksCorrectly()
    {
        // Arrange
        ushort AX = 0;
        ushort BX = 0;
        ushort CX = 5678;
        ushort DX = 0;

        var cpuService = new CpuService();

        // Act
        var result = cpuService.ExecuteMov(AX, BX, CX, DX, "BX CX");

        // Assert
        Assert.Equal(5678, result.BX);
        Assert.Equal(5678, result.CX);
    }

    [Fact]
    public void ExecuteMov_DX_AX_WorksCorrectly()
    {
        // Arrange
        ushort AX = 9101;
        ushort BX = 0;
        ushort CX = 0;
        ushort DX = 0;

        var cpuService = new CpuService();

        // Act
        var result = cpuService.ExecuteMov(AX, BX, CX, DX, "DX AX");

        // Assert
        Assert.Equal(9101, result.DX);
        Assert.Equal(9101, result.AX);
    }

    [Fact]
    public void ExecuteMov_AX_DX_WorksCorrectly()
    {
        // Arrange
        ushort AX = 0;
        ushort BX = 0;
        ushort CX = 0;
        ushort DX = 1122;

        var cpuService = new CpuService();

        // Act
        var result = cpuService.ExecuteMov(AX, BX, CX, DX, "AX DX");

        // Assert
        Assert.Equal(1122, result.AX);
        Assert.Equal(1122, result.DX);
    }

    [Fact]
    public void ExecuteMov_SameRegister_NoChange()
    {
        // Arrange
        ushort AX = 1234;
        ushort BX = 5678;
        ushort CX = 9101;
        ushort DX = 1122;

        var cpuService = new CpuService();

        // Act
        var resultAX = cpuService.ExecuteMov(AX, BX, CX, DX, "AX AX");
        var resultBX = cpuService.ExecuteMov(AX, BX, CX, DX, "BX BX");
        var resultCX = cpuService.ExecuteMov(AX, BX, CX, DX, "CX CX");
        var resultDX = cpuService.ExecuteMov(AX, BX, CX, DX, "DX DX");

        // Assert
        Assert.Equal(1234, resultAX.AX);
        Assert.Equal(5678, resultBX.BX);
        Assert.Equal(9101, resultCX.CX);
        Assert.Equal(1122, resultDX.DX);
    }

    [Fact]
    public void ExecuteMov_InvalidRegister_NoChange()
    {
        // Arrange
        ushort AX = 1234;
        ushort BX = 5678;
        ushort CX = 9101;
        ushort DX = 1122;

        var cpuService = new CpuService();

        // Act
        var result = cpuService.ExecuteMov(AX, BX, CX, DX, "INVALID");

        // Assert
        Assert.Equal(1234, result.AX);
        Assert.Equal(5678, result.BX);
        Assert.Equal(9101, result.CX);
        Assert.Equal(1122, result.DX);
    }
[Fact]
    public void ExecuteXchg_AX_BX_WorksCorrectly()
    {
        // Arrange
        ushort AX = 1234;
        ushort BX = 5678;
        ushort CX = 0;
        ushort DX = 0;

        var cpuService = new CpuService();

        // Act
        var result = cpuService.ExecuteXchg(AX, BX, CX, DX, "AX BX");

        // Assert
        Assert.Equal(5678, result.AX);
        Assert.Equal(1234, result.BX);
    }

    [Fact]
    public void ExecuteXchg_AX_CX_WorksCorrectly()
    {
        // Arrange
        ushort AX = 1111;
        ushort BX = 0;
        ushort CX = 2222;
        ushort DX = 0;

        var cpuService = new CpuService();

        // Act
        var result = cpuService.ExecuteXchg(AX, BX, CX, DX, "AX CX");

        // Assert
        Assert.Equal(2222, result.AX);
        Assert.Equal(1111, result.CX);
    }

    [Fact]
    public void ExecuteXchg_AX_DX_WorksCorrectly()
    {
        // Arrange
        ushort AX = 3333;
        ushort BX = 0;
        ushort CX = 0;
        ushort DX = 4444;

        var cpuService = new CpuService();

        // Act
        var result = cpuService.ExecuteXchg(AX, BX, CX, DX, "AX DX");

        // Assert
        Assert.Equal(4444, result.AX);
        Assert.Equal(3333, result.DX);
    }

    [Fact]
    public void ExecuteXchg_BX_CX_WorksCorrectly()
    {
        // Arrange
        ushort AX = 0;
        ushort BX = 5555;
        ushort CX = 6666;
        ushort DX = 0;

        var cpuService = new CpuService();

        // Act
        var result = cpuService.ExecuteXchg(AX, BX, CX, DX, "BX CX");

        // Assert
        Assert.Equal(6666, result.BX);
        Assert.Equal(5555, result.CX);
    }

    [Fact]
    public void ExecuteXchg_BX_DX_WorksCorrectly()
    {
        // Arrange
        ushort AX = 0;
        ushort BX = 7777;
        ushort CX = 0;
        ushort DX = 8888;

        var cpuService = new CpuService();

        // Act
        var result = cpuService.ExecuteXchg(AX, BX, CX, DX, "BX DX");

        // Assert
        Assert.Equal(8888, result.BX);
        Assert.Equal(7777, result.DX);
    }

    [Fact]
    public void ExecuteXchg_CX_DX_WorksCorrectly()
    {
        // Arrange
        ushort AX = 0;
        ushort BX = 0;
        ushort CX = 9999;
        ushort DX = 1111;

        var cpuService = new CpuService();

        // Act
        var result = cpuService.ExecuteXchg(AX, BX, CX, DX, "CX DX");

        // Assert
        Assert.Equal(1111, result.CX);
        Assert.Equal(9999, result.DX);
    }

    [Fact]
    public void ExecuteXchg_InvalidRegister_DoesNotChangeState()
    {
        // Arrange
        ushort AX = 1234;
        ushort BX = 5678;
        ushort CX = 9101;
        ushort DX = 1121;

        var cpuService = new CpuService();

        // Act
        var result = cpuService.ExecuteXchg(AX, BX, CX, DX, "INVALID");

        // Assert
        Assert.Equal(1234, result.AX);
        Assert.Equal(5678, result.BX);
        Assert.Equal(9101, result.CX);
        Assert.Equal(1121, result.DX);
    }

    [Fact]
    public void ExecuteMovMem_AX_MEM_BaseMode_WorksCorrectly()
    {
        // Arrange
        ushort AX = 0;
        ushort BX = 0;
        ushort CX = 0;
        ushort DX = 0;
        ushort BP = 100;
        ushort Offset = 20;
        ushort[] memory = new ushort[150];
        memory[120] = 5678;

        var cpuService = new CpuService();

        // Act
        var result = cpuService.ExecuteMovMem(AX, BX, CX, DX, "AX MEM", memory, addressingMode: "base", baseRegister: "BP", BP: BP, Offset: Offset);

        // Assert
        Assert.Equal(5678, result.AX);
        Assert.Equal(120, (int)result.memoryAddress);
    }

    [Fact]
    public void ExecuteMovMem_MEM_BX_IndexedMode_WorksCorrectly()
    {
        // Arrange
        ushort AX = 0;
        ushort BX = 2345;
        ushort CX = 0;
        ushort DX = 0;
        ushort SI = 50;
        ushort Offset = 30;
        ushort[] memory = new ushort[150];

        var cpuService = new CpuService();

        // Act
        var result = cpuService.ExecuteMovMem(AX, BX, CX, DX, "MEM BX", memory, addressingMode: "index", indexRegister: "SI", SI: SI, Offset: Offset);

        // Assert
        Assert.Equal(2345, memory[80]);
        Assert.Equal(80, (int)result.memoryAddress);
    }

    [Fact]
    public void ExecuteMovMem_MEM_CX_IndexedBaseMode_WorksCorrectly()
    {
        // Arrange
        ushort AX = 0;
        ushort BX = 0;
        ushort CX = 3456;
        ushort DX = 0;
        ushort BP = 70;
        ushort DI = 20;
        ushort Offset = 10;
        ushort[] memory = new ushort[150];

        var cpuService = new CpuService();

        // Act
        var result = cpuService.ExecuteMovMem(AX, BX, CX, DX, "MEM CX", memory, addressingMode: "indexed_base", baseRegister: "BP", indexRegister: "DI", BP: BP, DI: DI, Offset: Offset);

        // Assert
        Assert.Equal(3456, memory[100]);
        Assert.Equal(100, (int)result.memoryAddress);
    }

    [Fact]
    public void ExecuteMovMem_InvalidAddressingMode_ThrowsException()
    {
        // Arrange
        ushort AX = 0;
        ushort BX = 0;
        ushort CX = 0;
        ushort DX = 0;
        ushort[] memory = new ushort[150];

        var cpuService = new CpuService();

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() =>
            cpuService.ExecuteMovMem(AX, BX, CX, DX, "AX MEM", memory, addressingMode: "invalid"));
    }

    [Fact]
    public void ExecuteMovMem_AddressOutOfBounds_ThrowsException()
    {
        // Arrange
        ushort AX = 0;
        ushort BX = 0;
        ushort CX = 0;
        ushort DX = 0;
        ushort BP = 100;
        ushort Offset = 200;
        ushort[] memory = new ushort[150];

        var cpuService = new CpuService();

        // Act & Assert
        Assert.Throws<IndexOutOfRangeException>(() =>
            cpuService.ExecuteMovMem(AX, BX, CX, DX, "AX MEM", memory, addressingMode: "base", baseRegister: "BP", BP: BP, Offset: Offset));
    }
    [Fact]
    public void ExecuteXchgMem_AX_MEM_BaseMode_WorksCorrectly()
    {
        // Arrange
        var cpu = new CpuModel();
        ushort AX = 1234;
        ushort BX = 0;
        ushort CX = 0;
        ushort DX = 0;
        ushort BP = 100;
        ushort Offset = 20;
        ushort[] memory = new ushort[200];
        memory[120] = 5678;

        // Act
        var cpuService = new CpuService();
        var result = cpuService.ExecuteXchgMem(AX, BX, CX, DX, "AX MEM", memory, addressingMode: "base", baseRegister: "BP", BP: BP, Offset: Offset);


        // Assert
        Assert.Equal(5678, result.AX);
        Assert.Equal(1234, result.memory[120]);
        Assert.Equal(120, (int)result.memoryAddress);

    }

    [Fact]
    public void ExecuteXchgMem_BX_MEM_IndexedMode_WorksCorrectly()
    {
        // Arrange
        var cpu = new CpuModel();
        ushort AX = 0;
        ushort BX = 2345;
        ushort CX = 0;
        ushort DX = 0;
        ushort SI = 50;
        ushort Offset = 30;
        ushort[] memory = new ushort[200];
        memory[80] = 6789;

        // Act
        var cpuService = new CpuService();
        var result = cpuService.ExecuteXchgMem(AX, BX, CX, DX, "BX MEM", memory, addressingMode: "index", indexRegister: "SI", SI: SI, Offset: Offset);

        // Assert
        Assert.Equal(6789, result.BX);
        Assert.Equal(2345, result.memory[80]);
        Assert.Equal(80, (int)result.memoryAddress);
    }

    [Fact]
    public void ExecuteXchgMem_MEM_CX_IndexedBaseMode_WorksCorrectly()
    {
        // Arrange
        var cpu = new CpuModel();
        ushort AX = 0;
        ushort BX = 0;
        ushort CX = 3456;
        ushort DX = 0;
        ushort BP = 70;
        ushort DI = 20;
        ushort Offset = 10;
        ushort[] memory = new ushort[200];
        memory[100] = 7890;

        // Act
        var cpuService = new CpuService();
        var result = cpuService.ExecuteXchgMem(AX, BX, CX, DX, "MEM CX", memory, addressingMode: "indexed_base", baseRegister: "BP", indexRegister: "DI", BP: BP, DI: DI, Offset: Offset);

        // Assert
        Assert.Equal(7890, result.CX);
        Assert.Equal(3456, result.memory[100]);
        Assert.Equal(100, (int)result.memoryAddress);
    }

    [Fact]
    public void ExecuteXchgMem_InvalidAddressingMode_ThrowsException()
    {
        // Arrange
        var cpu = new CpuModel();
        ushort AX = 1234;
        ushort BX = 0;
        ushort CX = 0;
        ushort DX = 0;
        ushort[] memory = new ushort[100];

        // Act & Assert
        var cpuService = new CpuService();
        Assert.Throws<InvalidOperationException>(() =>
            cpuService.ExecuteXchgMem(AX, BX, CX, DX, "AX MEM", memory, addressingMode: "invalid"));
    }

    [Fact]
    public void ExecuteXchgMem_AddressOutOfBounds_ThrowsException()
    {
        // Arrange
        var cpu = new CpuModel();
        ushort AX = 1234;
        ushort BX = 0;
        ushort CX = 0;
        ushort DX = 0;
        ushort BP = 100;
        ushort Offset = 200;
        ushort[] memory = new ushort[150];

        // Act & Assert
        var cpuService = new CpuService();
        Assert.Throws<IndexOutOfRangeException>(() =>
            cpuService.ExecuteXchgMem(AX, BX, CX, DX, "AX MEM", memory, addressingMode: "base", baseRegister: "BP", BP: BP, Offset: Offset));
    }
}
}