using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.VisualBasic.Devices;

namespace BenchPro
{
    public partial class UI : Form
    {
        public UI() {
         InitializeComponent();
        }

        private Core.AppData Data;
        public Stopwatch Watch;
        public Form DimWnd;
        public Form LoadingWnd;

        private delegate void UpdateDelegate(int Value);
        private void UpdateMethod(int Value) {
         RunButton.BackgroundImage = (Image) Properties.Resources.ResourceManager.GetObject("progress_" + Value.ToString());
        }

        protected override void WndProc(ref Message m) {
         base.WndProc(ref m);
         if(m.Msg == Core.HTCONTEXT) {
	      int contMenuX = Cursor.Position.X - Location.X;
	      int contMenuY = Cursor.Position.Y - Location.Y;
	      Point contMenuPos = new Point(contMenuX, contMenuY);
	      PopupSkin.Show(this, contMenuPos);
	     }       
        }

        private void DragForm(object sender, MouseEventArgs e) {
         if(e.Button == MouseButtons.Left && DisplayRectangle.Contains(e.Location)) {
           Core.ReleaseCapture();
           Core.SendMessage(Handle, Core.WM_NCLBUTTONDOWN, Core.HTCAPTION, 0);
         }
        }

        private void LockUI() {
         ButtonFloat.Enabled = false;
         ButtonMonte.Enabled = false;
         ButtonTheme.Enabled = false;
         ButtonAuthor.Enabled = false;
         ButtonExit.Enabled = false;
        }

        private void UnlockUI() {
         ButtonFloat.Enabled = true;
         ButtonMonte.Enabled = true;
         ButtonTheme.Enabled = true;
         ButtonAuthor.Enabled = true;
         ButtonExit.Enabled = true;
        }

        private void SelectMethod(int Method) {
         LabelDescription.Text = (Method == Core.BP_MONTECARLO ? Properties.Resources.InfoMonte : Properties.Resources.InfoFloat);
         ResetData();
         LockUI();
         Data.Method = Method;
        }

        private void RunBenchmark() {
         Data.Active = true;
         Thread.RunWorkerAsync();
         StatusText.Text = "Testiranje u toku...";
        }

        private void SwitchTheme(string Name) {
         if(Name.Equals(Core.THEME_GREEN)) {
          AppBar.BackgroundImage = Properties.Resources.ThemeGreen;
          Data.Theme = "green";
          ThemeActive(1);
         }
         else
         if(Name.Equals(Core.THEME_RED)) {
          AppBar.BackgroundImage = Properties.Resources.ThemeRed;
          Data.Theme = "red";
          ThemeActive(2);
         }
         else
         if(Name.Equals(Core.THEME_PURPLE)) {
          AppBar.BackgroundImage = Properties.Resources.ThemePurple;
          Data.Theme = "purple";
          ThemeActive(3);
         }
         else
         if(Name.Equals(Core.THEME_BLACK)) {
          AppBar.BackgroundImage = Properties.Resources.ThemeBlack;
          Data.Theme = "black";
          ThemeActive(4);
         }
         else
         if(Name.Equals(Core.THEME_GRAY)) {
          AppBar.BackgroundImage = Properties.Resources.ThemeGray;
          Data.Theme = "gray";
          ThemeActive(5);
         }
         else
         if(Name.Equals(Core.THEME_AQUA)) {
          AppBar.BackgroundImage = Properties.Resources.ThemeAqua;
          Data.Theme = "aqua";
          ThemeActive(6);
         }
         else {
          AppBar.BackgroundImage = Properties.Resources.ThemeBlue;
          Data.Theme = "blue";
          ThemeActive(0);
         }
        }

        private void NextTheme() {
         int i = 0;
         int TotalThemes = Core.Themes.Length;
         int CurrentTheme = -1;

         for(; i < TotalThemes; i++)
          if(Core.Themes[i].Equals(Data.Theme)) {
           CurrentTheme = ++i;
           break;
          }

          if(CurrentTheme < TotalThemes)
           SwitchTheme(Core.Themes[CurrentTheme]);
          else
           SwitchTheme(Core.THEME_BLUE);
        }

        private void ThemeActive(int Item) {
         for(int i = 0; i < PopupSkin.Items.Count; i++)
          (PopupSkin.Items[i] as ToolStripMenuItem).Checked = false;
         (PopupSkin.Items[Item] as ToolStripMenuItem).Checked = true;
        }

        private void HandCursor(object sender, EventArgs e) {
         Cursor = Cursors.Hand;
         StatusText.Text = (string) ((Control) sender).Tag;
        }

        private void PointerCursor(object sender, EventArgs e) {
         Cursor = Cursors.Default;
         StatusText.Text = "";
        }

        private void RunButtonDefault(object sender, EventArgs e) {
         RunButton.BackgroundImage = Properties.Resources.RunButton;
         Cursor = Cursors.Default;
        }

        private void RunButtonActive(object sender, EventArgs e) {
         RunButton.BackgroundImage = Properties.Resources.RunButtonActive;
         Cursor = Cursors.Hand;
         Hint.SetToolTip(RunButton, (string) RunButton.Tag);
        }

        private void ButtonDefault(object sender, EventArgs e) {
         (sender as PictureBox).Image = Properties.Resources.Button;
         Cursor = Cursors.Default;
        }

        private void MinimizeActive(object sender, EventArgs e) {
         AppMinimize.Image = Properties.Resources.Minimize;
         Cursor = Cursors.Hand;
         Hint.SetToolTip(AppMinimize, (string) AppMinimize.Tag);
        }
        
        private void ButtonHover(object sender, EventArgs e) {
         Button ActiveButton = (sender as Button);
         Cursor = Cursors.Hand;
         ActiveButton.ForeColor = Color.White;
         ActiveButton.BackColor = SystemColors.Highlight;
         using(Graphics GFX = ActiveButton.CreateGraphics()) {
          ControlPaint.DrawBorder(GFX, ActiveButton.ClientRectangle, Color.CornflowerBlue, ButtonBorderStyle.Dashed);
         }
        }

        private void ButtonLeave(object sender, EventArgs e) {
         Button ActiveButton = (sender as Button);
         ActiveButton.BackColor = Color.White;
         ActiveButton.ForeColor = Color.Black;
         ActiveButton.Invalidate();
         Cursor = Cursors.Default;
        }

        private void CloseActive(object sender, EventArgs e) {
         AppClose.Image = Properties.Resources.Close;
         Cursor = Cursors.Hand;
         Hint.SetToolTip(AppClose, (string) AppClose.Tag);
        }

        // Benchmarking methods

        private void FloatOperations() {
         float a = 0.3803800f;
         float b = 1.53434344f;
         float c = 413.1111f;
         float d = c + a - a + a;
         float e = d + d + d - (float) Math.Pow(d, 1);
         float f = Math.Abs(e);
         float g = (float) Math.Log(f + f);
         float h = 100000f;
         float i = (float) new Random().NextDouble() * 100;
         float j = 413.1111f;
         float x = 0.000000113f;
         float y = (float) Math.PI;
         float z = (float) Math.Cos(90);
         float res = 0f;

         int k = 0;
         int testProgress = 0;

         for(; k < Data.Iterations; k++) {
          res += a + b + c + x + h - h + i - i + j - j + y + z - g + d - d + e - e + f - f + g - g;

          testProgress = k * 100 / (Data.Iterations - 1);

          Thread.ReportProgress(testProgress);
         }
        }

        private double MonteCarlo() {
         double x, y;
         double res = 0.0;
         double nThrows = 0;
         double nSuccess = 0;
         int i = 0;
         Random rand = new Random();

         for (; i < Data.Iterations; i++) {
          x = rand.NextDouble();
          y = rand.NextDouble();
          nThrows++;

          if ((x * x + y * y) <= 1)
           nSuccess++;

          Thread.ReportProgress(i * 100 / (Data.Iterations - 1));
         }

         res = (double) (4 * (nSuccess / nThrows));
         return res;
        }

        private void buttonExit_Click(object sender, EventArgs e) {
         Close();
        }

        private void AppMinimize_Click(object sender, EventArgs e) {
         WindowState = FormWindowState.Minimized;
        }

        private void AppClose_Click(object sender, EventArgs e) {
         Close();
        }

        private void buttonMonte_Click(object sender, EventArgs e) {
         StatusText.Text = "Izabrana metoda: Monte-Carlo";
         SelectMethod(Core.BP_MONTECARLO);
        }

        private void UI_Load(object sender, EventArgs e) {
         Data.Theme = Core.THEME_BLUE;
         ResetData();
         Data.Iterations = 1000;
         ComboNumIter.SelectedIndex = 2;
        }

        private void Benchmark(int Method = -1) {
         if(Method == -1) {
          Data.Error = true;
          return;
         }

         switch(Method) {
          case Core.BP_FLOAT:
           FloatOperations();
          break;

          case Core.BP_MONTECARLO:
           MonteCarlo();
          break;
         }
        }

        private void ShowData() {
         Iterations.Text = Data.Iterations.ToString();
         Mean.Text = ((double) (Data.Time / Data.Iterations)).ToString("#.##") + "ms";
         Total.Text = (Data.Time >= 1000 ? (Data.Time / 1000).ToString("#.##") + "s" : Data.Time.ToString() + "ms");
        }

        private void ResetData() {
         Focus();
         AppTitle.Text = "BenchPro";
         Data.Error = false;
         Data.Time = -1;
         Data.Active = false;
         Data.CanSave = false;
         LabelPercentage.Text = "Pokreni";
         RunButton.BackgroundImage = Properties.Resources.RunButton;
         Status.Text = "BenchPro";
       
         if(ComboNumIter.SelectedIndex == 5)
          ComboNumIter.SelectedIndex = 2;
        }

        private void Thread_DoWork(object sender, DoWorkEventArgs e) {
         Watch = Stopwatch.StartNew();
         Watch.Start();
         Benchmark(Data.Method);
        }

        private void Thread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
         Watch.Stop();
         Data.Time = (double) Watch.ElapsedMilliseconds;
         UnlockUI();
         ShowData();
         ResetData();
         Data.CanSave = true;
         StatusText.Text = "BenchPro";
         MessageBox.Show("Benčmark je uspešno završen.", "BenchPro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void Thread_ProgressChanged(object sender, ProgressChangedEventArgs e) {
         Action<int> Method = UpdateMethod;

         if(e.ProgressPercentage < 60)
          LabelPercentage.ForeColor = Color.Black;
         else
          LabelPercentage.ForeColor = Color.White;

         LabelPercentage.Text = e.ProgressPercentage + "%";
         RunButton.Invoke(Method, e.ProgressPercentage);
         StatusText.Text = "Testiranje u toku... (" + e.ProgressPercentage.ToString() + "%)";
         Update();
        }

        private void ButtonFloat_Click(object sender, EventArgs e) {
         StatusText.Text = "Izabrana metoda: pokretni zarez";
         SelectMethod(Core.BP_FLOAT);
        }

        private void UI_KeyUp(object sender, KeyEventArgs e) {
         if(e.Control && e.KeyCode == Keys.T)
          NextTheme();
         else
         if(e.KeyCode == Keys.Escape) {
          ResetData();
          UnlockUI();
         }
        }

        private void AppSkin_Click(object sender, EventArgs e) {
         PopupSkin.Show(AppSkin, Point.Empty);
        }

        private void AppSkin_MouseEnter(object sender, EventArgs e) {
         AppSkin.Image = Properties.Resources.SkinActive;
         Cursor = Cursors.Hand;
         Hint.SetToolTip(RunButton, (string) AppSkin.Tag);
        }

        private void AppSkin_MouseLeave(object sender, EventArgs e) {
         AppSkin.Image = Properties.Resources.SkinDefault;
         Cursor = Cursors.Default;
        }

        private void SkinBlue_Click(object sender, EventArgs e) {
         SwitchTheme(Core.THEME_BLUE);
        }

        private void SkinGreen_Click(object sender, EventArgs e) {
         SwitchTheme(Core.THEME_GREEN);
        }

        private void SkinRed_Click(object sender, EventArgs e) {
         SwitchTheme(Core.THEME_RED);
        }

        private void SkinPurple_Click(object sender, EventArgs e) {
         SwitchTheme(Core.THEME_PURPLE);
        }

        private void ButtonTheme_Click(object sender, EventArgs e) {
         PopupSkin.Show(ButtonTheme, Point.Empty);
        }

        private void LabelPercentage_Click(object sender, EventArgs e) {
         if(Data.Active) {
          MessageBox.Show("Test je već pokrenut.", "BenchPro", MessageBoxButtons.OK);
          return;
         }

         Update();
         RunBenchmark();
        }

        private void UI_Shown(object sender, EventArgs e) {
         try {
          Processor.Text = Core.HW.Processor.Trim().Replace("  ", "");
          Cores.Text = Core.HW.Cores.ToString();
          DataWidth.Text = Core.HW.DataWidth + "bita";
          L2.Text = (Core.HW.L2 > 0 ? Core.HW.L2 / 1024 : 0).ToString() + "MB";
          L3.Text = (Core.HW.L3 > 0 ? Core.HW.L3 / 1024 : 0).ToString() + "MB";
          RAM.Text = Core.FormatBytes(Core.HW.Memory);
         }
         finally { }

         ButtonMonte.Focus();
         LabelDescription.Text = Properties.Resources.InfoMonte;
        }

        private void buttonAuthor_Click(object sender, EventArgs e) {
         new Author().ShowDialog();
        }

        private void buttonExit_Click_1(object sender, EventArgs e) {
         Close();
        }

        private void ComboNumIter_SelectedIndexChanged(object sender, EventArgs e) {
         Form WndDialog;

         if(ComboNumIter.SelectedIndex != 4)
          Data.Iterations = int.Parse(ComboNumIter.Text);
         else {
          WndDialog = new Dialog();
          WndDialog.ShowDialog();
          
          if(Dialog.Ok && Dialog.Iterations > 0 && Dialog.Iterations < 999999)
           Data.Iterations = Dialog.Iterations;
         }
        }

        private void SkinBlack_Click(object sender, EventArgs e) {
         SwitchTheme(Core.THEME_BLACK);
        }

        private void SkinGray_Click(object sender, EventArgs e) {
         SwitchTheme(Core.THEME_GRAY);
        }

        private void SkinTropic_Click(object sender, EventArgs e) {
         SwitchTheme(Core.THEME_AQUA);
        }

        private void SubSaveAs_Click(object sender, EventArgs e) {
         SaveFile.FileName = "";
         bool IsSaved = false;

         if(SaveFile.ShowDialog() == DialogResult.OK) {
          if(SaveFile.FilterIndex == 5) {
           string Buffer = "";
           byte[] Bytes;

           SaveFile.FileName = Path.ChangeExtension(SaveFile.FileName, "txt");

           using(FileStream File = new FileStream(SaveFile.FileName, FileMode.Create)) {
            Buffer += (Data.Method == Core.BP_FLOAT ? "OPERACIJE SA POKRETNIM ZAREZOM" : "MONTE-CARLO METODA") + "\r\n\r\n";
            Buffer += "Broj iteracija\t" + Data.Iterations.ToString() + "\r\n";
            Buffer += "Prosečno vreme izvršavanja\t" + Mean.Text + "\r\n";
            Buffer += "Ukupno vreme izvršavanja\t" + Total.Text + "\0";
            Bytes = UTF8Encoding.UTF8.GetBytes(Buffer);
            File.Write(Bytes, 0, Bytes.Length);
            IsSaved = true;
           }
          }
          else {
           ImageFormat ImageType = ImageFormat.Bmp;
           Bitmap BMP = new Bitmap(Results.Width, Results.Height);
           Results.DrawToBitmap(BMP, Results.ClientRectangle);
          
           if(SaveFile.FilterIndex == 3)
            ImageType = ImageFormat.Jpeg;
           else
           if(SaveFile.FilterIndex == 4)
            ImageType = ImageFormat.Png;
           else
            ImageType = ImageFormat.Bmp;

           BMP.Save(SaveFile.FileName, ImageType);
           IsSaved = true;
          }
         }

         if(IsSaved) {
          System.Media.SystemSounds.Beep.Play();
          MessageBox.Show("Datoteka je uspešno sačuvana.", "BenchPro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
         }
        }

        private void SubExit_Click(object sender, EventArgs e) {
         Close();
        }

        private void SubAuthor_Click(object sender, EventArgs e) {
         new Author().ShowDialog();
        }

        private void vebsajtToolStripMenuItem_Click(object sender, EventArgs e) {
         XApp.StartInfo.FileName = "http://neovisio.org";
         XApp.Start();
        }

        private void SubMonte_Click(object sender, EventArgs e) {
         SelectMethod(Core.BP_MONTECARLO);
        }

        private void SubFloat_Click(object sender, EventArgs e) {
         SelectMethod(Core.BP_FLOAT);
        }

        private void SubBlue_Click(object sender, EventArgs e) {
         SwitchTheme(Core.THEME_BLUE);
        }

        private void SubGreen_Click(object sender, EventArgs e) {
         SwitchTheme(Core.THEME_GREEN);
        }

        private void SubRed_Click(object sender, EventArgs e) {
         SwitchTheme(Core.THEME_RED);
        }

        private void SubPurple_Click(object sender, EventArgs e) {
         SwitchTheme(Core.THEME_PURPLE);
        }

        private void SubBlack_Click(object sender, EventArgs e) {
         SwitchTheme(Core.THEME_BLACK);
        }

        private void SubGray_Click(object sender, EventArgs e) {
         SwitchTheme(Core.THEME_GRAY);
        }

        private void SubAqua_Click(object sender, EventArgs e) {
         SwitchTheme(Core.THEME_AQUA);
        }

        private void MenuFile_Click(object sender, EventArgs e) {
         SubSaveAs.Enabled = Data.CanSave;
        }

        private void PanelCmds_Paint(object sender, PaintEventArgs e) {
         ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.DodgerBlue, ButtonBorderStyle.Solid);
        }

        private void StatusText_Paint(object sender, PaintEventArgs e) {
         ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.DodgerBlue, ButtonBorderStyle.Solid);
        }

        private void Battery_Paint(object sender, PaintEventArgs e) {
         PowerStatus BatteryStatus = SystemInformation.PowerStatus;
         StringFormat TextFormat = new StringFormat();
         String Percentage = (BatteryStatus.BatteryLifePercent * 100).ToString() + "%";

         TextFormat.Alignment = StringAlignment.Center;
         TextFormat.LineAlignment = StringAlignment.Center;

        using(Font TextFont = new Font("Calibri", 7.6f, FontStyle.Bold)) {
         e.Graphics.DrawString(Percentage, TextFont, Brushes.White, Rectangle.Inflate(e.ClipRectangle, -7, -7), TextFormat);
        }
       }

        private void UI_Move(object sender, EventArgs e) {
         PanelCmds.Invalidate();
         StatusText.Invalidate();
        }

        private void Memory_Paint(object sender, PaintEventArgs e) {
         String Percentage;
         ComputerInfo Info = new ComputerInfo();
         StringFormat TextFormat = new StringFormat();
         double FreeRAM = Convert.ToDouble(Info.AvailablePhysicalMemory);
         double TotalRAM = Convert.ToDouble(Info.TotalPhysicalMemory);

         TextFormat.Alignment = StringAlignment.Center;
         TextFormat.LineAlignment = StringAlignment.Center;
         Percentage = ((FreeRAM / TotalRAM) * 100).ToString("#.#") + "%";
         using(Font TextFont = new Font("Calibri", 10f, FontStyle.Bold)) {
          e.Graphics.DrawString(Percentage, TextFont, Brushes.White, e.ClipRectangle, TextFormat);
         }
        }

        private void SubRestart_Click(object sender, EventArgs e) {
         XApp.StartInfo.FileName = Application.ExecutablePath;
         XApp.Start();
         Close();
        }

        private void PollTimer_Tick(object sender, EventArgs e) {
         Memory.Invalidate();
         Battery.Invalidate();
        }

        private void CheckRealtime_Click(object sender, EventArgs e) {
         PollTimer.Enabled = CheckRealtime.Checked;
        }
    }
}
