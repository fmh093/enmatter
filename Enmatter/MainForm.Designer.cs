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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelOptions = new System.Windows.Forms.Panel();
            this.btnOption07 = new System.Windows.Forms.Button();
            this.btnOption06 = new System.Windows.Forms.Button();
            this.btnOption05 = new System.Windows.Forms.Button();
            this.btnOption04 = new System.Windows.Forms.Button();
            this.btnOption03 = new System.Windows.Forms.Button();
            this.btnOption02 = new System.Windows.Forms.Button();
            this.btnOption01 = new System.Windows.Forms.Button();
            this.tboxOutput = new System.Windows.Forms.RichTextBox();
            this.tboxInput = new System.Windows.Forms.RichTextBox();
            this.lbHeaderCurrentTranslator = new System.Windows.Forms.Label();
            this.bnProgramMinimize = new System.Windows.Forms.Button();
            this.bnProgramExit = new System.Windows.Forms.Button();
            this.bnProgramMaximize = new System.Windows.Forms.Button();
            this.btnOption08 = new System.Windows.Forms.Button();
            this.btnOption09 = new System.Windows.Forms.Button();
            this.btnOption10 = new System.Windows.Forms.Button();
            this.btnOption11 = new System.Windows.Forms.Button();
            this.panelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOptions
            // 
            this.panelOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelOptions.AutoScroll = true;
            this.panelOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panelOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOptions.Controls.Add(this.btnOption11);
            this.panelOptions.Controls.Add(this.btnOption10);
            this.panelOptions.Controls.Add(this.btnOption09);
            this.panelOptions.Controls.Add(this.btnOption08);
            this.panelOptions.Controls.Add(this.btnOption07);
            this.panelOptions.Controls.Add(this.btnOption06);
            this.panelOptions.Controls.Add(this.btnOption05);
            this.panelOptions.Controls.Add(this.btnOption04);
            this.panelOptions.Controls.Add(this.btnOption03);
            this.panelOptions.Controls.Add(this.btnOption02);
            this.panelOptions.Controls.Add(this.btnOption01);
            this.panelOptions.Location = new System.Drawing.Point(12, 53);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(229, 1015);
            this.panelOptions.TabIndex = 0;
            // 
            // btnOption07
            // 
            this.btnOption07.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOption07.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOption07.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption07.Location = new System.Drawing.Point(0, 240);
            this.btnOption07.Name = "btnOption07";
            this.btnOption07.Size = new System.Drawing.Size(227, 40);
            this.btnOption07.TabIndex = 6;
            this.btnOption07.Text = "Url Decoder";
            this.btnOption07.UseVisualStyleBackColor = true;
            this.btnOption07.Click += new System.EventHandler(this.OptionClicked);
            // 
            // btnOption06
            // 
            this.btnOption06.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOption06.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOption06.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption06.Location = new System.Drawing.Point(0, 200);
            this.btnOption06.Name = "btnOption06";
            this.btnOption06.Size = new System.Drawing.Size(227, 40);
            this.btnOption06.TabIndex = 5;
            this.btnOption06.Text = "Url Encoder";
            this.btnOption06.UseVisualStyleBackColor = true;
            this.btnOption06.Click += new System.EventHandler(this.OptionClicked);
            // 
            // btnOption05
            // 
            this.btnOption05.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOption05.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOption05.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption05.Location = new System.Drawing.Point(0, 160);
            this.btnOption05.Name = "btnOption05";
            this.btnOption05.Size = new System.Drawing.Size(227, 40);
            this.btnOption05.TabIndex = 4;
            this.btnOption05.Text = "Base64 Decoder";
            this.btnOption05.UseVisualStyleBackColor = true;
            // 
            // btnOption04
            // 
            this.btnOption04.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOption04.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOption04.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption04.Location = new System.Drawing.Point(0, 120);
            this.btnOption04.Name = "btnOption04";
            this.btnOption04.Size = new System.Drawing.Size(227, 40);
            this.btnOption04.TabIndex = 3;
            this.btnOption04.Text = "Base64 Encoder";
            this.btnOption04.UseVisualStyleBackColor = true;
            this.btnOption04.Click += new System.EventHandler(this.OptionClicked);
            // 
            // btnOption03
            // 
            this.btnOption03.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOption03.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOption03.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption03.Location = new System.Drawing.Point(0, 80);
            this.btnOption03.Name = "btnOption03";
            this.btnOption03.Size = new System.Drawing.Size(227, 40);
            this.btnOption03.TabIndex = 2;
            this.btnOption03.Text = "Stacktrace Formatter";
            this.btnOption03.UseVisualStyleBackColor = true;
            this.btnOption03.Click += new System.EventHandler(this.OptionClicked);
            // 
            // btnOption02
            // 
            this.btnOption02.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOption02.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOption02.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption02.Location = new System.Drawing.Point(0, 40);
            this.btnOption02.Name = "btnOption02";
            this.btnOption02.Size = new System.Drawing.Size(227, 40);
            this.btnOption02.TabIndex = 1;
            this.btnOption02.Text = "Xml Formatter";
            this.btnOption02.UseVisualStyleBackColor = true;
            this.btnOption02.Click += new System.EventHandler(this.OptionClicked);
            // 
            // btnOption01
            // 
            this.btnOption01.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOption01.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOption01.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption01.Location = new System.Drawing.Point(0, 0);
            this.btnOption01.Name = "btnOption01";
            this.btnOption01.Size = new System.Drawing.Size(227, 40);
            this.btnOption01.TabIndex = 0;
            this.btnOption01.Text = "Json Formatter";
            this.btnOption01.UseVisualStyleBackColor = true;
            this.btnOption01.Click += new System.EventHandler(this.OptionClicked);
            // 
            // tboxOutput
            // 
            this.tboxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tboxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxOutput.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxOutput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tboxOutput.Location = new System.Drawing.Point(247, 166);
            this.tboxOutput.Name = "tboxOutput";
            this.tboxOutput.Size = new System.Drawing.Size(1181, 902);
            this.tboxOutput.TabIndex = 1;
            this.tboxOutput.Text = "";
            // 
            // tboxInput
            // 
            this.tboxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tboxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxInput.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxInput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tboxInput.Location = new System.Drawing.Point(247, 53);
            this.tboxInput.Name = "tboxInput";
            this.tboxInput.Size = new System.Drawing.Size(1181, 107);
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
            // bnProgramMinimize
            // 
            this.bnProgramMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnProgramMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.bnProgramMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bnProgramMinimize.FlatAppearance.BorderSize = 2;
            this.bnProgramMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnProgramMinimize.Location = new System.Drawing.Point(1320, 15);
            this.bnProgramMinimize.Name = "bnProgramMinimize";
            this.bnProgramMinimize.Size = new System.Drawing.Size(32, 32);
            this.bnProgramMinimize.TabIndex = 4;
            this.bnProgramMinimize.Text = "_";
            this.bnProgramMinimize.UseVisualStyleBackColor = false;
            this.bnProgramMinimize.Click += new System.EventHandler(this.bnProgramMinimize_Click);
            // 
            // bnProgramExit
            // 
            this.bnProgramExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnProgramExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.bnProgramExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bnProgramExit.FlatAppearance.BorderSize = 2;
            this.bnProgramExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnProgramExit.Location = new System.Drawing.Point(1396, 15);
            this.bnProgramExit.Name = "bnProgramExit";
            this.bnProgramExit.Size = new System.Drawing.Size(32, 32);
            this.bnProgramExit.TabIndex = 5;
            this.bnProgramExit.Text = "X";
            this.bnProgramExit.UseVisualStyleBackColor = false;
            this.bnProgramExit.Click += new System.EventHandler(this.bnProgramExit_Click);
            // 
            // bnProgramMaximize
            // 
            this.bnProgramMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnProgramMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.bnProgramMaximize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bnProgramMaximize.FlatAppearance.BorderSize = 2;
            this.bnProgramMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnProgramMaximize.Location = new System.Drawing.Point(1358, 15);
            this.bnProgramMaximize.Name = "bnProgramMaximize";
            this.bnProgramMaximize.Size = new System.Drawing.Size(32, 32);
            this.bnProgramMaximize.TabIndex = 6;
            this.bnProgramMaximize.Text = "|_|";
            this.bnProgramMaximize.UseVisualStyleBackColor = false;
            this.bnProgramMaximize.Click += new System.EventHandler(this.bnProgramMaximize_Click);
            // 
            // btnOption08
            // 
            this.btnOption08.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOption08.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOption08.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption08.Location = new System.Drawing.Point(0, 280);
            this.btnOption08.Name = "btnOption08";
            this.btnOption08.Size = new System.Drawing.Size(227, 40);
            this.btnOption08.TabIndex = 7;
            this.btnOption08.Text = "MD5 Hash Generator";
            this.btnOption08.UseVisualStyleBackColor = true;
            this.btnOption08.Click += new System.EventHandler(this.OptionClicked);
            // 
            // btnOption09
            // 
            this.btnOption09.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOption09.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOption09.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption09.Location = new System.Drawing.Point(0, 320);
            this.btnOption09.Name = "btnOption09";
            this.btnOption09.Size = new System.Drawing.Size(227, 40);
            this.btnOption09.TabIndex = 8;
            this.btnOption09.Text = "SHA-256 Hash Generator";
            this.btnOption09.UseVisualStyleBackColor = true;
            // 
            // btnOption10
            // 
            this.btnOption10.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOption10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOption10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption10.Location = new System.Drawing.Point(0, 360);
            this.btnOption10.Name = "btnOption10";
            this.btnOption10.Size = new System.Drawing.Size(227, 40);
            this.btnOption10.TabIndex = 9;
            this.btnOption10.Text = "Guid Parser";
            this.btnOption10.UseVisualStyleBackColor = true;
            // 
            // btnOption11
            // 
            this.btnOption11.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOption11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOption11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption11.Location = new System.Drawing.Point(0, 400);
            this.btnOption11.Name = "btnOption11";
            this.btnOption11.Size = new System.Drawing.Size(227, 40);
            this.btnOption11.TabIndex = 10;
            this.btnOption11.Text = "Status Code Lookup";
            this.btnOption11.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1440, 1080);
            this.Controls.Add(this.bnProgramMaximize);
            this.Controls.Add(this.bnProgramExit);
            this.Controls.Add(this.bnProgramMinimize);
            this.Controls.Add(this.lbHeaderCurrentTranslator);
            this.Controls.Add(this.tboxInput);
            this.Controls.Add(this.tboxOutput);
            this.Controls.Add(this.panelOptions);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enmatter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.panelOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.RichTextBox tboxOutput;
        private System.Windows.Forms.RichTextBox tboxInput;
        private System.Windows.Forms.Button btnOption04;
        private System.Windows.Forms.Button btnOption03;
        private System.Windows.Forms.Button btnOption02;
        private System.Windows.Forms.Button btnOption01;
        private System.Windows.Forms.Label lbHeaderCurrentTranslator;
        private System.Windows.Forms.Button btnOption05;
        private System.Windows.Forms.Button bnProgramMinimize;
        private System.Windows.Forms.Button bnProgramExit;
        private System.Windows.Forms.Button bnProgramMaximize;
        private System.Windows.Forms.Button btnOption07;
        private System.Windows.Forms.Button btnOption06;
        private System.Windows.Forms.Button btnOption08;
        private System.Windows.Forms.Button btnOption09;
        private System.Windows.Forms.Button btnOption10;
        private System.Windows.Forms.Button btnOption11;
    }
}

