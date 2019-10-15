using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace BenchPro {
    public partial class Dialog : Form {
        public Dialog() {
        InitializeComponent();
        }

        public static bool Ok = false;
        public static int Iterations = 0;

        private void SetResult() {
         Ok = true;
         Iterations = int.Parse(TextIterations.Text);
         Close();
        }

        private void MouseOver(object sender, EventArgs e) {
         Cursor = Cursors.Hand;
        }

        private void MouseOut(object sender, EventArgs e) {
         Cursor = Cursors.Default;
        }

        private void ImageCancel_Click(object sender, EventArgs e) {
         Close();
        }

        private void ImageOk_Click(object sender, EventArgs e) {
         SetResult();
        }

        private void TextIterations_KeyDown(object sender, KeyEventArgs e) {
         if(((e.KeyValue < 48 || e.KeyValue > 57) && (e.KeyValue < 96 || e.KeyValue > 105)) && e.KeyCode != Keys.Back) {
          e.Handled = true;
          e.SuppressKeyPress = true;
          SystemSounds.Beep.Play();
         }
         else if(e.KeyCode == Keys.Return) {
          SetResult();
         }
        }

        private void Dialog_Shown(object sender, EventArgs e) {
         Ok = false;
         Iterations = 0;
        }

        private void TextIterations_KeyUp(object sender, KeyEventArgs e) {
         bool IsValid = TextIterations.Text.Length > 2;
         ImageOk.Image = (IsValid ? Properties.Resources.Apply : Properties.Resources.ApplyDisabled);
         ImageOk.Enabled = IsValid;
        }
    }
}
