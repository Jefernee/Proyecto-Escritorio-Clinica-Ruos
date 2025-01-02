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
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void btn_buscarusuario_Click(object sender, EventArgs e)
        {
            try
            {
                int idkey_usuario = 0;
                idkey_usuario = Int32.Parse(txt_idusuario.Text);

                Metodos logica = new Metodos();
                 // no le cambio la palabra paciente por que da pereza pero es lo mismo
                Usuarios paciente = new Usuarios();
                dc_Generar_resu resultado = new dc_Generar_resu();

                resultado = logica.buscarUsuarioLogica(idkey_usuario);

                if (resultado.Estado)
                {
                    paciente = (Usuarios)resultado.Valor;
                    txt_nombre.Text = paciente.Nombre;
                    txt_correo.Text = paciente.CorreoElectronico;
                    txt_contraseña.Text = paciente.Contraseña;
                    cb_rol.Text=paciente.Rol;
                    paciente.Usuario_creacion= paciente.Usuario_creacion;
                    paciente.fecha_creacion= paciente.fecha_creacion;
                    paciente.fecha_modificacion=DateTime.Now;
                    

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

        private void btn_editarusuario_Click(object sender, EventArgs e)
        {
            try
            {
                Metodos logica = new Metodos();
                Usuarios usuario = new Usuarios();
                dc_Generar_resu resultado = new dc_Generar_resu();

                usuario.ID_Usuario = Convert.ToInt32(txt_idusuario.Text);
                usuario.Nombre=txt_nombre.Text;
                usuario.CorreoElectronico=txt_correo.Text;
                usuario.Contraseña=txt_contraseña.Text;
                usuario.Rol = cb_rol.SelectedItem.ToString();
                //usuario.Rol=txt_rol.Text;
                usuario.Usuario_creacion =null;
                usuario.fecha_creacion = null;
                usuario.Usuario_modificador = DatosUsuario.Usuario;
                usuario.fecha_modificacion = DateTime.Now;

                resultado = logica.EditarUsuarioLogica(usuario);
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
