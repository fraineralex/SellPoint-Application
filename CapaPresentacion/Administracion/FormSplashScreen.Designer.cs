namespace CapaPresentacion
{
    partial class FormSplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSplashScreen));
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxBufalosLogo = new System.Windows.Forms.PictureBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelContador = new System.Windows.Forms.Label();
            this.panelBarraCarga = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBufalosLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // temporizador
            // 
            this.temporizador.Enabled = true;
            this.temporizador.Tick += new System.EventHandler(this.CargarAplicacion);
            // 
            // pictureBoxBufalosLogo
            // 
            this.pictureBoxBufalosLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxBufalosLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBufalosLogo.Image")));
            this.pictureBoxBufalosLogo.Location = new System.Drawing.Point(85, 10);
            this.pictureBoxBufalosLogo.Name = "pictureBoxBufalosLogo";
            this.pictureBoxBufalosLogo.Size = new System.Drawing.Size(380, 370);
            this.pictureBoxBufalosLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxBufalosLogo.TabIndex = 0;
            this.pictureBoxBufalosLogo.TabStop = false;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Viner Hand ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(117, 390);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(315, 60);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "Eagles Academy";
            // 
            // labelContador
            // 
            this.labelContador.AutoSize = true;
            this.labelContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContador.Location = new System.Drawing.Point(505, 440);
            this.labelContador.Name = "labelContador";
            this.labelContador.Size = new System.Drawing.Size(28, 16);
            this.labelContador.TabIndex = 4;
            this.labelContador.Text = "0%";
            // 
            // panelBarraCarga
            // 
            this.panelBarraCarga.BackColor = System.Drawing.Color.Black;
            this.panelBarraCarga.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelBarraCarga.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelBarraCarga.Location = new System.Drawing.Point(0, 460);
            this.panelBarraCarga.Name = "panelBarraCarga";
            this.panelBarraCarga.Size = new System.Drawing.Size(25, 20);
            this.panelBarraCarga.TabIndex = 6;
            // 
            // FormSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(550, 480);
            this.ControlBox = false;
            this.Controls.Add(this.panelBarraCarga);
            this.Controls.Add(this.labelContador);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.pictureBoxBufalosLogo);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eagles Academy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBufalosLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.PictureBox pictureBoxBufalosLogo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelContador;
        private System.Windows.Forms.Panel panelBarraCarga;
    }
}