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
    public partial class EditarPaciente : Form
    {
        public EditarPaciente()
        {
            InitializeComponent();
        }

        private void rtb_detalles_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                int idkey_usuario = 0;
                idkey_usuario = Int32.Parse(txt_idpaciente.Text);

                Metodos logica = new Metodos();
                Pacientes paciente = new Pacientes();
                dc_Generar_resu resultado = new dc_Generar_resu();

                resultado = logica.buscarPacienteLogica(idkey_usuario);

                if (resultado.Estado)
                {
                    paciente = (Pacientes)resultado.Valor;
                    txt_nombre.Text = paciente.Nombre;
                    dtp_FechaNaci.Value = paciente.FechaNacimiento.Value;
                    txt_direccion.Text = paciente.Dirección;
                    txt_telefono.Text = paciente.Teléfono;
                    paciente.Usuario_creacion= paciente.Usuario_creacion;
                    paciente.fecha_creacion= paciente.fecha_creacion;
                    paciente.fecha_modificacion=DateTime.Now;
                    txt_correo.Text = paciente.CorreoElectronico;
                    rtb_detalles.Text = paciente.OtrasCaracterísticas;

                    MessageBox.Show(resultado.Mensaje);

                    //lbl_mensaje.Text = resultado.Mensaje.ToString();
                }
                else
                {
                    MessageBox.Show(resultado.Mensaje);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void btn_editarmedico_Click(object sender, EventArgs e)
        {
            try
            {
                Metodos logica = new Metodos();
                Pacientes paciente = new Pacientes();
                dc_Generar_resu resultado = new dc_Generar_resu();

                paciente.ID_Paciente = Int32.Parse(txt_idpaciente.Text);
                paciente.Nombre= txt_nombre.Text;
                paciente.FechaNacimiento = DateTime.Parse(dtp_FechaNaci.Text);
                paciente.Dirección= txt_direccion.Text;
                paciente.Teléfono= txt_telefono.Text;
                paciente.Usuario_creacion= paciente.Usuario_creacion;
                paciente.fecha_creacion= paciente.fecha_creacion;
                paciente.Usuario_modificador = DatosUsuario.Usuario;
                paciente.fecha_modificacion = DateTime.Now;
                paciente.CorreoElectronico= txt_correo.Text;
                paciente.OtrasCaracterísticas= rtb_detalles.Text;

                resultado = logica.EditarPacienteLogica(paciente);
                if (resultado.Estado)
                {
                    MessageBox.Show(resultado.Mensaje);
                    //limpiareditar();

                }
                else
                {
                    MessageBox.Show(resultado.Mensaje);
                    //limpiareditar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
