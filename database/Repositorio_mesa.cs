using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database
{
  public sealed  class repositorio_mesa
    {
        public int mesa_en_uso;

        public static repositorio_mesa instacia { get; } = new repositorio_mesa();

        private repositorio_mesa()
        {

        }
    }
}
