using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyeClinica.DataContracts;
using ProyeClinica.Datalogic;
using ProyeClinica.DataModel;

namespace Proyecto_Clinica
{
    public partial class FormPacientes : Form
    {
       List<Pacientes> listapacintes;
        public FormPacientes()
        {
            InitializeComponent();
            listapacintes = new List<Pacientes>();
            actualizarGridView();
            //listapacintes = new Lisr<Pacientes>;
            //CargarGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void actualizarGridView()
        {
            Metodos logica = new Metodos();
            listapacintes = logica.ObtenerPacientesLogica();
            dgv_pacientes.DataSource = null;
            dgv_pacientes.DataSource = listapacintes;
            dgv_pacientes.Columns[11].Visible = false;
            dgv_pacientes.Columns[12].Visible = false;
        }

        public void actulizarDGV()
        {
            dgv_pacientes.DataSource = null;
            dgv_pacientes.DataSource = listapacintes;
        }


        private void FormPacientes_Load(object sender, EventArgs e)
        {
            

        }


        
        object valorcelda = null;

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void btn_VerCitas_Click(object sender, EventArgs e)
        {

           if (valorcelda != null)
            {
                MessageBox.Show("El id de la celda es" + valorcelda.ToString());
                dgv_pacientes.ClearSelection();
                valorcelda= null;
            }
            else
            {
                MessageBox.Show("Niniguna celda ha sido seleccionada");
            }
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarPaciente frmNuevoPaciente = new AgregarPaciente();
            frmNuevoPaciente.Show();
        }

        private void btn_actualizarLista_Click(object sender, EventArgs e)
        {
            actualizarGridView();
        }

        private void btn_VerHistorial_Click(object sender, EventArgs e)
        {
            FormHistoriales_Medicos frmNuevohistorial = new FormHistoriales_Medicos();
            frmNuevohistorial.Show();
        }

        private void btn_editarpaciente_Click(object sender, EventArgs e)
        {
            EditarPaciente frmeditarpaciente = new EditarPaciente();
            frmeditarpaciente.Show();
        }

        private void btn_borrarpaciente_Click(object sender, EventArgs e)
        {
            if (dgv_pacientes.SelectedCells.Count > 0)
            {
                int rowIndex = dgv_pacientes.SelectedCells[0].RowIndex;
                int idpaciente = Convert.ToInt32(dgv_pacientes.Rows[rowIndex].Cells["ID_Paciente"].Value);

                Metodos logica = new Metodos();
                dc_Generar_resu resultado = logica.BorrarPacienteLogica(idpaciente);

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
                MessageBox.Show("Seleccione una celda que contenga el ID del paciente antes de hacer clic en Eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_pacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0 && e.ColumnIndex == dgv_pacientes.Columns["ID_Paciente"].Index)
            {
                int idpaciente = Convert.ToInt32(dgv_pacientes.Rows[e.RowIndex].Cells["ID_Paciente"].Value);
                Metodos logica = new Metodos();
                dc_Generar_resu resultado = logica.BorrarPacienteLogica(idpaciente);

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
