namespace Proyecto_Clinica
{
    partial class ContraseñaOlvidada
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
            this.btn_editarusuario = new System.Windows.Forms.Button();
            this.cb_rol = new System.Windows.Forms.ComboBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscarusuario = new System.Windows.Forms.Button();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_idusuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_editarusuario
            // 
            this.btn_editarusuario.Location = new System.Drawing.Point(286, 222);
            this.btn_editarusuario.Name = "btn_editarusuario";
            this.btn_editarusuario.Size = new System.Drawing.Size(89, 43);
            this.btn_editarusuario.TabIndex = 125;
            this.btn_editarusuario.Text = "Editar Usuario";
            this.btn_editarusuario.UseVisualStyleBackColor = true;
            this.btn_editarusuario.Click += new System.EventHandler(this.btn_editarusuario_Click);
            // 
            // cb_rol
            // 
            this.cb_rol.Enabled = false;
            this.cb_rol.FormattingEnabled = true;
            this.cb_rol.Items.AddRange(new object[] {
            "Administrador",
            "Secretari@",
            "Jefe",
            "Medico"});
            this.cb_rol.Location = new System.Drawing.Point(147, 217);
            this.cb_rol.Name = "cb_rol";
            this.cb_rol.Size = new System.Drawing.Size(121, 21);
            this.cb_rol.TabIndex = 124;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(147, 70);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(164, 20);
            this.txt_correo.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 120;
            this.label1.Text = "Modificar Contraseña";
            // 
            // btn_buscarusuario
            // 
            this.btn_buscarusuario.Location = new System.Drawing.Point(325, 60);
            this.btn_buscarusuario.Name = "btn_buscarusuario";
            this.btn_buscarusuario.Size = new System.Drawing.Size(113, 38);
            this.btn_buscarusuario.TabIndex = 119;
            this.btn_buscarusuario.Text = "Buscar Usuario";
            this.btn_buscarusuario.UseVisualStyleBackColor = true;
            this.btn_buscarusuario.Click += new System.EventHandler(this.btn_buscarusuario_Click);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(147, 174);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(164, 20);
            this.txt_contraseña.TabIndex = 118;
            this.txt_contraseña.UseSystemPasswordChar = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(147, 139);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(164, 20);
            this.txt_nombre.TabIndex = 117;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 115;
            this.label6.Text = "Rol:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 114;
            this.label5.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 113;
            this.label4.Text = "Correo Electronico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 112;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 111;
            this.label2.Text = "Id Usuario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 16);
            this.label7.TabIndex = 126;
            this.label7.Text = "Digite el Correo de ingreso a buscar";
            // 
            // txt_idusuario
            // 
            this.txt_idusuario.Enabled = false;
            this.txt_idusuario.Location = new System.Drawing.Point(147, 103);
            this.txt_idusuario.Name = "txt_idusuario";
            this.txt_idusuario.Size = new System.Drawing.Size(102, 20);
            this.txt_idusuario.TabIndex = 116;
            // 
            // ContraseñaOlvidada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(450, 291);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_editarusuario);
            this.Controls.Add(this.cb_rol);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_buscarusuario);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_idusuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ContraseñaOlvidada";
            this.Text = "ContraseñaOlvidada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_editarusuario;
        private System.Windows.Forms.ComboBox cb_rol;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscarusuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_idusuario;
    }
}