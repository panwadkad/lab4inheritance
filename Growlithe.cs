using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4inheritance
{
    public class Growlithe : POKAMON
    {
        public Growlithe()
        {
            name = "Growlithe";
            id = 58;
            level = 1;
            type = POKEMONtype.Fire;
        }
    }
}
