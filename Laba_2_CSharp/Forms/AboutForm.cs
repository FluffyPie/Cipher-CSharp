using System;
using System.Windows.Forms;

namespace Laba_2_CSharp.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Language == "Russian")
                CloseButton.ButtonText = "Закрыть";
            else
                CloseButton.ButtonText = "Close";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
