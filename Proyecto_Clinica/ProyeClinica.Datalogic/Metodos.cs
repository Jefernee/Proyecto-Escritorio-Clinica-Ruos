using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyeClinica.DataModel;
using ProyeClinica.DataContracts;
using System.Runtime.InteropServices;

namespace ProyeClinica.Datalogic
{
    public class Metodos
    {
        
        public List<Pacientes> ObtenerPacientesLogica()
        {
            MetodosModelo modelo = new MetodosModelo(); 

            return modelo.ObtenerPacientes();
        }

      
         public dc_Generar_resu AgregarPaciente (Pacientes paciente)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();
            MetodosModelo contexto = new MetodosModelo();
            resultado = contexto.GuardarPaciente(paciente);

            return resultado;
        }

        public List<Medicos> ObtenerMedicosLogica()
        {
            MetodosModelo modelo = new MetodosModelo();

            return modelo.ObtenerMedicos();
        }

        public dc_Generar_resu AgregarMedico(Medicos medico)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();
            MetodosModelo metodos= new MetodosModelo();
             resultado = metodos.GuardarMedico(medico);

            return resultado;
        }
        public dc_Generar_resu buscarMedico(int idkey_usuario)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();
            MetodosModelo contexto = new MetodosModelo();
            resultado = contexto.BuscarMedicos(idkey_usuario);
            return resultado;

        }
        public dc_Generar_resu EditarMedico(Medicos med)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();
            MetodosModelo contexto = new MetodosModelo();
            resultado = contexto.EditarMedicos(med);
            return resultado;

        }
        public dc_Generar_resu BorrarMedicoLogica(int idMedico)
        {
            MetodosModelo contexto = new MetodosModelo();
            return contexto.BorrarMedico(idMedico);
        }
        public List<HistorialesClinicos> ObtenerHistorialesLogica()
        {
            MetodosModelo context= new MetodosModelo();

            return context.ObtenerHistorialesClinicos();
        }
        public dc_Generar_resu GuardarHistorialMedicoLogica(HistorialesClinicos historia)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();
            MetodosModelo contexto = new MetodosModelo();
            resultado = contexto.GuardarHistorialMedico(historia);

            return resultado;
        }
        public dc_Generar_resu buscarHistorialLogica(int idkey_usuario, int idkey_usuario1)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();
            MetodosModelo contexto = new MetodosModelo();
            resultado = contexto.BuscarHistorialModelo(idkey_usuario,idkey_usuario1);
            return resultado;

        }
        public dc_Generar_resu EditarHistorialLogica(HistorialesClinicos historialMedico)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();
            MetodosModelo contexto = new MetodosModelo();
            resultado = contexto.EditarHistorialdepaciente(historialMedico);
            return resultado;

        }
        public dc_Generar_resu BorrarHistorialLogica(int idhistoria)
        {
            MetodosModelo contexto = new MetodosModelo();
            return contexto.BorrarHistorialdepaciente(idhistoria);
        }
        public dc_Generar_resu EditarPacienteLogica(Pacientes paciente)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();
            MetodosModelo contexto = new MetodosModelo();
            resultado = contexto.EditarPacientes(paciente);
            return resultado;

        }
        public dc_Generar_resu buscarPacienteLogica(int idkey_usuario)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();
            MetodosModelo contexto = new MetodosModelo();
            resultado = contexto.BuscarPacientes(idkey_usuario);
            return resultado;

        }
        public dc_Generar_resu BorrarPacienteLogica(int idpaciente)
        {
            MetodosModelo contexto = new MetodosModelo();
            return contexto.BorrarPaciente(idpaciente);
        }
        public List<Rol> ObtenerRolesLogica()
        {
            MetodosModelo modelo = new MetodosModelo();

            return modelo.ObtenerRol();
        }
        public dc_Generar_resu AgregarRolLogica(Rol roles)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();
            MetodosModelo metodos = new MetodosModelo();
            resultado = metodos.GuardarRol(roles);

            return resultado;
        }
        public dc_Generar_resu BuscarRolLogica(int idkey_usuario)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();
            MetodosModelo contexto = new MetodosModelo();
            resultado = contexto.BuscarRoles(idkey_usuario);
            return resultado;

        }
        public dc_Generar_resu EditarRolLogica(Rol roles)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();
            MetodosModelo contexto = new MetodosModelo();
            resultado = contexto.EditarRoles(roles);
            return resultado;

        }
        public dc_Generar_resu BorrarRolLogica(int idrol)
        {
            MetodosModelo contexto = new MetodosModelo();
            return contexto.BorrarRol(idrol);
        }
        public List<Usuarios> ObtenerUsuariosLogica()
        {
            MetodosModelo context = new MetodosModelo();

            return context.ObtenerUsuarios();
        }
        public dc_Generar_resu GuardarUsuariosLogica(Usuarios usuario)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();
            MetodosModelo contexto = new MetodosModelo();
            resultado = contexto.GuardarUsuario(usuario);

            return resultado;
        }
        public dc_Generar_resu EditarUsuarioLogica(Usuarios usuario)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();
            MetodosModelo contexto = new MetodosModelo();
            resultado = contexto.EditarUsuario(usuario);
            return resultado;

        }
        public dc_Generar_resu buscarUsuarioLogica(int idkey_usuario)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();
            MetodosModelo contexto = new MetodosModelo();
            resultado = contexto.BuscarUsuario(idkey_usuario);
            return resultado;

        }
        public dc_Generar_resu BorrarUsuarioLogica(int idusuario)
        {
            MetodosModelo contexto = new MetodosModelo();
            return contexto.BorrarUsuario(idusuario);
        }
        //public dc_Generar_resu BuscarUsuarioLoginLogica(string nombre, string contraseña, List<string> roles)
         public dc_Generar_resu BuscarUsuarioLoginLogica(string nombre, string contraseña)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();
            MetodosModelo contexto = new MetodosModelo();
            resultado = contexto.BuscarUsuarioLoginModelo(nombre,contraseña);
            return resultado;

        }
        public dc_Generar_resu buscarcontraseñaLogica(string idkey_usuario)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();
            MetodosModelo contexto = new MetodosModelo();
            resultado = contexto.BuscarContraseña(idkey_usuario);
            return resultado;

        }
        public dc_Generar_resu EditarContraseñaLogica(Usuarios usuario)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();
            MetodosModelo contexto = new MetodosModelo();
            resultado = contexto.EditarContraseña(usuario);
            return resultado;

        }

        // agrega codigo joan citas

        public List<Citas> ObtenerCitaslogica()
        {
            MetodosModelo contexto = new MetodosModelo();

            return contexto.ObtenerCitas();

        }



        public bool ExisteCita(Citas cita)
        {
            MetodosModelo contexto = new MetodosModelo();
            return contexto.ExisteCita(cita);
        }



        public dc_Generar_resu GuardarCitaLogica(Citas cita)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();
            MetodosModelo contexto = new MetodosModelo();

            resultado = contexto.GuardarCita(cita);

            return resultado;
        }

        public dc_Generar_resu EditarCitaLogica(Citas cita)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();
            MetodosModelo contexto = new MetodosModelo();
            resultado = contexto.EditarCita(cita);
            return resultado;
        }

        public dc_Generar_resu BorrarcitaLogica(int idcita)
        {
            MetodosModelo contexto = new MetodosModelo();
            return contexto.BorrarCita(idcita);
        }
    }
}

