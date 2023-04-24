namespace CapaPresentacion
{
    partial class Form2
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
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnFacturacion = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.BtnVendores = new System.Windows.Forms.Button();
            this.Btncliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProductos
            // 
            this.BtnProductos.Location = new System.Drawing.Point(128, 33);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(75, 23);
            this.BtnProductos.TabIndex = 0;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.UseVisualStyleBackColor = true;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnFacturacion
            // 
            this.BtnFacturacion.Location = new System.Drawing.Point(128, 232);
            this.BtnFacturacion.Name = "BtnFacturacion";
            this.BtnFacturacion.Size = new System.Drawing.Size(75, 23);
            this.BtnFacturacion.TabIndex = 1;
            this.BtnFacturacion.Text = "Facturacion";
            this.BtnFacturacion.UseVisualStyleBackColor = true;
            this.BtnFacturacion.Click += new System.EventHandler(this.BtnFacturacion_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.Location = new System.Drawing.Point(128, 177);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(75, 23);
            this.BtnInventario.TabIndex = 2;
            this.BtnInventario.Text = "Inventario";
            this.BtnInventario.UseVisualStyleBackColor = true;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // BtnVendores
            // 
            this.BtnVendores.Location = new System.Drawing.Point(128, 127);
            this.BtnVendores.Name = "BtnVendores";
            this.BtnVendores.Size = new System.Drawing.Size(75, 23);
            this.BtnVendores.TabIndex = 4;
            this.BtnVendores.Text = "Vendedores";
            this.BtnVendores.UseVisualStyleBackColor = true;
            this.BtnVendores.Click += new System.EventHandler(this.BtnVendores_Click);
            // 
            // Btncliente
            // 
            this.Btncliente.Location = new System.Drawing.Point(128, 73);
            this.Btncliente.Name = "Btncliente";
            this.Btncliente.Size = new System.Drawing.Size(75, 23);
            this.Btncliente.TabIndex = 5;
            this.Btncliente.Text = "Cliente";
            this.Btncliente.UseVisualStyleBackColor = true;
            this.Btncliente.Click += new System.EventHandler(this.Btncliente_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 337);
            this.Controls.Add(this.Btncliente);
            this.Controls.Add(this.BtnVendores);
            this.Controls.Add(this.BtnInventario);
            this.Controls.Add(this.BtnFacturacion);
            this.Controls.Add(this.BtnProductos);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnFacturacion;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Button BtnVendores;
        private System.Windows.Forms.Button Btncliente;
    }
}