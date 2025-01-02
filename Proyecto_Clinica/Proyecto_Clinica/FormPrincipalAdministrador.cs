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
    public partial class FormPrincipalAdministrador : Form
    {
        public FormPrincipalAdministrador(string NombreUsuario)
        {
            InitializeComponent();
            label6.Text = NombreUsuario;
        }

        private void btn_frmMedicos_Click_1(object sender, EventArgs e)
        {
            FormMedicos frm = new FormMedicos();
            frm.Show();
        }

        private void btn_usuarios_Click_1(object sender, EventArgs e)
        {
            FormUsuarios frm = new FormUsuarios();
            frm.Show();
        }

        private void btn_roles_Click_1(object sender, EventArgs e)
        {
            FormRoles frm = new FormRoles();
            frm.Show();
        }

        private void FormPrincipalAdministrador_Load(object sender, EventArgs e)
        {

        }
    }
}
