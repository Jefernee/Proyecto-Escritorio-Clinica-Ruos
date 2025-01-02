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
    public partial class EditarRol : Form
    {
        public EditarRol()
        {
            InitializeComponent();
        }

        private void btn_buscarrol_Click(object sender, EventArgs e)
        {
            try
            {
                int idkey_usuario = 0;
                idkey_usuario = Int32.Parse(txt_idrol.Text);

                Metodos logica = new Metodos();
                Rol roles = new Rol();
                dc_Generar_resu resultado = new dc_Generar_resu();

                resultado = logica.BuscarRolLogica(idkey_usuario);

                if (resultado.Estado)
                {
                    roles = (Rol)resultado.Valor;
                    txt_nombrerol.Text = roles.Nombre;
                    roles.Usuario_creacion= roles.Usuario_creacion;
                    roles.fecha_creacion= roles.fecha_creacion;
                    roles.fecha_modificacion=DateTime.Now;

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

        private void btn_editarrol_Click(object sender, EventArgs e)
        {
            try
            {
                Metodos logica = new Metodos();
                Rol med = new Rol();
                dc_Generar_resu resultado = new dc_Generar_resu();

                med.ID_Rol = Int32.Parse(txt_idrol.Text);
                med.Nombre= txt_nombrerol.Text;
                med.Usuario_creacion= med.Usuario_creacion;
                med.fecha_creacion= med.fecha_creacion;
                med.Usuario_modificador = DatosUsuario.Usuario;
                med.fecha_modificacion = DateTime.Now;

                resultado = logica.EditarRolLogica(med);
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
