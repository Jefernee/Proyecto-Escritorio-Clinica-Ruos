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
using ProyeClinica.DataModel;
using ProyeClinica.Datalogic;

namespace Proyecto_Clinica
{
    public partial class AgregarPaciente : Form
    {
        public AgregarPaciente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FormPacientes frmpacientes = new FormPacientes();
            
            Metodos logica = new Metodos();
            Pacientes paciente = new Pacientes();
            dc_Generar_resu resultado = new dc_Generar_resu();

            try
            {
                paciente.ID_Paciente = Int32.Parse(txt_idPaciente.Text);
                paciente.Nombre = txt_nombrePaci.Text;
                paciente.FechaNacimiento = DateTime.Parse(dtp_FechaNaci.Text);
                paciente.Dirección = txt_direccion.Text;
                paciente.Teléfono = txt_telefono.Text;
                paciente.Usuario_creacion = DatosUsuario.Usuario;
                //paciente.Usuario_creacion = "Joan";
                paciente.fecha_creacion = DateTime.Now;
                //paciente.Usuario_modificador = "Joan";
                paciente.fecha_modificacion = null;
                paciente.CorreoElectronico = txt_correo.Text;
                paciente.OtrasCaracterísticas = rtb_caracteristicas.Text;

                resultado = logica.AgregarPaciente(paciente);


                if (resultado.Estado)
                {
                    MessageBox.Show(resultado.Mensaje);
                    //limpiareditar();
                    frmpacientes.actualizarGridView();

                }
                else
                {
                    MessageBox.Show(resultado.Mensaje);
                    //limpiareditar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
                // frmpacientes.actulizarDGV();
        

        }
    }
}
