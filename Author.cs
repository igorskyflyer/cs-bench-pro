using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BenchPro {
    public partial class Author : Form {
        public Author() {
         InitializeComponent();
        }

         protected override void WndProc(ref Message m) {
          base.WndProc(ref m);

          if (m.Msg == Core.WM_NCHITTEST)
           m.Result = (IntPtr) Core.HTCAPTION;   
        }

        private void MouseOver(object sender, EventArgs e) {
         Cursor = Cursors.Hand;
        }

        private void MouseOut(object sender, EventArgs e) {
         Cursor = Cursors.Default;
        }

        private void GoTo(string Url) {
         Web.StartInfo.Verb = "open";
         Web.StartInfo.FileName = Url;
         Web.Start();
        }

        private void Link_Click(object sender, EventArgs e) {
         GoTo("http://neovisio.org");
        }

        private void ImageAuthor_Click(object sender, EventArgs e) {
         GoTo("http://facebook.com/IgorSkyFlyer");
        }

        private void Author_KeyUp(object sender, KeyEventArgs e) {
         if(e.KeyCode == Keys.Escape)
          Close();
        }

        private void WndClose_Click(object sender, EventArgs e) {
         Close();
        }

        private void Author_Paint(object sender, PaintEventArgs e) {
         ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.CornflowerBlue, ButtonBorderStyle.Solid);
        }

        private void Author_LocationChanged(object sender, EventArgs e) {
         Invalidate();
        }

        private void WndClose_MouseEnter(object sender, EventArgs e) {
         Cursor = Cursors.Hand;
         using(Graphics GFX = WndClose.CreateGraphics()) {
          ControlPaint.DrawBorder3D(GFX, WndClose.DisplayRectangle);
         }
        }

        private void WndClose_MouseLeave(object sender, EventArgs e) {
         Cursor = Cursors.Default;
         WndClose.Invalidate();
        }
    }
}
