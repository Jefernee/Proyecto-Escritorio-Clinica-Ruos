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
        public FormPrincipal(string NombreUsuario)
        {
            InitializeComponent();
            Login inicio = new Login();
            label6.Text = NombreUsuario; // joan
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

        private void btn_frmMedicos_Click(object sender, EventArgs e)
        {
            FormMedicos frmmedicos = new FormMedicos();
            frmmedicos.Show();
        }

        private void btn_frmHistoria_Click(object sender, EventArgs e)
        {
            FormHistoriales_Medicos frmhistoriales = new FormHistoriales_Medicos();
            frmhistoriales.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btn_roles_Click(object sender, EventArgs e)
        {
            FormRoles frmroles = new FormRoles();
            frmroles.Show();
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios frmroles = new FormUsuarios();
            frmroles.Show();
        }

        private void btn_citas_Click(object sender, EventArgs e)
        {
            Form_Citas frmcitas = new Form_Citas();
            frmcitas.Show();    
        }

        private void label6_Click(object sender, EventArgs e)
        {
            

            
             
        }
    }
}
