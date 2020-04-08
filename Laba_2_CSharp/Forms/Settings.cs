using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laba_2_CSharp.Forms
{
    public partial class Settings : Form
    {

        
        public Settings()
        {
            
            InitializeComponent();

            if (Properties.Settings.Default.Language == "Russian")
                LanguageComboBox.SelectedIndex = 0;
            else
                LanguageComboBox.SelectedIndex = 1;
            if (Properties.Settings.Default.TooltipActive == "Yes")
                TooltipSettings.Checked = true;
            else
                TooltipSettings.Checked = false;
            if (Properties.Settings.Default.Theme == "Dark")
                DarkThemeRadioButton.Checked = true;
            else
            {
                LightThemeRadioButton.Checked = true;
                SetLightTheme();
            }
            


        }
        private void SaveAndReboot_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Language == "Russian")
                MessageBox.Show("Для применения настроек необходим перезапуск приложения");
            else
                MessageBox.Show("You must restart the app to apply the settings");
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void ValueChanged(object sender, EventArgs e)
        {
           
            if (LanguageComboBox.SelectedIndex == 0)
                Properties.Settings.Default.Language = "Russian";
            else
                Properties.Settings.Default.Language = "English";

           
            
        }

        private void TooltipCheckedChanged(object sender, EventArgs e)
        {
            
            if (TooltipSettings.Checked == true)
                Properties.Settings.Default.TooltipActive = "Yes";
            else
                Properties.Settings.Default.TooltipActive = "No";

            
          
        }

        private void ThemeCheckedChange(object sender, EventArgs e)
        {
   
            if (DarkThemeRadioButton.Checked == true)
                Properties.Settings.Default.Theme = "Dark";
            else
                Properties.Settings.Default.Theme = "Light";
  
           

        }

       
        void SetLightTheme()
        {
            TopPanel.BackColor = Color.Purple;
            LanguageLabel.ForeColor = Color.Black;
            ThemeLabel.ForeColor = Color.Black;
            TooltipLabel.ForeColor = Color.Black;
            DarkThemeRadioButton.ForeColor = Color.Black;
            LightThemeRadioButton.ForeColor = Color.Black;
            this.BackColor = Color.LightGray;
            SaveAndReboot.ForeColor = Color.Black;
            SaveAndReboot.IdleFillColor = Color.LightGray;
            SaveAndReboot.IdleForecolor = Color.Black;
            TooltipSettings.ForeColor = Color.Black;
            CancelButton.ForeColor = Color.Black;
            CancelButton.IdleFillColor = Color.LightGray;
            CancelButton.IdleForecolor = Color.Black;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            if (Properties.Settings.Default.Language == "Russian")
                LanguageComboBox.SelectedIndex = 0;
            else
                LanguageComboBox.SelectedIndex = 1;
            if (Properties.Settings.Default.TooltipActive == "Yes")
                TooltipSettings.Checked = true;
            else
                TooltipSettings.Checked = false;
            if (Properties.Settings.Default.Theme == "Dark")
                DarkThemeRadioButton.Checked = true;
            else
                LightThemeRadioButton.Checked = true;
            this.Close();
        }
    }
    
}
