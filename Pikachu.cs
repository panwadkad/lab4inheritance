using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4inheritance
{
    public class Pikachu : POKAMON
    {
        public Pikachu()
        {
            name = "PIKACHU";
            id = 25;
            level = 1;
            type = POKEMONtype.Electr;
        }

    }
}
