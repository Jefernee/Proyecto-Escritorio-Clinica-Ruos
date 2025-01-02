namespace Proyecto_Clinica
{
    partial class FormPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPacientes));
            this.dgv_pacientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_actualizarLista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_editarpaciente = new System.Windows.Forms.Button();
            this.btn_borrarpaciente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pacientes
            // 
            this.dgv_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pacientes.Location = new System.Drawing.Point(9, 139);
            this.dgv_pacientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_pacientes.Name = "dgv_pacientes";
            this.dgv_pacientes.RowHeadersWidth = 51;
            this.dgv_pacientes.Size = new System.Drawing.Size(811, 254);
            this.dgv_pacientes.TabIndex = 0;
            this.dgv_pacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pacientes_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pacientes";
            // 
            // btn_actualizarLista
            // 
            this.btn_actualizarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizarLista.Location = new System.Drawing.Point(16, 93);
            this.btn_actualizarLista.Margin = new System.Windows.Forms.Padding(2);
            this.btn_actualizarLista.Name = "btn_actualizarLista";
            this.btn_actualizarLista.Size = new System.Drawing.Size(101, 42);
            this.btn_actualizarLista.TabIndex = 8;
            this.btn_actualizarLista.Text = "Actualizar Lista";
            this.btn_actualizarLista.UseVisualStyleBackColor = true;
            this.btn_actualizarLista.Click += new System.EventHandler(this.btn_actualizarLista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Editar Paciente";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Proyecto_Clinica.Properties.Resources.aaag1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(292, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 83);
            this.button1.TabIndex = 7;
            this.button1.Text = "           Agregar Paciente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_editarpaciente
            // 
            this.btn_editarpaciente.Image = ((System.Drawing.Image)(resources.GetObject("btn_editarpaciente.Image")));
            this.btn_editarpaciente.Location = new System.Drawing.Point(567, 35);
            this.btn_editarpaciente.Name = "btn_editarpaciente";
            this.btn_editarpaciente.Size = new System.Drawing.Size(144, 83);
            this.btn_editarpaciente.TabIndex = 11;
            this.btn_editarpaciente.UseVisualStyleBackColor = true;
            this.btn_editarpaciente.Click += new System.EventHandler(this.btn_editarpaciente_Click);
            // 
            // btn_borrarpaciente
            // 
            this.btn_borrarpaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrarpaciente.Location = new System.Drawing.Point(151, 93);
            this.btn_borrarpaciente.Name = "btn_borrarpaciente";
            this.btn_borrarpaciente.Size = new System.Drawing.Size(101, 41);
            this.btn_borrarpaciente.TabIndex = 12;
            this.btn_borrarpaciente.Text = "Borrar Paciente";
            this.btn_borrarpaciente.UseVisualStyleBackColor = true;
            this.btn_borrarpaciente.Click += new System.EventHandler(this.btn_borrarpaciente_Click);
            // 
            // FormPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(855, 418);
            this.Controls.Add(this.btn_borrarpaciente);
            this.Controls.Add(this.btn_editarpaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_actualizarLista);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_pacientes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPacientes";
            this.Text = "FormPacientes";
            this.Load += new System.EventHandler(this.FormPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pacientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_actualizarLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_editarpaciente;
        private System.Windows.Forms.Button btn_borrarpaciente;
    }
}