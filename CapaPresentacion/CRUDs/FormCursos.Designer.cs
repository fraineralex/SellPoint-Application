namespace CapaPresentacion.CRUDs
{
    partial class FormCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCursos));
            this.labelCursos = new System.Windows.Forms.Label();
            this.textBoxBuscarCursos = new System.Windows.Forms.TextBox();
            this.labelBuscarCursos = new System.Windows.Forms.Label();
            this.buttonBorrarCursos = new System.Windows.Forms.Button();
            this.buttonEditarCursos = new System.Windows.Forms.Button();
            this.buttonNuevoCursos = new System.Windows.Forms.Button();
            this.dataGridViewCursos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCursos
            // 
            this.labelCursos.AutoSize = true;
            this.labelCursos.BackColor = System.Drawing.Color.Silver;
            this.labelCursos.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCursos.ForeColor = System.Drawing.Color.Black;
            this.labelCursos.Location = new System.Drawing.Point(305, 16);
            this.labelCursos.Name = "labelCursos";
            this.labelCursos.Size = new System.Drawing.Size(113, 36);
            this.labelCursos.TabIndex = 13;
            this.labelCursos.Text = "Cursos";
            // 
            // textBoxBuscarCursos
            // 
            this.textBoxBuscarCursos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxBuscarCursos.Location = new System.Drawing.Point(67, 69);
            this.textBoxBuscarCursos.Name = "textBoxBuscarCursos";
            this.textBoxBuscarCursos.Size = new System.Drawing.Size(100, 20);
            this.textBoxBuscarCursos.TabIndex = 0;
            // 
            // labelBuscarCursos
            // 
            this.labelBuscarCursos.AutoSize = true;
            this.labelBuscarCursos.BackColor = System.Drawing.Color.Silver;
            this.labelBuscarCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarCursos.ForeColor = System.Drawing.Color.Black;
            this.labelBuscarCursos.Location = new System.Drawing.Point(12, 70);
            this.labelBuscarCursos.Name = "labelBuscarCursos";
            this.labelBuscarCursos.Size = new System.Drawing.Size(49, 16);
            this.labelBuscarCursos.TabIndex = 11;
            this.labelBuscarCursos.Text = "Buscar";
            this.labelBuscarCursos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBorrarCursos
            // 
            this.buttonBorrarCursos.BackColor = System.Drawing.Color.LightGray;
            this.buttonBorrarCursos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBorrarCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrarCursos.ForeColor = System.Drawing.Color.Black;
            this.buttonBorrarCursos.Location = new System.Drawing.Point(637, 69);
            this.buttonBorrarCursos.Name = "buttonBorrarCursos";
            this.buttonBorrarCursos.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrarCursos.TabIndex = 3;
            this.buttonBorrarCursos.Text = "Borrar";
            this.buttonBorrarCursos.UseVisualStyleBackColor = false;
            // 
            // buttonEditarCursos
            // 
            this.buttonEditarCursos.BackColor = System.Drawing.Color.LightGray;
            this.buttonEditarCursos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEditarCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditarCursos.ForeColor = System.Drawing.Color.Black;
            this.buttonEditarCursos.Location = new System.Drawing.Point(556, 69);
            this.buttonEditarCursos.Name = "buttonEditarCursos";
            this.buttonEditarCursos.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarCursos.TabIndex = 2;
            this.buttonEditarCursos.Text = "Editar";
            this.buttonEditarCursos.UseVisualStyleBackColor = false;
            // 
            // buttonNuevoCursos
            // 
            this.buttonNuevoCursos.BackColor = System.Drawing.Color.LightGray;
            this.buttonNuevoCursos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonNuevoCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuevoCursos.ForeColor = System.Drawing.Color.Black;
            this.buttonNuevoCursos.Location = new System.Drawing.Point(475, 69);
            this.buttonNuevoCursos.Name = "buttonNuevoCursos";
            this.buttonNuevoCursos.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevoCursos.TabIndex = 1;
            this.buttonNuevoCursos.Text = "Nuevo";
            this.buttonNuevoCursos.UseVisualStyleBackColor = false;
            this.buttonNuevoCursos.Click += new System.EventHandler(this.IrARegistrarCurso);
            // 
            // dataGridViewCursos
            // 
            this.dataGridViewCursos.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursos.Location = new System.Drawing.Point(12, 98);
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.ReadOnly = true;
            this.dataGridViewCursos.Size = new System.Drawing.Size(700, 331);
            this.dataGridViewCursos.TabIndex = 4;
            // 
            // FormCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(724, 441);
            this.Controls.Add(this.labelCursos);
            this.Controls.Add(this.textBoxBuscarCursos);
            this.Controls.Add(this.labelBuscarCursos);
            this.Controls.Add(this.buttonBorrarCursos);
            this.Controls.Add(this.buttonEditarCursos);
            this.Controls.Add(this.buttonNuevoCursos);
            this.Controls.Add(this.dataGridViewCursos);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eagles Academy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCursos;
        private System.Windows.Forms.TextBox textBoxBuscarCursos;
        private System.Windows.Forms.Label labelBuscarCursos;
        private System.Windows.Forms.Button buttonBorrarCursos;
        private System.Windows.Forms.Button buttonEditarCursos;
        private System.Windows.Forms.Button buttonNuevoCursos;
        private System.Windows.Forms.DataGridView dataGridViewCursos;
    }
}