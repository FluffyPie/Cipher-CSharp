using System.Media;
using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Text;

namespace Laba_2_CSharp.Forms
{
    public partial class MainWindow : Form
    {
        /// <summary>
        /// Начало главной формы. В ней производится проверка языка, количество запусков, язык и другие стартовые настройки
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            var SystemLanguage = System.Globalization.CultureInfo.CurrentCulture;
            if (Properties.Settings.Default.Theme == "Light")
                SetLightTheme();
            if (Properties.Settings.Default.FirstLaunch == "Yes")                 
            { 
                if (SystemLanguage.ToString() == "ru-RU")
                {
                    Properties.Settings.Default.Language = "Russian";            
                    Properties.Settings.Default.Save();                          
                }
                else
                    Properties.Settings.Default.Language = "English";
                Properties.Settings.Default.FirstLaunch = "No";
                Properties.Settings.Default.Save();
              
            }    
            if (Properties.Settings.Default.Language == "Russian")
                SetLanguageRussian();
            if (Properties.Settings.Default.TooltipActive == "Yes")
                HelpPopup("Если не знаете что делать - наведитесь на элемент. Вы всегда можете отключить подсказки в настройках!", "If you dont know what to do hover your mouse over the item. You can always disable help notifications in the settings");
            UncryptedTextbox.ShortcutsEnabled = false;
            UncryptedTextbox.ContextMenu = new ContextMenu();
            KeywordTextbox.ShortcutsEnabled = false;
            KeywordTextbox.ContextMenu = new ContextMenu();
           
        }
        
        Code.Vigenere VCode = new Code.Vigenere();
        Code.Atbash ACode = new Code.Atbash();
        Settings SettingForm = new Forms.Settings();
        AboutForm AboutForm = new AboutForm();

         /// <summary>
         /// Эта функция выводит уведомление ошибки
         /// </summary>
        public void ErrorPopupThreadFunc()
        {
            SoundPlayer Player = new SoundPlayer();
            Player.Stream = Properties.Resources.definite;
            Player.Play();
            PopupTransition.ShowSync(PopupPanel);
            Thread.Sleep(5000);
            PopupTransition.HideSync(PopupPanel);
        }

        /// <summary>
        /// Cворачивание окна по нажатию кнопки
        /// </summary>
      
        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// При изменении текста в поле для ввода текста - во втором поле (В зависимости от режима и метода шифровки)
        /// появится текст. В случае ошибки вылезет уведомление
        /// </summary>

        private void TextChangedEvent(object sender, EventArgs e)
        {
            
            if (VigenereRadioButton.Checked == true)
            {
                if (KeywordTextbox.Text.Length > 0)
                {
                    if (EncodeRadioButton.Checked == true)
                        EncryptedTextbox.Text = VCode.Encode(UncryptedTextbox.Text, KeywordTextbox.Text);
                    else
                        EncryptedTextbox.Text = VCode.Decode(UncryptedTextbox.Text, KeywordTextbox.Text);
                }
                else
                {
                    ErrorPopup();
                    EncryptedTextbox.Text = String.Empty;
                }
            }
            else
            {
                if (EncodeRadioButton.Checked == true)
                    EncryptedTextbox.Text = ACode.Encode(UncryptedTextbox.Text, null);
                else
                    EncryptedTextbox.Text = ACode.Decode(UncryptedTextbox.Text, null);
            }
        }
        
        /// <summary>
        /// Выход из программы
        /// </summary>
     
        private void ExitButtonClick(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            Application.Exit();
        }

     
        /// <summary>
        /// Проверка изменения режима работы (Необходима для работы в реальном времени)
        /// </summary>

        private void CheckedChangedEncode(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Language == "Russian")
            {
                Label.Location = new System.Drawing.Point(322, 0);
                Label.Text = "Зашифрованный текст";
            }
            else
                Label.Text = "Encrypted text";
            if (KeywordTextbox.Text.Length > 0 || AtbashRadioButton.Checked)
            {
                if (VigenereRadioButton.Checked == true)
                {
                    EncryptedTextbox.Text = VCode.Encode(UncryptedTextbox.Text, KeywordTextbox.Text);
                }
                else
                {
                    EncryptedTextbox.Text = ACode.Encode(UncryptedTextbox.Text, null);
                }
            }
            else
            {
                ErrorPopup();
                EncryptedTextbox.Text = String.Empty;
            }
        }
        /// <summary>
        /// Проверка изменения режима работы (Необходима для работы в реальном времени)
        /// </summary>
        private void CheckedChangedDecode(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Language == "Russian")
            {
                Label.Location = new System.Drawing.Point(322, 0);
                Label.Text = "Расшифрованный текст";
            }
            else
                Label.Text = "Decrypted text";
            if (KeywordTextbox.Text.Length > 0 || AtbashRadioButton.Checked)
            {
                if (VigenereRadioButton.Checked == true)
                {
                    EncryptedTextbox.Text = VCode.Decode(UncryptedTextbox.Text, KeywordTextbox.Text);
                }
                else
                {
                    EncryptedTextbox.Text = ACode.Encode(UncryptedTextbox.Text, null);
                }
            }
            else
            {
                ErrorPopup();
                EncryptedTextbox.Text = String.Empty;
            }

        }

        /// <summary>
        /// Поменять текст местами (Если необходимо расшифровать только что зашифрованный текст)
        /// </summary>

        private void SwapText_Click(object sender, EventArgs e)
        {
            
            string TemporaryText = UncryptedTextbox.Text;
            UncryptedTextbox.Text = EncryptedTextbox.Text;
            EncryptedTextbox.Text = TemporaryText;
            if (VigenereRadioButton.Checked == true)
            {
                if (EncodeRadioButton.Checked == true)
                    EncryptedTextbox.Text = VCode.Encode(UncryptedTextbox.Text, KeywordTextbox.Text);
                else
                    EncryptedTextbox.Text = VCode.Decode(UncryptedTextbox.Text, KeywordTextbox.Text);
            }
            else
            {
                if (EncodeRadioButton.Checked == true)
                    EncryptedTextbox.Text = ACode.Encode(UncryptedTextbox.Text, null);
                else
                    EncryptedTextbox.Text = ACode.Encode(UncryptedTextbox.Text, null);
            }    
        }

        /// <summary>
        /// Проверка изменения ключевого слова (Необходима для работы в реальном времени)
        /// Если была произведена попытка выбрать шифр Вижинера с пустым ключом - программа выдаст
        /// уведомление об ошибке
        /// </summary>

        private void KeywordTextChanged(object sender, EventArgs e)
        {
            if (VigenereRadioButton.Checked == true)
            {
                if (KeywordTextbox.Text.Length > 0)
                {
                    if (EncodeRadioButton.Checked == true)
                        EncryptedTextbox.Text = VCode.Encode(UncryptedTextbox.Text, KeywordTextbox.Text);
                    else
                        EncryptedTextbox.Text = VCode.Decode(UncryptedTextbox.Text, KeywordTextbox.Text);
                }
                else
                {
                    ErrorPopup();
                    EncryptedTextbox.Text = String.Empty;
                }
            }
            else
            {
                if (EncodeRadioButton.Checked == true)
                    EncryptedTextbox.Text = ACode.Encode(UncryptedTextbox.Text, null);
                else
                    EncryptedTextbox.Text = ACode.Decode(UncryptedTextbox.Text, null);
            }


        }
        /// <summary>
        /// Проверка изменения метода шифрования (Необходима для работы в реальном времени)
        /// </summary>
        private void CheckedChangedVigenere(object sender, EventArgs e)
        {
            if (VigenereRadioButton.Checked == true)
            {
                if (KeywordTextbox.Text.Length > 0)
                {
                    if (EncodeRadioButton.Checked == true)
                        EncryptedTextbox.Text = VCode.Encode(UncryptedTextbox.Text, KeywordTextbox.Text);
                    else
                        EncryptedTextbox.Text = VCode.Decode(UncryptedTextbox.Text, KeywordTextbox.Text);
                }
                else
                {
                    ErrorPopup();
                    EncryptedTextbox.Text = String.Empty;
                }
            }
            else
            {
                if (EncodeRadioButton.Checked == true)
                    EncryptedTextbox.Text = ACode.Encode(UncryptedTextbox.Text, null);
                else
                    EncryptedTextbox.Text = ACode.Decode(UncryptedTextbox.Text, null);
            }
        }
        /// <summary>
        /// Запрет на ввод определенных символов(В зависимости от языка)
        /// </summary>

        private void EnterTextKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (Properties.Settings.Default.Language == "Russian")
                e.Handled = System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[A-Za-z]+$");
            else
                e.Handled = System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[А-Яа-я]+$");
        }
        /// <summary>
        /// Запрет на ввод определенных символов(В зависимости от языка)
        /// </summary>
        private void KeywordKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (Properties.Settings.Default.Language == "Russian")
                e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[А-Яа-я\b]+$");
            else
                e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[A-Za-z\b]+$");
        }
        /// <summary>
        /// Вывод ошибки
        /// </summary>
        void ErrorPopup()
        {
            Thread PopupThread = new Thread(ErrorPopupThreadFunc);
            PopupPictureBox.Image = Properties.Resources.ErrorPhoto;
            if (Properties.Settings.Default.Language == "Russian")
                PopupLabel.Text = "Вы не ввели ключ!";
            else
                PopupLabel.Text = "You forgot to enter the keyword!";
            PopupThread.Start();
        }

        /// <summary>
        /// Показать скроллбар при наведении мыши на поле ввода
        /// </summary>
    
        private void MouseEnterDecrypted(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.TooltipActive == "Yes")
            {
                ToolTip ToolTipPopup = new ToolTip();
                if (Properties.Settings.Default.Language == "Russian")
                    ToolTipPopup.SetToolTip(UncryptedTextbox, "Это поле для ввода текста, который необходимо зашифровать или расшифровать. Обратите внимание, что ввод должен производиться на том же языке, что и язык в настройках. Также обратите внимание, что программа шифрует только текст, игнорируя цифры и спецсимволы");
                else
                    ToolTipPopup.SetToolTip(UncryptedTextbox, "This is a field for entering text to encrypt or decrypt. Please note that input must be in the same language as the language in the settings. Also note that the program encrypts only text, ignoring numbers and special characters");
            }
            UncryptedTextbox.ScrollBars = ScrollBars.Vertical;

        }
        /// <summary>
        /// Скрыть сколлбар при убирании мыши с поля ввода
        /// </summary>

        private void MouseLeaveDecrypted(object sender, EventArgs e)
        {
            UncryptedTextbox.ScrollBars = ScrollBars.None;
        }
        /// <summary>
        /// Показать скроллбар при наведении мыши на поле ввода
        /// </summary>
        private void MouseEnterEncrypted(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.TooltipActive == "Yes")
            {
                ToolTip ToolTipPopup = new ToolTip();
                if (Properties.Settings.Default.Language == "Russian")
                    ToolTipPopup.SetToolTip(EncryptedTextbox, "Это ваш зашифрованный или расшифрованный текст!");
                else
                    ToolTipPopup.SetToolTip(EncryptedTextbox, "This is your encrypted or decrypted text!");
            }
            EncryptedTextbox.ScrollBars = ScrollBars.Vertical;
        }
        /// <summary>
        /// Скрыть сколлбар при убирании мыши с поля ввода
        /// </summary>
        private void MouseLeaveEncrypted(object sender, EventArgs e)
        {
            EncryptedTextbox.ScrollBars = ScrollBars.None;
        }
        /// <summary>
        /// Смена языка на русский
        /// </summary>
        void SetLanguageRussian()
        {
            Label.Location = new System.Drawing.Point(322, 0);
            EnterYourTextGroupbox.Text = "Введите Ваш текст";
            Label.Text = "Зашифрованный текст";
            ModeGroupbox.Text = "Режим";
            MethodGroupbox.Text = "Метод";
            KeywordTextbox.Text = "Ключ";
            KeywordGroupbox.Text = "Введите ключ";
            EncodeRadioButton.Text = "Шифр";
            DecodeRadioButton.Text = "Дешифр";
            VigenereRadioButton.Text = "Виженер";
            AtbashRadioButton.Text = "Атбаш";
            SwapText.ButtonText = "Поменять текст местами";
            settingsToolStripMenuItem.Text = "Настройки";
            SaveEncryptedMenu.Text= "Сохр. шифр. текст";
            SaveUncryptedMenu.Text = "Сохр. исх. текст";
            aboutToolStripMenuItem.Text= "О программе";
            openYourFileToolStripMenuItem.Text = "Открыть файл";
            saveYourFileToolStripMenuItem.Text = "Сохранить файл";
            FileMenu.Text = "Файл";

        }
        /// <summary>
        /// Всплывающие подсказки при наведении мыши на элемент
        /// </summary>

        void HelpPopup(string RusMessage, string EngMessage)
        {
           

            if (Properties.Settings.Default.Language == "Russian")
                HelpPopupLabel.Text = RusMessage;
            else
                HelpPopupLabel.Text = EngMessage;
            
            Thread PopupThread = new Thread(PopupThreadFunc);
            PopupThread.Start();

            


        }
        /// <summary>
        /// Вывод уведомления с подсказкой
        /// </summary>
        void PopupThreadFunc()
        {
            Thread.Sleep(1000);
            SoundPlayer Player = new SoundPlayer();
            Player.Stream = Properties.Resources.notification;
            Player.Play();
            PopupTransition.ShowSync(HelpPopupPanel);
            Thread.Sleep(2000);
            PopupTransition.HideSync(HelpPopupPanel);
            Thread.CurrentThread.Abort();
           
        }
        /// <summary>
        /// Установка светлой темы
        /// </summary>
        void SetLightTheme()
        {
            this.BackColor = Color.LightGray;
            UncryptedTextbox.BackColor = Color.White;
            EncryptedTextbox.BackColor = Color.White;
            KeywordTextbox.BackColor = Color.White;
            TopPanel.BackColor = Color.Purple;
            EnterYourTextGroupbox.ForeColor = Color.Black;
            KeywordGroupbox.ForeColor = Color.Black;
            MethodGroupbox.ForeColor = Color.Black;
            ModeGroupbox.ForeColor = Color.Black;
            Label.ForeColor = Color.Black;
            EncryptedTextbox.ForeColor = Color.Black;
            KeywordTextbox.ForeColor = Color.Black;
            UncryptedTextbox.ForeColor = Color.Black;
            settingsToolStripMenuItem.BackColor = Color.Purple;
            SwapText.BackColor = Color.Purple;
            aboutToolStripMenuItem.BackColor = Color.Purple;
            SwapText.IdleFillColor = Color.Purple;
            SwapText.IdleLineColor = Color.Purple;
            SaveUncryptedMenu.BackColor = Color.Purple;
            SaveEncryptedMenu.BackColor = Color.Purple;
            saveYourFileToolStripMenuItem.BackColor = Color.Purple;
            openYourFileToolStripMenuItem.BackColor = Color.Purple;
            MenuPanel.BackColor = Color.Purple;

        }
    

        private void EncodeMouseEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.TooltipActive == "Yes")
            {
                ToolTip ToolTipPopup = new ToolTip();
                if (Properties.Settings.Default.Language == "Russian")
                    ToolTipPopup.SetToolTip(EncodeRadioButton, "Зашифровать текст!");
                else
                    ToolTipPopup.SetToolTip(EncodeRadioButton, "Encode your text!");
            }
        }

        private void DecodeMouseEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.TooltipActive == "Yes")
            {
                ToolTip ToolTipPopup = new ToolTip();
                if (Properties.Settings.Default.Language == "Russian")
                    ToolTipPopup.SetToolTip(DecodeRadioButton, "Расшифровать текст!");
                else
                    ToolTipPopup.SetToolTip(DecodeRadioButton, "Decode your text!");
            }
        }

        private void VigenereMouseEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.TooltipActive == "Yes")
            {
                ToolTip ToolTipPopup = new ToolTip();
                if (Properties.Settings.Default.Language == "Russian")
                    ToolTipPopup.SetToolTip(VigenereRadioButton, "Шифрование методом Виженера!");
                else
                    ToolTipPopup.SetToolTip(VigenereRadioButton, "Encode using Vigenere cipher!");
            }
        }

        private void AtbashMouseEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.TooltipActive == "Yes")
            {
                ToolTip ToolTipPopup = new ToolTip();
                if (Properties.Settings.Default.Language == "Russian")
                    ToolTipPopup.SetToolTip(AtbashRadioButton, "Шифрование методом Атбаш!");
                else
                    ToolTipPopup.SetToolTip(AtbashRadioButton, "Encode using Atbash cipher!");
            }

        }

        private void KeywordMouseEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.TooltipActive == "Yes")
            {
                ToolTip ToolTipPopup = new ToolTip();
                if (Properties.Settings.Default.Language == "Russian")
                    ToolTipPopup.SetToolTip(KeywordTextbox, "Поле для ввода ключа (Необходим для метода Виженера). Обратите внимание, что ввод должен производиться на том же языке, что и язык в настройках");
                else
                    ToolTipPopup.SetToolTip(KeywordTextbox, "Field for entering the keyword (Required for the Vigenere Cipher). Please note that input must be in the same language as the language in the settings");
            }
        }

        private void SwapTextMouseEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.TooltipActive == "Yes")
            {
                ToolTip ToolTipPopup = new ToolTip();
                if (Properties.Settings.Default.Language == "Russian")
                    ToolTipPopup.SetToolTip(KeywordTextbox, "Поменять текст в левом поле с текстом в правом");
                else
                    ToolTipPopup.SetToolTip(KeywordTextbox, "Switch texts from both fields");
            }
        }


        private void SaveUncryptedMenu_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter =
            "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.FileName = "MyText";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FileName = saveFileDialog1.FileName;
                File.WriteAllText(FileName, UncryptedTextbox.Text);
                HelpPopup("Файл успешно сохранен", "File save successfully");
            }
            else
                HelpPopup("Ошибка сохранения файла", "Failed to save file");
        }

        private void SaveEncryptedMenu_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter =
            "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.FileName = "EncryptedText";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FileName = saveFileDialog1.FileName;
                File.WriteAllText(FileName, EncryptedTextbox.Text);
                HelpPopup("Файл успешно сохранен", "File save successfully");
            }
            else
                HelpPopup("Ошибка сохранения файла", "Failed to save file");
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm.ShowDialog();
        }

        private void openYourFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Filename = openFileDialog1.FileName;
                try
                {
                    string Text;
                    using (var streamReader = new StreamReader(Filename, Encoding.UTF8))
                        Text = streamReader.ReadToEnd();
                    UncryptedTextbox.Text = Text;
                    HelpPopup("Файл успешно открыт!", "Successfully opened your file!");

                }
                catch
                {
                    HelpPopup("Не удалось считать файл", "Bad data. Unable to read file");
                }

            }
            else
            {
                HelpPopup("Не удалось открыть файл", "Unable to open file");
            }

        }
    }
}


