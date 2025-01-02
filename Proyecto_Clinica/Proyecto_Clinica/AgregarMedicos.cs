using ProyeClinica.DataContracts;
using ProyeClinica.Datalogic;
using ProyeClinica.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Clinica
{
    public partial class AgregarMedicos : Form
    {
        List<Medicos> listadeMedicos;
        public AgregarMedicos()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            txt_idMedico.Text="";
            txt_nombremedico.Text="";
            txt_especialidad.Text="";
            rtb_detallesmedico.Text="";
        }
       
        public void button1_Click(object sender, EventArgs e)
        {
            
            
            dc_Generar_resu resu = new dc_Generar_resu();
            FormMedicos frmmedicos = new FormMedicos();
            
            Metodos logica = new Metodos();
            Medicos med = new Medicos();
            dc_Generar_resu resultado = new dc_Generar_resu();
            try
            {
                med.ID_Medico = Int32.Parse(txt_idMedico.Text);
                med.Nombre = txt_nombremedico.Text;
                med.Especialidad = txt_especialidad.Text;
                med.HorarioInicio = TimeSpan.Parse(dtp_inicio.Text);
                med.HorarioFin = TimeSpan.Parse(dtp_salida.Text);
                med.Usuario_creacion = DatosUsuario.Usuario;
                //med.Usuario_creacion =txt_usuario.Text;
                med.fecha_creacion = DateTime.Now;
                med.Usuario_modificador ="";
                med.fecha_modificacion = null;
                med.OtrosDetalles = rtb_detallesmedico.Text;

               
                
                
                resultado = logica.AgregarMedico(med);

                frmmedicos.actualizarGridView();
                MessageBox.Show(resultado.Mensaje);
                limpiar();

            }
            
             catch (FormatException ex)
            {
       
                 MessageBox.Show($"Error al convertir la hora: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
            }
            
            
        }
    }
}
