namespace CapaPresentacion
{
    partial class FormAcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAcercaDe));
            this.pictureBoxContribuidor = new System.Windows.Forms.PictureBox();
            this.labelContribuidorInfo = new System.Windows.Forms.Label();
            this.linkLabelContribuidorGmail = new System.Windows.Forms.LinkLabel();
            this.richTextBoxAppInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContribuidor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxContribuidor
            // 
            this.pictureBoxContribuidor.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxContribuidor.Image")));
            this.pictureBoxContribuidor.Location = new System.Drawing.Point(241, 236);
            this.pictureBoxContribuidor.Name = "pictureBoxContribuidor";
            this.pictureBoxContribuidor.Size = new System.Drawing.Size(120, 75);
            this.pictureBoxContribuidor.TabIndex = 0;
            this.pictureBoxContribuidor.TabStop = false;
            // 
            // labelContribuidorInfo
            // 
            this.labelContribuidorInfo.AutoSize = true;
            this.labelContribuidorInfo.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContribuidorInfo.ForeColor = System.Drawing.Color.Black;
            this.labelContribuidorInfo.Location = new System.Drawing.Point(163, 314);
            this.labelContribuidorInfo.Name = "labelContribuidorInfo";
            this.labelContribuidorInfo.Size = new System.Drawing.Size(276, 25);
            this.labelContribuidorInfo.TabIndex = 1;
            this.labelContribuidorInfo.Text = "Abraham Rivera Domínguez\r\n";
            // 
            // linkLabelContribuidorGmail
            // 
            this.linkLabelContribuidorGmail.AutoSize = true;
            this.linkLabelContribuidorGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelContribuidorGmail.ForeColor = System.Drawing.Color.Black;
            this.linkLabelContribuidorGmail.LinkColor = System.Drawing.Color.Black;
            this.linkLabelContribuidorGmail.Location = new System.Drawing.Point(196, 349);
            this.linkLabelContribuidorGmail.Name = "linkLabelContribuidorGmail";
            this.linkLabelContribuidorGmail.Size = new System.Drawing.Size(210, 18);
            this.linkLabelContribuidorGmail.TabIndex = 2;
            this.linkLabelContribuidorGmail.TabStop = true;
            this.linkLabelContribuidorGmail.Text = "riveraabraham332@gmail.com";
            // 
            // richTextBoxAppInfo
            // 
            this.richTextBoxAppInfo.BackColor = System.Drawing.Color.Silver;
            this.richTextBoxAppInfo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAppInfo.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxAppInfo.Location = new System.Drawing.Point(14, 12);
            this.richTextBoxAppInfo.Name = "richTextBoxAppInfo";
            this.richTextBoxAppInfo.ReadOnly = true;
            this.richTextBoxAppInfo.Size = new System.Drawing.Size(578, 197);
            this.richTextBoxAppInfo.TabIndex = 3;
            this.richTextBoxAppInfo.Text = "";
            // 
            // FormAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(604, 381);
            this.Controls.Add(this.richTextBoxAppInfo);
            this.Controls.Add(this.linkLabelContribuidorGmail);
            this.Controls.Add(this.labelContribuidorInfo);
            this.Controls.Add(this.pictureBoxContribuidor);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eagles Academy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContribuidor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxContribuidor;
        private System.Windows.Forms.Label labelContribuidorInfo;
        private System.Windows.Forms.LinkLabel linkLabelContribuidorGmail;
        private System.Windows.Forms.RichTextBox richTextBoxAppInfo;
    }
}