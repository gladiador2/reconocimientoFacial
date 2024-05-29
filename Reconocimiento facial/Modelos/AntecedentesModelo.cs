using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconocimiento_facial.Clases
{
   public class AntecedentesModelo
    {
        public int id { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
       
        public Nullable<int> PersonaId { get; set; }
    
    }
}
