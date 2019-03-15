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
        private readonly List<Button> _translatorOptionButtons = new List<Button>();
        private readonly List<Translator> _allTranslators = new List<Translator>();
        private TranslatorController _translatorController = new TranslatorController();

        private string _currentOption = null;


        public MainForm()
        {
            InitializeComponent();
            _currentOption = "Json";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tboxInput.Text = Clipboard.GetText();

            foreach (var button in panelOptions.Controls.OfType<Button>())
                button.Click += OptionClicked;
        }

        private void OptionClicked(object sender, EventArgs e)
        {
            var button = (Button) sender;
            _currentOption = button.Text;

            _translatorController.Translate(button.Text);
            UpdateHeader(sender, e);
        }

        private void UpdateHeader(object sender, EventArgs e)
        {
            var button = (Button)sender;
            lbHeaderCurrentTranslator.Text = button.Text;
            _translatorController.UpdateCurrentTranslator(button.Text);
        }

        private void tboxInput_TextChanged(object sender, EventArgs e)
        {
            tboxOutput.Visible = !string.IsNullOrWhiteSpace(tboxInput.Text);
        }
    }
}
