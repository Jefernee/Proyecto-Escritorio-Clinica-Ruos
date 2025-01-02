namespace Proyecto_Clinica
{
    partial class EditarMedico
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
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_idmedico = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_editarmedico = new System.Windows.Forms.Button();
            this.txt_especialidad = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_salida = new System.Windows.Forms.DateTimePicker();
            this.rtb_detalles = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(266, 76);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(116, 38);
            this.btn_buscar.TabIndex = 50;
            this.btn_buscar.Text = "Buscar Medico";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_idmedico
            // 
            this.txt_idmedico.Location = new System.Drawing.Point(150, 88);
            this.txt_idmedico.Name = "txt_idmedico";
            this.txt_idmedico.Size = new System.Drawing.Size(100, 20);
            this.txt_idmedico.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "Id Medico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Editar Medico";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Otros Detalles";
            // 
            // btn_editarmedico
            // 
            this.btn_editarmedico.Location = new System.Drawing.Point(150, 360);
            this.btn_editarmedico.Name = "btn_editarmedico";
            this.btn_editarmedico.Size = new System.Drawing.Size(105, 35);
            this.btn_editarmedico.TabIndex = 44;
            this.btn_editarmedico.Text = "Editar Medico";
            this.btn_editarmedico.UseVisualStyleBackColor = true;
            this.btn_editarmedico.Click += new System.EventHandler(this.btn_editarmedico_Click);
            // 
            // txt_especialidad
            // 
            this.txt_especialidad.Location = new System.Drawing.Point(150, 149);
            this.txt_especialidad.Name = "txt_especialidad";
            this.txt_especialidad.Size = new System.Drawing.Size(164, 20);
            this.txt_especialidad.TabIndex = 40;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(150, 120);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(165, 20);
            this.txt_nombre.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Hora de salida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Hora de inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Especialidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre:";
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.CustomFormat = "HH:mm tt";
            this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_inicio.Location = new System.Drawing.Point(150, 181);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(200, 20);
            this.dtp_inicio.TabIndex = 51;
            this.dtp_inicio.Value = new System.DateTime(2023, 7, 22, 7, 0, 0, 0);
            // 
            // dtp_salida
            // 
            this.dtp_salida.CustomFormat = "HH:mm tt";
            this.dtp_salida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_salida.Location = new System.Drawing.Point(150, 209);
            this.dtp_salida.Name = "dtp_salida";
            this.dtp_salida.Size = new System.Drawing.Size(200, 20);
            this.dtp_salida.TabIndex = 52;
            this.dtp_salida.Value = new System.DateTime(2023, 7, 22, 7, 0, 0, 0);
            // 
            // rtb_detalles
            // 
            this.rtb_detalles.Location = new System.Drawing.Point(150, 250);
            this.rtb_detalles.Name = "rtb_detalles";
            this.rtb_detalles.Size = new System.Drawing.Size(186, 88);
            this.rtb_detalles.TabIndex = 53;
            this.rtb_detalles.Text = "";
            // 
            // EditarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.rtb_detalles);
            this.Controls.Add(this.dtp_salida);
            this.Controls.Add(this.dtp_inicio);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_idmedico);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_editarmedico);
            this.Controls.Add(this.txt_especialidad);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EditarMedico";
            this.Text = "EditarMedico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_idmedico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_editarmedico;
        private System.Windows.Forms.TextBox txt_especialidad;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.DateTimePicker dtp_salida;
        private System.Windows.Forms.RichTextBox rtb_detalles;
    }
}