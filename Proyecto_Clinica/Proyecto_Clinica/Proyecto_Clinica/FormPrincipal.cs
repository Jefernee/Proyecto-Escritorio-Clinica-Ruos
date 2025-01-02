using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Clinica
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            Login inicio = new Login();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login inicio = new Login();
            Close();
            
            inicio.Show();
            
        }

        private void btn_frmCliente_Click(object sender, EventArgs e)
        {
            FormPacientes frmpacientes = new FormPacientes();
            frmpacientes.Show();
        }
    }
}
