//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyeClinica.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class HistorialesClinicos
    {
        public int ID_Historial { get; set; }
        public Nullable<int> ID_paciente { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Alergias { get; set; }
        public string Medicamentos { get; set; }
        public string ResultadosPruebas { get; set; }
        public string NotasSeguimiento { get; set; }
        public string OtrosDetalles { get; set; }
    
        public virtual Pacientes Pacientes { get; set; }
    }
}