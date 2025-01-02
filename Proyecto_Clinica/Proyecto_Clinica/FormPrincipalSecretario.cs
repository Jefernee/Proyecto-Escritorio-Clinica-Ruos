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
    public partial class FormPrincipalSecretario : Form
    {
        public FormPrincipalSecretario(string NombreUsuario)
        {
            InitializeComponent();
            label6.Text = NombreUsuario;
        }

        private void btn_frmCliente_Click(object sender, EventArgs e)
        {
            FormPacientes frm = new FormPacientes();
                frm.Show();
        }

        private void btn_citas_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipalSecretario_Load(object sender, EventArgs e)
        {

        }
    }
}
