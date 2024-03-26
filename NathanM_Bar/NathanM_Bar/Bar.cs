using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NathanM_Bar
{
    public class Bar
    {
        private Bouteille[] _reserve;

        public Bouteille[]  Reserve
        {
            get { return  _reserve; }
            set { _reserve = value; }
        }


        public Bar( Bouteille[] reserve)
        { 
            _reserve = reserve;
        }
    }
}
