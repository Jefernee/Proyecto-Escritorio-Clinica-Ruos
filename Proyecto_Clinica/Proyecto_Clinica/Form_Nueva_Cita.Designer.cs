namespace Proyecto_Clinica
{
    partial class Form_Nueva_Cita
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
            this.btn_agregarcita = new System.Windows.Forms.Button();
            this.dtp_hora = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.cbo_medico = new System.Windows.Forms.ComboBox();
            this.txt_id_paciente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_estado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_agregarcita
            // 
            this.btn_agregarcita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarcita.Location = new System.Drawing.Point(156, 271);
            this.btn_agregarcita.Name = "btn_agregarcita";
            this.btn_agregarcita.Size = new System.Drawing.Size(92, 67);
            this.btn_agregarcita.TabIndex = 17;
            this.btn_agregarcita.Text = "Agregar Cita";
            this.btn_agregarcita.UseVisualStyleBackColor = true;
            this.btn_agregarcita.Click += new System.EventHandler(this.btn_agregarcita_Click);
            // 
            // dtp_hora
            // 
            this.dtp_hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_hora.Location = new System.Drawing.Point(128, 193);
            this.dtp_hora.Name = "dtp_hora";
            this.dtp_hora.Size = new System.Drawing.Size(179, 22);
            this.dtp_hora.TabIndex = 16;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(128, 140);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(179, 22);
            this.dtp_fecha.TabIndex = 15;
            // 
            // cbo_medico
            // 
            this.cbo_medico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_medico.FormattingEnabled = true;
            this.cbo_medico.Location = new System.Drawing.Point(128, 90);
            this.cbo_medico.Name = "cbo_medico";
            this.cbo_medico.Size = new System.Drawing.Size(179, 24);
            this.cbo_medico.TabIndex = 14;
            this.cbo_medico.SelectedIndexChanged += new System.EventHandler(this.cbo_medico_SelectedIndexChanged);
            // 
            // txt_id_paciente
            // 
            this.txt_id_paciente.Location = new System.Drawing.Point(128, 37);
            this.txt_id_paciente.Name = "txt_id_paciente";
            this.txt_id_paciente.Size = new System.Drawing.Size(179, 22);
            this.txt_id_paciente.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Medico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Paciente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Estado";
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
            this.cbo_estado.Location = new System.Drawing.Point(128, 239);
            this.cbo_estado.Name = "cbo_estado";
            this.cbo_estado.Size = new System.Drawing.Size(179, 24);
            this.cbo_estado.TabIndex = 19;
            this.cbo_estado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form_Nueva_Cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 350);
            this.Controls.Add(this.cbo_estado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_agregarcita);
            this.Controls.Add(this.dtp_hora);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.cbo_medico);
            this.Controls.Add(this.txt_id_paciente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Nueva_Cita";
            this.Text = "Form_Nueva_Cita";
            this.Load += new System.EventHandler(this.Form_Nueva_Cita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregarcita;
        private System.Windows.Forms.DateTimePicker dtp_hora;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.ComboBox cbo_medico;
        private System.Windows.Forms.TextBox txt_id_paciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_estado;
    }
}