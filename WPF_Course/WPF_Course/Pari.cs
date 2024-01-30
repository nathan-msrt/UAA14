using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WPF_Course
{
    internal class Pari
    {
        protected int _montant;

        public int Montant
        {
            get { return _montant; }
            set { _montant = value; }

        }
        protected int _numeroChien;

        public int NumeroChien
        {
            get { return _numeroChien; }
            set { _numeroChien = value; }
        }

        public Pari(int montant, int numeroChien)
        {
            _montant = montant;
            _numeroChien = numeroChien;

        }
    }
}
