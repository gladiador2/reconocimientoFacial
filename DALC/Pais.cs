//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pais
    {
        public Pais()
        {
            this.Departamento = new HashSet<Departamento>();
        }
    
        public int id { get; set; }
        public string Pais1 { get; set; }
        public byte[] bandera { get; set; }
    
        public virtual ICollection<Departamento> Departamento { get; set; }
    }
}
