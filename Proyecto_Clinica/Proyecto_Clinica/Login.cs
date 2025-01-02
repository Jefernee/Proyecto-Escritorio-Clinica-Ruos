using ProyeClinica.DataContracts;
using ProyeClinica.Datalogic;
using ProyeClinica.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Clinica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string NombreUsuario { get; set; } // hice esta variable para poder usar el nombre del usuario en el form de cada usuario
                                                  //joan

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txt_passw_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void txt_passw_Leave(object sender, EventArgs e)
        {
            
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "USUARIO")
            {
                txt_user.Text = "";
                txt_user.ForeColor = Color.LightGray;
            }
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                txt_user.Text = "USUARIO";
                txt_user.ForeColor = Color.DimGray;
            }
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "CONTRASEÑA")
            {
                txt_pass.Text = "";
                txt_pass.ForeColor = Color.LightGray;
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.Text = "CONTRASEÑA";
                txt_pass.ForeColor = Color.DimGray;
                txt_pass.UseSystemPasswordChar = false;
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void btn_log_Click(object sender, EventArgs e)
        {
            try
            {



                string nombre = Convert.ToString(txt_user.Text);
                string contraseña = Convert.ToString(txt_pass.Text);
                //List<string> roles = new List<string> { "Administrador", "Jefe", "Secretari@","Medico"}; quitè esta linea para seguir con los roles de la base

                Metodos logica = new Metodos();
                dc_Generar_resu resultado = new dc_Generar_resu();

                resultado = logica.BuscarUsuarioLoginLogica(nombre, contraseña);
                if (resultado.Estado)
                {
                    Usuarios usuarioEncontrado = (Usuarios)resultado.Valor;
                    string rolUsuario = usuarioEncontrado.Rol;
                    DatosUsuario.Usuario = usuarioEncontrado.Nombre;
                    
                    NombreUsuario = nombre;
                    //DatosUsuario.UsuarioModificado = usuarioEncontrado.Usuario_modificador;
                    if (rolUsuario=="Jefe")
                    {
                     
                        MessageBox.Show("Autenticación exitosa. El usuario tiene el rol de " + rolUsuario, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormPrincipal formPrincipal = new FormPrincipal(DatosUsuario.Usuario);
                        formPrincipal.Show();
                    }
                    else if (rolUsuario=="Administrador")
                    {

                        MessageBox.Show("Autenticación exitosa. El usuario tiene el rol de " + rolUsuario, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormPrincipalAdministrador formPrincipal = new FormPrincipalAdministrador(DatosUsuario.Usuario);
                        formPrincipal.Show();
                    }
                    else if (rolUsuario=="Secretari@")
                    {

                        MessageBox.Show("Autenticación exitosa. El usuario tiene el rol de " + rolUsuario, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormPrincipalSecretario formPrincipal = new FormPrincipalSecretario(DatosUsuario.Usuario);
                        formPrincipal.Show();
                    }
                    else if (rolUsuario=="Medico")
                    {

                        MessageBox.Show("Autenticación exitosa. El usuario tiene el rol de " + rolUsuario, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormPrincipalMedicos formPrincipal = new FormPrincipalMedicos(DatosUsuario.Usuario);
                        formPrincipal.Show();
                    }
                    else
                    {

                        MessageBox.Show("Autenticación exitosa, pero el usuario no tiene un rol permitido.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

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

            //FormPrincipal formPrincipal = new FormPrincipal();
            //formPrincipal.Show();







            //if (txt_user.Text != "USUARIO")
            //{
            //    if (txt_pass.Text != "CONTRASEÑA")
            //    {

            //    }
            //    else
            //    {

            //        lbl_error.Visible = true;
            //        lbl_error.Text = "Ingrese su contraseña, por favor";
            //    }


            //}
            //else
            //{
            //    lbl_error.Visible = true;
            //    lbl_error.Text = "Ingrese su usuario, por favor";
            //}


        }

        private void mensajeError(string msg)
        {
            lbl_error.Text = "    " + msg;
            lbl_error.Visible = true;
        }
        
        public void limpiareditar()
        {

        }

        private void btn_olvidado_Click(object sender, EventArgs e)
        {
            ContraseñaOlvidada frm = new ContraseñaOlvidada();
            frm.Show();
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}