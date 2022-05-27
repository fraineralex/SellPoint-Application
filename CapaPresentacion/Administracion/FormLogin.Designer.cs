namespace CapaPresentacion
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBoxEaglesAcademyLogo = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxUsuarioLogin = new System.Windows.Forms.TextBox();
            this.textBoxContrasenaLogin = new System.Windows.Forms.TextBox();
            this.buttonAcceder = new System.Windows.Forms.Button();
            this.buttonMinimizar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.underline = new System.Windows.Forms.PictureBox();
            this.underline2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxUserPNG = new System.Windows.Forms.PictureBox();
            this.pictureBoxPasswordPNG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEaglesAcademyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.underline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.underline2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPNG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordPNG)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEaglesAcademyLogo
            // 
            this.pictureBoxEaglesAcademyLogo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxEaglesAcademyLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEaglesAcademyLogo.Image")));
            this.pictureBoxEaglesAcademyLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEaglesAcademyLogo.Name = "pictureBoxEaglesAcademyLogo";
            this.pictureBoxEaglesAcademyLogo.Size = new System.Drawing.Size(300, 280);
            this.pictureBoxEaglesAcademyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEaglesAcademyLogo.TabIndex = 0;
            this.pictureBoxEaglesAcademyLogo.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.Black;
            this.labelLogin.Location = new System.Drawing.Point(493, 10);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(113, 45);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Log in";
            // 
            // textBoxUsuarioLogin
            // 
            this.textBoxUsuarioLogin.BackColor = System.Drawing.Color.Silver;
            this.textBoxUsuarioLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsuarioLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuarioLogin.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsuarioLogin.Location = new System.Drawing.Point(354, 68);
            this.textBoxUsuarioLogin.Name = "textBoxUsuarioLogin";
            this.textBoxUsuarioLogin.Size = new System.Drawing.Size(426, 22);
            this.textBoxUsuarioLogin.TabIndex = 1;
            this.textBoxUsuarioLogin.Text = "Usuario";
            this.textBoxUsuarioLogin.Enter += new System.EventHandler(this.TextBoxUsuarioLoginMouseIn);
            this.textBoxUsuarioLogin.Leave += new System.EventHandler(this.TextBoxUsuarioLoginMouseOut);
            // 
            // textBoxContrasenaLogin
            // 
            this.textBoxContrasenaLogin.BackColor = System.Drawing.Color.Silver;
            this.textBoxContrasenaLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContrasenaLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContrasenaLogin.ForeColor = System.Drawing.Color.Black;
            this.textBoxContrasenaLogin.Location = new System.Drawing.Point(354, 134);
            this.textBoxContrasenaLogin.Name = "textBoxContrasenaLogin";
            this.textBoxContrasenaLogin.Size = new System.Drawing.Size(426, 22);
            this.textBoxContrasenaLogin.TabIndex = 2;
            this.textBoxContrasenaLogin.Text = "Contraseña";
            this.textBoxContrasenaLogin.Enter += new System.EventHandler(this.TextBoxContrasenaLoginMouseIn);
            this.textBoxContrasenaLogin.Leave += new System.EventHandler(this.TextBoxContrasenaLoginMouseOut);
            // 
            // buttonAcceder
            // 
            this.buttonAcceder.BackColor = System.Drawing.Color.DimGray;
            this.buttonAcceder.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonAcceder.FlatAppearance.BorderSize = 0;
            this.buttonAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcceder.ForeColor = System.Drawing.Color.White;
            this.buttonAcceder.Location = new System.Drawing.Point(320, 216);
            this.buttonAcceder.Name = "buttonAcceder";
            this.buttonAcceder.Size = new System.Drawing.Size(460, 35);
            this.buttonAcceder.TabIndex = 3;
            this.buttonAcceder.Text = "ACCEDER";
            this.buttonAcceder.UseVisualStyleBackColor = false;
            this.buttonAcceder.Click += new System.EventHandler(this.Acceder);
            // 
            // buttonMinimizar
            // 
            this.buttonMinimizar.BackColor = System.Drawing.Color.DimGray;
            this.buttonMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonMinimizar.FlatAppearance.BorderSize = 0;
            this.buttonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizar.ForeColor = System.Drawing.Color.White;
            this.buttonMinimizar.Location = new System.Drawing.Point(752, 5);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Size = new System.Drawing.Size(20, 23);
            this.buttonMinimizar.TabIndex = 4;
            this.buttonMinimizar.Text = "_";
            this.buttonMinimizar.UseVisualStyleBackColor = false;
            this.buttonMinimizar.Click += new System.EventHandler(this.MinimizarVentana);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.DimGray;
            this.buttonCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.ForeColor = System.Drawing.Color.White;
            this.buttonCerrar.Location = new System.Drawing.Point(775, 5);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(20, 23);
            this.buttonCerrar.TabIndex = 0;
            this.buttonCerrar.Text = "X";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.CerrarAplicacion);
            // 
            // underline
            // 
            this.underline.BackColor = System.Drawing.Color.Black;
            this.underline.Location = new System.Drawing.Point(354, 94);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(426, 1);
            this.underline.TabIndex = 8;
            this.underline.TabStop = false;
            // 
            // underline2
            // 
            this.underline2.BackColor = System.Drawing.Color.Black;
            this.underline2.Location = new System.Drawing.Point(354, 162);
            this.underline2.Name = "underline2";
            this.underline2.Size = new System.Drawing.Size(426, 1);
            this.underline2.TabIndex = 9;
            this.underline2.TabStop = false;
            // 
            // pictureBoxUserPNG
            // 
            this.pictureBoxUserPNG.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUserPNG.Image")));
            this.pictureBoxUserPNG.Location = new System.Drawing.Point(320, 67);
            this.pictureBoxUserPNG.Name = "pictureBoxUserPNG";
            this.pictureBoxUserPNG.Size = new System.Drawing.Size(28, 28);
            this.pictureBoxUserPNG.TabIndex = 10;
            this.pictureBoxUserPNG.TabStop = false;
            // 
            // pictureBoxPasswordPNG
            // 
            this.pictureBoxPasswordPNG.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPasswordPNG.Image")));
            this.pictureBoxPasswordPNG.Location = new System.Drawing.Point(320, 135);
            this.pictureBoxPasswordPNG.Name = "pictureBoxPasswordPNG";
            this.pictureBoxPasswordPNG.Size = new System.Drawing.Size(28, 28);
            this.pictureBoxPasswordPNG.TabIndex = 11;
            this.pictureBoxPasswordPNG.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 280);
            this.Controls.Add(this.pictureBoxPasswordPNG);
            this.Controls.Add(this.pictureBoxUserPNG);
            this.Controls.Add(this.underline2);
            this.Controls.Add(this.underline);
            this.Controls.Add(this.pictureBoxEaglesAcademyLogo);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonMinimizar);
            this.Controls.Add(this.buttonAcceder);
            this.Controls.Add(this.textBoxUsuarioLogin);
            this.Controls.Add(this.textBoxContrasenaLogin);
            this.Controls.Add(this.labelLogin);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eagles Academy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEaglesAcademyLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.underline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.underline2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPNG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordPNG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.PictureBox pictureBoxEaglesAcademyLogo;
        private System.Windows.Forms.TextBox textBoxUsuarioLogin;
        private System.Windows.Forms.TextBox textBoxContrasenaLogin;
        private System.Windows.Forms.Button buttonAcceder;
        private System.Windows.Forms.Button buttonMinimizar;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.PictureBox underline;
        private System.Windows.Forms.PictureBox underline2;
        private System.Windows.Forms.PictureBox pictureBoxUserPNG;
        private System.Windows.Forms.PictureBox pictureBoxPasswordPNG;
    }
}