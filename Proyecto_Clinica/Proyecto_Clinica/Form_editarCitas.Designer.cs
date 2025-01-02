namespace Proyecto_Clinica
{
    partial class Form_editarCitas
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
            this.lbl_id_cita = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_idCita = new System.Windows.Forms.TextBox();
            this.txt_idPaciente = new System.Windows.Forms.TextBox();
            this.txt_idMedico = new System.Windows.Forms.TextBox();
            this.dtp_hora = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.btn_editarcita = new System.Windows.Forms.Button();
            this.cbo_estado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_id_cita
            // 
            this.lbl_id_cita.AutoSize = true;
            this.lbl_id_cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_cita.Location = new System.Drawing.Point(78, 64);
            this.lbl_id_cita.Name = "lbl_id_cita";
            this.lbl_id_cita.Size = new System.Drawing.Size(59, 18);
            this.lbl_id_cita.TabIndex = 0;
            this.lbl_id_cita.Text = "ID Cita";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Medico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hora";
            // 
            // txt_idCita
            // 
            this.txt_idCita.Location = new System.Drawing.Point(160, 64);
            this.txt_idCita.Name = "txt_idCita";
            this.txt_idCita.ReadOnly = true;
            this.txt_idCita.Size = new System.Drawing.Size(169, 22);
            this.txt_idCita.TabIndex = 6;
            // 
            // txt_idPaciente
            // 
            this.txt_idPaciente.Location = new System.Drawing.Point(160, 131);
            this.txt_idPaciente.Name = "txt_idPaciente";
            this.txt_idPaciente.ReadOnly = true;
            this.txt_idPaciente.Size = new System.Drawing.Size(169, 22);
            this.txt_idPaciente.TabIndex = 7;
            // 
            // txt_idMedico
            // 
            this.txt_idMedico.Location = new System.Drawing.Point(160, 187);
            this.txt_idMedico.Name = "txt_idMedico";
            this.txt_idMedico.ReadOnly = true;
            this.txt_idMedico.Size = new System.Drawing.Size(169, 22);
            this.txt_idMedico.TabIndex = 8;
            // 
            // dtp_hora
            // 
            this.dtp_hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_hora.Location = new System.Drawing.Point(160, 294);
            this.dtp_hora.Name = "dtp_hora";
            this.dtp_hora.Size = new System.Drawing.Size(169, 22);
            this.dtp_hora.TabIndex = 12;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(160, 245);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(169, 22);
            this.dtp_fecha.TabIndex = 13;
            // 
            // btn_editarcita
            // 
            this.btn_editarcita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarcita.Location = new System.Drawing.Point(185, 406);
            this.btn_editarcita.Name = "btn_editarcita";
            this.btn_editarcita.Size = new System.Drawing.Size(103, 64);
            this.btn_editarcita.TabIndex = 14;
            this.btn_editarcita.Text = "Guardar Cambios";
            this.btn_editarcita.UseVisualStyleBackColor = true;
            this.btn_editarcita.Click += new System.EventHandler(this.btn_editarcita_Click);
            // 
            // cbo_estado
            // 
            this.cbo_estado.FormattingEnabled = true;
            this.cbo_estado.Items.AddRange(new object[] {
            "Pendiente",
            "Confirmada",
            "Completada",
            "Cancelada por el paciente",
            "No asistió"});
            this.cbo_estado.Location = new System.Drawing.Point(160, 345);
            this.cbo_estado.Name = "cbo_estado";
            this.cbo_estado.Size = new System.Drawing.Size(169, 24);
            this.cbo_estado.TabIndex = 15;
            this.cbo_estado.SelectedIndexChanged += new System.EventHandler(this.cbo_estado_SelectedIndexChanged);
            // 
            // Form_editarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 482);
            this.Controls.Add(this.cbo_estado);
            this.Controls.Add(this.btn_editarcita);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.dtp_hora);
            this.Controls.Add(this.txt_idMedico);
            this.Controls.Add(this.txt_idPaciente);
            this.Controls.Add(this.txt_idCita);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_id_cita);
            this.Name = "Form_editarCitas";
            this.Text = "Form_editarCitas";
            this.Load += new System.EventHandler(this.Form_editarCitas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id_cita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_idCita;
        private System.Windows.Forms.TextBox txt_idPaciente;
        private System.Windows.Forms.TextBox txt_idMedico;
        private System.Windows.Forms.DateTimePicker dtp_hora;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Button btn_editarcita;
        private System.Windows.Forms.ComboBox cbo_estado;
    }
}