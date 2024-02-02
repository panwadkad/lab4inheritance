using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4inheritance
{
    public class Palafin : POKAMON
    {
        public Palafin()
        {
            name = "Palafin";
            id = 964;
            level = 1;
            type = POKEMONtype.Water;
        }
    }
}
