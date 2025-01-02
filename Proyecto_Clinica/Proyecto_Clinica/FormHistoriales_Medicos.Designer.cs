namespace Proyecto_Clinica
{
    partial class FormHistoriales_Medicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoriales_Medicos));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_historialesmedicos = new System.Windows.Forms.Button();
            this.btn_agregarhistorialpaciente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Borrar_historial = new System.Windows.Forms.Button();
            this.dgv_historialesmedicos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historialesmedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Historiales Medicos";
            // 
            // btn_historialesmedicos
            // 
            this.btn_historialesmedicos.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_historialesmedicos.Location = new System.Drawing.Point(12, 91);
            this.btn_historialesmedicos.Name = "btn_historialesmedicos";
            this.btn_historialesmedicos.Size = new System.Drawing.Size(156, 53);
            this.btn_historialesmedicos.TabIndex = 2;
            this.btn_historialesmedicos.Text = "Actualizar Historiales";
            this.btn_historialesmedicos.UseVisualStyleBackColor = true;
            this.btn_historialesmedicos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_agregarhistorialpaciente
            // 
            this.btn_agregarhistorialpaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarhistorialpaciente.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregarhistorialpaciente.Image")));
            this.btn_agregarhistorialpaciente.Location = new System.Drawing.Point(226, 51);
            this.btn_agregarhistorialpaciente.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregarhistorialpaciente.Name = "btn_agregarhistorialpaciente";
            this.btn_agregarhistorialpaciente.Size = new System.Drawing.Size(169, 84);
            this.btn_agregarhistorialpaciente.TabIndex = 7;
            this.btn_agregarhistorialpaciente.UseVisualStyleBackColor = true;
            this.btn_agregarhistorialpaciente.Click += new System.EventHandler(this.btn_agregarhistorialpaciente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Agregar Historial de Paciente";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(442, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 84);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Editar Historial de Paciente";
            // 
            // Borrar_historial
            // 
            this.Borrar_historial.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrar_historial.Location = new System.Drawing.Point(644, 91);
            this.Borrar_historial.Name = "Borrar_historial";
            this.Borrar_historial.Size = new System.Drawing.Size(116, 53);
            this.Borrar_historial.TabIndex = 11;
            this.Borrar_historial.Text = "Eliminar Historial";
            this.Borrar_historial.UseVisualStyleBackColor = true;
            this.Borrar_historial.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv_historialesmedicos
            // 
            this.dgv_historialesmedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historialesmedicos.Location = new System.Drawing.Point(16, 174);
            this.dgv_historialesmedicos.Name = "dgv_historialesmedicos";
            this.dgv_historialesmedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_historialesmedicos.Size = new System.Drawing.Size(744, 241);
            this.dgv_historialesmedicos.TabIndex = 12;
            // 
            // FormHistoriales_Medicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_historialesmedicos);
            this.Controls.Add(this.Borrar_historial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_agregarhistorialpaciente);
            this.Controls.Add(this.btn_historialesmedicos);
            this.Controls.Add(this.label1);
            this.Name = "FormHistoriales_Medicos";
            this.Text = "Historiales_Medicos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historialesmedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_historialesmedicos;
        private System.Windows.Forms.Button btn_agregarhistorialpaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Borrar_historial;
        private System.Windows.Forms.DataGridView dgv_historialesmedicos;
    }
}