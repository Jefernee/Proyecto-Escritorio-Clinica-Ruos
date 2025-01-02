namespace Proyecto_Clinica
{
    partial class Form_Citas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Citas));
            this.dgv_Citas = new System.Windows.Forms.DataGridView();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_editar_cita = new System.Windows.Forms.Button();
            this.btn_agregar_cita = new System.Windows.Forms.Button();
            this.btn_eliminarcita = new System.Windows.Forms.Button();
            this.txt_filtrar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Citas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Citas
            // 
            this.dgv_Citas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_Citas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Citas.Location = new System.Drawing.Point(45, 208);
            this.dgv_Citas.Name = "dgv_Citas";
            this.dgv_Citas.RowHeadersWidth = 51;
            this.dgv_Citas.RowTemplate.Height = 24;
            this.dgv_Citas.Size = new System.Drawing.Size(861, 304);
            this.dgv_Citas.TabIndex = 4;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_actualizar.Location = new System.Drawing.Point(55, 54);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(188, 63);
            this.btn_actualizar.TabIndex = 7;
            this.btn_actualizar.Text = "                Actualizar                      Lista";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_editar_cita
            // 
            this.btn_editar_cita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_editar_cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_cita.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar_cita.Image")));
            this.btn_editar_cita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar_cita.Location = new System.Drawing.Point(701, 55);
            this.btn_editar_cita.Name = "btn_editar_cita";
            this.btn_editar_cita.Size = new System.Drawing.Size(215, 62);
            this.btn_editar_cita.TabIndex = 6;
            this.btn_editar_cita.Text = "                 Editar Cita";
            this.btn_editar_cita.UseVisualStyleBackColor = true;
            this.btn_editar_cita.Click += new System.EventHandler(this.btn_editar_cita_Click);
            // 
            // btn_agregar_cita
            // 
            this.btn_agregar_cita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_agregar_cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_cita.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar_cita.Image")));
            this.btn_agregar_cita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar_cita.Location = new System.Drawing.Point(465, 55);
            this.btn_agregar_cita.Name = "btn_agregar_cita";
            this.btn_agregar_cita.Size = new System.Drawing.Size(230, 63);
            this.btn_agregar_cita.TabIndex = 5;
            this.btn_agregar_cita.Text = "                       Nueva Cita";
            this.btn_agregar_cita.UseVisualStyleBackColor = true;
            this.btn_agregar_cita.Click += new System.EventHandler(this.btn_agregar_cita_Click);
            // 
            // btn_eliminarcita
            // 
            this.btn_eliminarcita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarcita.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminarcita.Image")));
            this.btn_eliminarcita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminarcita.Location = new System.Drawing.Point(249, 55);
            this.btn_eliminarcita.Name = "btn_eliminarcita";
            this.btn_eliminarcita.Size = new System.Drawing.Size(210, 62);
            this.btn_eliminarcita.TabIndex = 8;
            this.btn_eliminarcita.Text = "     Eliminar";
            this.btn_eliminarcita.UseVisualStyleBackColor = true;
            this.btn_eliminarcita.Click += new System.EventHandler(this.btn_eliminarcita_Click);
            // 
            // txt_filtrar
            // 
            this.txt_filtrar.Location = new System.Drawing.Point(157, 171);
            this.txt_filtrar.Name = "txt_filtrar";
            this.txt_filtrar.Size = new System.Drawing.Size(276, 22);
            this.txt_filtrar.TabIndex = 9;
            this.txt_filtrar.TextChanged += new System.EventHandler(this.txt_filtrar_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(439, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID Paciente";
            // 
            // Form_Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_filtrar);
            this.Controls.Add(this.btn_eliminarcita);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_editar_cita);
            this.Controls.Add(this.btn_agregar_cita);
            this.Controls.Add(this.dgv_Citas);
            this.Name = "Form_Citas";
            this.Text = "Form_Citas";
            this.Load += new System.EventHandler(this.Form_Citas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Citas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_editar_cita;
        private System.Windows.Forms.Button btn_agregar_cita;
        private System.Windows.Forms.DataGridView dgv_Citas;
        private System.Windows.Forms.Button btn_eliminarcita;
        private System.Windows.Forms.TextBox txt_filtrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}