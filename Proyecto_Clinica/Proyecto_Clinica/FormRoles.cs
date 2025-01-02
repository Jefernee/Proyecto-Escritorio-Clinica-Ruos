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
    public partial class FormRoles : Form
    {
        List<Rol> listadeRoles;
        public FormRoles()
        {
            InitializeComponent();
            listadeRoles= new List<Rol>();
            actualizarGridView();
        }
        public void actualizarGridView()
        {
            Metodos logica = new Metodos();
            listadeRoles=logica.ObtenerRolesLogica();
            dgv_roles.DataSource = null;
            dgv_roles.DataSource = listadeRoles;
            dgv_roles.Columns[6].Visible = false;
        }
        public void actualizarDGV()
        {
            dgv_roles.DataSource = null;
            dgv_roles.DataSource = listadeRoles;
            dgv_roles.Columns[6].Visible = false;
        }

        private void btn_actualizarrol_Click(object sender, EventArgs e)
        {
            actualizarGridView();
        }

        private void btn_agregarrol_Click(object sender, EventArgs e)
        {
            AgregarRoles roles = new AgregarRoles();
                roles.Show();
        }

        private void btn_editarrol_Click(object sender, EventArgs e)
        {
            EditarRol roles = new EditarRol();
            roles.Show();
        }

        private void btn_eliminarrol_Click(object sender, EventArgs e)
        {
            if (dgv_roles.SelectedCells.Count > 0)
            {
                int rowIndex = dgv_roles.SelectedCells[0].RowIndex;
                int idrol = Convert.ToInt32(dgv_roles.Rows[rowIndex].Cells["ID_Rol"].Value);

                Metodos logica = new Metodos();
                dc_Generar_resu resultado = logica.BorrarRolLogica(idrol);

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

        private void dgv_roles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0 && e.ColumnIndex == dgv_roles.Columns["ID_Rol"].Index)
            {
                int idrol = Convert.ToInt32(dgv_roles.Rows[e.RowIndex].Cells["ID_Rol"].Value);
                Metodos logica = new Metodos();
                dc_Generar_resu resultado = logica.BorrarRolLogica(idrol);

                if (resultado.Estado)
                {
                    // Actualizar el DataGridView después de borrar el médico
                    actualizarGridView();
                    MessageBox.Show(resultado.Mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(resultado.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
        }
    }
}
