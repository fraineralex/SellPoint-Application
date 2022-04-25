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
            this.tablaEntidadesEntidadesCrud = new System.Windows.Forms.DataGridView();
            this.labelTituloRegistrarEntidad = new System.Windows.Forms.Label();
            this.buttonNuevoEntidadesCrud = new System.Windows.Forms.Button();
            this.buttonEditarEntidadesCrud = new System.Windows.Forms.Button();
            this.buttonEliminarEntidadesCrud = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBuscarEntidadesCrud = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEntidadesEntidadesCrud)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaEntidadesEntidadesCrud
            // 
            this.tablaEntidadesEntidadesCrud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEntidadesEntidadesCrud.Location = new System.Drawing.Point(12, 83);
            this.tablaEntidadesEntidadesCrud.Name = "tablaEntidadesEntidadesCrud";
            this.tablaEntidadesEntidadesCrud.Size = new System.Drawing.Size(743, 369);
            this.tablaEntidadesEntidadesCrud.TabIndex = 0;
            // 
            // labelTituloRegistrarEntidad
            // 
            this.labelTituloRegistrarEntidad.AutoSize = true;
            this.labelTituloRegistrarEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloRegistrarEntidad.Location = new System.Drawing.Point(310, 9);
            this.labelTituloRegistrarEntidad.Name = "labelTituloRegistrarEntidad";
            this.labelTituloRegistrarEntidad.Size = new System.Drawing.Size(165, 24);
            this.labelTituloRegistrarEntidad.TabIndex = 1;
            this.labelTituloRegistrarEntidad.Text = "CRUD Entidades";
            // 
            // buttonNuevoEntidadesCrud
            // 
            this.buttonNuevoEntidadesCrud.Location = new System.Drawing.Point(518, 54);
            this.buttonNuevoEntidadesCrud.Name = "buttonNuevoEntidadesCrud";
            this.buttonNuevoEntidadesCrud.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevoEntidadesCrud.TabIndex = 2;
            this.buttonNuevoEntidadesCrud.Text = "Nuevo";
            this.buttonNuevoEntidadesCrud.UseVisualStyleBackColor = true;
            this.buttonNuevoEntidadesCrud.Click += new System.EventHandler(this.CrearEntidad);
            // 
            // buttonEditarEntidadesCrud
            // 
            this.buttonEditarEntidadesCrud.Location = new System.Drawing.Point(599, 54);
            this.buttonEditarEntidadesCrud.Name = "buttonEditarEntidadesCrud";
            this.buttonEditarEntidadesCrud.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarEntidadesCrud.TabIndex = 3;
            this.buttonEditarEntidadesCrud.Text = "Editar";
            this.buttonEditarEntidadesCrud.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarEntidadesCrud
            // 
            this.buttonEliminarEntidadesCrud.Location = new System.Drawing.Point(680, 54);
            this.buttonEliminarEntidadesCrud.Name = "buttonEliminarEntidadesCrud";
            this.buttonEliminarEntidadesCrud.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarEntidadesCrud.TabIndex = 4;
            this.buttonEliminarEntidadesCrud.Text = "Eliminar";
            this.buttonEliminarEntidadesCrud.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar";
            // 
            // textBoxBuscarEntidadesCrud
            // 
            this.textBoxBuscarEntidadesCrud.Location = new System.Drawing.Point(70, 56);
            this.textBoxBuscarEntidadesCrud.Name = "textBoxBuscarEntidadesCrud";
            this.textBoxBuscarEntidadesCrud.Size = new System.Drawing.Size(92, 20);
            this.textBoxBuscarEntidadesCrud.TabIndex = 6;
            // 
            // FormEntidadesCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 496);
            this.Controls.Add(this.textBoxBuscarEntidadesCrud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEliminarEntidadesCrud);
            this.Controls.Add(this.buttonEditarEntidadesCrud);
            this.Controls.Add(this.buttonNuevoEntidadesCrud);
            this.Controls.Add(this.labelTituloRegistrarEntidad);
            this.Controls.Add(this.tablaEntidadesEntidadesCrud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEntidadesCRUD";
            this.Text = "FormEntidadesCRUD";
            ((System.ComponentModel.ISupportInitialize)(this.tablaEntidadesEntidadesCrud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaEntidadesEntidadesCrud;
        private System.Windows.Forms.Label labelTituloRegistrarEntidad;
        private System.Windows.Forms.Button buttonNuevoEntidadesCrud;
        private System.Windows.Forms.Button buttonEditarEntidadesCrud;
        private System.Windows.Forms.Button buttonEliminarEntidadesCrud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBuscarEntidadesCrud;
    }
}