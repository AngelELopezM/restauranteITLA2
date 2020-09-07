using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database
{
   public sealed class mesa_ocupada
    {
        public bool ocupada;

        public static mesa_ocupada instacia { get; } = new mesa_ocupada();

        private mesa_ocupada()
        {

        }
    }
}
