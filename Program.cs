using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;

namespace BenchPro
{
    static class Program
    {
        public static Form UIWnd;
        public static Form LoadingWnd;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main() {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         LoadingWnd = new Loading();
         UIWnd = new UI();
         UIWnd.Hide();
         LoadingWnd.ShowDialog();
         Application.Run(UIWnd);
        }
    }
}
