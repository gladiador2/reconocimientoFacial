using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconocimiento_facial.Modelos
{
    public class UsuarioModelo
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Username { get; set; }
        public Nullable<int> ciudadId { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public byte[] foto { get; set; }
        public Nullable<int> RolId { get; set; }

       
    }
}
