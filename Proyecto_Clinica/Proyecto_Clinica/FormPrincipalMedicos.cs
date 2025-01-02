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
    public partial class FormPrincipalMedicos : Form
    {
        public FormPrincipalMedicos(string NombreUsuario)
        {
            InitializeComponent();
            label6.Text = NombreUsuario;
            
        }

        private void btn_frmHistoria_Click(object sender, EventArgs e)
        {
            FormHistoriales_Medicos frm = new FormHistoriales_Medicos();
            frm.Show();
        }

        private void btn_frmCliente_Click(object sender, EventArgs e)
        {
            FormPacientes frm = new FormPacientes();
            frm.Show();
        }

        private void FormPrincipalMedicos_Load(object sender, EventArgs e)
        {

        }
    }
}
