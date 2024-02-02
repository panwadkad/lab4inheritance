using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4inheritance
{
    public class POKAMON
    {
        protected int id;
        protected string name;
        protected Image pic;
        protected int level;
        protected POKEMONtype type;
        protected POKEMONAbilities abilities;
        protected int HP;
        protected int Att;
        protected int Def;
        protected int SAtt;
        protected int SDef;
        protected int Speed;

        public string Name()
        {
            return name;
        }
        public Image Picture()
        {
            return pic;
        }
    }

    public enum POKEMONtype
    {
        Grass, Poison, Electr , Fire ,Steel ,Water
    }

    public enum POKEMONAbilities
    {
        Overgrow, chlorophyII, Static, LightningRod
    }
}
