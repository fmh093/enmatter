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


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeTextboxes();
            InitializeOptions();
        }

        private void InitializeOptions()
        {
            var _allTranslators = Assembly.GetAssembly(typeof(Translator)).GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(Translator)));

            foreach (var translator in _allTranslators)
            {
                var translatorOption = Activator.CreateInstance(translator) as Translator;
                var translatorOptionButton = BuildOptionButton(translatorOption?.Name);
                _translatorOptionButtons.Add(translatorOptionButton);
            }

            foreach (var e in Enum.GetNames(typeof(Translator.TranslatorType)))
            {
                foreach (var translatorOptionButton in _translatorOptionButtons)
                {
                    translatorOptionButton.Click += OptionClicked;
                    panelOptions.Controls.Add(translatorOptionButton);
                }
            }

            foreach (var button in _translatorOptionButtons)
                button.Click += OptionClicked;
        }

        private void OptionClicked(object sender, EventArgs e)
        {
            var buttonInfo = (Button) sender;
            _translatorController
        }

        private void InitializeTextboxes()
        {
            tboxInput_TextChanged(null, null);

            foreach (var richTextBox in Controls.OfType<RichTextBox>())
            {
                richTextBox.BorderStyle = BorderStyle.FixedSingle;
                richTextBox.BackColor = Colors.Background.Grey;
                richTextBox.ForeColor = Colors.Label.White;
                richTextBox.Font = new Font("Lucida Console", 10);
            }
        }

        private Button BuildOptionButton(string text = "Undefined")
        {
            var button = new Button
            {
                Font = new Font("Tahoma", 10),
                Text = text,
                FlatStyle = FlatStyle.Popup,
                Dock = DockStyle.Top,
                Height = 30,
                FlatAppearance = { BorderColor = Color.White }
            };
            return button;
        }


        private void tboxInput_TextChanged(object sender, EventArgs e)
        {
            tboxOutput.Visible = !string.IsNullOrWhiteSpace(tboxInput.Text);
        }
    }
}
