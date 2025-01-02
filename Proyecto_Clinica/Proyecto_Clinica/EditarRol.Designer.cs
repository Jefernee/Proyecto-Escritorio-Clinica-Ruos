namespace Proyecto_Clinica
{
    partial class EditarRol
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
            this.btn_buscarrol = new System.Windows.Forms.Button();
            this.txt_idrol = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombrerol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_editarrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_buscarrol
            // 
            this.btn_buscarrol.Location = new System.Drawing.Point(266, 57);
            this.btn_buscarrol.Name = "btn_buscarrol";
            this.btn_buscarrol.Size = new System.Drawing.Size(116, 38);
            this.btn_buscarrol.TabIndex = 58;
            this.btn_buscarrol.Text = "Buscar Rol";
            this.btn_buscarrol.UseVisualStyleBackColor = true;
            this.btn_buscarrol.Click += new System.EventHandler(this.btn_buscarrol_Click);
            // 
            // txt_idrol
            // 
            this.txt_idrol.Location = new System.Drawing.Point(160, 72);
            this.txt_idrol.Name = "txt_idrol";
            this.txt_idrol.Size = new System.Drawing.Size(100, 20);
            this.txt_idrol.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(99, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 56;
            this.label8.Text = "Id Rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Editar Rol";
            // 
            // txt_nombrerol
            // 
            this.txt_nombrerol.Location = new System.Drawing.Point(159, 101);
            this.txt_nombrerol.Name = "txt_nombrerol";
            this.txt_nombrerol.Size = new System.Drawing.Size(165, 20);
            this.txt_nombrerol.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nombre:";
            // 
            // btn_editarrol
            // 
            this.btn_editarrol.Location = new System.Drawing.Point(153, 147);
            this.btn_editarrol.Name = "btn_editarrol";
            this.btn_editarrol.Size = new System.Drawing.Size(107, 36);
            this.btn_editarrol.TabIndex = 59;
            this.btn_editarrol.Text = "Editar Rol";
            this.btn_editarrol.UseVisualStyleBackColor = true;
            this.btn_editarrol.Click += new System.EventHandler(this.btn_editarrol_Click);
            // 
            // EditarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(413, 225);
            this.Controls.Add(this.btn_editarrol);
            this.Controls.Add(this.btn_buscarrol);
            this.Controls.Add(this.txt_idrol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombrerol);
            this.Controls.Add(this.label2);
            this.Name = "EditarRol";
            this.Text = "EditarRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscarrol;
        private System.Windows.Forms.TextBox txt_idrol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombrerol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_editarrol;
    }
}