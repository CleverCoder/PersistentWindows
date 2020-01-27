﻿using System;
using Ninjacrab.PersistentWindows.Common.WinApiBridge;
using ManagedWinapi.Windows;

namespace Ninjacrab.PersistentWindows.Common.Models
{
    public class ApplicationDisplayMetrics
    {
        public IntPtr HWnd { get; set; }
        public SystemWindow Window { get; set; }
        public int ProcessId { get; set; }
        public string ApplicationName { get; set; }
        public WindowPlacement WindowPlacement { get; set; }
        public RECT ScreenPosition { get; set; }

        public string Key
        {
            // in release mode, ApplicatioName is "" to reduce runtime
            get { return string.Format("{0}-{1}", HWnd.ToInt64(), ApplicationName); }
        }

        public bool EqualPlacement(ApplicationDisplayMetrics other)
        {
            /*
            return this.WindowPlacement.NormalPosition.Left == other.WindowPlacement.NormalPosition.Left
                && this.WindowPlacement.NormalPosition.Top == other.WindowPlacement.NormalPosition.Top
                && this.WindowPlacement.NormalPosition.Width == other.WindowPlacement.NormalPosition.Width
                && this.WindowPlacement.NormalPosition.Height == other.WindowPlacement.NormalPosition.Height;
            */
            return this.WindowPlacement.Equals(other.WindowPlacement);
        }

        public override string ToString()
        {
            return string.Format("{0}.{1} {2}", ProcessId, HWnd.ToInt64(), ApplicationName);
        }
    }
}
