
using System;

namespace T22_Patrón_MVC_3
{
    partial class DB_Manager
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
            this.client_list = new System.Windows.Forms.Panel();
            this.tablas = new System.Windows.Forms.DataGridView();
            this.text_BD = new System.Windows.Forms.Label();
            this.textBoxBD = new System.Windows.Forms.TextBox();
            this.text_tabla = new System.Windows.Forms.Label();
            this.text_acciones = new System.Windows.Forms.Label();
            this.boton_verTabla = new System.Windows.Forms.Button();
            this.boton_verRegistros = new System.Windows.Forms.Button();
            this.boton_actualizar = new System.Windows.Forms.Button();
            this.boton_eliminar = new System.Windows.Forms.Button();
            this.boton_editar = new System.Windows.Forms.Button();
            this.listBoxTabla = new System.Windows.Forms.ListBox();
            this.buttonListarTablas = new System.Windows.Forms.Button();
            this.client_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablas)).BeginInit();
            this.SuspendLayout();
            // 
            // client_list
            // 
            this.client_list.Controls.Add(this.tablas);
            this.client_list.Location = new System.Drawing.Point(12, 274);
            this.client_list.Name = "client_list";
            this.client_list.Size = new System.Drawing.Size(1907, 949);
            this.client_list.TabIndex = 0;
            // 
            // tablas
            // 
            this.tablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablas.Location = new System.Drawing.Point(11, 3);
            this.tablas.Name = "tablas";
            this.tablas.RowHeadersWidth = 72;
            this.tablas.RowTemplate.Height = 31;
            this.tablas.Size = new System.Drawing.Size(1882, 969);
            this.tablas.TabIndex = 11;
            // 
            // text_BD
            // 
            this.text_BD.AutoSize = true;
            this.text_BD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14286F);
            this.text_BD.Location = new System.Drawing.Point(12, 29);
            this.text_BD.Name = "text_BD";
            this.text_BD.Size = new System.Drawing.Size(213, 33);
            this.text_BD.TabIndex = 2;
            this.text_BD.Text = "Base de Datos:";
            // 
            // textBoxBD
            // 
            this.textBoxBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14286F);
            this.textBoxBD.Location = new System.Drawing.Point(244, 22);
            this.textBoxBD.Name = "textBoxBD";
            this.textBoxBD.Size = new System.Drawing.Size(280, 40);
            this.textBoxBD.TabIndex = 3;
            this.textBoxBD.Text = "T22_Patron_MVC_3";
            this.textBoxBD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_tabla
            // 
            this.text_tabla.AutoSize = true;
            this.text_tabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14286F);
            this.text_tabla.Location = new System.Drawing.Point(558, 22);
            this.text_tabla.Name = "text_tabla";
            this.text_tabla.Size = new System.Drawing.Size(96, 33);
            this.text_tabla.TabIndex = 4;
            this.text_tabla.Text = "Tabla:";
            // 
            // text_acciones
            // 
            this.text_acciones.AutoSize = true;
            this.text_acciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14286F);
            this.text_acciones.Location = new System.Drawing.Point(17, 174);
            this.text_acciones.Name = "text_acciones";
            this.text_acciones.Size = new System.Drawing.Size(142, 33);
            this.text_acciones.TabIndex = 6;
            this.text_acciones.Text = "Acciones:";
            // 
            // boton_verTabla
            // 
            this.boton_verTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14286F);
            this.boton_verTabla.Location = new System.Drawing.Point(18, 210);
            this.boton_verTabla.Name = "boton_verTabla";
            this.boton_verTabla.Size = new System.Drawing.Size(245, 58);
            this.boton_verTabla.TabIndex = 7;
            this.boton_verTabla.Text = "Mostrar Tabla";
            this.boton_verTabla.UseVisualStyleBackColor = true;
            // 
            // boton_verRegistros
            // 
            this.boton_verRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14286F);
            this.boton_verRegistros.Location = new System.Drawing.Point(269, 210);
            this.boton_verRegistros.Name = "boton_verRegistros";
            this.boton_verRegistros.Size = new System.Drawing.Size(289, 58);
            this.boton_verRegistros.TabIndex = 8;
            this.boton_verRegistros.Text = "Mostrar Registros";
            this.boton_verRegistros.UseVisualStyleBackColor = true;
            // 
            // boton_actualizar
            // 
            this.boton_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14286F);
            this.boton_actualizar.Location = new System.Drawing.Point(885, 210);
            this.boton_actualizar.Name = "boton_actualizar";
            this.boton_actualizar.Size = new System.Drawing.Size(315, 58);
            this.boton_actualizar.TabIndex = 9;
            this.boton_actualizar.Text = "Añadir Registro";
            this.boton_actualizar.UseVisualStyleBackColor = true;
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14286F);
            this.boton_eliminar.Location = new System.Drawing.Point(1206, 210);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(315, 58);
            this.boton_eliminar.TabIndex = 10;
            this.boton_eliminar.Text = "Eliminar Registro";
            this.boton_eliminar.UseVisualStyleBackColor = true;
            // 
            // boton_editar
            // 
            this.boton_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14286F);
            this.boton_editar.Location = new System.Drawing.Point(564, 210);
            this.boton_editar.Name = "boton_editar";
            this.boton_editar.Size = new System.Drawing.Size(315, 58);
            this.boton_editar.TabIndex = 11;
            this.boton_editar.Text = "Editar Registro";
            this.boton_editar.UseVisualStyleBackColor = true;
            // 
            // listBoxTabla
            // 
            this.listBoxTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14286F);
            this.listBoxTabla.FormattingEnabled = true;
            this.listBoxTabla.ItemHeight = 32;
            this.listBoxTabla.Location = new System.Drawing.Point(660, 22);
            this.listBoxTabla.Name = "listBoxTabla";
            this.listBoxTabla.Size = new System.Drawing.Size(309, 164);
            this.listBoxTabla.TabIndex = 12;
            this.listBoxTabla.SelectedValueChanged += (sender, EventArgs) => { this.listBoxTabla_SelectedValueChanged(sender, EventArgs, Convert.ToString(this.listBoxTabla.SelectedItem), this); };
            // 
            // buttonListarTablas
            // 
            this.buttonListarTablas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14286F);
            this.buttonListarTablas.Location = new System.Drawing.Point(18, 95);
            this.buttonListarTablas.Margin = new System.Windows.Forms.Padding(0);
            this.buttonListarTablas.Name = "buttonListarTablas";
            this.buttonListarTablas.Size = new System.Drawing.Size(506, 61);
            this.buttonListarTablas.TabIndex = 13;
            this.buttonListarTablas.Text = "Listar Tablas";
            this.buttonListarTablas.UseVisualStyleBackColor = true;
            // 
            // DB_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1931, 1235);
            this.Controls.Add(this.buttonListarTablas);
            this.Controls.Add(this.listBoxTabla);
            this.Controls.Add(this.boton_editar);
            this.Controls.Add(this.boton_eliminar);
            this.Controls.Add(this.boton_actualizar);
            this.Controls.Add(this.boton_verRegistros);
            this.Controls.Add(this.boton_verTabla);
            this.Controls.Add(this.text_acciones);
            this.Controls.Add(this.text_tabla);
            this.Controls.Add(this.textBoxBD);
            this.Controls.Add(this.text_BD);
            this.Controls.Add(this.client_list);
            this.Name = "DB_Manager";
            this.Text = "DB_Manager";
            this.client_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel client_list;
        private System.Windows.Forms.Label text_BD;
        public System.Windows.Forms.TextBox textBoxBD;
        private System.Windows.Forms.Label text_tabla;
        private System.Windows.Forms.Label text_acciones;
        public System.Windows.Forms.Button boton_verTabla;
        public System.Windows.Forms.Button boton_verRegistros;
        public System.Windows.Forms.Button boton_actualizar;
        public System.Windows.Forms.Button boton_eliminar;
        public System.Windows.Forms.DataGridView tablas;
        public System.Windows.Forms.Button boton_editar;
        public System.Windows.Forms.ListBox listBoxTabla;
        public System.Windows.Forms.Button buttonListarTablas;
    }
}

