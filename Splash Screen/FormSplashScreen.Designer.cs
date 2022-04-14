namespace Splash_Screen
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barraProgresiva = new CircularProgressBar.CircularProgressBar();
            this.labelDataViewer = new System.Windows.Forms.Label();
            this.labelIniciando = new System.Windows.Forms.Label();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // barraProgresiva
            // 
            this.barraProgresiva.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("barraProgresiva.AnimationFunction")));
            this.barraProgresiva.AnimationSpeed = 500;
            this.barraProgresiva.BackColor = System.Drawing.Color.Gainsboro;
            this.barraProgresiva.Font = new System.Drawing.Font("Agency FB", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraProgresiva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(180)))), ((int)(((byte)(148)))));
            this.barraProgresiva.InnerColor = System.Drawing.Color.Gainsboro;
            this.barraProgresiva.InnerMargin = 2;
            this.barraProgresiva.InnerWidth = -1;
            this.barraProgresiva.Location = new System.Drawing.Point(89, 145);
            this.barraProgresiva.MarqueeAnimationSpeed = 2000;
            this.barraProgresiva.Name = "barraProgresiva";
            this.barraProgresiva.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(210)))));
            this.barraProgresiva.OuterMargin = -25;
            this.barraProgresiva.OuterWidth = 26;
            this.barraProgresiva.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(180)))), ((int)(((byte)(148)))));
            this.barraProgresiva.ProgressWidth = 6;
            this.barraProgresiva.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.barraProgresiva.Size = new System.Drawing.Size(180, 180);
            this.barraProgresiva.StartAngle = 270;
            this.barraProgresiva.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barraProgresiva.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.barraProgresiva.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.barraProgresiva.SubscriptText = "";
            this.barraProgresiva.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.barraProgresiva.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.barraProgresiva.SuperscriptText = "";
            this.barraProgresiva.TabIndex = 0;
            this.barraProgresiva.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.barraProgresiva.UseWaitCursor = true;
            this.barraProgresiva.Value = 68;
            // 
            // labelDataViewer
            // 
            this.labelDataViewer.AutoSize = true;
            this.labelDataViewer.BackColor = System.Drawing.Color.Gainsboro;
            this.labelDataViewer.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataViewer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(180)))), ((int)(((byte)(148)))));
            this.labelDataViewer.Location = new System.Drawing.Point(65, 44);
            this.labelDataViewer.Name = "labelDataViewer";
            this.labelDataViewer.Size = new System.Drawing.Size(215, 61);
            this.labelDataViewer.TabIndex = 1;
            this.labelDataViewer.Text = "SELL POINT";
            this.labelDataViewer.UseWaitCursor = true;
            // 
            // labelIniciando
            // 
            this.labelIniciando.AutoSize = true;
            this.labelIniciando.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIniciando.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(180)))), ((int)(((byte)(148)))));
            this.labelIniciando.Location = new System.Drawing.Point(102, 365);
            this.labelIniciando.Name = "labelIniciando";
            this.labelIniciando.Size = new System.Drawing.Size(142, 39);
            this.labelIniciando.TabIndex = 2;
            this.labelIniciando.Text = "INICIANDO...";
            this.labelIniciando.UseWaitCursor = true;
            // 
            // temporizador
            // 
            this.temporizador.Enabled = true;
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(367, 453);
            this.ControlBox = false;
            this.Controls.Add(this.labelIniciando);
            this.Controls.Add(this.labelDataViewer);
            this.Controls.Add(this.barraProgresiva);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar barraProgresiva;
        private System.Windows.Forms.Label labelDataViewer;
        private System.Windows.Forms.Label labelIniciando;
        private System.Windows.Forms.Timer temporizador;
    }
}

