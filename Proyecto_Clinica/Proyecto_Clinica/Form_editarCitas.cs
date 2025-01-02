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
    public partial class Form_editarCitas : Form
    {
        public Form_editarCitas(int idcita, int idpaciente, int idmedico, DateTime fecha, TimeSpan hora, string estado)
        {
            InitializeComponent();

            txt_idCita.Text = idcita.ToString();
            txt_idPaciente.Text = idpaciente.ToString();
            txt_idMedico.Text = idmedico.ToString();
            dtp_fecha.Text = fecha.ToShortDateString();
            dtp_hora.Text = hora.ToString();
            //txt_estado.Text = estado;
        }

        public string estadoSeleccionado;




        private void Form_editarCitas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_editarcita_Click(object sender, EventArgs e)
        {
            try
            {
                Metodos logica = new Metodos();
                dc_Generar_resu resultado = new dc_Generar_resu();
                Citas cita   = new Citas();

                cita.ID_Cita = Int32.Parse(txt_idCita.Text);
                cita.ID_Paciente = Int32.Parse(txt_idPaciente.Text);
                cita.ID_Medico = Int32.Parse(txt_idMedico.Text);
                cita.Fecha = DateTime.Parse(dtp_fecha.Text);
                cita.Hora = TimeSpan.Parse(dtp_hora.Text);
                cita.Estado = estadoSeleccionado;

                

                resultado = logica.EditarCitaLogica(cita);



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
            catch(Exception ex)
            {
                MessageBox.Show("Error al editar cita, intentelo de nuevo", "Error", MessageBoxButtons.OK);

            }
        }

        private void cbo_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            estadoSeleccionado= cbo_estado.SelectedItem.ToString();

        }
    }
}
