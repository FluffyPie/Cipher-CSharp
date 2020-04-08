namespace Laba_2_CSharp.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.LanguageComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.TooltipLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TooltipSettings = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LightThemeRadioButton = new System.Windows.Forms.RadioButton();
            this.DarkThemeRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SaveAndReboot = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CancelButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(514, 31);
            this.TopPanel.TabIndex = 2;
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LanguageLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LanguageLabel.Location = new System.Drawing.Point(86, 51);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(329, 21);
            this.LanguageLabel.TabIndex = 4;
            this.LanguageLabel.Text = "Choose Language/Выберите язык\r\n";
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.BackColor = System.Drawing.Color.Transparent;
            this.LanguageComboBox.BaseColor = System.Drawing.Color.White;
            this.LanguageComboBox.BorderColor = System.Drawing.Color.Silver;
            this.LanguageComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.LanguageComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LanguageComboBox.ForeColor = System.Drawing.Color.Black;
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Items.AddRange(new object[] {
            "Русский",
            "English"});
            this.LanguageComboBox.Location = new System.Drawing.Point(151, 93);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.LanguageComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.LanguageComboBox.Size = new System.Drawing.Size(194, 26);
            this.LanguageComboBox.TabIndex = 5;
            this.LanguageComboBox.SelectedValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.TopPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ThemeLabel.Location = new System.Drawing.Point(5, 156);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(505, 21);
            this.ThemeLabel.TabIndex = 6;
            this.ThemeLabel.Text = "Choose a color scheme/Выберите цветовую схему";
            // 
            // TooltipLabel
            // 
            this.TooltipLabel.AutoSize = true;
            this.TooltipLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TooltipLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TooltipLabel.Location = new System.Drawing.Point(86, 366);
            this.TooltipLabel.Name = "TooltipLabel";
            this.TooltipLabel.Size = new System.Drawing.Size(329, 21);
            this.TooltipLabel.TabIndex = 7;
            this.TooltipLabel.Text = "Tooltip/Всплывающие подсказки";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-15, -15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TooltipSettings
            // 
            this.TooltipSettings.Checked = true;
            this.TooltipSettings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TooltipSettings.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TooltipSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.TooltipSettings.Location = new System.Drawing.Point(151, 390);
            this.TooltipSettings.Name = "TooltipSettings";
            this.TooltipSettings.Size = new System.Drawing.Size(229, 36);
            this.TooltipSettings.TabIndex = 9;
            this.TooltipSettings.Text = "Active/Включены";
            this.TooltipSettings.UseVisualStyleBackColor = true;
            this.TooltipSettings.CheckedChanged += new System.EventHandler(this.TooltipCheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LightThemeRadioButton);
            this.panel1.Controls.Add(this.DarkThemeRadioButton);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(90, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 161);
            this.panel1.TabIndex = 10;
            // 
            // LightThemeRadioButton
            // 
            this.LightThemeRadioButton.AutoSize = true;
            this.LightThemeRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LightThemeRadioButton.Location = new System.Drawing.Point(205, 117);
            this.LightThemeRadioButton.Name = "LightThemeRadioButton";
            this.LightThemeRadioButton.Size = new System.Drawing.Size(84, 17);
            this.LightThemeRadioButton.TabIndex = 3;
            this.LightThemeRadioButton.Text = "Light Theme";
            this.LightThemeRadioButton.UseVisualStyleBackColor = true;
            // 
            // DarkThemeRadioButton
            // 
            this.DarkThemeRadioButton.AutoSize = true;
            this.DarkThemeRadioButton.Checked = true;
            this.DarkThemeRadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DarkThemeRadioButton.Location = new System.Drawing.Point(43, 117);
            this.DarkThemeRadioButton.Name = "DarkThemeRadioButton";
            this.DarkThemeRadioButton.Size = new System.Drawing.Size(84, 17);
            this.DarkThemeRadioButton.TabIndex = 2;
            this.DarkThemeRadioButton.TabStop = true;
            this.DarkThemeRadioButton.Text = "Dark Theme";
            this.DarkThemeRadioButton.UseVisualStyleBackColor = true;
            this.DarkThemeRadioButton.CheckedChanged += new System.EventHandler(this.ThemeCheckedChange);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(196, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SaveAndReboot
            // 
            this.SaveAndReboot.ActiveBorderThickness = 1;
            this.SaveAndReboot.ActiveCornerRadius = 20;
            this.SaveAndReboot.ActiveFillColor = System.Drawing.Color.Transparent;
            this.SaveAndReboot.ActiveForecolor = System.Drawing.Color.White;
            this.SaveAndReboot.ActiveLineColor = System.Drawing.Color.Transparent;
            this.SaveAndReboot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.SaveAndReboot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveAndReboot.BackgroundImage")));
            this.SaveAndReboot.ButtonText = "Save/Сохранить";
            this.SaveAndReboot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveAndReboot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAndReboot.ForeColor = System.Drawing.Color.Honeydew;
            this.SaveAndReboot.IdleBorderThickness = 1;
            this.SaveAndReboot.IdleCornerRadius = 20;
            this.SaveAndReboot.IdleFillColor = System.Drawing.Color.Transparent;
            this.SaveAndReboot.IdleForecolor = System.Drawing.Color.Honeydew;
            this.SaveAndReboot.IdleLineColor = System.Drawing.Color.Transparent;
            this.SaveAndReboot.Location = new System.Drawing.Point(286, 445);
            this.SaveAndReboot.Margin = new System.Windows.Forms.Padding(5);
            this.SaveAndReboot.Name = "SaveAndReboot";
            this.SaveAndReboot.Size = new System.Drawing.Size(187, 87);
            this.SaveAndReboot.TabIndex = 11;
            this.SaveAndReboot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveAndReboot.Click += new System.EventHandler(this.SaveAndReboot_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.ActiveBorderThickness = 1;
            this.CancelButton.ActiveCornerRadius = 20;
            this.CancelButton.ActiveFillColor = System.Drawing.Color.Transparent;
            this.CancelButton.ActiveForecolor = System.Drawing.Color.White;
            this.CancelButton.ActiveLineColor = System.Drawing.Color.Transparent;
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.CancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelButton.BackgroundImage")));
            this.CancelButton.ButtonText = "Cancel/Отмена";
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.Honeydew;
            this.CancelButton.IdleBorderThickness = 1;
            this.CancelButton.IdleCornerRadius = 20;
            this.CancelButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.CancelButton.IdleForecolor = System.Drawing.Color.Honeydew;
            this.CancelButton.IdleLineColor = System.Drawing.Color.Transparent;
            this.CancelButton.Location = new System.Drawing.Point(53, 445);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(187, 87);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(514, 534);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveAndReboot);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TooltipSettings);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TooltipLabel);
            this.Controls.Add(this.ThemeLabel);
            this.Controls.Add(this.LanguageComboBox);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label LanguageLabel;
        private Guna.UI.WinForms.GunaComboBox LanguageComboBox;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.CheckBox TooltipSettings;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label TooltipLabel;
        private System.Windows.Forms.Label ThemeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton LightThemeRadioButton;
        private System.Windows.Forms.RadioButton DarkThemeRadioButton;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveAndReboot;
        private Bunifu.Framework.UI.BunifuThinButton2 CancelButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}