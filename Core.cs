using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using System.Runtime.InteropServices;

namespace BenchPro {
    class Core {
         // Messages consts
        public const int HTCAPTION = 0x2;
        public const int HTCONTEXT = 0xa4;
        public const int WM_NCHITTEST = 0x84; 
        public const int WM_NCLBUTTONDOWN = 0x00a1;

        // Method id consts
        public const int BP_FLOAT = 0;
        public const int BP_MONTECARLO = 1;

        // Theme style consts
        public const string THEME_BLUE = "blue";
        public const string THEME_GREEN = "green";
        public const string THEME_RED = "red";
        public const string THEME_PURPLE = "purple";
        public const string THEME_BLACK = "black";
        public const string THEME_GRAY = "gray";
        public const string THEME_AQUA = "aqua";
        public static string[] Themes = new string[7] { "blue", "green", "red", "purple", "black", "gray", "aqua" };

        public struct HWInfo {
         public int Cores;
         public string Processor;
         public string DataWidth;
         public int L2;
         public int L3;
         public ulong Memory;
        }

        // App data type
        public struct AppData {
         public int Method;
         public double Time;
         public bool Error;
         public string Theme;
         public bool Active;
         public int Iterations;
         public bool CanSave;
        };

        [DllImport("user32", CharSet = CharSet.Auto)]
        public static extern bool ReleaseCapture();

        [DllImport("user32", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public static HWInfo HW;
        public delegate void UpdateDelegate(int Value);
        private static void UpdateProgress(int Value) {
         Loading.Bar.Value = Value;
         Loading.Bar.Update();
        }

        public static HWInfo GetInfo() {
         HWInfo HW = default(HWInfo);
         Action<int> Method = UpdateProgress;
         ComputerInfo Memory = new ComputerInfo();

         Loading.Bar.Invoke(Method, 0);
         HW.Cores = Environment.ProcessorCount;
         Loading.Bar.Invoke(Method, 17);
         HW.Memory = Memory.TotalPhysicalMemory;
         Loading.Bar.Invoke(Method, 34);

        using(ManagementObjectSearcher Info = new ManagementObjectSearcher("SELECT * FROM Win32_Processor")) {

         foreach(ManagementObject Obj in Info.Get()) {
          HW.Processor = Obj["Name"].ToString();
          Loading.Bar.Invoke(Method, 51);
          HW.DataWidth = Obj["DataWidth"].ToString();
          Loading.Bar.Invoke(Method, 68);
          HW.L2 = int.Parse(Obj["L2CacheSize"].ToString());
          Loading.Bar.Invoke(Method, 85);
          HW.L3 = int.Parse(Obj["L3CacheSize"].ToString());
          Loading.Bar.Invoke(Method, 100);
         }   
        }
         
        return HW;
       }

        public static string FormatBytes(ulong Bytes) {
         ulong MB = 1024 * 1024, GB = 1024 * MB;
         string Result = "";

         if(Bytes == 0)
          return Result;

         if(Bytes >= GB)
          Result = Math.Round((double) Bytes / (1024U * 1024U) / 1024U).ToString() + "GB";
         else
          Result = (Bytes / MB).ToString() + "MB";

         return Result;
        }
    }
}
