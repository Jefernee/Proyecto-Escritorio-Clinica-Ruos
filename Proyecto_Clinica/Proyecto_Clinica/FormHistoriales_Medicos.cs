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
    public partial class FormHistoriales_Medicos : Form
    {
        List<HistorialesClinicos> listadeHistoriales;
        public FormHistoriales_Medicos()
        {
            InitializeComponent();
            listadeHistoriales = new List<HistorialesClinicos>();
            actualizarGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizarGridView();
        }
        public void actualizarGridView()
        {
            Metodos logica = new Metodos();
            listadeHistoriales=logica.ObtenerHistorialesLogica();
            dgv_historialesmedicos.DataSource = null;
            dgv_historialesmedicos.DataSource = listadeHistoriales;
            dgv_historialesmedicos.Columns[9].Visible = false;
        }
        private void Actualizar_medicos_Click(object sender, EventArgs e)
        {
            actualizarGridView();
        }
        public void Actualizar_historia()
        {
            dgv_historialesmedicos.DataSource = null;
            dgv_historialesmedicos.Columns[9].Visible = false;
            dgv_historialesmedicos.DataSource = listadeHistoriales;
        }

        private void btn_agregarhistorialpaciente_Click(object sender, EventArgs e)
        {
            AgregarHistorialdePaciente frmhistorial = new AgregarHistorialdePaciente();
                frmhistorial.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EditarHistorialdePacientes frmhistorial = new EditarHistorialdePacientes();
            frmhistorial.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_historialesmedicos.SelectedCells.Count > 0)
            {
                int rowIndex = dgv_historialesmedicos.SelectedCells[0].RowIndex;
                int idhistorial = Convert.ToInt32(dgv_historialesmedicos.Rows[rowIndex].Cells["ID_Historial"].Value);

                Metodos logica = new Metodos();
                dc_Generar_resu resultado = logica.BorrarHistorialLogica(idhistorial);

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
            }
            else
            {
                MessageBox.Show("Seleccione una celda que contenga el ID del Historial antes de hacer clic en Eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_historialesmedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
