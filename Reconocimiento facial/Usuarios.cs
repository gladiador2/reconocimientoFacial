//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reconocimiento_facial
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        public int id { get; set; }
        public Nullable<int> RolId { get; set; }
        public string Usernsme { get; set; }
        public string Contrasenha { get; set; }
        public Nullable<int> personaID { get; set; }
    
        public virtual Personas Personas { get; set; }
        public virtual Roles Roles { get; set; }
    }
}
