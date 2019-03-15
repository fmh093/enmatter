using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enmatter.Controllers;
using Enmatter.Design;
using Enmatter.Models;

namespace Enmatter
{
    public partial class MainForm : Form
    {
        private readonly TranslatorController _translatorController = new TranslatorController();

        private string _currentOption = null;


        public MainForm()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tboxInput.Text = Clipboard.GetText();

            _currentOption = _translatorController.SuggestTranslator(tboxInput.Text);

            foreach (var button in panelOptions.Controls.OfType<Button>())
            {
                button.Click += OptionClicked;
                button.BackColor = Colors.Background.Grey;

                button.BackColor = button.Text == _currentOption
                    ? Colors.Background.Grey
                    : Colors.Background.LightGrey;
            }

            UpdateButtonNames();
            UpdateHeader(btnOption01, e);
            Translate();

            foreach (var richTextBox in Controls.OfType<RichTextBox>())
            {
                richTextBox.BackColor = Colors.Background.Grey;
                richTextBox.ForeColor = Colors.Foreground.WhiteGrey;
            }
        }
        private void Translate()
        {
            _translatorController.UpdateCurrentTranslator(_currentOption);
            var response = _translatorController.Translate(tboxInput.Text);
            tboxOutput.Text = response.Output;
        }

        private void UpdateButtonNames()
        {
            btnOption01.Text = TranslatorStaticNames.JsonFormatter;
            btnOption02.Text = TranslatorStaticNames.XmlFormatter;
            btnOption03.Text = TranslatorStaticNames.StacktraceFormatter;
            btnOption04.Text = TranslatorStaticNames.Base64Encoder;
            btnOption05.Text = TranslatorStaticNames.Base64Decoder;
            btnOption06.Text = TranslatorStaticNames.UrlEncoder;
            btnOption07.Text = TranslatorStaticNames.UrlDecoder;
            btnOption08.Text = TranslatorStaticNames.MD5HashGenerator;
            btnOption09.Text = TranslatorStaticNames.SHA256HashGenerator;
            btnOption10.Text = TranslatorStaticNames.GuidParser;
            btnOption11.Text = TranslatorStaticNames.StatusCodeLookup;
        }

        private void OptionClicked(object sender, EventArgs e)
        {
            var buttonInfo = (Button)sender;
            _currentOption = buttonInfo.Text;

            UpdateHeader(sender, e);
            Translate();
            

            foreach (var button in panelOptions.Controls.OfType<Button>())
            {
                button.BackColor = button.Text == _currentOption
                    ? Colors.Background.Grey
                    : Colors.Background.LightGrey;
            }
        }

        private void UpdateHeader(object sender, EventArgs e)
        {
            lbHeaderCurrentTranslator.Text = _currentOption;
        }

        private void tboxInput_TextChanged(object sender, EventArgs e)
        {
            var inputText = tboxInput.Text;
            tboxOutput.Visible = !string.IsNullOrWhiteSpace(inputText);

            if (string.IsNullOrWhiteSpace(inputText))
                return;

            Translate();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Application.Exit();
        }

        private void bnProgramMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bnProgramMaximize_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void bnProgramExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
