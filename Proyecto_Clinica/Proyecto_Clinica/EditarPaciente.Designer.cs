namespace Proyecto_Clinica
{
    partial class EditarPaciente
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
            this.rtb_detalles = new System.Windows.Forms.RichTextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_idpaciente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_editarmedico = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_FechaNaci = new System.Windows.Forms.DateTimePicker();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtb_detalles
            // 
            this.rtb_detalles.Location = new System.Drawing.Point(122, 292);
            this.rtb_detalles.Name = "rtb_detalles";
            this.rtb_detalles.Size = new System.Drawing.Size(186, 88);
            this.rtb_detalles.TabIndex = 70;
            this.rtb_detalles.Text = "";
            this.rtb_detalles.TextChanged += new System.EventHandler(this.rtb_detalles_TextChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(281, 65);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(116, 38);
            this.btn_buscar.TabIndex = 67;
            this.btn_buscar.Text = "Buscar Paciente";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_idpaciente
            // 
            this.txt_idpaciente.Location = new System.Drawing.Point(165, 77);
            this.txt_idpaciente.Name = "txt_idpaciente";
            this.txt_idpaciente.Size = new System.Drawing.Size(100, 20);
            this.txt_idpaciente.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(83, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 65;
            this.label8.Text = "Id Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Editar Paciente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 63;
            this.label7.Text = "Otros Detalles";
            // 
            // btn_editarmedico
            // 
            this.btn_editarmedico.Location = new System.Drawing.Point(325, 320);
            this.btn_editarmedico.Name = "btn_editarmedico";
            this.btn_editarmedico.Size = new System.Drawing.Size(105, 40);
            this.btn_editarmedico.TabIndex = 62;
            this.btn_editarmedico.Text = "Editar Paciente";
            this.btn_editarmedico.UseVisualStyleBackColor = true;
            this.btn_editarmedico.Click += new System.EventHandler(this.btn_editarmedico_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(165, 109);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(165, 20);
            this.txt_nombre.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Nombre:";
            // 
            // dtp_FechaNaci
            // 
            this.dtp_FechaNaci.Location = new System.Drawing.Point(166, 144);
            this.dtp_FechaNaci.Name = "dtp_FechaNaci";
            this.dtp_FechaNaci.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaNaci.TabIndex = 71;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(166, 184);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(154, 20);
            this.txt_direccion.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(88, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 75;
            this.label9.Text = "Telefono:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(167, 219);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(153, 20);
            this.txt_telefono.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 77;
            this.label3.Text = "Correo Electronico:";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(167, 252);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(153, 20);
            this.txt_correo.TabIndex = 78;
            // 
            // EditarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(451, 421);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.dtp_FechaNaci);
            this.Controls.Add(this.rtb_detalles);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_idpaciente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_editarmedico);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "EditarPaciente";
            this.Text = "EditarPaciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_detalles;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_idpaciente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_editarmedico;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_FechaNaci;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_correo;
    }
}