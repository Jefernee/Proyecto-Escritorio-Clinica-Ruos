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
    public partial class EditarMedico : Form
    {
        public EditarMedico()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void limpiareditar()
        {
            txt_idmedico.Text="";
            txt_nombre.Text="";
            txt_especialidad.Text="";
            rtb_detalles.Text="";
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                int idkey_usuario = 0;
                idkey_usuario = Int32.Parse(txt_idmedico.Text);

                Metodos logica = new Metodos();
                Medicos medicos = new Medicos();
                dc_Generar_resu resultado = new dc_Generar_resu();

                resultado = logica.buscarMedico(idkey_usuario);

                if (resultado.Estado)
                {
                    medicos = (Medicos)resultado.Valor;
                    txt_nombre.Text = medicos.Nombre;
                    txt_especialidad.Text = medicos.Especialidad;
                    TimeSpan inicio = medicos.HorarioInicio ?? TimeSpan.Zero;
                    TimeSpan salida = medicos.HorarioFin ?? TimeSpan.Zero;
                    dtp_inicio.Value = DateTime.Today.Add(inicio);
                    dtp_salida.Value = DateTime.Today.Add(salida);
                    medicos.Usuario_creacion= medicos.Usuario_creacion;
                    medicos.fecha_creacion= medicos.fecha_creacion;
                    medicos.fecha_modificacion=DateTime.Now;
                    rtb_detalles.Text = medicos.OtrosDetalles;

                    MessageBox.Show(resultado.Mensaje);

                    //lbl_mensaje.Text = resultado.Mensaje.ToString();
                }
                else
                {
                    MessageBox.Show(resultado.Mensaje);


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void btn_editarmedico_Click(object sender, EventArgs e)
        {
            try
            {
                Metodos logica = new Metodos();
                Medicos med = new Medicos();
                dc_Generar_resu resultado = new dc_Generar_resu();

                med.ID_Medico = Int32.Parse(txt_idmedico.Text);
                med.Nombre= txt_nombre.Text;
                med.Especialidad = txt_especialidad.Text;
                med.HorarioInicio = TimeSpan.Parse(dtp_inicio.Text);
                med.HorarioFin = TimeSpan.Parse(dtp_salida.Text);
                med.Usuario_creacion= med.Usuario_creacion;
                med.fecha_creacion= med.fecha_creacion;
                med.Usuario_modificador = DatosUsuario.Usuario;
                med.fecha_modificacion = DateTime.Now;
                med.OtrosDetalles= rtb_detalles.Text;

                resultado = logica.EditarMedico(med);
                if (resultado.Estado)
                {
                    MessageBox.Show(resultado.Mensaje);
                    limpiareditar();

                }
                else
                {
                    MessageBox.Show(resultado.Mensaje);
                    limpiareditar();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            

        }
    }
    
}
