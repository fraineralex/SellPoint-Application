namespace Splash_Screen
{
    partial class FormTiposEntidadesCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTiposEntidadesCRUD));
            this.label1 = new System.Windows.Forms.Label();
            this.tablaTiposEntidadesCRUD = new System.Windows.Forms.DataGridView();
            this.buttonEliminarTiposEntidadesCrud = new System.Windows.Forms.Button();
            this.buttonEditarTiposEntidadesCrud = new System.Windows.Forms.Button();
            this.buttonNuevoTiposEntidadesCrud = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBuscarTiposEntidadesCrud = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTiposEntidadesCRUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "CRUD Tipo de Entidad";
            // 
            // tablaTiposEntidadesCRUD
            // 
            this.tablaTiposEntidadesCRUD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tablaTiposEntidadesCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTiposEntidadesCRUD.GridColor = System.Drawing.Color.Silver;
            this.tablaTiposEntidadesCRUD.Location = new System.Drawing.Point(12, 114);
            this.tablaTiposEntidadesCRUD.Name = "tablaTiposEntidadesCRUD";
            this.tablaTiposEntidadesCRUD.Size = new System.Drawing.Size(743, 369);
            this.tablaTiposEntidadesCRUD.TabIndex = 12;
            // 
            // buttonEliminarTiposEntidadesCrud
            // 
            this.buttonEliminarTiposEntidadesCrud.Location = new System.Drawing.Point(680, 81);
            this.buttonEliminarTiposEntidadesCrud.Name = "buttonEliminarTiposEntidadesCrud";
            this.buttonEliminarTiposEntidadesCrud.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarTiposEntidadesCrud.TabIndex = 15;
            this.buttonEliminarTiposEntidadesCrud.Text = "Eliminar";
            this.buttonEliminarTiposEntidadesCrud.UseVisualStyleBackColor = true;
            this.buttonEliminarTiposEntidadesCrud.Click += new System.EventHandler(this.EliminarTipoEntidad);
            // 
            // buttonEditarTiposEntidadesCrud
            // 
            this.buttonEditarTiposEntidadesCrud.Location = new System.Drawing.Point(599, 81);
            this.buttonEditarTiposEntidadesCrud.Name = "buttonEditarTiposEntidadesCrud";
            this.buttonEditarTiposEntidadesCrud.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarTiposEntidadesCrud.TabIndex = 14;
            this.buttonEditarTiposEntidadesCrud.Text = "Editar";
            this.buttonEditarTiposEntidadesCrud.UseVisualStyleBackColor = true;
            this.buttonEditarTiposEntidadesCrud.Click += new System.EventHandler(this.EditarTipoEntidad);
            // 
            // buttonNuevoTiposEntidadesCrud
            // 
            this.buttonNuevoTiposEntidadesCrud.Location = new System.Drawing.Point(518, 81);
            this.buttonNuevoTiposEntidadesCrud.Name = "buttonNuevoTiposEntidadesCrud";
            this.buttonNuevoTiposEntidadesCrud.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevoTiposEntidadesCrud.TabIndex = 13;
            this.buttonNuevoTiposEntidadesCrud.Text = "Nuevo";
            this.buttonNuevoTiposEntidadesCrud.UseVisualStyleBackColor = true;
            this.buttonNuevoTiposEntidadesCrud.Click += new System.EventHandler(this.CrearTipoEntidad);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Buscar";
            // 
            // textBoxBuscarTiposEntidadesCrud
            // 
            this.textBoxBuscarTiposEntidadesCrud.BackColor = System.Drawing.Color.Silver;
            this.textBoxBuscarTiposEntidadesCrud.Location = new System.Drawing.Point(67, 88);
            this.textBoxBuscarTiposEntidadesCrud.Name = "textBoxBuscarTiposEntidadesCrud";
            this.textBoxBuscarTiposEntidadesCrud.Size = new System.Drawing.Size(162, 20);
            this.textBoxBuscarTiposEntidadesCrud.TabIndex = 17;
            this.textBoxBuscarTiposEntidadesCrud.TextChanged += new System.EventHandler(this.BuscarTipoEntidad);
            // 
            // FormTiposEntidadesCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 541);
            this.Controls.Add(this.textBoxBuscarTiposEntidadesCrud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonEliminarTiposEntidadesCrud);
            this.Controls.Add(this.buttonEditarTiposEntidadesCrud);
            this.Controls.Add(this.buttonNuevoTiposEntidadesCrud);
            this.Controls.Add(this.tablaTiposEntidadesCRUD);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTiposEntidadesCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell Point";
            ((System.ComponentModel.ISupportInitialize)(this.tablaTiposEntidadesCRUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaTiposEntidadesCRUD;
        private System.Windows.Forms.Button buttonEliminarTiposEntidadesCrud;
        private System.Windows.Forms.Button buttonEditarTiposEntidadesCrud;
        private System.Windows.Forms.Button buttonNuevoTiposEntidadesCrud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBuscarTiposEntidadesCrud;
    }
}