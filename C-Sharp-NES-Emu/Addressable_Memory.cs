using System;
using System.Runtime.CompilerServices;

namespace NESDOTNET
{
    abstract class Addressable_Memory
    {
        public delegate uint ReadDelegate(uint addr);

        public delegate void WriteDelegate(uint addr, byte val);

        protected readonly EMU_MAIN _emulator;
        protected readonly ReadDelegate[] _readMem;
        protected readonly WriteDelegate[] _writeMem;
        protected readonly uint _addressSize;

        protected Addressable_Memory(EMU_MAIN emulator, uint addressSpace)
        {
            _emulator = emulator;
            _addressSize = addressSpace;
            _readMem = new ReadDelegate[addressSpace + 1];
            _writeMem = new WriteDelegate[addressSpace + 1];
        }

        protected virtual void InitializeMemory() //Initializing the Memory map to prevent any conflicts
        {
            _readMem.Fill(addr => 0);

            // Some games will attempt to write to address that is not mapped and expect to continue running afterwards
            _writeMem.Fill((addr, val) => { });
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint ReadByte(uint addr)
        {
            addr &= _addressSize;
            return _readMem[addr](addr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteByte(uint addr, uint val)
        {
            addr &= _addressSize;
            _writeMem[addr](addr, (byte)val);
        }

        public void MapReadHandler(uint start, uint end, CPU_CLASS.ReadDelegate func) //The method for the reading of memory
        {
            for (uint i = start; i <= end; i++)
                _readMem[i] = func;
        }

        public void MapWriteHandler(uint start, uint end, CPU_CLASS.WriteDelegate func) //The method for the writing or memory
        {
            for (uint i = start; i <= end; i++)
                _writeMem[i] = func;
        }
    }
}
