using Cosmos.Assembler;
using XSharp.Common;

namespace Cosmos.CPU_Asm {
    public class CPUGetAmountOfRAMAsm : AssemblerMethod
    {
        public override void AssembleNew(Cosmos.Assembler.Assembler aAssembler, object aMethodInfo)
        {
            XS.Set(XSRegisters.EAX, "MultiBootInfo_Memory_High", sourceIsIndirect: true);
            XS.Xor(XSRegisters.EDX, XSRegisters.EDX);
            XS.Set(XSRegisters.ECX, 1024);
            XS.Divide(XSRegisters.ECX);
            XS.Add(XSRegisters.EAX, 1);
            XS.Push(XSRegisters.EAX);
        }
    }
}
