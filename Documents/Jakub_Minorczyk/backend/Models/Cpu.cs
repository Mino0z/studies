namespace Jakub_Minorczyk.Models
{
public class CpuModel
{
    public ushort AX { get; set; }
    public ushort BX { get; set; }
    public ushort CX { get; set; }
    public ushort DX { get; set; }
    public ushort BP { get; set; }
    public ushort DI { get; set; }
    public ushort SI { get; set; }
    public ushort SP { get; set; }  
    public ushort Offset { get; set; }
    public string? Command { get; set; }
    public string? Register { get; set; }
    public string? RegisterMem { get; set; }
    public string? RegisterPushPop { get; set; }
    public string? addressingMode { get; set; }
    public string? baseRegister { get; set; }
    public string? indexRegister { get; set; }
    public ushort[]? memory { get; set; } 
     public ushort? memoryAddress { get; set; }
     public ushort? memoryValue { get; set; }  
    public List<ushort> Stack { get; set; } = new List<ushort>();
}
}