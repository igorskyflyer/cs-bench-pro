namespace BenchPro
{
    partial class UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.AppBar = new System.Windows.Forms.Panel();
            this.AppSkin = new System.Windows.Forms.PictureBox();
            this.AppClose = new System.Windows.Forms.PictureBox();
            this.AppMinimize = new System.Windows.Forms.PictureBox();
            this.AppIcon = new System.Windows.Forms.PictureBox();
            this.AppTitle = new System.Windows.Forms.Label();
            this.SkinBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.PopupSkin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SkinGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinRed = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinPurple = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinBlack = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinGray = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinAqua = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonTheme = new System.Windows.Forms.Button();
            this.ButtonMonte = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.ButtonAuthor = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonFloat = new System.Windows.Forms.Button();
            this.Thread = new System.ComponentModel.BackgroundWorker();
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            this.Battery = new System.Windows.Forms.PictureBox();
            this.Memory = new System.Windows.Forms.PictureBox();
            this.AppMenu = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SubSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SubRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.SubExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMethod = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMonte = new System.Windows.Forms.ToolStripMenuItem();
            this.SubFloat = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.temaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.SubGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.SubRed = new System.Windows.Forms.ToolStripMenuItem();
            this.SubPurple = new System.Windows.Forms.ToolStripMenuItem();
            this.SubBlack = new System.Windows.Forms.ToolStripMenuItem();
            this.SubGray = new System.Windows.Forms.ToolStripMenuItem();
            this.SubAqua = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.SubAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.SubWeb = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.XApp = new System.Diagnostics.Process();
            this.Info = new System.Windows.Forms.TableLayoutPanel();
            this.Processor = new System.Windows.Forms.Label();
            this.Cores = new System.Windows.Forms.Label();
            this.DataWidth = new System.Windows.Forms.Label();
            this.HeadingData = new System.Windows.Forms.Label();
            this.HeadingCores = new System.Windows.Forms.Label();
            this.RAM = new System.Windows.Forms.Label();
            this.L3 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.HeadingProcessor = new System.Windows.Forms.Label();
            this.HeadingRAM = new System.Windows.Forms.Label();
            this.HeadingL2 = new System.Windows.Forms.Label();
            this.HeadingL3 = new System.Windows.Forms.Label();
            this.LabelNumIter = new System.Windows.Forms.Label();
            this.ComboNumIter = new System.Windows.Forms.ComboBox();
            this.Results = new System.Windows.Forms.TableLayoutPanel();
            this.HeadingTotal = new System.Windows.Forms.Label();
            this.HeadingMean = new System.Windows.Forms.Label();
            this.HeadingIterations = new System.Windows.Forms.Label();
            this.Iterations = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Mean = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Panel();
            this.LabelPercentage = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.StatusText = new System.Windows.Forms.Label();
            this.PanelCmds = new System.Windows.Forms.Panel();
            this.PollTimer = new System.Windows.Forms.Timer(this.components);
            this.CheckRealtime = new System.Windows.Forms.CheckBox();
            this.AppBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppSkin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).BeginInit();
            this.PopupSkin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Battery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Memory)).BeginInit();
            this.AppMenu.SuspendLayout();
            this.Info.SuspendLayout();
            this.Results.SuspendLayout();
            this.RunButton.SuspendLayout();
            this.PanelCmds.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppBar
            // 
            this.AppBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AppBar.BackgroundImage = global::BenchPro.Properties.Resources.ThemeBlue;
            this.AppBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AppBar.Controls.Add(this.AppSkin);
            this.AppBar.Controls.Add(this.AppClose);
            this.AppBar.Controls.Add(this.AppMinimize);
            this.AppBar.Controls.Add(this.AppIcon);
            this.AppBar.Controls.Add(this.AppTitle);
            this.AppBar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppBar.Location = new System.Drawing.Point(-1, 0);
            this.AppBar.Name = "AppBar";
            this.AppBar.Size = new System.Drawing.Size(873, 35);
            this.AppBar.TabIndex = 16;
            this.AppBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
            // 
            // AppSkin
            // 
            this.AppSkin.BackColor = System.Drawing.Color.Transparent;
            this.AppSkin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AppSkin.Image = global::BenchPro.Properties.Resources.SkinDefault;
            this.AppSkin.Location = new System.Drawing.Point(797, 8);
            this.AppSkin.MaximumSize = new System.Drawing.Size(16, 16);
            this.AppSkin.MinimumSize = new System.Drawing.Size(16, 16);
            this.AppSkin.Name = "AppSkin";
            this.AppSkin.Size = new System.Drawing.Size(16, 16);
            this.AppSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AppSkin.TabIndex = 11;
            this.AppSkin.TabStop = false;
            this.AppSkin.Tag = "Tema";
            this.AppSkin.Click += new System.EventHandler(this.AppSkin_Click);
            this.AppSkin.MouseEnter += new System.EventHandler(this.AppSkin_MouseEnter);
            this.AppSkin.MouseLeave += new System.EventHandler(this.AppSkin_MouseLeave);
            // 
            // AppClose
            // 
            this.AppClose.BackColor = System.Drawing.Color.Transparent;
            this.AppClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AppClose.Image = global::BenchPro.Properties.Resources.Button;
            this.AppClose.Location = new System.Drawing.Point(841, 8);
            this.AppClose.MaximumSize = new System.Drawing.Size(16, 16);
            this.AppClose.MinimumSize = new System.Drawing.Size(16, 16);
            this.AppClose.Name = "AppClose";
            this.AppClose.Size = new System.Drawing.Size(16, 16);
            this.AppClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AppClose.TabIndex = 10;
            this.AppClose.TabStop = false;
            this.AppClose.Tag = "Zatvori";
            this.AppClose.Click += new System.EventHandler(this.AppClose_Click);
            this.AppClose.MouseEnter += new System.EventHandler(this.CloseActive);
            this.AppClose.MouseLeave += new System.EventHandler(this.ButtonDefault);
            // 
            // AppMinimize
            // 
            this.AppMinimize.BackColor = System.Drawing.Color.Transparent;
            this.AppMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AppMinimize.Image = global::BenchPro.Properties.Resources.Button;
            this.AppMinimize.Location = new System.Drawing.Point(819, 8);
            this.AppMinimize.MaximumSize = new System.Drawing.Size(16, 16);
            this.AppMinimize.MinimumSize = new System.Drawing.Size(16, 16);
            this.AppMinimize.Name = "AppMinimize";
            this.AppMinimize.Size = new System.Drawing.Size(16, 16);
            this.AppMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AppMinimize.TabIndex = 9;
            this.AppMinimize.TabStop = false;
            this.AppMinimize.Tag = "Minimizuj";
            this.AppMinimize.Click += new System.EventHandler(this.AppMinimize_Click);
            this.AppMinimize.MouseEnter += new System.EventHandler(this.MinimizeActive);
            this.AppMinimize.MouseLeave += new System.EventHandler(this.ButtonDefault);
            // 
            // AppIcon
            // 
            this.AppIcon.BackColor = System.Drawing.Color.Transparent;
            this.AppIcon.Image = ((System.Drawing.Image)(resources.GetObject("AppIcon.Image")));
            this.AppIcon.Location = new System.Drawing.Point(5, 6);
            this.AppIcon.Name = "AppIcon";
            this.AppIcon.Size = new System.Drawing.Size(29, 25);
            this.AppIcon.TabIndex = 8;
            this.AppIcon.TabStop = false;
            this.AppIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
            // 
            // AppTitle
            // 
            this.AppTitle.BackColor = System.Drawing.Color.Transparent;
            this.AppTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTitle.ForeColor = System.Drawing.Color.White;
            this.AppTitle.Location = new System.Drawing.Point(40, 6);
            this.AppTitle.Name = "AppTitle";
            this.AppTitle.Size = new System.Drawing.Size(428, 25);
            this.AppTitle.TabIndex = 7;
            this.AppTitle.Text = "BenchPro";
            this.AppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AppTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
            // 
            // SkinBlue
            // 
            this.SkinBlue.Checked = true;
            this.SkinBlue.CheckOnClick = true;
            this.SkinBlue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SkinBlue.Name = "SkinBlue";
            this.SkinBlue.Size = new System.Drawing.Size(127, 22);
            this.SkinBlue.Text = "Plava";
            this.SkinBlue.Click += new System.EventHandler(this.SkinBlue_Click);
            // 
            // PopupSkin
            // 
            this.PopupSkin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SkinBlue,
            this.SkinGreen,
            this.SkinRed,
            this.SkinPurple,
            this.SkinBlack,
            this.SkinGray,
            this.SkinAqua});
            this.PopupSkin.Name = "contextMenuStrip1";
            this.PopupSkin.Size = new System.Drawing.Size(128, 158);
            // 
            // SkinGreen
            // 
            this.SkinGreen.CheckOnClick = true;
            this.SkinGreen.Name = "SkinGreen";
            this.SkinGreen.Size = new System.Drawing.Size(127, 22);
            this.SkinGreen.Text = "Zelena";
            this.SkinGreen.Click += new System.EventHandler(this.SkinGreen_Click);
            // 
            // SkinRed
            // 
            this.SkinRed.CheckOnClick = true;
            this.SkinRed.Name = "SkinRed";
            this.SkinRed.Size = new System.Drawing.Size(127, 22);
            this.SkinRed.Text = "Crvena";
            this.SkinRed.Click += new System.EventHandler(this.SkinRed_Click);
            // 
            // SkinPurple
            // 
            this.SkinPurple.CheckOnClick = true;
            this.SkinPurple.Name = "SkinPurple";
            this.SkinPurple.Size = new System.Drawing.Size(127, 22);
            this.SkinPurple.Text = "Ljubičasta";
            this.SkinPurple.Click += new System.EventHandler(this.SkinPurple_Click);
            // 
            // SkinBlack
            // 
            this.SkinBlack.CheckOnClick = true;
            this.SkinBlack.Name = "SkinBlack";
            this.SkinBlack.Size = new System.Drawing.Size(127, 22);
            this.SkinBlack.Text = "Crna";
            this.SkinBlack.Click += new System.EventHandler(this.SkinBlack_Click);
            // 
            // SkinGray
            // 
            this.SkinGray.CheckOnClick = true;
            this.SkinGray.Name = "SkinGray";
            this.SkinGray.Size = new System.Drawing.Size(127, 22);
            this.SkinGray.Text = "Siva";
            this.SkinGray.Click += new System.EventHandler(this.SkinGray_Click);
            // 
            // SkinAqua
            // 
            this.SkinAqua.CheckOnClick = true;
            this.SkinAqua.Name = "SkinAqua";
            this.SkinAqua.Size = new System.Drawing.Size(127, 22);
            this.SkinAqua.Text = "Morska";
            this.SkinAqua.Click += new System.EventHandler(this.SkinTropic_Click);
            // 
            // ButtonTheme
            // 
            this.ButtonTheme.BackColor = System.Drawing.Color.White;
            this.ButtonTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonTheme.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTheme.Image = global::BenchPro.Properties.Resources.Theme;
            this.ButtonTheme.Location = new System.Drawing.Point(4, 96);
            this.ButtonTheme.Name = "ButtonTheme";
            this.ButtonTheme.Size = new System.Drawing.Size(156, 42);
            this.ButtonTheme.TabIndex = 20;
            this.ButtonTheme.Tag = "Promena teme aplikacije";
            this.ButtonTheme.Text = "Tema";
            this.ButtonTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonTheme.UseVisualStyleBackColor = false;
            this.ButtonTheme.Click += new System.EventHandler(this.ButtonTheme_Click);
            this.ButtonTheme.MouseEnter += new System.EventHandler(this.ButtonHover);
            this.ButtonTheme.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // ButtonMonte
            // 
            this.ButtonMonte.BackColor = System.Drawing.Color.White;
            this.ButtonMonte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonMonte.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMonte.Image = global::BenchPro.Properties.Resources.Pi;
            this.ButtonMonte.Location = new System.Drawing.Point(4, 6);
            this.ButtonMonte.Name = "ButtonMonte";
            this.ButtonMonte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonMonte.Size = new System.Drawing.Size(156, 42);
            this.ButtonMonte.TabIndex = 19;
            this.ButtonMonte.Tag = "Benčmark Monte-Carlo metodom";
            this.ButtonMonte.Text = "Monte-Carlo";
            this.ButtonMonte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonMonte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonMonte.UseVisualStyleBackColor = false;
            this.ButtonMonte.Click += new System.EventHandler(this.buttonMonte_Click);
            this.ButtonMonte.MouseEnter += new System.EventHandler(this.ButtonHover);
            this.ButtonMonte.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // Status
            // 
            this.Status.AutoSize = false;
            this.Status.Location = new System.Drawing.Point(0, 591);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(872, 22);
            this.Status.TabIndex = 18;
            // 
            // ButtonAuthor
            // 
            this.ButtonAuthor.BackColor = System.Drawing.Color.White;
            this.ButtonAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonAuthor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAuthor.Image = global::BenchPro.Properties.Resources.Author;
            this.ButtonAuthor.Location = new System.Drawing.Point(4, 141);
            this.ButtonAuthor.Name = "ButtonAuthor";
            this.ButtonAuthor.Size = new System.Drawing.Size(156, 42);
            this.ButtonAuthor.TabIndex = 17;
            this.ButtonAuthor.Tag = "Podaci o autoru aplikacije";
            this.ButtonAuthor.Text = "Autor";
            this.ButtonAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAuthor.UseVisualStyleBackColor = false;
            this.ButtonAuthor.Click += new System.EventHandler(this.buttonAuthor_Click);
            this.ButtonAuthor.MouseEnter += new System.EventHandler(this.ButtonHover);
            this.ButtonAuthor.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.White;
            this.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonExit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Image = global::BenchPro.Properties.Resources.Exit;
            this.ButtonExit.Location = new System.Drawing.Point(4, 186);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(156, 42);
            this.ButtonExit.TabIndex = 15;
            this.ButtonExit.Tag = "Kraj rada aplikacije";
            this.ButtonExit.Text = "Izađi";
            this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            this.ButtonExit.MouseEnter += new System.EventHandler(this.ButtonHover);
            this.ButtonExit.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // ButtonFloat
            // 
            this.ButtonFloat.BackColor = System.Drawing.Color.White;
            this.ButtonFloat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonFloat.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFloat.Image = global::BenchPro.Properties.Resources.Math;
            this.ButtonFloat.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonFloat.Location = new System.Drawing.Point(4, 51);
            this.ButtonFloat.Name = "ButtonFloat";
            this.ButtonFloat.Size = new System.Drawing.Size(156, 42);
            this.ButtonFloat.TabIndex = 13;
            this.ButtonFloat.Text = "Pokretni zarez";
            this.ButtonFloat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonFloat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonFloat.UseVisualStyleBackColor = false;
            this.ButtonFloat.Click += new System.EventHandler(this.ButtonFloat_Click);
            this.ButtonFloat.MouseEnter += new System.EventHandler(this.ButtonHover);
            this.ButtonFloat.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // Thread
            // 
            this.Thread.WorkerReportsProgress = true;
            this.Thread.WorkerSupportsCancellation = true;
            this.Thread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Thread_DoWork);
            this.Thread.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Thread_ProgressChanged);
            this.Thread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Thread_RunWorkerCompleted);
            // 
            // Hint
            // 
            this.Hint.AutoPopDelay = 5000;
            this.Hint.InitialDelay = 0;
            this.Hint.ReshowDelay = 100;
            // 
            // Battery
            // 
            this.Battery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Battery.BackColor = System.Drawing.Color.Transparent;
            this.Battery.Image = global::BenchPro.Properties.Resources.Battery;
            this.Battery.Location = new System.Drawing.Point(229, 93);
            this.Battery.Name = "Battery";
            this.Battery.Size = new System.Drawing.Size(48, 48);
            this.Battery.TabIndex = 33;
            this.Battery.TabStop = false;
            this.Hint.SetToolTip(this.Battery, "Procenat preostale baterije");
            this.Battery.Paint += new System.Windows.Forms.PaintEventHandler(this.Battery_Paint);
            // 
            // Memory
            // 
            this.Memory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Memory.BackColor = System.Drawing.Color.Transparent;
            this.Memory.Image = global::BenchPro.Properties.Resources.Memory;
            this.Memory.Location = new System.Drawing.Point(175, 93);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(48, 48);
            this.Memory.TabIndex = 34;
            this.Memory.TabStop = false;
            this.Hint.SetToolTip(this.Memory, "Procenat slobodne operativne memorije (RAM)");
            this.Memory.Paint += new System.Windows.Forms.PaintEventHandler(this.Memory_Paint);
            // 
            // AppMenu
            // 
            this.AppMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AppMenu.AutoSize = false;
            this.AppMenu.BackColor = System.Drawing.Color.White;
            this.AppMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.AppMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuMethod,
            this.MenuOptions,
            this.MenuAbout});
            this.AppMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.AppMenu.Location = new System.Drawing.Point(0, 35);
            this.AppMenu.Name = "AppMenu";
            this.AppMenu.Size = new System.Drawing.Size(872, 24);
            this.AppMenu.TabIndex = 25;
            this.AppMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubSaveAs,
            this.Separator1,
            this.SubRestart,
            this.SubExit});
            this.MenuFile.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(66, 20);
            this.MenuFile.Text = "Datoteka";
            this.MenuFile.Click += new System.EventHandler(this.MenuFile_Click);
            // 
            // SubSaveAs
            // 
            this.SubSaveAs.Enabled = false;
            this.SubSaveAs.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SubSaveAs.Name = "SubSaveAs";
            this.SubSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SubSaveAs.Size = new System.Drawing.Size(219, 22);
            this.SubSaveAs.Text = "Sačuvaj kao...";
            this.SubSaveAs.Click += new System.EventHandler(this.SubSaveAs_Click);
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(216, 6);
            // 
            // SubRestart
            // 
            this.SubRestart.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SubRestart.Name = "SubRestart";
            this.SubRestart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Space)));
            this.SubRestart.Size = new System.Drawing.Size(219, 22);
            this.SubRestart.Text = "Pokreni ponovo";
            this.SubRestart.Click += new System.EventHandler(this.SubRestart_Click);
            // 
            // SubExit
            // 
            this.SubExit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SubExit.Name = "SubExit";
            this.SubExit.ShortcutKeyDisplayString = "Esc";
            this.SubExit.Size = new System.Drawing.Size(219, 22);
            this.SubExit.Text = "Izađi";
            this.SubExit.Click += new System.EventHandler(this.SubExit_Click);
            // 
            // MenuMethod
            // 
            this.MenuMethod.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMonte,
            this.SubFloat});
            this.MenuMethod.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MenuMethod.Name = "MenuMethod";
            this.MenuMethod.Size = new System.Drawing.Size(60, 20);
            this.MenuMethod.Text = "Metoda";
            // 
            // SubMonte
            // 
            this.SubMonte.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SubMonte.Name = "SubMonte";
            this.SubMonte.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.SubMonte.Size = new System.Drawing.Size(187, 22);
            this.SubMonte.Text = "Monte-Carlo";
            this.SubMonte.Click += new System.EventHandler(this.SubMonte_Click);
            // 
            // SubFloat
            // 
            this.SubFloat.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SubFloat.Name = "SubFloat";
            this.SubFloat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.SubFloat.Size = new System.Drawing.Size(187, 22);
            this.SubFloat.Text = "Pokretni zarez";
            this.SubFloat.Click += new System.EventHandler(this.SubFloat_Click);
            // 
            // MenuOptions
            // 
            this.MenuOptions.BackColor = System.Drawing.Color.Transparent;
            this.MenuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temaToolStripMenuItem});
            this.MenuOptions.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MenuOptions.Name = "MenuOptions";
            this.MenuOptions.Size = new System.Drawing.Size(53, 20);
            this.MenuOptions.Text = "Opcije";
            // 
            // temaToolStripMenuItem
            // 
            this.temaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubBlue,
            this.SubGreen,
            this.SubRed,
            this.SubPurple,
            this.SubBlack,
            this.SubGray,
            this.SubAqua});
            this.temaToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            this.temaToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.temaToolStripMenuItem.Text = "Tema";
            // 
            // SubBlue
            // 
            this.SubBlue.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SubBlue.Name = "SubBlue";
            this.SubBlue.Size = new System.Drawing.Size(127, 22);
            this.SubBlue.Text = "Plava";
            this.SubBlue.Click += new System.EventHandler(this.SubBlue_Click);
            // 
            // SubGreen
            // 
            this.SubGreen.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.SubGreen.Name = "SubGreen";
            this.SubGreen.Size = new System.Drawing.Size(127, 22);
            this.SubGreen.Text = "Zelena";
            this.SubGreen.Click += new System.EventHandler(this.SubGreen_Click);
            // 
            // SubRed
            // 
            this.SubRed.ForeColor = System.Drawing.Color.Red;
            this.SubRed.Name = "SubRed";
            this.SubRed.Size = new System.Drawing.Size(127, 22);
            this.SubRed.Text = "Crvena";
            this.SubRed.Click += new System.EventHandler(this.SubRed_Click);
            // 
            // SubPurple
            // 
            this.SubPurple.ForeColor = System.Drawing.Color.DarkViolet;
            this.SubPurple.Name = "SubPurple";
            this.SubPurple.Size = new System.Drawing.Size(127, 22);
            this.SubPurple.Text = "Ljubičasta";
            this.SubPurple.Click += new System.EventHandler(this.SubPurple_Click);
            // 
            // SubBlack
            // 
            this.SubBlack.Name = "SubBlack";
            this.SubBlack.Size = new System.Drawing.Size(127, 22);
            this.SubBlack.Text = "Crna";
            this.SubBlack.Click += new System.EventHandler(this.SubBlack_Click);
            // 
            // SubGray
            // 
            this.SubGray.ForeColor = System.Drawing.Color.Gray;
            this.SubGray.Name = "SubGray";
            this.SubGray.Size = new System.Drawing.Size(127, 22);
            this.SubGray.Text = "Siva";
            this.SubGray.Click += new System.EventHandler(this.SubGray_Click);
            // 
            // SubAqua
            // 
            this.SubAqua.ForeColor = System.Drawing.Color.Turquoise;
            this.SubAqua.Name = "SubAqua";
            this.SubAqua.Size = new System.Drawing.Size(127, 22);
            this.SubAqua.Text = "Morska";
            this.SubAqua.Click += new System.EventHandler(this.SubAqua_Click);
            // 
            // MenuAbout
            // 
            this.MenuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubAuthor,
            this.SubWeb});
            this.MenuAbout.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(37, 20);
            this.MenuAbout.Text = "O...";
            // 
            // SubAuthor
            // 
            this.SubAuthor.ForeColor = System.Drawing.Color.SteelBlue;
            this.SubAuthor.Name = "SubAuthor";
            this.SubAuthor.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.SubAuthor.Size = new System.Drawing.Size(130, 22);
            this.SubAuthor.Text = "Autor";
            this.SubAuthor.Click += new System.EventHandler(this.SubAuthor_Click);
            // 
            // SubWeb
            // 
            this.SubWeb.ForeColor = System.Drawing.Color.SteelBlue;
            this.SubWeb.Name = "SubWeb";
            this.SubWeb.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.SubWeb.Size = new System.Drawing.Size(130, 22);
            this.SubWeb.Text = "Vebsajt";
            this.SubWeb.Click += new System.EventHandler(this.vebsajtToolStripMenuItem_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Filter = "Svi podržani formati (*.bmp, *.jpg, *.png, *.txt)|*.bmp;*.jpg;*.png|BMP slike (*." +
    "bmp)|*.bmp|JPEG slike (*.jpg)|*.jpg|PNG slike (*.png)|*.png|Tekstualne datoteke " +
    "(*.txt)|*txt";
            this.SaveFile.Title = "Sačuvaj kao...";
            // 
            // XApp
            // 
            this.XApp.StartInfo.Domain = "";
            this.XApp.StartInfo.LoadUserProfile = false;
            this.XApp.StartInfo.Password = null;
            this.XApp.StartInfo.StandardErrorEncoding = null;
            this.XApp.StartInfo.StandardOutputEncoding = null;
            this.XApp.StartInfo.UserName = "";
            this.XApp.StartInfo.Verb = "open";
            this.XApp.SynchronizingObject = this;
            // 
            // Info
            // 
            this.Info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Info.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Info.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.Info.ColumnCount = 6;
            this.Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.4F));
            this.Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.4F));
            this.Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.4F));
            this.Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.4F));
            this.Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.4F));
            this.Info.Controls.Add(this.Processor, 0, 1);
            this.Info.Controls.Add(this.Cores, 0, 1);
            this.Info.Controls.Add(this.DataWidth, 0, 1);
            this.Info.Controls.Add(this.HeadingData, 2, 0);
            this.Info.Controls.Add(this.HeadingCores, 1, 0);
            this.Info.Controls.Add(this.RAM, 0, 1);
            this.Info.Controls.Add(this.L3, 2, 1);
            this.Info.Controls.Add(this.L2, 1, 1);
            this.Info.Controls.Add(this.HeadingProcessor, 0, 0);
            this.Info.Controls.Add(this.HeadingRAM, 3, 0);
            this.Info.Controls.Add(this.HeadingL2, 4, 0);
            this.Info.Controls.Add(this.HeadingL3, 5, 0);
            this.Info.Location = new System.Drawing.Point(175, 363);
            this.Info.Name = "Info";
            this.Info.RowCount = 2;
            this.Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.75F));
            this.Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.25F));
            this.Info.Size = new System.Drawing.Size(684, 115);
            this.Info.TabIndex = 31;
            // 
            // Processor
            // 
            this.Processor.BackColor = System.Drawing.Color.SteelBlue;
            this.Processor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Processor.ForeColor = System.Drawing.Color.White;
            this.Processor.Location = new System.Drawing.Point(6, 52);
            this.Processor.Name = "Processor";
            this.Processor.Size = new System.Drawing.Size(245, 60);
            this.Processor.TabIndex = 11;
            this.Processor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cores
            // 
            this.Cores.BackColor = System.Drawing.Color.SteelBlue;
            this.Cores.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cores.ForeColor = System.Drawing.Color.White;
            this.Cores.Location = new System.Drawing.Point(260, 52);
            this.Cores.Name = "Cores";
            this.Cores.Size = new System.Drawing.Size(76, 60);
            this.Cores.TabIndex = 10;
            this.Cores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataWidth
            // 
            this.DataWidth.BackColor = System.Drawing.Color.SteelBlue;
            this.DataWidth.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataWidth.ForeColor = System.Drawing.Color.White;
            this.DataWidth.Location = new System.Drawing.Point(345, 52);
            this.DataWidth.Name = "DataWidth";
            this.DataWidth.Size = new System.Drawing.Size(76, 60);
            this.DataWidth.TabIndex = 9;
            this.DataWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeadingData
            // 
            this.HeadingData.BackColor = System.Drawing.Color.DodgerBlue;
            this.HeadingData.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingData.ForeColor = System.Drawing.Color.White;
            this.HeadingData.Location = new System.Drawing.Point(345, 3);
            this.HeadingData.Name = "HeadingData";
            this.HeadingData.Size = new System.Drawing.Size(76, 46);
            this.HeadingData.TabIndex = 2;
            this.HeadingData.Text = "Širina magistrale";
            this.HeadingData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeadingCores
            // 
            this.HeadingCores.BackColor = System.Drawing.Color.DodgerBlue;
            this.HeadingCores.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingCores.ForeColor = System.Drawing.Color.White;
            this.HeadingCores.Location = new System.Drawing.Point(260, 3);
            this.HeadingCores.Name = "HeadingCores";
            this.HeadingCores.Size = new System.Drawing.Size(76, 46);
            this.HeadingCores.TabIndex = 1;
            this.HeadingCores.Text = "Broj jezgara";
            this.HeadingCores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RAM
            // 
            this.RAM.BackColor = System.Drawing.Color.SteelBlue;
            this.RAM.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAM.ForeColor = System.Drawing.Color.White;
            this.RAM.Location = new System.Drawing.Point(430, 52);
            this.RAM.Name = "RAM";
            this.RAM.Size = new System.Drawing.Size(76, 60);
            this.RAM.TabIndex = 5;
            this.RAM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L3
            // 
            this.L3.BackColor = System.Drawing.Color.SteelBlue;
            this.L3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L3.ForeColor = System.Drawing.Color.White;
            this.L3.Location = new System.Drawing.Point(600, 52);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(78, 60);
            this.L3.TabIndex = 3;
            this.L3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L2
            // 
            this.L2.BackColor = System.Drawing.Color.SteelBlue;
            this.L2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2.ForeColor = System.Drawing.Color.White;
            this.L2.Location = new System.Drawing.Point(515, 52);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(76, 60);
            this.L2.TabIndex = 4;
            this.L2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeadingProcessor
            // 
            this.HeadingProcessor.BackColor = System.Drawing.Color.DodgerBlue;
            this.HeadingProcessor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingProcessor.ForeColor = System.Drawing.Color.White;
            this.HeadingProcessor.Location = new System.Drawing.Point(6, 3);
            this.HeadingProcessor.Name = "HeadingProcessor";
            this.HeadingProcessor.Size = new System.Drawing.Size(245, 46);
            this.HeadingProcessor.TabIndex = 6;
            this.HeadingProcessor.Text = "Procesor";
            this.HeadingProcessor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeadingRAM
            // 
            this.HeadingRAM.BackColor = System.Drawing.Color.DodgerBlue;
            this.HeadingRAM.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingRAM.ForeColor = System.Drawing.Color.White;
            this.HeadingRAM.Location = new System.Drawing.Point(430, 3);
            this.HeadingRAM.Name = "HeadingRAM";
            this.HeadingRAM.Size = new System.Drawing.Size(76, 46);
            this.HeadingRAM.TabIndex = 0;
            this.HeadingRAM.Text = "RAM";
            this.HeadingRAM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeadingL2
            // 
            this.HeadingL2.BackColor = System.Drawing.Color.DodgerBlue;
            this.HeadingL2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingL2.ForeColor = System.Drawing.Color.White;
            this.HeadingL2.Location = new System.Drawing.Point(515, 3);
            this.HeadingL2.Name = "HeadingL2";
            this.HeadingL2.Size = new System.Drawing.Size(76, 46);
            this.HeadingL2.TabIndex = 7;
            this.HeadingL2.Text = "L2";
            this.HeadingL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeadingL3
            // 
            this.HeadingL3.BackColor = System.Drawing.Color.DodgerBlue;
            this.HeadingL3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingL3.ForeColor = System.Drawing.Color.White;
            this.HeadingL3.Location = new System.Drawing.Point(600, 3);
            this.HeadingL3.Name = "HeadingL3";
            this.HeadingL3.Size = new System.Drawing.Size(78, 46);
            this.HeadingL3.TabIndex = 8;
            this.HeadingL3.Text = "L3";
            this.HeadingL3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelNumIter
            // 
            this.LabelNumIter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelNumIter.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumIter.ForeColor = System.Drawing.Color.White;
            this.LabelNumIter.Location = new System.Drawing.Point(734, 70);
            this.LabelNumIter.Name = "LabelNumIter";
            this.LabelNumIter.Size = new System.Drawing.Size(111, 15);
            this.LabelNumIter.TabIndex = 30;
            this.LabelNumIter.Text = "Broj iteracija:";
            // 
            // ComboNumIter
            // 
            this.ComboNumIter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboNumIter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboNumIter.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboNumIter.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ComboNumIter.FormattingEnabled = true;
            this.ComboNumIter.Items.AddRange(new object[] {
            "100",
            "500",
            "1000",
            "5000",
            "Proizvoljno..."});
            this.ComboNumIter.Location = new System.Drawing.Point(737, 88);
            this.ComboNumIter.Name = "ComboNumIter";
            this.ComboNumIter.Size = new System.Drawing.Size(122, 23);
            this.ComboNumIter.TabIndex = 29;
            this.ComboNumIter.SelectedIndexChanged += new System.EventHandler(this.ComboNumIter_SelectedIndexChanged);
            // 
            // Results
            // 
            this.Results.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Results.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Results.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.Results.ColumnCount = 3;
            this.Results.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.99933F));
            this.Results.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.66845F));
            this.Results.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33222F));
            this.Results.Controls.Add(this.HeadingTotal, 2, 0);
            this.Results.Controls.Add(this.HeadingMean, 1, 0);
            this.Results.Controls.Add(this.HeadingIterations, 0, 0);
            this.Results.Controls.Add(this.Iterations, 0, 1);
            this.Results.Controls.Add(this.Total, 2, 1);
            this.Results.Controls.Add(this.Mean, 1, 1);
            this.Results.Location = new System.Drawing.Point(175, 233);
            this.Results.Name = "Results";
            this.Results.RowCount = 2;
            this.Results.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.75F));
            this.Results.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.25F));
            this.Results.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Results.Size = new System.Drawing.Size(684, 115);
            this.Results.TabIndex = 28;
            // 
            // HeadingTotal
            // 
            this.HeadingTotal.BackColor = System.Drawing.Color.DodgerBlue;
            this.HeadingTotal.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingTotal.ForeColor = System.Drawing.Color.White;
            this.HeadingTotal.Location = new System.Drawing.Point(459, 3);
            this.HeadingTotal.Name = "HeadingTotal";
            this.HeadingTotal.Size = new System.Drawing.Size(219, 46);
            this.HeadingTotal.TabIndex = 2;
            this.HeadingTotal.Text = "Ukupno vreme izvršavanja";
            this.HeadingTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeadingMean
            // 
            this.HeadingMean.BackColor = System.Drawing.Color.DodgerBlue;
            this.HeadingMean.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingMean.ForeColor = System.Drawing.Color.White;
            this.HeadingMean.Location = new System.Drawing.Point(143, 3);
            this.HeadingMean.Name = "HeadingMean";
            this.HeadingMean.Size = new System.Drawing.Size(307, 46);
            this.HeadingMean.TabIndex = 1;
            this.HeadingMean.Text = "Prosečno vreme izvršavanja";
            this.HeadingMean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeadingIterations
            // 
            this.HeadingIterations.BackColor = System.Drawing.Color.DodgerBlue;
            this.HeadingIterations.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingIterations.ForeColor = System.Drawing.Color.White;
            this.HeadingIterations.Location = new System.Drawing.Point(6, 3);
            this.HeadingIterations.Name = "HeadingIterations";
            this.HeadingIterations.Size = new System.Drawing.Size(128, 46);
            this.HeadingIterations.TabIndex = 0;
            this.HeadingIterations.Text = "Broj iteracija";
            this.HeadingIterations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Iterations
            // 
            this.Iterations.BackColor = System.Drawing.Color.SteelBlue;
            this.Iterations.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iterations.ForeColor = System.Drawing.Color.White;
            this.Iterations.Location = new System.Drawing.Point(6, 52);
            this.Iterations.Name = "Iterations";
            this.Iterations.Size = new System.Drawing.Size(128, 60);
            this.Iterations.TabIndex = 5;
            this.Iterations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Total
            // 
            this.Total.BackColor = System.Drawing.Color.SteelBlue;
            this.Total.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.White;
            this.Total.Location = new System.Drawing.Point(459, 52);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(219, 60);
            this.Total.TabIndex = 3;
            this.Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mean
            // 
            this.Mean.BackColor = System.Drawing.Color.SteelBlue;
            this.Mean.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mean.ForeColor = System.Drawing.Color.White;
            this.Mean.Location = new System.Drawing.Point(143, 52);
            this.Mean.Name = "Mean";
            this.Mean.Size = new System.Drawing.Size(307, 60);
            this.Mean.TabIndex = 4;
            this.Mean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RunButton
            // 
            this.RunButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RunButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RunButton.BackgroundImage")));
            this.RunButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RunButton.Controls.Add(this.LabelPercentage);
            this.RunButton.Location = new System.Drawing.Point(448, 70);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(128, 129);
            this.RunButton.TabIndex = 27;
            // 
            // LabelPercentage
            // 
            this.LabelPercentage.BackColor = System.Drawing.Color.Transparent;
            this.LabelPercentage.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPercentage.ForeColor = System.Drawing.Color.White;
            this.LabelPercentage.Location = new System.Drawing.Point(0, 0);
            this.LabelPercentage.Name = "LabelPercentage";
            this.LabelPercentage.Size = new System.Drawing.Size(128, 129);
            this.LabelPercentage.TabIndex = 3;
            this.LabelPercentage.Text = "Pokreni";
            this.LabelPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelPercentage.Click += new System.EventHandler(this.LabelPercentage_Click);
            this.LabelPercentage.MouseEnter += new System.EventHandler(this.HandCursor);
            this.LabelPercentage.MouseLeave += new System.EventHandler(this.PointerCursor);
            // 
            // LabelDescription
            // 
            this.LabelDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelDescription.BackColor = System.Drawing.Color.Black;
            this.LabelDescription.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescription.ForeColor = System.Drawing.Color.White;
            this.LabelDescription.Location = new System.Drawing.Point(175, 491);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(684, 90);
            this.LabelDescription.TabIndex = 26;
            this.LabelDescription.Text = "...";
            this.LabelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusText
            // 
            this.StatusText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusText.BackColor = System.Drawing.Color.White;
            this.StatusText.ForeColor = System.Drawing.Color.Black;
            this.StatusText.Location = new System.Drawing.Point(0, 591);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(873, 22);
            this.StatusText.TabIndex = 24;
            this.StatusText.Text = "BenchPro";
            this.StatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusText.Paint += new System.Windows.Forms.PaintEventHandler(this.StatusText_Paint);
            // 
            // PanelCmds
            // 
            this.PanelCmds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelCmds.BackColor = System.Drawing.Color.White;
            this.PanelCmds.Controls.Add(this.ButtonMonte);
            this.PanelCmds.Controls.Add(this.ButtonExit);
            this.PanelCmds.Controls.Add(this.ButtonTheme);
            this.PanelCmds.Controls.Add(this.ButtonAuthor);
            this.PanelCmds.Controls.Add(this.ButtonFloat);
            this.PanelCmds.Location = new System.Drawing.Point(0, 59);
            this.PanelCmds.Name = "PanelCmds";
            this.PanelCmds.Size = new System.Drawing.Size(163, 532);
            this.PanelCmds.TabIndex = 32;
            this.PanelCmds.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCmds_Paint);
            this.PanelCmds.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
            // 
            // PollTimer
            // 
            this.PollTimer.Interval = 800;
            this.PollTimer.Tick += new System.EventHandler(this.PollTimer_Tick);
            // 
            // CheckRealtime
            // 
            this.CheckRealtime.AutoSize = true;
            this.CheckRealtime.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.CheckRealtime.ForeColor = System.Drawing.Color.White;
            this.CheckRealtime.Location = new System.Drawing.Point(178, 70);
            this.CheckRealtime.Name = "CheckRealtime";
            this.CheckRealtime.Size = new System.Drawing.Size(133, 19);
            this.CheckRealtime.TabIndex = 35;
            this.CheckRealtime.Text = "U realnom vremenu";
            this.CheckRealtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckRealtime.UseVisualStyleBackColor = true;
            this.CheckRealtime.Click += new System.EventHandler(this.CheckRealtime_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(872, 613);
            this.ControlBox = false;
            this.Controls.Add(this.CheckRealtime);
            this.Controls.Add(this.Memory);
            this.Controls.Add(this.Battery);
            this.Controls.Add(this.PanelCmds);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.LabelNumIter);
            this.Controls.Add(this.ComboNumIter);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.AppMenu);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.AppBar);
            this.Controls.Add(this.Status);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.AppMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(874, 615);
            this.MinimumSize = new System.Drawing.Size(874, 615);
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UI_Load);
            this.Shown += new System.EventHandler(this.UI_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UI_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
            this.Move += new System.EventHandler(this.UI_Move);
            this.AppBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppSkin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).EndInit();
            this.PopupSkin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Battery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Memory)).EndInit();
            this.AppMenu.ResumeLayout(false);
            this.AppMenu.PerformLayout();
            this.Info.ResumeLayout(false);
            this.Results.ResumeLayout(false);
            this.RunButton.ResumeLayout(false);
            this.PanelCmds.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel AppBar;
        private System.Windows.Forms.PictureBox AppIcon;
        private System.Windows.Forms.Label AppTitle;
        private System.Windows.Forms.ToolStripMenuItem SkinBlue;
        private System.Windows.Forms.ContextMenuStrip PopupSkin;
        private System.Windows.Forms.Button ButtonTheme;
        private System.Windows.Forms.Button ButtonMonte;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.Button ButtonAuthor;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonFloat;
        private System.ComponentModel.BackgroundWorker Thread;
        private System.Windows.Forms.ToolTip Hint;
        private System.Windows.Forms.ToolStripMenuItem SkinGreen;
        private System.Windows.Forms.ToolStripMenuItem SkinRed;
        private System.Windows.Forms.ToolStripMenuItem SkinPurple;
        private System.Windows.Forms.ToolStripMenuItem SkinBlack;
        private System.Windows.Forms.ToolStripMenuItem SkinGray;
        private System.Windows.Forms.ToolStripMenuItem SkinAqua;
        private System.Windows.Forms.MenuStrip AppMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuMethod;
        private System.Windows.Forms.ToolStripMenuItem MenuOptions;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.ToolStripMenuItem SubSaveAs;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.ToolStripMenuItem SubExit;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.ToolStripMenuItem temaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SubAuthor;
        private System.Windows.Forms.ToolStripMenuItem SubWeb;
        private System.Diagnostics.Process XApp;
        private System.Windows.Forms.ToolStripMenuItem SubBlue;
        private System.Windows.Forms.ToolStripMenuItem SubGreen;
        private System.Windows.Forms.ToolStripMenuItem SubRed;
        private System.Windows.Forms.ToolStripMenuItem SubPurple;
        private System.Windows.Forms.ToolStripMenuItem SubBlack;
        private System.Windows.Forms.ToolStripMenuItem SubGray;
        private System.Windows.Forms.ToolStripMenuItem SubAqua;
        private System.Windows.Forms.ToolStripMenuItem SubMonte;
        private System.Windows.Forms.ToolStripMenuItem SubFloat;
        private System.Windows.Forms.TableLayoutPanel Info;
        private System.Windows.Forms.Label Processor;
        private System.Windows.Forms.Label Cores;
        private System.Windows.Forms.Label DataWidth;
        private System.Windows.Forms.Label HeadingData;
        private System.Windows.Forms.Label HeadingCores;
        private System.Windows.Forms.Label RAM;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label HeadingProcessor;
        private System.Windows.Forms.Label HeadingRAM;
        private System.Windows.Forms.Label HeadingL2;
        private System.Windows.Forms.Label HeadingL3;
        private System.Windows.Forms.Label LabelNumIter;
        private System.Windows.Forms.ComboBox ComboNumIter;
        private System.Windows.Forms.TableLayoutPanel Results;
        private System.Windows.Forms.Label HeadingTotal;
        private System.Windows.Forms.Label HeadingMean;
        private System.Windows.Forms.Label HeadingIterations;
        private System.Windows.Forms.Label Iterations;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Mean;
        private System.Windows.Forms.Panel RunButton;
        private System.Windows.Forms.Label LabelPercentage;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.PictureBox AppSkin;
        private System.Windows.Forms.PictureBox AppClose;
        private System.Windows.Forms.PictureBox AppMinimize;
        private System.Windows.Forms.Panel PanelCmds;
        private System.Windows.Forms.PictureBox Battery;
        private System.Windows.Forms.PictureBox Memory;
        private System.Windows.Forms.ToolStripMenuItem SubRestart;
        private System.Windows.Forms.Timer PollTimer;
        private System.Windows.Forms.CheckBox CheckRealtime;
    }
}

