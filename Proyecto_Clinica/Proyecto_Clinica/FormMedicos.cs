
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
    public partial class FormMedicos : Form
    {
        List<Medicos> listadeMedicos;
        public FormMedicos()
        {
            InitializeComponent();
            listadeMedicos = new List<Medicos>();
            actualizarGridView();
        }
        public void actualizarGridView()
        {
            Metodos logica = new Metodos();
            listadeMedicos=logica.ObtenerMedicosLogica();
            dgv_medicos.DataSource = null;
            dgv_medicos.DataSource = listadeMedicos;
            dgv_medicos.Columns[10].Visible = false;
        }

        public void btn_medicos_Click(object sender, EventArgs e)
        {
            AgregarMedicos frmnuevomedico = new AgregarMedicos();
            frmnuevomedico.Show();
        }

        private void Actualizar_medicos_Click(object sender, EventArgs e)
        {
            actualizarGridView();
        }
        public void actulizarDGV()
        {
            dgv_medicos.DataSource = null;
            dgv_medicos.DataSource = listadeMedicos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditarMedico frmnuevomedico = new EditarMedico();
            frmnuevomedico.Show();
        }

        private void FormMedicos_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgv_medicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0 && e.ColumnIndex == dgv_medicos.Columns["ID_Medico"].Index)
            {
                int idMedico = Convert.ToInt32(dgv_medicos.Rows[e.RowIndex].Cells["ID_Medico"].Value);
                Metodos logica = new Metodos();
                dc_Generar_resu resultado = logica.BorrarMedicoLogica(idMedico);

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

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (dgv_medicos.SelectedCells.Count > 0)
            {
                int rowIndex = dgv_medicos.SelectedCells[0].RowIndex;
                int idMedico = Convert.ToInt32(dgv_medicos.Rows[rowIndex].Cells["ID_Medico"].Value);

                Metodos logica = new Metodos();
                dc_Generar_resu resultado = logica.BorrarMedicoLogica(idMedico);

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





            /*if (dgv_medicos.SelectedRows.Count > 0)
            {
                // Obtener el ID del médico seleccionado (suponiendo que la columna del ID se llama "ID_Medico")
                int idMedico = Convert.ToInt32(dgv_medicos.SelectedRows[0].Cells["ID_Medico"].Value);

                Metodos logica = new Metodos();
                dc_Generar_resu resultado = logica.BorrarMedicoLogica(idMedico);

                // Verificar el resultado de la eliminación
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
                MessageBox.Show("Por favor, seleccione un médico para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
