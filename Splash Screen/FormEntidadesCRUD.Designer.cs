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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntidadesCRUD));
            this.tablaEntidadesCrud = new System.Windows.Forms.DataGridView();
            this.buttonNuevoEntidadesCrud = new System.Windows.Forms.Button();
            this.buttonEditarEntidadesCrud = new System.Windows.Forms.Button();
            this.buttonEliminarEntidadesCrud = new System.Windows.Forms.Button();
            this.textBoxBuscarEntidadesCrud = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEntidadesCrud)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaEntidadesCrud
            // 
            this.tablaEntidadesCrud.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tablaEntidadesCrud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEntidadesCrud.GridColor = System.Drawing.Color.Silver;
            this.tablaEntidadesCrud.Location = new System.Drawing.Point(12, 109);
            this.tablaEntidadesCrud.Name = "tablaEntidadesCrud";
            this.tablaEntidadesCrud.Size = new System.Drawing.Size(743, 369);
            this.tablaEntidadesCrud.TabIndex = 0;
            // 
            // buttonNuevoEntidadesCrud
            // 
            this.buttonNuevoEntidadesCrud.Location = new System.Drawing.Point(518, 77);
            this.buttonNuevoEntidadesCrud.Name = "buttonNuevoEntidadesCrud";
            this.buttonNuevoEntidadesCrud.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevoEntidadesCrud.TabIndex = 2;
            this.buttonNuevoEntidadesCrud.Text = "Nuevo";
            this.buttonNuevoEntidadesCrud.UseVisualStyleBackColor = true;
            this.buttonNuevoEntidadesCrud.Click += new System.EventHandler(this.CrearEntidad);
            // 
            // buttonEditarEntidadesCrud
            // 
            this.buttonEditarEntidadesCrud.Location = new System.Drawing.Point(599, 77);
            this.buttonEditarEntidadesCrud.Name = "buttonEditarEntidadesCrud";
            this.buttonEditarEntidadesCrud.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarEntidadesCrud.TabIndex = 3;
            this.buttonEditarEntidadesCrud.Text = "Editar";
            this.buttonEditarEntidadesCrud.UseVisualStyleBackColor = true;
            this.buttonEditarEntidadesCrud.Click += new System.EventHandler(this.EditarEntidad);
            // 
            // buttonEliminarEntidadesCrud
            // 
            this.buttonEliminarEntidadesCrud.Location = new System.Drawing.Point(680, 77);
            this.buttonEliminarEntidadesCrud.Name = "buttonEliminarEntidadesCrud";
            this.buttonEliminarEntidadesCrud.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarEntidadesCrud.TabIndex = 4;
            this.buttonEliminarEntidadesCrud.Text = "Eliminar";
            this.buttonEliminarEntidadesCrud.UseVisualStyleBackColor = true;
            this.buttonEliminarEntidadesCrud.Click += new System.EventHandler(this.Eliminar);
            // 
            // textBoxBuscarEntidadesCrud
            // 
            this.textBoxBuscarEntidadesCrud.BackColor = System.Drawing.Color.Silver;
            this.textBoxBuscarEntidadesCrud.Location = new System.Drawing.Point(67, 79);
            this.textBoxBuscarEntidadesCrud.Name = "textBoxBuscarEntidadesCrud";
            this.textBoxBuscarEntidadesCrud.Size = new System.Drawing.Size(162, 20);
            this.textBoxBuscarEntidadesCrud.TabIndex = 6;
            this.textBoxBuscarEntidadesCrud.TextChanged += new System.EventHandler(this.Buscar);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(214, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 46);
            this.label3.TabIndex = 10;
            this.label3.Text = "CRUD Entidades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar";
            // 
            // FormEntidadesCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBuscarEntidadesCrud);
            this.Controls.Add(this.buttonEliminarEntidadesCrud);
            this.Controls.Add(this.buttonEditarEntidadesCrud);
            this.Controls.Add(this.buttonNuevoEntidadesCrud);
            this.Controls.Add(this.tablaEntidadesCrud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEntidadesCRUD";
            this.Text = "Sell Point";
            ((System.ComponentModel.ISupportInitialize)(this.tablaEntidadesCrud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaEntidadesCrud;
        private System.Windows.Forms.Button buttonNuevoEntidadesCrud;
        private System.Windows.Forms.Button buttonEditarEntidadesCrud;
        private System.Windows.Forms.Button buttonEliminarEntidadesCrud;
        private System.Windows.Forms.TextBox textBoxBuscarEntidadesCrud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}