namespace NESDOTNET
{
    sealed partial class PPU : Addressable_Memory
    {   
        public PPU(EMU_MAIN emulator) : base(emulator, 0x3FFF)
        {
            InitializeMemory();
        }
    }
}
