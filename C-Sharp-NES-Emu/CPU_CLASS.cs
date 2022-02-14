using System;
using System.Linq;
using System.Reflection;

namespace NESDOTNET
{
    sealed partial class CPU_CLASS : Addressable_Memory
    {
        private readonly byte[] __RAM = new byte[0x800]; //Initializing the 2kb of NES ram 
        public int CycleNUM; //A variable for cycle numbers
        private uint _currentInstruction;

        public delegate void CpuOpcode();

        private readonly CpuOpcode[] _opcodes = new CpuOpcode[256];
        private readonly string[] _opcodeNames = new string[256];
        private readonly CpuOpcodeDef[] _opcodeDefs = new CpuOpcodeDef[256];

        public CPU_CLASS(EMU_MAIN emulator) : base(emulator, 0xFFFF) //The main loop for the CPU bit of the emulator. 
        {
            InitializeCpuOpcodes();
            InitializeMemory();
            Initialize();
        }

        private void InitializeCpuOpcodes() //Instantiating the OPcodes for the NES CPU
        {
            var opcodeBindings = from opcode in GetType().GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                                 let defs = opcode.GetCustomAttributes(typeof(CpuOpcodeDef), false)
                                 where defs.Length > 0
                                 select new
                                 {
                                     binding = (CpuOpcode)Delegate.CreateDelegate(typeof(CpuOpcode), this, opcode.Name),
                                     name = opcode.Name,
                                     defs = (from d in defs select (CpuOpcodeDef)d)
                                 };

            foreach (var opcode in opcodeBindings)
            {
                foreach (var def in opcode.defs)
                {
                    _opcodes[def.Opcode] = opcode.binding;
                    _opcodeNames[def.Opcode] = opcode.name;
                    this._opcodeDefs[def.Opcode] = def;
                }
            }
        }

        public void Execute()
        {
            for (int i = 0; i < 5000; i++)
            {
                ExecuteSingleInstruction();
            }


            uint w;
            ushort x = 6000;
            string z = "";
            while ((w = ReadByte(x)) != '\0')
            {
                z += (char)w;
            }

            Console.WriteLine(">>> " + ReadByte(0x02));
        }
    }
}
