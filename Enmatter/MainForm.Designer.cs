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
            this.tboxOutput = new System.Windows.Forms.RichTextBox();
            this.tboxInput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // panelOptions
            // 
            this.panelOptions.AutoScroll = true;
            this.panelOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panelOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOptions.Location = new System.Drawing.Point(12, 12);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(229, 696);
            this.panelOptions.TabIndex = 0;
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
            this.tboxInput.Location = new System.Drawing.Point(247, 13);
            this.tboxInput.Name = "tboxInput";
            this.tboxInput.Size = new System.Drawing.Size(1021, 147);
            this.tboxInput.TabIndex = 2;
            this.tboxInput.Text = "";
            this.tboxInput.TextChanged += new System.EventHandler(this.tboxInput_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 720);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.RichTextBox tboxOutput;
        private System.Windows.Forms.RichTextBox tboxInput;
    }
}

