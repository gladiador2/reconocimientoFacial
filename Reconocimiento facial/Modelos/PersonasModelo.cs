
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconocimiento_facial.Modelos
{
    public class PersonasModelo
    {

        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string DescripcionFisica { get; set; }
        public string Email { get; set; }
        public string Nivel { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public Nullable<int> ciudadId { get; set; }
        public Nullable<int> AntecedentesId { get; set; }

        public virtual Antecedentes Antecedentes { get; set; }
        
    }
}
