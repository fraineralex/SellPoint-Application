namespace CapaPresentacion
{
    partial class FormEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstudiantes));
            this.dataGridViewEstudiantes = new System.Windows.Forms.DataGridView();
            this.buttonNuevoEstudiantes = new System.Windows.Forms.Button();
            this.buttonEditarEstudiantes = new System.Windows.Forms.Button();
            this.buttonBorrarEstudiantes = new System.Windows.Forms.Button();
            this.labelBuscarEstudiantes = new System.Windows.Forms.Label();
            this.textBoxBuscarEstudiantes = new System.Windows.Forms.TextBox();
            this.labelEstudiantes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEstudiantes
            // 
            this.dataGridViewEstudiantes.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstudiantes.Location = new System.Drawing.Point(12, 98);
            this.dataGridViewEstudiantes.Name = "dataGridViewEstudiantes";
            this.dataGridViewEstudiantes.ReadOnly = true;
            this.dataGridViewEstudiantes.Size = new System.Drawing.Size(700, 331);
            this.dataGridViewEstudiantes.TabIndex = 4;
            // 
            // buttonNuevoEstudiantes
            // 
            this.buttonNuevoEstudiantes.BackColor = System.Drawing.Color.LightGray;
            this.buttonNuevoEstudiantes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonNuevoEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuevoEstudiantes.ForeColor = System.Drawing.Color.Black;
            this.buttonNuevoEstudiantes.Location = new System.Drawing.Point(475, 69);
            this.buttonNuevoEstudiantes.Name = "buttonNuevoEstudiantes";
            this.buttonNuevoEstudiantes.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevoEstudiantes.TabIndex = 1;
            this.buttonNuevoEstudiantes.Text = "Nuevo";
            this.buttonNuevoEstudiantes.UseVisualStyleBackColor = false;
            this.buttonNuevoEstudiantes.Click += new System.EventHandler(this.IrARegistrarEstudiante);
            // 
            // buttonEditarEstudiantes
            // 
            this.buttonEditarEstudiantes.BackColor = System.Drawing.Color.LightGray;
            this.buttonEditarEstudiantes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEditarEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditarEstudiantes.ForeColor = System.Drawing.Color.Black;
            this.buttonEditarEstudiantes.Location = new System.Drawing.Point(556, 69);
            this.buttonEditarEstudiantes.Name = "buttonEditarEstudiantes";
            this.buttonEditarEstudiantes.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarEstudiantes.TabIndex = 2;
            this.buttonEditarEstudiantes.Text = "Editar";
            this.buttonEditarEstudiantes.UseVisualStyleBackColor = false;
            // 
            // buttonBorrarEstudiantes
            // 
            this.buttonBorrarEstudiantes.BackColor = System.Drawing.Color.LightGray;
            this.buttonBorrarEstudiantes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBorrarEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrarEstudiantes.ForeColor = System.Drawing.Color.Black;
            this.buttonBorrarEstudiantes.Location = new System.Drawing.Point(637, 69);
            this.buttonBorrarEstudiantes.Name = "buttonBorrarEstudiantes";
            this.buttonBorrarEstudiantes.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrarEstudiantes.TabIndex = 3;
            this.buttonBorrarEstudiantes.Text = "Borrar";
            this.buttonBorrarEstudiantes.UseVisualStyleBackColor = false;
            // 
            // labelBuscarEstudiantes
            // 
            this.labelBuscarEstudiantes.AutoSize = true;
            this.labelBuscarEstudiantes.BackColor = System.Drawing.Color.Silver;
            this.labelBuscarEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarEstudiantes.ForeColor = System.Drawing.Color.Black;
            this.labelBuscarEstudiantes.Location = new System.Drawing.Point(12, 70);
            this.labelBuscarEstudiantes.Name = "labelBuscarEstudiantes";
            this.labelBuscarEstudiantes.Size = new System.Drawing.Size(49, 16);
            this.labelBuscarEstudiantes.TabIndex = 4;
            this.labelBuscarEstudiantes.Text = "Buscar";
            this.labelBuscarEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxBuscarEstudiantes
            // 
            this.textBoxBuscarEstudiantes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxBuscarEstudiantes.Location = new System.Drawing.Point(67, 69);
            this.textBoxBuscarEstudiantes.Name = "textBoxBuscarEstudiantes";
            this.textBoxBuscarEstudiantes.Size = new System.Drawing.Size(100, 20);
            this.textBoxBuscarEstudiantes.TabIndex = 0;
            // 
            // labelEstudiantes
            // 
            this.labelEstudiantes.AutoSize = true;
            this.labelEstudiantes.BackColor = System.Drawing.Color.Silver;
            this.labelEstudiantes.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstudiantes.ForeColor = System.Drawing.Color.Black;
            this.labelEstudiantes.Location = new System.Drawing.Point(265, 20);
            this.labelEstudiantes.Name = "labelEstudiantes";
            this.labelEstudiantes.Size = new System.Drawing.Size(193, 36);
            this.labelEstudiantes.TabIndex = 6;
            this.labelEstudiantes.Text = "Estudiantes";
            // 
            // FormEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(724, 441);
            this.Controls.Add(this.labelEstudiantes);
            this.Controls.Add(this.textBoxBuscarEstudiantes);
            this.Controls.Add(this.labelBuscarEstudiantes);
            this.Controls.Add(this.buttonBorrarEstudiantes);
            this.Controls.Add(this.buttonEditarEstudiantes);
            this.Controls.Add(this.buttonNuevoEstudiantes);
            this.Controls.Add(this.dataGridViewEstudiantes);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eagles Academy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEstudiantes;
        private System.Windows.Forms.Button buttonNuevoEstudiantes;
        private System.Windows.Forms.Button buttonEditarEstudiantes;
        private System.Windows.Forms.Button buttonBorrarEstudiantes;
        private System.Windows.Forms.Label labelBuscarEstudiantes;
        private System.Windows.Forms.TextBox textBoxBuscarEstudiantes;
        private System.Windows.Forms.Label labelEstudiantes;
    }
}