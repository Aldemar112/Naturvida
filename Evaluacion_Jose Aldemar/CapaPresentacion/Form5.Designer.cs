namespace CapaPresentacion
{
    partial class Form5
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Txtcorreo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DgvCliente = new System.Windows.Forms.DataGridView();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.CmbCliente = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TxtCorreoD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtelefonoD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDireccionD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtNombreD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtDocumentoD = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Btnmodificar = new System.Windows.Forms.Button();
            this.BtnConsulatrD = new System.Windows.Forms.Button();
            this.CmbClienteeditar = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Btneliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbeliminarC = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1140, 457);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Txtcorreo);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.BtnLimpiar);
            this.tabPage1.Controls.Add(this.BtnInsertar);
            this.tabPage1.Controls.Add(this.TxtTelefono);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.TxtDireccion);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.TxtNombre);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TxtDocumento);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1132, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "InsertarProduccto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Txtcorreo
            // 
            this.Txtcorreo.Location = new System.Drawing.Point(230, 233);
            this.Txtcorreo.Name = "Txtcorreo";
            this.Txtcorreo.Size = new System.Drawing.Size(100, 20);
            this.Txtcorreo.TabIndex = 12;
            this.Txtcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcorreo_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(143, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Correo";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(255, 285);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 9;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(130, 286);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(75, 23);
            this.BtnInsertar.TabIndex = 8;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(230, 181);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefono.TabIndex = 7;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(230, 139);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(100, 20);
            this.TxtDireccion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dirección";
            // 
            // TxtNombre
            // 
            this.TxtNombre.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TxtNombre.Location = new System.Drawing.Point(230, 87);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(230, 38);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(100, 20);
            this.TxtDocumento.TabIndex = 1;
            this.TxtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDocumento_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DgvCliente);
            this.tabPage2.Controls.Add(this.BtnMostrar);
            this.tabPage2.Controls.Add(this.BtnConsultar);
            this.tabPage2.Controls.Add(this.CmbCliente);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1132, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DgvCliente
            // 
            this.DgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCliente.Location = new System.Drawing.Point(17, 119);
            this.DgvCliente.Name = "DgvCliente";
            this.DgvCliente.Size = new System.Drawing.Size(1112, 306);
            this.DgvCliente.TabIndex = 3;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(534, 60);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(135, 23);
            this.BtnMostrar.TabIndex = 2;
            this.BtnMostrar.Text = "Mostrar Todo";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(380, 60);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 1;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // CmbCliente
            // 
            this.CmbCliente.FormattingEnabled = true;
            this.CmbCliente.Location = new System.Drawing.Point(339, 23);
            this.CmbCliente.Name = "CmbCliente";
            this.CmbCliente.Size = new System.Drawing.Size(355, 21);
            this.CmbCliente.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TxtCorreoD);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.TxtelefonoD);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.TxtDireccionD);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.TxtNombreD);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.TxtDocumentoD);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.Btnmodificar);
            this.tabPage3.Controls.Add(this.BtnConsulatrD);
            this.tabPage3.Controls.Add(this.CmbClienteeditar);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1132, 431);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TxtCorreoD
            // 
            this.TxtCorreoD.Location = new System.Drawing.Point(576, 316);
            this.TxtCorreoD.Name = "TxtCorreoD";
            this.TxtCorreoD.Size = new System.Drawing.Size(100, 20);
            this.TxtCorreoD.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Correo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(599, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "label5";
            // 
            // TxtelefonoD
            // 
            this.TxtelefonoD.Location = new System.Drawing.Point(576, 264);
            this.TxtelefonoD.Name = "TxtelefonoD";
            this.TxtelefonoD.Size = new System.Drawing.Size(100, 20);
            this.TxtelefonoD.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Telefono";
            // 
            // TxtDireccionD
            // 
            this.TxtDireccionD.Location = new System.Drawing.Point(576, 222);
            this.TxtDireccionD.Name = "TxtDireccionD";
            this.TxtDireccionD.Size = new System.Drawing.Size(100, 20);
            this.TxtDireccionD.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(489, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Dirección";
            // 
            // TxtNombreD
            // 
            this.TxtNombreD.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TxtNombreD.Location = new System.Drawing.Point(576, 170);
            this.TxtNombreD.Name = "TxtNombreD";
            this.TxtNombreD.Size = new System.Drawing.Size(100, 20);
            this.TxtNombreD.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(489, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Nombre";
            // 
            // TxtDocumentoD
            // 
            this.TxtDocumentoD.Location = new System.Drawing.Point(576, 121);
            this.TxtDocumentoD.Name = "TxtDocumentoD";
            this.TxtDocumentoD.Size = new System.Drawing.Size(100, 20);
            this.TxtDocumentoD.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(489, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Documento";
            // 
            // Btnmodificar
            // 
            this.Btnmodificar.Location = new System.Drawing.Point(537, 358);
            this.Btnmodificar.Name = "Btnmodificar";
            this.Btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.Btnmodificar.TabIndex = 21;
            this.Btnmodificar.Text = "Modificar";
            this.Btnmodificar.UseVisualStyleBackColor = true;
            this.Btnmodificar.Click += new System.EventHandler(this.Btnmodificar_Click);
            // 
            // BtnConsulatrD
            // 
            this.BtnConsulatrD.Location = new System.Drawing.Point(559, 85);
            this.BtnConsulatrD.Name = "BtnConsulatrD";
            this.BtnConsulatrD.Size = new System.Drawing.Size(75, 23);
            this.BtnConsulatrD.TabIndex = 20;
            this.BtnConsulatrD.Text = "Consultar";
            this.BtnConsulatrD.UseVisualStyleBackColor = true;
            this.BtnConsulatrD.Click += new System.EventHandler(this.BtnConsulatrD_Click);
            // 
            // CmbClienteeditar
            // 
            this.CmbClienteeditar.FormattingEnabled = true;
            this.CmbClienteeditar.Location = new System.Drawing.Point(404, 58);
            this.CmbClienteeditar.Name = "CmbClienteeditar";
            this.CmbClienteeditar.Size = new System.Drawing.Size(355, 21);
            this.CmbClienteeditar.TabIndex = 19;
            this.CmbClienteeditar.SelectedIndexChanged += new System.EventHandler(this.CmbClienteeditar_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Btneliminar);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.cmbeliminarC);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1132, 431);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eliminar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Btneliminar
            // 
            this.Btneliminar.Location = new System.Drawing.Point(540, 134);
            this.Btneliminar.Name = "Btneliminar";
            this.Btneliminar.Size = new System.Drawing.Size(75, 23);
            this.Btneliminar.TabIndex = 22;
            this.Btneliminar.Text = "Eliminar";
            this.Btneliminar.UseVisualStyleBackColor = true;
            this.Btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Producto:";
            // 
            // cmbeliminarC
            // 
            this.cmbeliminarC.FormattingEnabled = true;
            this.cmbeliminarC.Location = new System.Drawing.Point(388, 77);
            this.cmbeliminarC.Name = "cmbeliminarC";
            this.cmbeliminarC.Size = new System.Drawing.Size(355, 21);
            this.cmbeliminarC.TabIndex = 20;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 535);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DgvCliente;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.ComboBox CmbCliente;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Btnmodificar;
        private System.Windows.Forms.Button BtnConsulatrD;
        private System.Windows.Forms.ComboBox CmbClienteeditar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button Btneliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbeliminarC;
        private System.Windows.Forms.TextBox Txtcorreo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtCorreoD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtelefonoD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtDireccionD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtNombreD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtDocumentoD;
        private System.Windows.Forms.Label label13;
    }
}