using System;
using System.Runtime.InteropServices;

namespace MirSDL
{
    public class SDLException : Exception
    {
        public const string SDLLib = Resource<SDLException>.SDLLib;

        public SDLException () : base(Util.ToString(SDL_GetError())) {}

        [DllImport(SDLLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr SDL_GetError();
    }
}
