using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    public class Estudiante
    {
        public int estudianteId { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public string email { get; set; }
    }
}
