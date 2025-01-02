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
    public partial class AgregarUsuarios : Form
    {

        List<Rol> listaroles;

        public AgregarUsuarios()
        {
            InitializeComponent();
            listaroles = new List<Rol>();
            cargarRolesEnCombo();
        }

        private void btn_agregarusuario_Click(object sender, EventArgs e)
        {

            Metodos logica = new Metodos();
            FormUsuarios frmhistoria = new FormUsuarios();
            Usuarios usuario = new Usuarios();
            Rol rolseleccionado = (Rol)cb_rol.SelectedItem;
            dc_Generar_resu resultado = new dc_Generar_resu();

            
            try
            {

                usuario.ID_Usuario = Convert.ToInt32(txt_idusuario.Text);
                usuario.Nombre=txt_nombre.Text;
                usuario.CorreoElectronico=txt_correo.Text;
                usuario.Contraseña=txt_contraseña.Text;
                usuario.Rol = rolseleccionado.Nombre;
                //usuario.Rol=txt_rol.Text;
                usuario.Usuario_creacion = DatosUsuario.Usuario;
                usuario.fecha_creacion = DateTime.Now;
                usuario.Usuario_modificador ="";
                usuario.fecha_modificacion = null;

                resultado = logica.GuardarUsuariosLogica(usuario);
                frmhistoria.actualizarGridView();
                if (resultado.Estado)
                {
                    MessageBox.Show(resultado.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(resultado.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                //limpiar()
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //limpiar();
                 // Construir un mensaje con la información completa de la excepción
                 string mensajeExcepcion = "Error: " + ex.GetType().Name + Environment.NewLine +
                                           "Mensaje: " + ex.Message + Environment.NewLine +
                                           "Stack Trace: " + ex.StackTrace;

                 // Si hay una excepción interna, agregar información de la excepción interna
                 if (ex.InnerException != null)
                 {
                     mensajeExcepcion += Environment.NewLine + "Excepción interna: " + Environment.NewLine +
                                         "Tipo: " + ex.InnerException.GetType().Name + Environment.NewLine +
                                         "Mensaje: " + ex.InnerException.Message + Environment.NewLine +
                                         "Stack Trace: " + ex.InnerException.StackTrace;
                 }

                 MessageBox.Show(mensajeExcepcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           

        }

        public void cargarRolesEnCombo()
        {
            Metodos logica = new Metodos();

            listaroles = logica.ObtenerRolesLogica();
            cb_rol.DataSource = listaroles;
            cb_rol.DisplayMember = "Nombre";
            cb_rol.ValueMember = "ID_Rol";

        }
        private void cb_rol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
