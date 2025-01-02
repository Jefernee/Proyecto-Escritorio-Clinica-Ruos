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
    public partial class AgregarHistorialdePaciente : Form
    {
        List<Pacientes> listapacintes;
        public AgregarHistorialdePaciente()
        {
            InitializeComponent();
            listapacintes = new List<Pacientes>();
            actualizarGridView();
        }

        private void AgregarHistorialdePaciente_Load(object sender, EventArgs e)
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
        private void btn_asignarhistorial_Click(object sender, EventArgs e)
        {

            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView
                if (dgv_pacientes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione un paciente en la lista.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int rowIndex = dgv_pacientes.SelectedCells[0].RowIndex;
                int idPacienteSeleccionado = Convert.ToInt32(dgv_pacientes.Rows[rowIndex].Cells["ID_Paciente"].Value);
                
                HistorialesClinicos historial = new HistorialesClinicos();
                historial.ID_paciente = idPacienteSeleccionado;

                
                historial.Diagnostico=txt_diagnostico.Text;
                historial.Tratamiento=txt_tratamiento.Text;
                historial.Alergias=txt_alergias.Text;
                historial.Medicamentos=txt_medicamentos.Text;
                historial.ResultadosPruebas=txt_resupruebas.Text;
                historial.NotasSeguimiento=txt_nota.Text;
                historial.OtrosDetalles = rtb_detalles2.Text;

                Metodos logica = new Metodos();
                dc_Generar_resu resultado = logica.GuardarHistorialMedicoLogica(historial);

                if (resultado.Estado)
                {
                    MessageBox.Show(resultado.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarGridView();
                }
                else
                {
                    MessageBox.Show(resultado.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

    

        private void txt_nota_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizarGridView();
        }
    }
}
