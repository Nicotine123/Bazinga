namespace ZXing
{
    partial class Form1
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
            this.tbGenerate = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.pboxQRCode = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // tbGenerate
            // 
            this.tbGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGenerate.Location = new System.Drawing.Point(362, 340);
            this.tbGenerate.Name = "tbGenerate";
            this.tbGenerate.Size = new System.Drawing.Size(75, 23);
            this.tbGenerate.TabIndex = 0;
            this.tbGenerate.Text = "Generate";
            this.tbGenerate.UseVisualStyleBackColor = true;
            this.tbGenerate.Click += new System.EventHandler(this.tbGenerate_Click);
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Location = new System.Drawing.Point(12, 342);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(344, 44);
            this.tbInput.TabIndex = 1;
            // 
            // pboxQRCode
            // 
            this.pboxQRCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxQRCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pboxQRCode.Location = new System.Drawing.Point(12, 12);
            this.pboxQRCode.Name = "pboxQRCode";
            this.pboxQRCode.Size = new System.Drawing.Size(425, 322);
            this.pboxQRCode.TabIndex = 2;
            this.pboxQRCode.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Location = new System.Drawing.Point(192, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 427);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pboxQRCode);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.tbGenerate);
            this.Name = "Form1";
            this.Text = "Bazinga!! Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.pboxQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbGenerate;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.PictureBox pboxQRCode;
        private System.Windows.Forms.Button btnSave;
    }
}

