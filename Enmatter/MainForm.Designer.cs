namespace Enmatter
{
    partial class MainForm
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
            this.panelOptions = new System.Windows.Forms.Panel();
            this.btnOptionBase64Encoder = new System.Windows.Forms.Button();
            this.btnOptionStacktraceFormatter = new System.Windows.Forms.Button();
            this.btnOptionXmlFormatter = new System.Windows.Forms.Button();
            this.btnOptionJsonFormatter = new System.Windows.Forms.Button();
            this.tboxOutput = new System.Windows.Forms.RichTextBox();
            this.tboxInput = new System.Windows.Forms.RichTextBox();
            this.lbHeaderCurrentTranslator = new System.Windows.Forms.Label();
            this.panelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOptions
            // 
            this.panelOptions.AutoScroll = true;
            this.panelOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panelOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOptions.Controls.Add(this.btnOptionBase64Encoder);
            this.panelOptions.Controls.Add(this.btnOptionStacktraceFormatter);
            this.panelOptions.Controls.Add(this.btnOptionXmlFormatter);
            this.panelOptions.Controls.Add(this.btnOptionJsonFormatter);
            this.panelOptions.Location = new System.Drawing.Point(12, 53);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(229, 655);
            this.panelOptions.TabIndex = 0;
            // 
            // btnOptionBase64Encoder
            // 
            this.btnOptionBase64Encoder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOptionBase64Encoder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOptionBase64Encoder.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionBase64Encoder.Location = new System.Drawing.Point(0, 120);
            this.btnOptionBase64Encoder.Name = "btnOptionBase64Encoder";
            this.btnOptionBase64Encoder.Size = new System.Drawing.Size(227, 40);
            this.btnOptionBase64Encoder.TabIndex = 3;
            this.btnOptionBase64Encoder.Text = "Base64 Encoder/Decoder";
            this.btnOptionBase64Encoder.UseVisualStyleBackColor = true;
            this.btnOptionBase64Encoder.Click += new System.EventHandler(this.OptionClicked);
            // 
            // btnOptionStacktraceFormatter
            // 
            this.btnOptionStacktraceFormatter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOptionStacktraceFormatter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOptionStacktraceFormatter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionStacktraceFormatter.Location = new System.Drawing.Point(0, 80);
            this.btnOptionStacktraceFormatter.Name = "btnOptionStacktraceFormatter";
            this.btnOptionStacktraceFormatter.Size = new System.Drawing.Size(227, 40);
            this.btnOptionStacktraceFormatter.TabIndex = 2;
            this.btnOptionStacktraceFormatter.Text = "Stacktrace Formatter";
            this.btnOptionStacktraceFormatter.UseVisualStyleBackColor = true;
            this.btnOptionStacktraceFormatter.Click += new System.EventHandler(this.OptionClicked);
            // 
            // btnOptionXmlFormatter
            // 
            this.btnOptionXmlFormatter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOptionXmlFormatter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOptionXmlFormatter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionXmlFormatter.Location = new System.Drawing.Point(0, 40);
            this.btnOptionXmlFormatter.Name = "btnOptionXmlFormatter";
            this.btnOptionXmlFormatter.Size = new System.Drawing.Size(227, 40);
            this.btnOptionXmlFormatter.TabIndex = 1;
            this.btnOptionXmlFormatter.Text = "Xml Formatter";
            this.btnOptionXmlFormatter.UseVisualStyleBackColor = true;
            this.btnOptionXmlFormatter.Click += new System.EventHandler(this.OptionClicked);
            // 
            // btnOptionJsonFormatter
            // 
            this.btnOptionJsonFormatter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOptionJsonFormatter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOptionJsonFormatter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionJsonFormatter.Location = new System.Drawing.Point(0, 0);
            this.btnOptionJsonFormatter.Name = "btnOptionJsonFormatter";
            this.btnOptionJsonFormatter.Size = new System.Drawing.Size(227, 40);
            this.btnOptionJsonFormatter.TabIndex = 0;
            this.btnOptionJsonFormatter.Text = "Json Formatter";
            this.btnOptionJsonFormatter.UseVisualStyleBackColor = true;
            this.btnOptionJsonFormatter.Click += new System.EventHandler(this.OptionClicked);
            // 
            // tboxOutput
            // 
            this.tboxOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tboxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxOutput.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxOutput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tboxOutput.Location = new System.Drawing.Point(247, 166);
            this.tboxOutput.Name = "tboxOutput";
            this.tboxOutput.Size = new System.Drawing.Size(1021, 542);
            this.tboxOutput.TabIndex = 1;
            this.tboxOutput.Text = "";
            // 
            // tboxInput
            // 
            this.tboxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tboxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxInput.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxInput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tboxInput.Location = new System.Drawing.Point(247, 53);
            this.tboxInput.Name = "tboxInput";
            this.tboxInput.Size = new System.Drawing.Size(1021, 107);
            this.tboxInput.TabIndex = 2;
            this.tboxInput.Text = "";
            this.tboxInput.TextChanged += new System.EventHandler(this.tboxInput_TextChanged);
            // 
            // lbHeaderCurrentTranslator
            // 
            this.lbHeaderCurrentTranslator.AutoSize = true;
            this.lbHeaderCurrentTranslator.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeaderCurrentTranslator.Location = new System.Drawing.Point(240, 11);
            this.lbHeaderCurrentTranslator.Name = "lbHeaderCurrentTranslator";
            this.lbHeaderCurrentTranslator.Size = new System.Drawing.Size(161, 39);
            this.lbHeaderCurrentTranslator.TabIndex = 3;
            this.lbHeaderCurrentTranslator.Text = "Undefined";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lbHeaderCurrentTranslator);
            this.Controls.Add(this.tboxInput);
            this.Controls.Add(this.tboxOutput);
            this.Controls.Add(this.panelOptions);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enmatter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.RichTextBox tboxOutput;
        private System.Windows.Forms.RichTextBox tboxInput;
        private System.Windows.Forms.Button btnOptionBase64Encoder;
        private System.Windows.Forms.Button btnOptionStacktraceFormatter;
        private System.Windows.Forms.Button btnOptionXmlFormatter;
        private System.Windows.Forms.Button btnOptionJsonFormatter;
        private System.Windows.Forms.Label lbHeaderCurrentTranslator;
    }
}

