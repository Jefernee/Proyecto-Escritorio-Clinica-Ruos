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
    public partial class EditarHistorialdePacientes : Form
    {
        public EditarHistorialdePacientes()
        {
            InitializeComponent();
        }

        private void btn_asignarhistorial_Click(object sender, EventArgs e)
        {
            try
            {
                int idkey_usuario = Int32.Parse(txt_idhistorial.Text);
                int idkey_usuario1 = Int32.Parse(txt_idpaciente2.Text);

                Metodos logica = new Metodos();
                dc_Generar_resu resultado = new dc_Generar_resu();

                resultado = logica.buscarHistorialLogica(idkey_usuario, idkey_usuario1);

                if (resultado.Estado)
                {
                    HistorialesClinicos histo = (HistorialesClinicos)resultado.Valor;
                    txt_diagnostico.Text = histo.Diagnostico;
                    txt_tratamiento.Text = histo.Tratamiento;
                    txt_alergias.Text = histo.Alergias;
                    txt_medicamentos.Text = histo.Medicamentos;
                    txt_resupruebas.Text = histo.ResultadosPruebas;
                    txt_nota.Text = histo.NotasSeguimiento;
                    rtb_detalles2.Text = histo.OtrosDetalles;

                    MessageBox.Show(resultado.Mensaje);
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

        private void btn_editarhistorial_Click(object sender, EventArgs e)
        {
            try
            {
                Metodos logica = new Metodos();
                HistorialesClinicos historia = new HistorialesClinicos();
                dc_Generar_resu resultado = new dc_Generar_resu();

                historia.ID_Historial = Int32.Parse(txt_idhistorial.Text);
                historia.ID_paciente = Int32.Parse(txt_idpaciente2.Text);
                historia.Diagnostico = txt_diagnostico.Text;
                historia.Tratamiento = txt_tratamiento.Text;
                historia.Alergias = txt_alergias.Text;
                historia.Medicamentos = txt_medicamentos.Text;
                historia.ResultadosPruebas = txt_resupruebas.Text;
                historia.NotasSeguimiento = txt_nota.Text;
                historia.OtrosDetalles= rtb_detalles2.Text;

                resultado = logica.EditarHistorialLogica(historia);
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
