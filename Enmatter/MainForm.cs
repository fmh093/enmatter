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

namespace Enmatter
{
    public partial class MainForm : Form
    {
        private List<Label> headerLabels;

        public MainForm()
        {
            InitializeComponent();
            tboxOutput.BackColor = Colors.Background.Grey;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeLabels();
            InitializeTextboxes();
        }

        private void InitializeLabels()
        {
            headerLabels = new List<Label> { lbHeaderFormatters, lbHeaderEncoders, lbHeaderTools };
            foreach (var header in headerLabels)
            {
                header.BorderStyle = BorderStyle.FixedSingle;
            }
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
