using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ProyeClinica.DataContracts;

namespace ProyeClinica.DataModel
{
    public class MetodosModelo
    {
        public List<Pacientes> ObtenerPacientes()
        {
            using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
            {

                //List<Citas> citas = contexto.Citas.ToList();
                List<Pacientes> pacientes = contexto.Pacientes.ToList();

                return pacientes;
            }

        }

        public dc_Generar_resu GuardarPaciente(Pacientes paciente)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();
            Pacientes usuarioBuscado = new Pacientes();
            try
            {

                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {
                    //usuarioBuscado = contexto.Pacientes.Where(x => x.ID_Paciente == idkey_usuario).FirstOrDefault();

                    if (usuarioBuscado != null)
                    {
                        resultado.Estado = true;
                        resultado.Mensaje = "El Paciente si existe";
                        resultado.Valor = usuarioBuscado;
                    }
                    else
                    {
                        resultado.Estado = false;
                        resultado.Mensaje = "No se encontró el Paciente con el id especificado";
                    }
                    contexto.Pacientes.Add(paciente);
                    contexto.SaveChanges();
                    resultado.Estado = true;
                    resultado.Mensaje = "Se ingreso correctamente el usuario";


                }

            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;

            }

            return resultado;


        }

        public List<Pacientes> GuardarPaciente(Pacientes paci, List<Pacientes> ListaPacientesA)
        {


            return ListaPacientesA;
        }
        public List<Medicos> ObtenerMedicos()
        {
            using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
            {


                List<Medicos> medicos = contexto.Medicos.ToList();

                return medicos;
            }

        }

        public dc_Generar_resu GuardarMedico(Medicos medicos)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();

            try
            {

                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {
                    contexto.Medicos.Add(medicos);
                    contexto.SaveChanges();
                    resultado.Estado = true;
                    resultado.Mensaje = "Se ingreso correctamente el Medico";


                }

            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;

            }

            return resultado;

        }
        public List<Medicos> GuardarMedico(Medicos medico, List<Medicos> ListaMedicosA)
        {


            return ListaMedicosA;
        }

        public dc_Generar_resu BuscarMedicos(int idkey_usuario)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();
            Medicos usuarioBuscado = new Medicos();
            try
            {

                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {


                    usuarioBuscado = contexto.Medicos.Where(x => x.ID_Medico == idkey_usuario).FirstOrDefault();

                    if (usuarioBuscado != null)
                    {
                        resultado.Estado = true;
                        resultado.Mensaje = "El Medico si existe";
                        resultado.Valor = usuarioBuscado;
                    }
                    else
                    {
                        resultado.Estado = false;
                        resultado.Mensaje = "No se encontró el Medico con el id especificado";
                    }

                }


            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;
            }




            return resultado;


        }

        public dc_Generar_resu EditarMedicos(Medicos med)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();
            try
            {
                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {

                    contexto.Entry(med).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();
                    resultado.Estado = true;
                    resultado.Mensaje = "Se editó correctamente el Medico";

                }


            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;

            }

            return resultado;
        }

        public dc_Generar_resu BorrarMedico(int idMedico)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();
            try
            {
                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {
                    Medicos medicoABorrar = contexto.Medicos.FirstOrDefault(m => m.ID_Medico == idMedico);
                    if (medicoABorrar != null)
                    {
                        contexto.Medicos.Remove(medicoABorrar);
                        contexto.SaveChanges();

                        resultado.Estado = true;
                        resultado.Mensaje = "Se ha borrado correctamente el Médico.";
                    }
                    else
                    {
                        resultado.Estado = false;
                        resultado.Mensaje = "No se encontró el Médico con el ID especificado.";
                    }
                }
            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;
            }

            return resultado;
        }

        public List<HistorialesClinicos> ObtenerHistorialesClinicos()
        {
            using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
            {
                List<HistorialesClinicos> historiales = contexto.HistorialesClinicos.Include("Pacientes").ToList();
                return historiales;
            }
        }

        public dc_Generar_resu GuardarHistorialMedico(HistorialesClinicos historia)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();
            try
            {
                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {

                    int idPaciente = historia.ID_paciente ?? 0;
                    Pacientes paciente = contexto.Pacientes.FirstOrDefault(p => p.ID_Paciente == idPaciente);

                    if (paciente == null)
                    {
                        resultado.Estado = false;
                        resultado.Mensaje = "El paciente con el ID especificado no existe en la base de datos.";
                        return resultado;
                    }


                    historia.Pacientes = paciente;
                    contexto.HistorialesClinicos.Add(historia);
                    contexto.SaveChanges();
                    resultado.Estado = true;
                    resultado.Mensaje = "Se ingresó correctamente el historial médico del paciente.";
                }
            }
            catch (Exception ex)
            {

                resultado.Estado = false;
                resultado.Mensaje = ex.Message;
            }
            return resultado;
        }


        public dc_Generar_resu BuscarHistorialModelo(int idkey_usuario, int idkey_usuario1)
        {
            {
                dc_Generar_resu resultado = new dc_Generar_resu();
                HistorialesClinicos historialMedico = new HistorialesClinicos();

                try
                {
                    using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                    {
                        historialMedico = contexto.HistorialesClinicos
                                                  .Include("Pacientes")
                                                  .FirstOrDefault(x => x.ID_Historial == idkey_usuario && x.ID_paciente == idkey_usuario1);

                        if (historialMedico != null)
                        {
                            resultado.Estado = true;
                            resultado.Mensaje = "El Historial medico si existe";
                            resultado.Valor = historialMedico;
                        }
                        else
                        {
                            resultado.Estado = false;
                            resultado.Mensaje = "No se encontró el Historial medico con el id especificado";
                        }
                    }

                    // Agrega una instrucción return aquí para devolver el resultado
                    return resultado;
                }
                catch (Exception ex)
                {
                    resultado.Estado = false;
                    resultado.Mensaje = ex.Message;

                    // Agrega una instrucción return aquí para devolver el resultado en caso de excepción
                    return resultado;
                }
            }

        }

        public dc_Generar_resu EditarHistorialdepaciente(HistorialesClinicos historialMedico)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();
            try
            {
                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {

                    contexto.Entry(historialMedico).State = System.Data.Entity.EntityState.Modified;

                    contexto.SaveChanges();
                    resultado.Estado = true;
                    resultado.Mensaje = "Se editó correctamente el Historial medico del Paciente";

                }



            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;

            }

            return resultado;
        }

        public dc_Generar_resu BorrarHistorialdepaciente(int idhistoria)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();

            try
            {
                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {

                    HistorialesClinicos historialABorrar = contexto.HistorialesClinicos.FirstOrDefault(m => m.ID_Historial == idhistoria);
                    if (historialABorrar != null)
                    {
                        contexto.HistorialesClinicos.Remove(historialABorrar);
                        contexto.SaveChanges();

                        resultado.Estado = true;
                        resultado.Mensaje = "Se ha borrado correctamente el HIstorial del Paciente correctamente.";
                    }
                    else
                    {
                        resultado.Estado = false;
                        resultado.Mensaje = "No se encontró el HIstorial del paciente con el ID especificado.";
                    }
                }
            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;
            }

            return resultado;
        }
        public dc_Generar_resu BuscarPacientes(int idkey_usuario)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();
            Pacientes usuarioBuscado = new Pacientes();
            try
            {

                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {


                    usuarioBuscado = contexto.Pacientes.Where(x => x.ID_Paciente == idkey_usuario).FirstOrDefault();

                    if (usuarioBuscado != null)
                    {
                        resultado.Estado = true;
                        resultado.Mensaje = "El Paciente si existe";
                        resultado.Valor = usuarioBuscado;
                    }
                    else
                    {
                        resultado.Estado = false;
                        resultado.Mensaje = "No se encontró el Paciente con el id especificado";
                    }

                }


            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;
            }




            return resultado;


        }
        public dc_Generar_resu EditarPacientes(Pacientes paciente)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();
            try
            {
                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {

                    contexto.Entry(paciente).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();
                    resultado.Estado = true;
                    resultado.Mensaje = "Se editó correctamente el Paciente";

                }


            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;

            }

            return resultado;
        }
        public dc_Generar_resu BorrarPaciente(int idpaciente)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();
            try
            {
                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {
                    Pacientes pacienteABorrar = contexto.Pacientes.FirstOrDefault(m => m.ID_Paciente == idpaciente);
                    if (pacienteABorrar != null)
                    {
                        contexto.Pacientes.Remove(pacienteABorrar);
                        contexto.SaveChanges();

                        resultado.Estado = true;
                        resultado.Mensaje = "Se ha borrado correctamente el Paciente.";
                    }
                    else
                    {
                        resultado.Estado = false;
                        resultado.Mensaje = "No se encontró el Médico con el ID especificado.";
                    }
                }
            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;
            }

            return resultado;
        }
        public List<Rol> ObtenerRol()
        {
            using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
            {


                List<Rol> medicos = contexto.Rol.ToList();

                return medicos;
            }

        }
        public dc_Generar_resu GuardarRol(Rol roles)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();

            try
            {

                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {
                    contexto.Rol.Add(roles);
                    contexto.SaveChanges();
                    resultado.Estado = true;
                    resultado.Mensaje = "Se ingreso correctamente el Rol";


                }

            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;

            }

            return resultado;

        }
        public dc_Generar_resu BuscarRoles(int idkey_usuario)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();
            Rol usuarioBuscado = new Rol();
            try
            {

                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {


                    usuarioBuscado = contexto.Rol.Where(x => x.ID_Rol == idkey_usuario).FirstOrDefault();

                    if (usuarioBuscado != null)
                    {
                        resultado.Estado = true;
                        resultado.Mensaje = "El Rol si existe";
                        resultado.Valor = usuarioBuscado;
                    }
                    else
                    {
                        resultado.Estado = false;
                        resultado.Mensaje = "No se encontró el Rol con el id especificado";
                    }

                }


            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;
            }




            return resultado;


        }

        public dc_Generar_resu EditarRoles(Rol roles)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();
            try
            {
                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {

                    contexto.Entry(roles).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();
                    resultado.Estado = true;
                    resultado.Mensaje = "Se editó correctamente el Rol";

                }


            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;

            }

            return resultado;
        }
        public dc_Generar_resu BorrarRol(int idrol)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();
            try
            {
                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {
                    Rol rolABorrar = contexto.Rol.FirstOrDefault(m => m.ID_Rol == idrol);
                    if (rolABorrar != null)
                    {
                        contexto.Rol.Remove(rolABorrar);
                        contexto.SaveChanges();

                        resultado.Estado = true;
                        resultado.Mensaje = "Se ha borrado correctamente el Rol.";
                    }
                    else
                    {
                        resultado.Estado = false;
                        resultado.Mensaje = "No se encontró el Rol con el ID especificado.";
                    }
                }
            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;
            }

            return resultado;
        }
        public List<Usuarios> ObtenerUsuarios()
        {
            using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
            {
                List<Usuarios> usuario = contexto.Usuarios.ToList();
                return usuario;
            }
        }

        public dc_Generar_resu GuardarUsuario(Usuarios usuario)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();

            try
            {
                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {
                    //se hace así por que no lleva llave foranea en la base de datos sale la llave foranea y no es cierto
                    // Agregar el usuario y guardar los cambios en la base de datos
                    contexto.Usuarios.Add(usuario);
                    contexto.SaveChanges();

                    resultado.Estado = true;
                    resultado.Mensaje = "Se ingresó correctamente el usuario.";
                }
            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.ToString();
                resultado.Mensaje = ex.Message;
            }

            return resultado;



        }
        public dc_Generar_resu BuscarUsuario(int idkey_usuario)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();
            Usuarios usuarioBuscado = new Usuarios();
            try
            {

                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {


                    usuarioBuscado = contexto.Usuarios.Where(x => x.ID_Usuario == idkey_usuario).FirstOrDefault();

                    if (usuarioBuscado != null)
                    {
                        resultado.Estado = true;
                        resultado.Mensaje = "El Usuario si existe";
                        resultado.Valor = usuarioBuscado;
                    }
                    else
                    {
                        resultado.Estado = false;
                        resultado.Mensaje = "No se encontró el Usuario con el id especificado";
                    }

                }


            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;
            }




            return resultado;

        }
        public dc_Generar_resu EditarUsuario(Usuarios usuario)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();
            try
            {
                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {

                    contexto.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();
                    resultado.Estado = true;
                    resultado.Mensaje = "Se editó correctamente el Usuario";

                }


            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;

            }

            return resultado;
        }

        public dc_Generar_resu BorrarUsuario(int idusuario)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();
            try
            {
                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {
                    Usuarios usuarioABorrar = contexto.Usuarios.FirstOrDefault(m => m.ID_Usuario == idusuario);
                    if (usuarioABorrar != null)
                    {
                        contexto.Usuarios.Remove(usuarioABorrar);
                        contexto.SaveChanges();

                        resultado.Estado = true;
                        resultado.Mensaje = "Se ha borrado correctamente el Usuario.";
                    }
                    else
                    {
                        resultado.Estado = false;
                        resultado.Mensaje = "No se encontró el Usuario con el ID especificado.";
                    }
                }
            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;
            }

            return resultado;

        }
        //public dc_Generar_resu BuscarUsuarioLoginModelo(string nombre, string contraseña, List<string> roles)
         public dc_Generar_resu BuscarUsuarioLoginModelo(string nombre, string contraseña) // se quita el roles para implementar traer el rol desde la base
        {
            {
                dc_Generar_resu resultado = new dc_Generar_resu();
                Usuarios usuario = new Usuarios();

                try
                {
                    using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                    {
                        usuario = contexto.Usuarios
                                  .FirstOrDefault(x => x.Nombre == nombre && x.Contraseña == contraseña);

                        if (usuario != null)
                        {
                            resultado.Estado = true;
                            resultado.Mensaje = "El Usuario si existe";
                            resultado.Valor = usuario;
                        }
                        else
                        {
                            resultado.Estado = false;
                            resultado.Mensaje = "No se encontró el Usuario con el id especificado";
                        }
                    }

                    // Agrega una instrucción return aquí para devolver el resultado
                    return resultado;
                }
                catch (Exception ex)
                {
                    resultado.Estado = false;
                    resultado.Mensaje = ex.Message;

                    // Agrega una instrucción return aquí para devolver el resultado en caso de excepción
                    return resultado;
                }
            }

        }
        public dc_Generar_resu BuscarContraseña(string idkey_usuario)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();
            Usuarios usuarioBuscado = new Usuarios();
            try
            {

                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {


                    usuarioBuscado = contexto.Usuarios.Where(x => x.CorreoElectronico == idkey_usuario).FirstOrDefault();

                    if (usuarioBuscado != null)
                    {
                        resultado.Estado = true;
                        resultado.Mensaje = "El Usuario si existe";
                        resultado.Valor = usuarioBuscado;
                    }
                    else
                    {
                        resultado.Estado = false;
                        resultado.Mensaje = "No se encontró el Usuario con el id especificado";
                    }

                }


            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;
            }




            return resultado;

        }
        public dc_Generar_resu EditarContraseña(Usuarios usuario)
        {

            dc_Generar_resu resultado = new dc_Generar_resu();
            try
            {
                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {

                    contexto.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();
                    resultado.Estado = true;
                    resultado.Mensaje = "Se Modifico correctamente el Usuario";

                }


            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;

            }

            return resultado;
        }


        // agrega codigo joan de citas 

        public List<Citas> ObtenerCitas()
        {
            using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
            {
                List<Citas> citas = contexto.Citas.ToList();

                return citas;
            }
        }

        public bool ExisteCita(Citas cita)
        {
            using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
            {
                return contexto.Citas.Any(c =>
                    c.ID_Medico == cita.ID_Medico &&
                    c.Fecha == cita.Fecha &&
                    c.Hora == cita.Hora);
            }
        }


        public dc_Generar_resu GuardarCita(Citas cita)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();

            try
            {
                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {
                    int idPaciente = cita.ID_Paciente ?? 0;

                    Pacientes pacientes = contexto.Pacientes.FirstOrDefault(p => p.ID_Paciente == idPaciente);

                    if (pacientes == null)
                    {
                        resultado.Estado = false;
                        resultado.Mensaje = "El paciente con el ID especificado no existe en la base de datos.";
                    }
                    else
                    {
                        cita.Pacientes = pacientes;

                        contexto.Citas.Add(cita);
                        contexto.SaveChanges();

                        resultado.Estado = true;
                        resultado.Mensaje = "Se ingresó correctamente la cita";
                    }
                }
            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;
            }

            return resultado;
        }


        public dc_Generar_resu EditarCita(Citas cita)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();
            try
            {
                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {

                    contexto.Entry(cita).State = System.Data.Entity.EntityState.Modified;

                    contexto.SaveChanges();
                    resultado.Estado = true;
                    resultado.Mensaje = "Cambios guardados correctamente";

                }



            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;

            }

            return resultado;

        }

        public dc_Generar_resu BorrarCita(int idcita)
        {
            dc_Generar_resu resultado = new dc_Generar_resu();
            try
            {
                using (ProyectoClinicaEntities contexto = new ProyectoClinicaEntities())
                {
                    Citas idcitaABorrar = contexto.Citas.FirstOrDefault(m => m.ID_Cita == idcita);
                    if (idcitaABorrar != null)
                    {
                        contexto.Citas.Remove(idcitaABorrar);
                        contexto.SaveChanges();

                        resultado.Estado = true;
                        resultado.Mensaje = "Se ha borrado correctamente la cita.";
                    }
                    else
                    {
                        resultado.Estado = false;
                        resultado.Mensaje = "No se pudo borrar.";
                    }
                }
            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.Mensaje = ex.Message;
            }

            return resultado;
        }
    }

}



