namespace Splash_Screen
{
    partial class FormGruposEntidadesCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGruposEntidadesCRUD));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBuscarGruposEntidadesCrud = new System.Windows.Forms.TextBox();
            this.buttonEliminarGruposEntidadesCrud = new System.Windows.Forms.Button();
            this.buttonEditarGruposEntidadesCrud = new System.Windows.Forms.Button();
            this.buttonNuevoGruposEntidadesCrud = new System.Windows.Forms.Button();
            this.tablaGruposEntidadesCRUD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaGruposEntidadesCRUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "CRUD Grupo de Entidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Buscar";
            // 
            // textBoxBuscarGruposEntidadesCrud
            // 
            this.textBoxBuscarGruposEntidadesCrud.BackColor = System.Drawing.Color.Silver;
            this.textBoxBuscarGruposEntidadesCrud.Location = new System.Drawing.Point(67, 86);
            this.textBoxBuscarGruposEntidadesCrud.Name = "textBoxBuscarGruposEntidadesCrud";
            this.textBoxBuscarGruposEntidadesCrud.Size = new System.Drawing.Size(162, 20);
            this.textBoxBuscarGruposEntidadesCrud.TabIndex = 18;
            this.textBoxBuscarGruposEntidadesCrud.TextChanged += new System.EventHandler(this.BuscarGrupoEntidad);
            // 
            // buttonEliminarGruposEntidadesCrud
            // 
            this.buttonEliminarGruposEntidadesCrud.Location = new System.Drawing.Point(744, 82);
            this.buttonEliminarGruposEntidadesCrud.Name = "buttonEliminarGruposEntidadesCrud";
            this.buttonEliminarGruposEntidadesCrud.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarGruposEntidadesCrud.TabIndex = 21;
            this.buttonEliminarGruposEntidadesCrud.Text = "Eliminar";
            this.buttonEliminarGruposEntidadesCrud.UseVisualStyleBackColor = true;
            this.buttonEliminarGruposEntidadesCrud.Click += new System.EventHandler(this.EliminarGrupoEntidad);
            // 
            // buttonEditarGruposEntidadesCrud
            // 
            this.buttonEditarGruposEntidadesCrud.Location = new System.Drawing.Point(663, 82);
            this.buttonEditarGruposEntidadesCrud.Name = "buttonEditarGruposEntidadesCrud";
            this.buttonEditarGruposEntidadesCrud.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarGruposEntidadesCrud.TabIndex = 20;
            this.buttonEditarGruposEntidadesCrud.Text = "Editar";
            this.buttonEditarGruposEntidadesCrud.UseVisualStyleBackColor = true;
            this.buttonEditarGruposEntidadesCrud.Click += new System.EventHandler(this.EditarGrupoEntidad);
            // 
            // buttonNuevoGruposEntidadesCrud
            // 
            this.buttonNuevoGruposEntidadesCrud.Location = new System.Drawing.Point(582, 82);
            this.buttonNuevoGruposEntidadesCrud.Name = "buttonNuevoGruposEntidadesCrud";
            this.buttonNuevoGruposEntidadesCrud.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevoGruposEntidadesCrud.TabIndex = 19;
            this.buttonNuevoGruposEntidadesCrud.Text = "Nuevo";
            this.buttonNuevoGruposEntidadesCrud.UseVisualStyleBackColor = true;
            this.buttonNuevoGruposEntidadesCrud.Click += new System.EventHandler(this.CrearGrupoEntidad);
            // 
            // tablaGruposEntidadesCRUD
            // 
            this.tablaGruposEntidadesCRUD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tablaGruposEntidadesCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaGruposEntidadesCRUD.GridColor = System.Drawing.Color.Silver;
            this.tablaGruposEntidadesCRUD.Location = new System.Drawing.Point(36, 127);
            this.tablaGruposEntidadesCRUD.Name = "tablaGruposEntidadesCRUD";
            this.tablaGruposEntidadesCRUD.Size = new System.Drawing.Size(743, 369);
            this.tablaGruposEntidadesCRUD.TabIndex = 22;
            // 
            // FormGruposEntidadesCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 546);
            this.Controls.Add(this.tablaGruposEntidadesCRUD);
            this.Controls.Add(this.buttonEliminarGruposEntidadesCrud);
            this.Controls.Add(this.buttonEditarGruposEntidadesCrud);
            this.Controls.Add(this.buttonNuevoGruposEntidadesCrud);
            this.Controls.Add(this.textBoxBuscarGruposEntidadesCrud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGruposEntidadesCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell Point";
            ((System.ComponentModel.ISupportInitialize)(this.tablaGruposEntidadesCRUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBuscarGruposEntidadesCrud;
        private System.Windows.Forms.Button buttonEliminarGruposEntidadesCrud;
        private System.Windows.Forms.Button buttonEditarGruposEntidadesCrud;
        private System.Windows.Forms.Button buttonNuevoGruposEntidadesCrud;
        private System.Windows.Forms.DataGridView tablaGruposEntidadesCRUD;
    }
}