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
using Enmatter.Design;
using Enmatter.Models;

namespace Enmatter
{
    public partial class MainForm : Form
    {
        private List<Label> headerLabels = new List<Label>();
        private List<Button> translatorOptionButtons = new List<Button>();

        public MainForm()
        {
            InitializeComponent();
            tboxOutput.BackColor = Colors.Background.Grey;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tboxInput_TextChanged(null, null);
            InitializeOptions();
            DisplayOptions();
        }

        private void InitializeOptions()
        {
            var allTranslators = Assembly.GetAssembly(typeof(Translator)).GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(Translator)));

            foreach (var translator in allTranslators)
            {
                var translatorOption = Activator.CreateInstance(translator) as Translator;
                var translatorOptionButton = BuildOptionButton(translatorOption?.Name);
                translatorOptionButtons.Add(translatorOptionButton);
            }
        }

        private void DisplayOptions()
        {
            foreach (var e in Enum.GetNames(typeof(Translator.TranslatorType)))
            {
                foreach (var translatorOptionButton in translatorOptionButtons)
                    panelOptions.Controls.Add(translatorOptionButton);
            }


        }

        private Label BuildHeaderLabel(string text)
        {
            var label = new Label { Font = new Font("Tahoma", 16), Text = text, Dock = DockStyle.Top, ForeColor = Colors.Label.Header};
            label.Height = 30;
            return label;
        }
        private Button BuildOptionButton(string text)
        {
            var button = new Button();
            button.Font = new Font("Tahoma", 10);
            button.Text = text;
            button.Dock = DockStyle.Top;
            button.Height = 30;
            return button;
        }

        private void InitializeTextboxes()
        {
            tboxInput_TextChanged(null, null);
            tboxOutput.BorderStyle = BorderStyle.FixedSingle;
            tboxOutput.BackColor = Colors.Background.Grey;
        }

        private void tboxInput_TextChanged(object sender, EventArgs e)
        {
            tboxOutput.Visible = !string.IsNullOrWhiteSpace(tboxInput.Text);
        }
    }
}
