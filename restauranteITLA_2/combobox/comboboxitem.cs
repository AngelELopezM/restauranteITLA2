using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauranteITLA_2.combobox
{
    public class comboboxitem
    {
        public string text { get; set; }
        public object value { get; set; }

        public override string ToString()
        {
            return text;
        }
    }
}
