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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

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

        private void btn_log_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();

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
    }
}