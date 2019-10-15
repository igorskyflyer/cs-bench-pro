using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BenchPro {
    public partial class Loading : Form {
        public Loading() {
         InitializeComponent();
        }

        public static ProgressBar Bar;

        private void FetchHW_DoWork(object sender, DoWorkEventArgs e) {
         Core.HW = Core.GetInfo();
        }

        private void FetchHW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
         Program.UIWnd.Show();
         Close();
        }

        private void Loading_Shown(object sender, EventArgs e) {
         Bar = this.LoadingProgress;
         FetchHW.RunWorkerAsync();
        }

        private void LabelTitle_Paint(object sender, PaintEventArgs e) {
         using(Font TextFont = new Font("Calibri", 18, FontStyle.Bold)) {
          e.Graphics.DrawString("BenchPro", TextFont, Brushes.White, Rectangle.Inflate(e.ClipRectangle, 1, 1));
         }
        }

        private void Loading_Paint(object sender, PaintEventArgs e) {
         e.Graphics.DrawRectangle(Pens.White, new Rectangle(0, 0, Width - 1, Height - 1));
        }
    }
}
