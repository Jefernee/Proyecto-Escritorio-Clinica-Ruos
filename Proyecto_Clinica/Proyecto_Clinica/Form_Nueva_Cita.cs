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
    public partial class Form_Nueva_Cita : Form
    {

        List<Medicos> listamedicos;
        public Form_Nueva_Cita()
        {
            
            InitializeComponent();
            listamedicos = new List<Medicos>();
            cargarDocEnCombo();
        }

        public string estadoSeleccionado;

        private void Form_Nueva_Cita_Load(object sender, EventArgs e)
        {

        }

        public void cargarDocEnCombo()
        {
            Metodos logica = new Metodos();

            listamedicos = logica.ObtenerMedicosLogica();
            cbo_medico.DataSource = listamedicos;
            cbo_medico.DisplayMember = "Nombre";
            cbo_medico.ValueMember = "ID_Medico";

        }

        public void Guardarcita()
        {
            dc_Generar_resu resultado = new dc_Generar_resu();
            Metodos logica = new Metodos();
            Citas cita = new Citas();


            try
            {
                if (cbo_medico.SelectedItem != null)
                {
                    Medicos medicoselecc = (Medicos)cbo_medico.SelectedItem;
                    cita.ID_Medico = medicoselecc.ID_Medico;
                    cita.ID_Paciente = Int32.Parse(txt_id_paciente.Text);
                    cita.Fecha = DateTime.Parse(dtp_fecha.Text);
                    cita.Hora = TimeSpan.Parse(dtp_hora.Text);
                    cita.Estado = estadoSeleccionado;


                    if (logica.ExisteCita(cita))
                    {
                        MessageBox.Show("Ya existe una cita para este médico a esta hora y fecha.");
                        return;
                    }

                    resultado = logica.GuardarCitaLogica(cita);

                    if (resultado.Estado)
                    {
                        MessageBox.Show(resultado.Mensaje);
                        this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show(resultado.Mensaje);
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona un médico antes de guardar la cita.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al convertir el ID del paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_agregarcita_Click(object sender, EventArgs e)
        {
            Guardarcita();
        }

        private void cbo_medico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            estadoSeleccionado = cbo_estado.SelectedItem.ToString();
        }
    }
}
