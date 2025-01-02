namespace Proyecto_Clinica
{
    partial class FormRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoles));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_roles = new System.Windows.Forms.DataGridView();
            this.btn_actualizarrol = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_eliminarrol = new System.Windows.Forms.Button();
            this.btn_editarrol = new System.Windows.Forms.Button();
            this.btn_agregarrol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 88;
            this.label1.Text = "Roles";
            // 
            // dgv_roles
            // 
            this.dgv_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_roles.Location = new System.Drawing.Point(12, 176);
            this.dgv_roles.Name = "dgv_roles";
            this.dgv_roles.Size = new System.Drawing.Size(571, 215);
            this.dgv_roles.TabIndex = 91;
            this.dgv_roles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_roles_CellClick);
            // 
            // btn_actualizarrol
            // 
            this.btn_actualizarrol.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizarrol.Location = new System.Drawing.Point(232, 112);
            this.btn_actualizarrol.Name = "btn_actualizarrol";
            this.btn_actualizarrol.Size = new System.Drawing.Size(109, 39);
            this.btn_actualizarrol.TabIndex = 92;
            this.btn_actualizarrol.Text = "Actualizar";
            this.btn_actualizarrol.UseVisualStyleBackColor = true;
            this.btn_actualizarrol.Click += new System.EventHandler(this.btn_actualizarrol_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 93;
            this.label2.Text = "Agregar Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 94;
            this.label3.Text = "Editar Rol";
            // 
            // btn_eliminarrol
            // 
            this.btn_eliminarrol.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarrol.Location = new System.Drawing.Point(232, 63);
            this.btn_eliminarrol.Name = "btn_eliminarrol";
            this.btn_eliminarrol.Size = new System.Drawing.Size(109, 33);
            this.btn_eliminarrol.TabIndex = 95;
            this.btn_eliminarrol.Text = "Eliminar";
            this.btn_eliminarrol.UseVisualStyleBackColor = true;
            this.btn_eliminarrol.Click += new System.EventHandler(this.btn_eliminarrol_Click);
            // 
            // btn_editarrol
            // 
            this.btn_editarrol.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarrol.Image = ((System.Drawing.Image)(resources.GetObject("btn_editarrol.Image")));
            this.btn_editarrol.Location = new System.Drawing.Point(374, 53);
            this.btn_editarrol.Name = "btn_editarrol";
            this.btn_editarrol.Size = new System.Drawing.Size(164, 98);
            this.btn_editarrol.TabIndex = 90;
            this.btn_editarrol.UseVisualStyleBackColor = true;
            this.btn_editarrol.Click += new System.EventHandler(this.btn_editarrol_Click);
            // 
            // btn_agregarrol
            // 
            this.btn_agregarrol.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarrol.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregarrol.Image")));
            this.btn_agregarrol.Location = new System.Drawing.Point(29, 53);
            this.btn_agregarrol.Name = "btn_agregarrol";
            this.btn_agregarrol.Size = new System.Drawing.Size(181, 98);
            this.btn_agregarrol.TabIndex = 89;
            this.btn_agregarrol.UseVisualStyleBackColor = true;
            this.btn_agregarrol.Click += new System.EventHandler(this.btn_agregarrol_Click);
            // 
            // FormRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(595, 419);
            this.Controls.Add(this.btn_eliminarrol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_actualizarrol);
            this.Controls.Add(this.dgv_roles);
            this.Controls.Add(this.btn_editarrol);
            this.Controls.Add(this.btn_agregarrol);
            this.Controls.Add(this.label1);
            this.Name = "FormRoles";
            this.Text = "FormRoles";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_agregarrol;
        private System.Windows.Forms.Button btn_editarrol;
        private System.Windows.Forms.DataGridView dgv_roles;
        private System.Windows.Forms.Button btn_actualizarrol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_eliminarrol;
    }
}