using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyeClinica.DataModel;
using ProyeClinica.Datalogic;
using ProyeClinica.DataContracts;



namespace Proyecto_Clinica
{
    public partial class Form_Citas : Form
    {

        List<Citas> citas;
        //private DataTable citas;
        public Form_Citas()
        {
            InitializeComponent();
            citas = new List<Citas>();
            CargarGrid();
        }

        public void CargarGrid()
        {
            try {
                Metodos logica = new Metodos();
                citas = logica.ObtenerCitaslogica();
                dgv_Citas.DataSource = null;
                dgv_Citas.DataSource = citas;

                dgv_Citas.Columns[6].Visible = false;
                dgv_Citas.Columns[7].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void Form_Citas_Load(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btn_agregar_cita_Click(object sender, EventArgs e)
        {
            Form_Nueva_Cita frmnuevaci = new Form_Nueva_Cita();
            frmnuevaci.Show();
        }

        private void btn_editar_cita_Click(object sender, EventArgs e)
        {
            if (dgv_Citas.SelectedRows.Count > 0)
            {
                //int indiceFila = dgv_Citas.SelectedRows[0];

                DataGridViewRow fila = dgv_Citas.SelectedRows[0];


                int idCita = Convert.ToInt32(fila.Cells[0].Value);
                int idPaciente = Convert.ToInt32(fila.Cells[1].Value);
                int idMedico = Convert.ToInt32(fila.Cells[2].Value);
                DateTime fecha = Convert.ToDateTime(fila.Cells[3].Value);
                TimeSpan hora = TimeSpan.Parse(fila.Cells[4].Value.ToString());
                string estado = fila.Cells[5].Value.ToString();

                Form_editarCitas frmeditarcitas = new Form_editarCitas(idCita, idPaciente, idMedico, fecha, hora, estado); // es para enviar la informacion recordar - joan
                frmeditarcitas.Show();


            }
            else
            {
                MessageBox.Show("Debes seleccionar algun paciente", "Alerta", MessageBoxButtons.OK);
            }
        }

        private void btn_eliminarcita_Click(object sender, EventArgs e)
        {
            if (dgv_Citas.SelectedCells.Count > 0)
            {
                int rowIndex = dgv_Citas.SelectedCells[0].RowIndex;
                int idcita = Convert.ToInt32(dgv_Citas.Rows[rowIndex].Cells["ID_Cita"].Value);

                Metodos logica = new Metodos();
                dc_Generar_resu resultado = logica.BorrarcitaLogica(idcita);

                if (resultado.Estado)
                {
                    CargarGrid();
                    MessageBox.Show(resultado.Mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(resultado.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una celda que contenga el ID de la cita antes de hacer clic en Eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string filtroId = txt_filtrar.Text;

            // Verificar que el TextBox de filtro no esté vacío
            if (!string.IsNullOrEmpty(filtroId))
            {
                // Filtrar la lista de citas por el ID de cita
                int idpaciente;
                if (int.TryParse(filtroId, out idpaciente))
                {
                    List<Citas> citasFiltradas = citas.Where(c => c.ID_Paciente == idpaciente).ToList();

                    // Actualizar el DataGridView con las citas filtradas
                    dgv_Citas.DataSource = null;
                    dgv_Citas.DataSource = citasFiltradas;
                }
            }
            else
            {
                // Si el TextBox de filtro está vacío, mostrar todas las citas
                dgv_Citas.DataSource = null;
                dgv_Citas.DataSource = citas;
            }
        }

        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
