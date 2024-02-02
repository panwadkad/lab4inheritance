using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4inheritance
{
    public class Charmander : POKAMON
    {
        public Charmander() 
        {
            name = "Charmander";
            id = 4;
            level = 1;
            type = POKEMONtype.Fire;
        }
    }
}
