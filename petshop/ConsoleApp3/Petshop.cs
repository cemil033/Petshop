using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Petshop
    {
        public List<Cathouse> cathause;
        public Petshop()
        {
            cathause = new();
        }
        public Petshop(List<Cathouse> cathause)
        {
            this.cathause = cathause;
        }
        public void Addhouse(Cathouse cath)
        {
            cathause.Add(cath);
        }
    }
}
