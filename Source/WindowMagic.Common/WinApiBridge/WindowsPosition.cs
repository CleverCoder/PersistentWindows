﻿using System;
using System.Runtime.InteropServices;

namespace WindowMagic.Common.WinApiBridge
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WindowsPosition
    {
        public IntPtr hwnd;
        public IntPtr hwndInsertAfter;
        public int Left;
        public int Top;
        public int Width;
        public int Height;
        public int Flags;
    }
}
