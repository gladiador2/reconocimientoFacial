using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconocimiento_facial.Modelos
{
    public class FotosModelo
    {
        public int id { get; set; }
        public Nullable<int> PersonaId { get; set; }
        public byte[] Foto { get; set; }

       
    }
}
