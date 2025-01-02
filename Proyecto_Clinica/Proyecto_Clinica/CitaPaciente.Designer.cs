namespace Proyecto_Clinica
{
    partial class CitaPaciente
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
            this.dgv_citasdePacientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_citasdePacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_citasdePacientes
            // 
            this.dgv_citasdePacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_citasdePacientes.Location = new System.Drawing.Point(117, 146);
            this.dgv_citasdePacientes.Name = "dgv_citasdePacientes";
            this.dgv_citasdePacientes.RowHeadersWidth = 51;
            this.dgv_citasdePacientes.RowTemplate.Height = 24;
            this.dgv_citasdePacientes.Size = new System.Drawing.Size(240, 150);
            this.dgv_citasdePacientes.TabIndex = 0;
            // 
            // CitaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_citasdePacientes);
            this.Name = "CitaPaciente";
            this.Text = "CitaPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_citasdePacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_citasdePacientes;
    }
}