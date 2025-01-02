namespace Proyecto_Clinica
{
    partial class FormMedicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedicos));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_medicos = new System.Windows.Forms.Button();
            this.dgv_medicos = new System.Windows.Forms.DataGridView();
            this.Actualizar_medicos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Medicos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_medicos
            // 
            this.btn_medicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_medicos.Image = ((System.Drawing.Image)(resources.GetObject("btn_medicos.Image")));
            this.btn_medicos.Location = new System.Drawing.Point(214, 46);
            this.btn_medicos.Name = "btn_medicos";
            this.btn_medicos.Size = new System.Drawing.Size(187, 102);
            this.btn_medicos.TabIndex = 4;
            this.btn_medicos.UseVisualStyleBackColor = true;
            this.btn_medicos.Click += new System.EventHandler(this.btn_medicos_Click);
            // 
            // dgv_medicos
            // 
            this.dgv_medicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_medicos.Location = new System.Drawing.Point(28, 178);
            this.dgv_medicos.Name = "dgv_medicos";
            this.dgv_medicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_medicos.Size = new System.Drawing.Size(720, 248);
            this.dgv_medicos.TabIndex = 5;
            this.dgv_medicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_medicos_CellClick);
            // 
            // Actualizar_medicos
            // 
            this.Actualizar_medicos.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar_medicos.Location = new System.Drawing.Point(28, 134);
            this.Actualizar_medicos.Name = "Actualizar_medicos";
            this.Actualizar_medicos.Size = new System.Drawing.Size(160, 38);
            this.Actualizar_medicos.TabIndex = 5;
            this.Actualizar_medicos.Text = "Actualizar Medicos";
            this.Actualizar_medicos.UseVisualStyleBackColor = true;
            this.Actualizar_medicos.Click += new System.EventHandler(this.Actualizar_medicos_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(440, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 102);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar.Location = new System.Drawing.Point(642, 125);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(134, 37);
            this.btn_borrar.TabIndex = 10;
            this.btn_borrar.Text = "Eliminar Medico";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Agregar Medico";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(469, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Editar Medico ";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // FormMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_medicos);
            this.Controls.Add(this.Actualizar_medicos);
            this.Controls.Add(this.btn_medicos);
            this.Name = "FormMedicos";
            this.Text = "Medicos";
            this.Load += new System.EventHandler(this.FormMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_medicos;
        private System.Windows.Forms.Button btn_medicos;
        private System.Windows.Forms.Button Actualizar_medicos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}