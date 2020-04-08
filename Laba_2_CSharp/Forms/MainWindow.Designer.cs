namespace Laba_2_CSharp.Forms
{
    partial class MainWindow
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
            Guna.UI.Animation.Animation animation8 = new Guna.UI.Animation.Animation();
            Guna.UI.Animation.Animation animation7 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CollapseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.ExitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MenuPanel = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveYourFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveUncryptedMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveEncryptedMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openYourFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFormSurface = new Guna.UI.WinForms.GunaElipse(this.components);
            this.InitializeAnimation = new Guna.UI.WinForms.GunaTransition(this.components);
            this.PopupPanel = new System.Windows.Forms.Panel();
            this.PopupPictureBox = new System.Windows.Forms.PictureBox();
            this.PopupLabel = new System.Windows.Forms.Label();
            this.UncryptedTextbox = new System.Windows.Forms.TextBox();
            this.EnterYourTextGroupbox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Label = new System.Windows.Forms.Label();
            this.EncryptedTextbox = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.EncodeRadioButton = new System.Windows.Forms.RadioButton();
            this.DecodeRadioButton = new System.Windows.Forms.RadioButton();
            this.ModeGroupbox = new System.Windows.Forms.GroupBox();
            this.MethodGroupbox = new System.Windows.Forms.GroupBox();
            this.VigenereRadioButton = new System.Windows.Forms.RadioButton();
            this.AtbashRadioButton = new System.Windows.Forms.RadioButton();
            this.KeywordGroupbox = new System.Windows.Forms.GroupBox();
            this.KeywordTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HelpPopupPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.HelpPopupLabel = new System.Windows.Forms.Label();
            this.SwapText = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.PopupTransition = new Guna.UI.WinForms.GunaTransition(this.components);
            this.PopupElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CollapseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.PopupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupPictureBox)).BeginInit();
            this.EnterYourTextGroupbox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ModeGroupbox.SuspendLayout();
            this.MethodGroupbox.SuspendLayout();
            this.KeywordGroupbox.SuspendLayout();
            this.HelpPopupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.TopPanel.Controls.Add(this.CollapseButton);
            this.TopPanel.Controls.Add(this.ExitButton);
            this.TopPanel.Controls.Add(this.MenuPanel);
            this.PopupTransition.SetDecoration(this.TopPanel, Guna.UI.Animation.DecorationType.None);
            this.InitializeAnimation.SetDecoration(this.TopPanel, Guna.UI.Animation.DecorationType.None);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1292, 34);
            this.TopPanel.TabIndex = 1;
            // 
            // CollapseButton
            // 
            this.CollapseButton.BackColor = System.Drawing.Color.Transparent;
            this.PopupTransition.SetDecoration(this.CollapseButton, Guna.UI.Animation.DecorationType.None);
            this.InitializeAnimation.SetDecoration(this.CollapseButton, Guna.UI.Animation.DecorationType.None);
            this.CollapseButton.Image = ((System.Drawing.Image)(resources.GetObject("CollapseButton.Image")));
            this.CollapseButton.ImageActive = null;
            this.CollapseButton.Location = new System.Drawing.Point(1227, -1);
            this.CollapseButton.Name = "CollapseButton";
            this.CollapseButton.Size = new System.Drawing.Size(27, 29);
            this.CollapseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CollapseButton.TabIndex = 4;
            this.CollapseButton.TabStop = false;
            this.CollapseButton.Zoom = 10;
            this.CollapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.PopupTransition.SetDecoration(this.ExitButton, Guna.UI.Animation.DecorationType.None);
            this.InitializeAnimation.SetDecoration(this.ExitButton, Guna.UI.Animation.DecorationType.None);
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageActive = null;
            this.ExitButton.Location = new System.Drawing.Point(1260, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(29, 29);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButton.TabIndex = 3;
            this.ExitButton.TabStop = false;
            this.ExitButton.Zoom = 10;
            this.ExitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.PopupTransition.SetDecoration(this.MenuPanel, Guna.UI.Animation.DecorationType.None);
            this.InitializeAnimation.SetDecoration(this.MenuPanel, Guna.UI.Animation.DecorationType.None);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu});
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1292, 34);
            this.MenuPanel.TabIndex = 5;
            this.MenuPanel.Text = "MenuPnel";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveYourFileToolStripMenuItem,
            this.openYourFileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.FileMenu.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(60, 30);
            this.FileMenu.Text = "File";
            // 
            // saveYourFileToolStripMenuItem
            // 
            this.saveYourFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.saveYourFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveUncryptedMenu,
            this.SaveEncryptedMenu});
            this.saveYourFileToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveYourFileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveYourFileToolStripMenuItem.Name = "saveYourFileToolStripMenuItem";
            this.saveYourFileToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.saveYourFileToolStripMenuItem.Text = "Save Your file";
            // 
            // SaveUncryptedMenu
            // 
            this.SaveUncryptedMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SaveUncryptedMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveUncryptedMenu.Name = "SaveUncryptedMenu";
            this.SaveUncryptedMenu.Size = new System.Drawing.Size(266, 22);
            this.SaveUncryptedMenu.Text = "Save uncrypted text";
            this.SaveUncryptedMenu.Click += new System.EventHandler(this.SaveUncryptedMenu_Click);
            // 
            // SaveEncryptedMenu
            // 
            this.SaveEncryptedMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SaveEncryptedMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveEncryptedMenu.Name = "SaveEncryptedMenu";
            this.SaveEncryptedMenu.Size = new System.Drawing.Size(266, 22);
            this.SaveEncryptedMenu.Text = "Save encrypted text";
            this.SaveEncryptedMenu.Click += new System.EventHandler(this.SaveEncryptedMenu_Click);
            // 
            // openYourFileToolStripMenuItem
            // 
            this.openYourFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.openYourFileToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openYourFileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.openYourFileToolStripMenuItem.Name = "openYourFileToolStripMenuItem";
            this.openYourFileToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.openYourFileToolStripMenuItem.Text = "Open Your file";
            this.openYourFileToolStripMenuItem.Click += new System.EventHandler(this.openYourFileToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainFormSurface
            // 
            this.MainFormSurface.Radius = 15;
            this.MainFormSurface.TargetControl = this;
            // 
            // InitializeAnimation
            // 
            this.InitializeAnimation.AnimationType = Guna.UI.Animation.AnimationType.Transparent;
            this.InitializeAnimation.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 0;
            animation8.Padding = new System.Windows.Forms.Padding(0);
            animation8.RotateCoeff = 0F;
            animation8.RotateLimit = 0F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 0F;
            animation8.TransparencyCoeff = 1F;
            this.InitializeAnimation.DefaultAnimation = animation8;
            this.InitializeAnimation.TimeStep = 0.03F;
            // 
            // PopupPanel
            // 
            this.PopupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.PopupPanel.Controls.Add(this.PopupPictureBox);
            this.PopupPanel.Controls.Add(this.PopupLabel);
            this.PopupTransition.SetDecoration(this.PopupPanel, Guna.UI.Animation.DecorationType.None);
            this.InitializeAnimation.SetDecoration(this.PopupPanel, Guna.UI.Animation.DecorationType.None);
            this.PopupPanel.Location = new System.Drawing.Point(912, 554);
            this.PopupPanel.Name = "PopupPanel";
            this.PopupPanel.Size = new System.Drawing.Size(368, 57);
            this.PopupPanel.TabIndex = 2;
            this.PopupPanel.Visible = false;
            // 
            // PopupPictureBox
            // 
            this.InitializeAnimation.SetDecoration(this.PopupPictureBox, Guna.UI.Animation.DecorationType.None);
            this.PopupTransition.SetDecoration(this.PopupPictureBox, Guna.UI.Animation.DecorationType.None);
            this.PopupPictureBox.Image = global::Laba_2_CSharp.Properties.Resources.ErrorPhoto;
            this.PopupPictureBox.Location = new System.Drawing.Point(17, 3);
            this.PopupPictureBox.Name = "PopupPictureBox";
            this.PopupPictureBox.Size = new System.Drawing.Size(76, 54);
            this.PopupPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PopupPictureBox.TabIndex = 3;
            this.PopupPictureBox.TabStop = false;
            // 
            // PopupLabel
            // 
            this.PopupLabel.AutoSize = true;
            this.InitializeAnimation.SetDecoration(this.PopupLabel, Guna.UI.Animation.DecorationType.None);
            this.PopupTransition.SetDecoration(this.PopupLabel, Guna.UI.Animation.DecorationType.None);
            this.PopupLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PopupLabel.ForeColor = System.Drawing.Color.Silver;
            this.PopupLabel.Location = new System.Drawing.Point(99, 19);
            this.PopupLabel.Name = "PopupLabel";
            this.PopupLabel.Size = new System.Drawing.Size(250, 21);
            this.PopupLabel.TabIndex = 0;
            this.PopupLabel.Text = "New features are coming soon!";
            // 
            // UncryptedTextbox
            // 
            this.UncryptedTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.UncryptedTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InitializeAnimation.SetDecoration(this.UncryptedTextbox, Guna.UI.Animation.DecorationType.None);
            this.PopupTransition.SetDecoration(this.UncryptedTextbox, Guna.UI.Animation.DecorationType.None);
            this.UncryptedTextbox.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UncryptedTextbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.UncryptedTextbox.Location = new System.Drawing.Point(6, 19);
            this.UncryptedTextbox.Multiline = true;
            this.UncryptedTextbox.Name = "UncryptedTextbox";
            this.UncryptedTextbox.Size = new System.Drawing.Size(548, 459);
            this.UncryptedTextbox.TabIndex = 3;
            this.UncryptedTextbox.TextChanged += new System.EventHandler(this.TextChangedEvent);
            this.UncryptedTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTextKeyPressed);
            this.UncryptedTextbox.MouseEnter += new System.EventHandler(this.MouseEnterDecrypted);
            this.UncryptedTextbox.MouseLeave += new System.EventHandler(this.MouseLeaveDecrypted);
            // 
            // EnterYourTextGroupbox
            // 
            this.EnterYourTextGroupbox.Controls.Add(this.UncryptedTextbox);
            this.PopupTransition.SetDecoration(this.EnterYourTextGroupbox, Guna.UI.Animation.DecorationType.None);
            this.InitializeAnimation.SetDecoration(this.EnterYourTextGroupbox, Guna.UI.Animation.DecorationType.None);
            this.EnterYourTextGroupbox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterYourTextGroupbox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EnterYourTextGroupbox.Location = new System.Drawing.Point(12, 37);
            this.EnterYourTextGroupbox.Name = "EnterYourTextGroupbox";
            this.EnterYourTextGroupbox.Size = new System.Drawing.Size(560, 481);
            this.EnterYourTextGroupbox.TabIndex = 4;
            this.EnterYourTextGroupbox.TabStop = false;
            this.EnterYourTextGroupbox.Text = "Enter Your Text";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Label);
            this.groupBox2.Controls.Add(this.EncryptedTextbox);
            this.PopupTransition.SetDecoration(this.groupBox2, Guna.UI.Animation.DecorationType.None);
            this.InitializeAnimation.SetDecoration(this.groupBox2, Guna.UI.Animation.DecorationType.None);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(723, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(557, 484);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.InitializeAnimation.SetDecoration(this.Label, Guna.UI.Animation.DecorationType.None);
            this.PopupTransition.SetDecoration(this.Label, Guna.UI.Animation.DecorationType.None);
            this.Label.Location = new System.Drawing.Point(387, 3);
            this.Label.Name = "Label";
            this.Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label.Size = new System.Drawing.Size(164, 21);
            this.Label.TabIndex = 4;
            this.Label.Text = "Encrypted Text";
            this.Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // EncryptedTextbox
            // 
            this.EncryptedTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.EncryptedTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InitializeAnimation.SetDecoration(this.EncryptedTextbox, Guna.UI.Animation.DecorationType.None);
            this.PopupTransition.SetDecoration(this.EncryptedTextbox, Guna.UI.Animation.DecorationType.None);
            this.EncryptedTextbox.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncryptedTextbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.EncryptedTextbox.Location = new System.Drawing.Point(6, 19);
            this.EncryptedTextbox.Multiline = true;
            this.EncryptedTextbox.Name = "EncryptedTextbox";
            this.EncryptedTextbox.ReadOnly = true;
            this.EncryptedTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EncryptedTextbox.Size = new System.Drawing.Size(545, 459);
            this.EncryptedTextbox.TabIndex = 3;
            this.EncryptedTextbox.MouseEnter += new System.EventHandler(this.MouseEnterEncrypted);
            this.EncryptedTextbox.MouseLeave += new System.EventHandler(this.MouseLeaveEncrypted);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.InitializeAnimation.SetDecoration(this.radioButton1, Guna.UI.Animation.DecorationType.None);
            this.PopupTransition.SetDecoration(this.radioButton1, Guna.UI.Animation.DecorationType.None);
            this.radioButton1.Location = new System.Drawing.Point(-15, -15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(106, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // EncodeRadioButton
            // 
            this.EncodeRadioButton.AutoSize = true;
            this.EncodeRadioButton.Checked = true;
            this.InitializeAnimation.SetDecoration(this.EncodeRadioButton, Guna.UI.Animation.DecorationType.None);
            this.PopupTransition.SetDecoration(this.EncodeRadioButton, Guna.UI.Animation.DecorationType.None);
            this.EncodeRadioButton.Location = new System.Drawing.Point(6, 20);
            this.EncodeRadioButton.Name = "EncodeRadioButton";
            this.EncodeRadioButton.Size = new System.Drawing.Size(106, 27);
            this.EncodeRadioButton.TabIndex = 9;
            this.EncodeRadioButton.TabStop = true;
            this.EncodeRadioButton.Text = "Encode";
            this.EncodeRadioButton.UseVisualStyleBackColor = true;
            this.EncodeRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChangedEncode);
            this.EncodeRadioButton.MouseEnter += new System.EventHandler(this.EncodeMouseEnter);
            // 
            // DecodeRadioButton
            // 
            this.DecodeRadioButton.AutoSize = true;
            this.InitializeAnimation.SetDecoration(this.DecodeRadioButton, Guna.UI.Animation.DecorationType.None);
            this.PopupTransition.SetDecoration(this.DecodeRadioButton, Guna.UI.Animation.DecorationType.None);
            this.DecodeRadioButton.Location = new System.Drawing.Point(6, 51);
            this.DecodeRadioButton.Name = "DecodeRadioButton";
            this.DecodeRadioButton.Size = new System.Drawing.Size(106, 27);
            this.DecodeRadioButton.TabIndex = 10;
            this.DecodeRadioButton.TabStop = true;
            this.DecodeRadioButton.Text = "Decode";
            this.DecodeRadioButton.UseVisualStyleBackColor = true;
            this.DecodeRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChangedDecode);
            this.DecodeRadioButton.MouseEnter += new System.EventHandler(this.DecodeMouseEnter);
            // 
            // ModeGroupbox
            // 
            this.ModeGroupbox.Controls.Add(this.EncodeRadioButton);
            this.ModeGroupbox.Controls.Add(this.DecodeRadioButton);
            this.PopupTransition.SetDecoration(this.ModeGroupbox, Guna.UI.Animation.DecorationType.None);
            this.InitializeAnimation.SetDecoration(this.ModeGroupbox, Guna.UI.Animation.DecorationType.None);
            this.ModeGroupbox.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeGroupbox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ModeGroupbox.Location = new System.Drawing.Point(578, 37);
            this.ModeGroupbox.Name = "ModeGroupbox";
            this.ModeGroupbox.Size = new System.Drawing.Size(139, 83);
            this.ModeGroupbox.TabIndex = 11;
            this.ModeGroupbox.TabStop = false;
            this.ModeGroupbox.Text = "Mode";
            // 
            // MethodGroupbox
            // 
            this.MethodGroupbox.Controls.Add(this.VigenereRadioButton);
            this.MethodGroupbox.Controls.Add(this.AtbashRadioButton);
            this.PopupTransition.SetDecoration(this.MethodGroupbox, Guna.UI.Animation.DecorationType.None);
            this.InitializeAnimation.SetDecoration(this.MethodGroupbox, Guna.UI.Animation.DecorationType.None);
            this.MethodGroupbox.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MethodGroupbox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MethodGroupbox.Location = new System.Drawing.Point(577, 121);
            this.MethodGroupbox.Name = "MethodGroupbox";
            this.MethodGroupbox.Size = new System.Drawing.Size(139, 83);
            this.MethodGroupbox.TabIndex = 12;
            this.MethodGroupbox.TabStop = false;
            this.MethodGroupbox.Text = "Method";
            // 
            // VigenereRadioButton
            // 
            this.VigenereRadioButton.AutoSize = true;
            this.VigenereRadioButton.Checked = true;
            this.InitializeAnimation.SetDecoration(this.VigenereRadioButton, Guna.UI.Animation.DecorationType.None);
            this.PopupTransition.SetDecoration(this.VigenereRadioButton, Guna.UI.Animation.DecorationType.None);
            this.VigenereRadioButton.Location = new System.Drawing.Point(6, 20);
            this.VigenereRadioButton.Name = "VigenereRadioButton";
            this.VigenereRadioButton.Size = new System.Drawing.Size(132, 27);
            this.VigenereRadioButton.TabIndex = 9;
            this.VigenereRadioButton.TabStop = true;
            this.VigenereRadioButton.Text = "Vigenere";
            this.VigenereRadioButton.UseVisualStyleBackColor = true;
            this.VigenereRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChangedVigenere);
            this.VigenereRadioButton.MouseEnter += new System.EventHandler(this.VigenereMouseEnter);
            // 
            // AtbashRadioButton
            // 
            this.AtbashRadioButton.AutoSize = true;
            this.InitializeAnimation.SetDecoration(this.AtbashRadioButton, Guna.UI.Animation.DecorationType.None);
            this.PopupTransition.SetDecoration(this.AtbashRadioButton, Guna.UI.Animation.DecorationType.None);
            this.AtbashRadioButton.Location = new System.Drawing.Point(6, 51);
            this.AtbashRadioButton.Name = "AtbashRadioButton";
            this.AtbashRadioButton.Size = new System.Drawing.Size(106, 27);
            this.AtbashRadioButton.TabIndex = 10;
            this.AtbashRadioButton.TabStop = true;
            this.AtbashRadioButton.Text = "Atbash";
            this.AtbashRadioButton.UseVisualStyleBackColor = true;
            this.AtbashRadioButton.MouseEnter += new System.EventHandler(this.AtbashMouseEnter);
            // 
            // KeywordGroupbox
            // 
            this.KeywordGroupbox.Controls.Add(this.KeywordTextbox);
            this.PopupTransition.SetDecoration(this.KeywordGroupbox, Guna.UI.Animation.DecorationType.None);
            this.InitializeAnimation.SetDecoration(this.KeywordGroupbox, Guna.UI.Animation.DecorationType.None);
            this.KeywordGroupbox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeywordGroupbox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.KeywordGroupbox.Location = new System.Drawing.Point(578, 210);
            this.KeywordGroupbox.Name = "KeywordGroupbox";
            this.KeywordGroupbox.Size = new System.Drawing.Size(138, 180);
            this.KeywordGroupbox.TabIndex = 5;
            this.KeywordGroupbox.TabStop = false;
            this.KeywordGroupbox.Text = "Enter Your Keyword";
            // 
            // KeywordTextbox
            // 
            this.KeywordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.InitializeAnimation.SetDecoration(this.KeywordTextbox, Guna.UI.Animation.DecorationType.None);
            this.PopupTransition.SetDecoration(this.KeywordTextbox, Guna.UI.Animation.DecorationType.None);
            this.KeywordTextbox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.KeywordTextbox.Location = new System.Drawing.Point(9, 46);
            this.KeywordTextbox.Multiline = true;
            this.KeywordTextbox.Name = "KeywordTextbox";
            this.KeywordTextbox.Size = new System.Drawing.Size(120, 119);
            this.KeywordTextbox.TabIndex = 0;
            this.KeywordTextbox.Text = "Key";
            this.KeywordTextbox.TextChanged += new System.EventHandler(this.KeywordTextChanged);
            this.KeywordTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeywordKeyPressed);
            this.KeywordTextbox.MouseEnter += new System.EventHandler(this.KeywordMouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.InitializeAnimation.SetDecoration(this.label1, Guna.UI.Animation.DecorationType.None);
            this.PopupTransition.SetDecoration(this.label1, Guna.UI.Animation.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(99, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "New features are coming soon!";
            // 
            // HelpPopupPanel
            // 
            this.HelpPopupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.HelpPopupPanel.Controls.Add(this.pictureBox2);
            this.HelpPopupPanel.Controls.Add(this.HelpPopupLabel);
            this.PopupTransition.SetDecoration(this.HelpPopupPanel, Guna.UI.Animation.DecorationType.None);
            this.InitializeAnimation.SetDecoration(this.HelpPopupPanel, Guna.UI.Animation.DecorationType.None);
            this.HelpPopupPanel.Location = new System.Drawing.Point(12, 524);
            this.HelpPopupPanel.Name = "HelpPopupPanel";
            this.HelpPopupPanel.Size = new System.Drawing.Size(560, 79);
            this.HelpPopupPanel.TabIndex = 13;
            this.HelpPopupPanel.Visible = false;
            // 
            // pictureBox2
            // 
            this.InitializeAnimation.SetDecoration(this.pictureBox2, Guna.UI.Animation.DecorationType.None);
            this.PopupTransition.SetDecoration(this.pictureBox2, Guna.UI.Animation.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // HelpPopupLabel
            // 
            this.InitializeAnimation.SetDecoration(this.HelpPopupLabel, Guna.UI.Animation.DecorationType.None);
            this.PopupTransition.SetDecoration(this.HelpPopupLabel, Guna.UI.Animation.DecorationType.None);
            this.HelpPopupLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpPopupLabel.ForeColor = System.Drawing.Color.Silver;
            this.HelpPopupLabel.Location = new System.Drawing.Point(99, 6);
            this.HelpPopupLabel.Name = "HelpPopupLabel";
            this.HelpPopupLabel.Size = new System.Drawing.Size(458, 73);
            this.HelpPopupLabel.TabIndex = 0;
            this.HelpPopupLabel.Text = "New features are coming soon!";
            this.HelpPopupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SwapText
            // 
            this.SwapText.ActiveBorderThickness = 1;
            this.SwapText.ActiveCornerRadius = 20;
            this.SwapText.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SwapText.ActiveForecolor = System.Drawing.Color.White;
            this.SwapText.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SwapText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.SwapText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SwapText.BackgroundImage")));
            this.SwapText.ButtonText = "Swap Text";
            this.SwapText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PopupTransition.SetDecoration(this.SwapText, Guna.UI.Animation.DecorationType.None);
            this.InitializeAnimation.SetDecoration(this.SwapText, Guna.UI.Animation.DecorationType.None);
            this.SwapText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwapText.ForeColor = System.Drawing.Color.Honeydew;
            this.SwapText.IdleBorderThickness = 1;
            this.SwapText.IdleCornerRadius = 20;
            this.SwapText.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SwapText.IdleForecolor = System.Drawing.Color.Honeydew;
            this.SwapText.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SwapText.Location = new System.Drawing.Point(578, 397);
            this.SwapText.Margin = new System.Windows.Forms.Padding(5);
            this.SwapText.Name = "SwapText";
            this.SwapText.Size = new System.Drawing.Size(139, 46);
            this.SwapText.TabIndex = 12;
            this.SwapText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SwapText.Click += new System.EventHandler(this.SwapText_Click);
            this.SwapText.MouseEnter += new System.EventHandler(this.SwapTextMouseEnter);
            // 
            // pictureBox1
            // 
            this.InitializeAnimation.SetDecoration(this.pictureBox1, Guna.UI.Animation.DecorationType.None);
            this.PopupTransition.SetDecoration(this.pictureBox1, Guna.UI.Animation.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.PopupTransition.SetDecoration(this.contextMenuStrip1, Guna.UI.Animation.DecorationType.None);
            this.InitializeAnimation.SetDecoration(this.contextMenuStrip1, Guna.UI.Animation.DecorationType.None);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.TopPanel;
            // 
            // PopupTransition
            // 
            this.PopupTransition.AnimationType = Guna.UI.Animation.AnimationType.VertSlide;
            this.PopupTransition.Cursor = null;
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(0);
            animation7.RotateCoeff = 0F;
            animation7.RotateLimit = 0F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 0F;
            this.PopupTransition.DefaultAnimation = animation7;
            // 
            // PopupElipse
            // 
            this.PopupElipse.ElipseRadius = 10;
            this.PopupElipse.TargetControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1292, 615);
            this.Controls.Add(this.HelpPopupPanel);
            this.Controls.Add(this.KeywordGroupbox);
            this.Controls.Add(this.MethodGroupbox);
            this.Controls.Add(this.SwapText);
            this.Controls.Add(this.ModeGroupbox);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.EnterYourTextGroupbox);
            this.Controls.Add(this.PopupPanel);
            this.Controls.Add(this.TopPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.PopupTransition.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.InitializeAnimation.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CollapseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.PopupPanel.ResumeLayout(false);
            this.PopupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupPictureBox)).EndInit();
            this.EnterYourTextGroupbox.ResumeLayout(false);
            this.EnterYourTextGroupbox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ModeGroupbox.ResumeLayout(false);
            this.ModeGroupbox.PerformLayout();
            this.MethodGroupbox.ResumeLayout(false);
            this.MethodGroupbox.PerformLayout();
            this.KeywordGroupbox.ResumeLayout(false);
            this.KeywordGroupbox.PerformLayout();
            this.HelpPopupPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private Guna.UI.WinForms.GunaTransition InitializeAnimation;
        private Guna.UI.WinForms.GunaElipse MainFormSurface;
        private Guna.UI.WinForms.GunaDragControl DragControl;
        private Guna.UI.WinForms.GunaTransition PopupTransition;
        private System.Windows.Forms.Panel PopupPanel;
        private Bunifu.Framework.UI.BunifuElipse PopupElipse;
        private System.Windows.Forms.Label PopupLabel;
        private System.Windows.Forms.PictureBox PopupPictureBox;
        private Bunifu.Framework.UI.BunifuImageButton ExitButton;
        private Bunifu.Framework.UI.BunifuImageButton CollapseButton;
        private System.Windows.Forms.TextBox UncryptedTextbox;
        private System.Windows.Forms.GroupBox EnterYourTextGroupbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox EncryptedTextbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox ModeGroupbox;
        private System.Windows.Forms.RadioButton EncodeRadioButton;
        private System.Windows.Forms.RadioButton DecodeRadioButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 SwapText;
        private System.Windows.Forms.GroupBox MethodGroupbox;
        private System.Windows.Forms.RadioButton VigenereRadioButton;
        private System.Windows.Forms.RadioButton AtbashRadioButton;
        private System.Windows.Forms.GroupBox KeywordGroupbox;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox KeywordTextbox;
   
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel HelpPopupPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label HelpPopupLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveYourFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveUncryptedMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveEncryptedMenu;
        private System.Windows.Forms.ToolStripMenuItem openYourFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.MenuStrip MenuPanel;
    }
}