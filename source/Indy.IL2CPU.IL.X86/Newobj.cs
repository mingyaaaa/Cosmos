using System;
using System.IO;
using Mono.Cecil;
using Mono.Cecil.Cil;
using CPU = Indy.IL2CPU.Assembler.X86;

namespace Indy.IL2CPU.IL.X86 {
	[OpCode(Code.Newobj)]
	public class Newobj: Op {
		/// <summary>
		/// This overload takes the label name of the ctor
		/// </summary>
		/// <param name="aCtor"></param>
		public void Assemble(string aCtor) {
			new CPU.JumpAlways(aCtor);
		}

		public override void Assemble(Instruction aInstruction) {
            //TODO: Call the other assemble
			throw new NotImplementedException("This file has been autogenerated and not been changed afterwards!");
		}
	}
}