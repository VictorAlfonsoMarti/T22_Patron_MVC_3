
namespace T22_Patrón_MVC_3.View
{
    partial class RegistroAsignado_A
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
            this.panel_mostrar = new System.Windows.Forms.Panel();
            this.textBoxMostrarID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMostrarDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boton_salir = new System.Windows.Forms.Button();
            this.boton_enviar = new System.Windows.Forms.Button();
            this.panel_mostrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_mostrar
            // 
            this.panel_mostrar.Controls.Add(this.textBoxMostrarID);
            this.panel_mostrar.Controls.Add(this.label3);
            this.panel_mostrar.Controls.Add(this.label2);
            this.panel_mostrar.Controls.Add(this.textBoxMostrarDNI);
            this.panel_mostrar.Controls.Add(this.label1);
            this.panel_mostrar.Location = new System.Drawing.Point(71, 81);
            this.panel_mostrar.Name = "panel_mostrar";
            this.panel_mostrar.Size = new System.Drawing.Size(703, 321);
            this.panel_mostrar.TabIndex = 0;
            this.panel_mostrar.Visible = false;
            // 
            // textBoxMostrarID
            // 
            this.textBoxMostrarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14286F);
            this.textBoxMostrarID.Location = new System.Drawing.Point(261, 187);
            this.textBoxMostrarID.Name = "textBoxMostrarID";
            this.textBoxMostrarID.Size = new System.Drawing.Size(379, 40);
            this.textBoxMostrarID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14286F);
            this.label3.Location = new System.Drawing.Point(15, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Proyecto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14286F);
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI Cientifico:";
            // 
            // textBoxMostrarDNI
            // 
            this.textBoxMostrarDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14286F);
            this.textBoxMostrarDNI.Location = new System.Drawing.Point(261, 81);
            this.textBoxMostrarDNI.Name = "textBoxMostrarDNI";
            this.textBoxMostrarDNI.Size = new System.Drawing.Size(379, 40);
            this.textBoxMostrarDNI.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14286F);
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mostrar Relaciones:";
            // 
            // boton_salir
            // 
            this.boton_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14286F);
            this.boton_salir.Location = new System.Drawing.Point(56, 467);
            this.boton_salir.Name = "boton_salir";
            this.boton_salir.Size = new System.Drawing.Size(264, 54);
            this.boton_salir.TabIndex = 1;
            this.boton_salir.Text = "Salir";
            this.boton_salir.UseVisualStyleBackColor = true;
            this.boton_salir.Click += new System.EventHandler(this.boton_salir_Click_1);
            // 
            // boton_enviar
            // 
            this.boton_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14286F);
            this.boton_enviar.Location = new System.Drawing.Point(447, 467);
            this.boton_enviar.Name = "boton_enviar";
            this.boton_enviar.Size = new System.Drawing.Size(264, 54);
            this.boton_enviar.TabIndex = 2;
            this.boton_enviar.Text = "Enviar";
            this.boton_enviar.UseVisualStyleBackColor = true;
            // 
            // RegistroAsignado_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.boton_enviar);
            this.Controls.Add(this.panel_mostrar);
            this.Controls.Add(this.boton_salir);
            this.Name = "RegistroAsignado_A";
            this.Text = "Asignado_A ";
            this.panel_mostrar.ResumeLayout(false);
            this.panel_mostrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_mostrar;
        public System.Windows.Forms.TextBox textBoxMostrarDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_salir;
        public System.Windows.Forms.Button boton_enviar;
        public System.Windows.Forms.TextBox textBoxMostrarID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}