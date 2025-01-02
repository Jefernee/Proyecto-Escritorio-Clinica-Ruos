namespace Proyecto_Clinica
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_log = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_olvidado = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 268);
            this.panel1.TabIndex = 0;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_user.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_user.Location = new System.Drawing.Point(232, 56);
            this.txt_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(293, 24);
            this.txt_user.TabIndex = 1;
            this.txt_user.Text = "USUARIO";
            this.txt_user.TextChanged += new System.EventHandler(this.txt_passw_TextChanged);
            this.txt_user.Enter += new System.EventHandler(this.txt_user_Enter);
            this.txt_user.Leave += new System.EventHandler(this.txt_user_Leave);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_pass.Location = new System.Drawing.Point(232, 104);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(293, 24);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.Text = "CONTRASEÑA";
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);
            this.txt_pass.Leave += new System.EventHandler(this.txt_pass_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(360, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            // 
            // btn_log
            // 
            this.btn_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_log.FlatAppearance.BorderSize = 0;
            this.btn_log.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_log.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_log.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_log.Location = new System.Drawing.Point(232, 212);
            this.btn_log.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(300, 32);
            this.btn_log.TabIndex = 0;
            this.btn_log.Text = "ACCEDER";
            this.btn_log.UseVisualStyleBackColor = false;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_error.Location = new System.Drawing.Point(246, 183);
            this.lbl_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(99, 16);
            this.lbl_error.TabIndex = 7;
            this.lbl_error.Text = "Error message";
            this.lbl_error.Visible = false;
            // 
            // btn_olvidado
            // 
            this.btn_olvidado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_olvidado.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_olvidado.Location = new System.Drawing.Point(232, 145);
            this.btn_olvidado.Name = "btn_olvidado";
            this.btn_olvidado.Size = new System.Drawing.Size(145, 26);
            this.btn_olvidado.TabIndex = 8;
            this.btn_olvidado.Text = "Olvidaste la contraseña";
            this.btn_olvidado.UseVisualStyleBackColor = false;
            this.btn_olvidado.Click += new System.EventHandler(this.btn_olvidado_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(545, 0);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(21, 20);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 6;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(564, 0);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(21, 20);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar.TabIndex = 5;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(38, 77);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(113, 94);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(585, 268);
            this.Controls.Add(this.btn_olvidado);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Button btn_olvidado;
    }
}