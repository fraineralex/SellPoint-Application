namespace Splash_Screen
{
    partial class FormEntidadesCRUD
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
            this.tablaEntidades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEntidades)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaEntidades
            // 
            this.tablaEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEntidades.Location = new System.Drawing.Point(69, 46);
            this.tablaEntidades.Name = "tablaEntidades";
            this.tablaEntidades.Size = new System.Drawing.Size(438, 227);
            this.tablaEntidades.TabIndex = 0;
            // 
            // FormEntidadesCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 496);
            this.Controls.Add(this.tablaEntidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEntidadesCRUD";
            this.Text = "FormEntidadesCRUD";
            ((System.ComponentModel.ISupportInitialize)(this.tablaEntidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaEntidades;
    }
}