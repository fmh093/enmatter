using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            foreach (var translatorType in Enum.GetNames(typeof(Translator.TranslatorType)))
            {
                var headerLabel = BuildHeaderLabel(translatorType);
                headerLabels.Add(headerLabel);
            }
        }

        private void DisplayOptions()
        {
            foreach (var headerLabel in headerLabels)
            {
                panelOptions.Controls.Add(headerLabel);
                foreach (var translatorOptionButton in translatorOptionButtons)
                    panelOptions.Controls.Add(translatorOptionButton);
            }
        }

        private Label BuildHeaderLabel(string text)
        {
            var label = new Label { Font = new Font("Arial", 16), Text = text, Dock = DockStyle.Top };
            return label;
        }
        private Button BuildOptionButton(string text)
        {

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
