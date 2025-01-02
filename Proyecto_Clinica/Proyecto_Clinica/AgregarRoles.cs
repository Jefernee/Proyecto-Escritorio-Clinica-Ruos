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
    public partial class AgregarRoles : Form
    {
        public AgregarRoles()
        {
            InitializeComponent();
        }

        private void btn_agregarrol_Click(object sender, EventArgs e)
        {
            dc_Generar_resu resu = new dc_Generar_resu();
            FormRoles frmmedicos = new FormRoles();

            Metodos logica = new Metodos();
            Rol med = new Rol();
            dc_Generar_resu resultado = new dc_Generar_resu();
            try
            {
                //med.ID_Rol = Int32.Parse(txt_idrol.Text);
                med.Nombre = txt_nombrerol.Text;
                med.Usuario_creacion = DatosUsuario.Usuario;
                //med.Usuario_creacion =txt_usuariocreacion.Text;
                med.fecha_creacion = DateTime.Now;
                med.Usuario_modificador ="";
                med.fecha_modificacion = null;
               




                resultado = logica.AgregarRolLogica(med);

                frmmedicos.actualizarGridView();
                MessageBox.Show(resultado.Mensaje);
                //limpiar();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //limpiar();
            }


        }
    
    }
}
