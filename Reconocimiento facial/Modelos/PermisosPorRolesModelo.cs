
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconocimiento_facial.Modelos
{
    public class PermisosPorRolesModelo
    {
        public int id { get; set; }
        public Nullable<int> RolId { get; set; }
        public Nullable<int> PermisoId { get; set; }

        public virtual Permisos Permisos { get; set; }
        public virtual Roles Roles { get; set; }
    }
}
