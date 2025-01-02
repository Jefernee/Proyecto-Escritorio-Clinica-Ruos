namespace Proyecto_Clinica
{
    partial class AgregarRoles
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
            this.txt_nombrerol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_agregarrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nombrerol
            // 
            this.txt_nombrerol.Location = new System.Drawing.Point(145, 72);
            this.txt_nombrerol.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombrerol.Name = "txt_nombrerol";
            this.txt_nombrerol.Size = new System.Drawing.Size(205, 20);
            this.txt_nombrerol.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Agregar Roles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Nombre";
            // 
            // btn_agregarrol
            // 
            this.btn_agregarrol.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarrol.Location = new System.Drawing.Point(124, 152);
            this.btn_agregarrol.Name = "btn_agregarrol";
            this.btn_agregarrol.Size = new System.Drawing.Size(159, 38);
            this.btn_agregarrol.TabIndex = 39;
            this.btn_agregarrol.Text = "Agregar Rol";
            this.btn_agregarrol.UseVisualStyleBackColor = true;
            this.btn_agregarrol.Click += new System.EventHandler(this.btn_agregarrol_Click);
            // 
            // AgregarRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(417, 223);
            this.Controls.Add(this.btn_agregarrol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nombrerol);
            this.Controls.Add(this.label1);
            this.Name = "AgregarRoles";
            this.Text = "AgregarRoles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombrerol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_agregarrol;
    }
}