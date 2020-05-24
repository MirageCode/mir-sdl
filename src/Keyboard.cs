using System;
using System.Runtime.InteropServices;

namespace MirSDL
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Keysym
    {
        public ScanCode scancode;
        public KeyCode sym;
        public KeyMod mod; /* UInt16 */
        public UInt32 unicode; /* Deprecated */
    }

}
