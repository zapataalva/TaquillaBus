//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ViajesTerrestres.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Conductor
    {
        public int ConductorId { get; set; }
        public Nullable<int> BusRefId { get; set; }
        public string NombreConductor { get; set; }
    
        public virtual Bus Bus { get; set; }
    }
}
