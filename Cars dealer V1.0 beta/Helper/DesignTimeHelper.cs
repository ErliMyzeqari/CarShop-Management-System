using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Helper
{
  public  static class DesignTimeHelper
    {
        /// <summary>
        /// Detect if in desigm mode
        /// </summary>
        public static bool IsInDesignMode
        {
            get
            {
                 
                    using (var process = Process.GetCurrentProcess())
                    {
                        return process.ProcessName.ToLowerInvariant().Contains("devenv");
                    }
               
            }
        }

    }
}
