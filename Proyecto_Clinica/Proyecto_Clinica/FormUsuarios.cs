using ProyeClinica.DataContracts;
using ProyeClinica.Datalogic;
using ProyeClinica.DataModel;
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
    public partial class FormUsuarios : Form
    {
        List<Usuarios> listadeUsuarios;
        public FormUsuarios()
        {
            InitializeComponent();
            listadeUsuarios= new List<Usuarios>();
            actualizarGridView();
        }
        public void actualizarGridView()
        {
            Metodos logica = new Metodos();
            listadeUsuarios=logica.ObtenerUsuariosLogica();
            dgv_usuarios.DataSource = null;
            dgv_usuarios.DataSource = listadeUsuarios;
            dgv_usuarios.Columns[1].Visible = false;
            dgv_usuarios.Columns[10].Visible = false;
        }
        public void actulizarDGV()
        {
            dgv_usuarios.DataSource = null;
            dgv_usuarios.DataSource = listadeUsuarios;
        }


        private void Actualizar_usuarios_Click(object sender, EventArgs e)
        {
            actualizarGridView();
        }

        private void btn_agregarusuario_Click(object sender, EventArgs e)
        {
            AgregarUsuarios frmusuario = new AgregarUsuarios();
            frmusuario.Show();
        }

        private void btn_editarusuario_Click(object sender, EventArgs e)
        {

            EditarUsuario frmusuario = new EditarUsuario();
            frmusuario.Show();
        }

        private void dgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_borrarusuario_Click(object sender, EventArgs e)
        {
            if (dgv_usuarios.SelectedCells.Count > 0)
            {
                int rowIndex = dgv_usuarios.SelectedCells[0].RowIndex;
                int idrol = Convert.ToInt32(dgv_usuarios.Rows[rowIndex].Cells["ID_Usuario"].Value);

                Metodos logica = new Metodos();
                dc_Generar_resu resultado = logica.BorrarUsuarioLogica(idrol);

                if (resultado.Estado)
                {
                    actualizarGridView();
                    MessageBox.Show(resultado.Mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(resultado.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una celda que contenga el ID del médico antes de hacer clic en Eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
