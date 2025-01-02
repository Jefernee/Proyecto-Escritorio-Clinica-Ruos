namespace Proyecto_Clinica
{
    partial class FormUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_borrarusuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Actualizar_usuarios = new System.Windows.Forms.Button();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.btn_editarusuario = new System.Windows.Forms.Button();
            this.btn_agregarusuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Editar Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Agregar Usuario";
            // 
            // btn_borrarusuario
            // 
            this.btn_borrarusuario.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrarusuario.Location = new System.Drawing.Point(618, 107);
            this.btn_borrarusuario.Name = "btn_borrarusuario";
            this.btn_borrarusuario.Size = new System.Drawing.Size(134, 37);
            this.btn_borrarusuario.TabIndex = 17;
            this.btn_borrarusuario.Text = "Eliminar Usuario";
            this.btn_borrarusuario.UseVisualStyleBackColor = true;
            this.btn_borrarusuario.Click += new System.EventHandler(this.btn_borrarusuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Usuarios";
            // 
            // Actualizar_usuarios
            // 
            this.Actualizar_usuarios.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar_usuarios.Location = new System.Drawing.Point(4, 116);
            this.Actualizar_usuarios.Name = "Actualizar_usuarios";
            this.Actualizar_usuarios.Size = new System.Drawing.Size(160, 38);
            this.Actualizar_usuarios.TabIndex = 15;
            this.Actualizar_usuarios.Text = "Actualizar Usuarios";
            this.Actualizar_usuarios.UseVisualStyleBackColor = true;
            this.Actualizar_usuarios.Click += new System.EventHandler(this.Actualizar_usuarios_Click);
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(13, 172);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.Size = new System.Drawing.Size(719, 248);
            this.dgv_usuarios.TabIndex = 20;
            this.dgv_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuarios_CellClick);
            // 
            // btn_editarusuario
            // 
            this.btn_editarusuario.BackColor = System.Drawing.Color.White;
            this.btn_editarusuario.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarusuario.Image = ((System.Drawing.Image)(resources.GetObject("btn_editarusuario.Image")));
            this.btn_editarusuario.Location = new System.Drawing.Point(416, 28);
            this.btn_editarusuario.Name = "btn_editarusuario";
            this.btn_editarusuario.Size = new System.Drawing.Size(179, 102);
            this.btn_editarusuario.TabIndex = 16;
            this.btn_editarusuario.UseVisualStyleBackColor = false;
            this.btn_editarusuario.Click += new System.EventHandler(this.btn_editarusuario_Click);
            // 
            // btn_agregarusuario
            // 
            this.btn_agregarusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarusuario.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregarusuario.Image")));
            this.btn_agregarusuario.Location = new System.Drawing.Point(190, 28);
            this.btn_agregarusuario.Name = "btn_agregarusuario";
            this.btn_agregarusuario.Size = new System.Drawing.Size(187, 102);
            this.btn_agregarusuario.TabIndex = 14;
            this.btn_agregarusuario.UseVisualStyleBackColor = true;
            this.btn_agregarusuario.Click += new System.EventHandler(this.btn_agregarusuario_Click);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.dgv_usuarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_borrarusuario);
            this.Controls.Add(this.btn_editarusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Actualizar_usuarios);
            this.Controls.Add(this.btn_agregarusuario);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_borrarusuario;
        private System.Windows.Forms.Button btn_editarusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Actualizar_usuarios;
        private System.Windows.Forms.Button btn_agregarusuario;
        private System.Windows.Forms.DataGridView dgv_usuarios;
    }
}