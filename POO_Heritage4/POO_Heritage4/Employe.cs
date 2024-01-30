using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heritage4
{
    public abstract class Employe
    {
        protected string _matricule;
        protected string _nom;
        protected string _prenom;
        protected string _dateDeNaissance;

        public string Matricule
        {
            get { return _matricule; }
        }

        public string Nom
        {
            get { return _nom; }
        }

        public string Prenom
        {
            get { return _prenom; }
        }

        public string DateDeNaissance
        {
            get { return _dateDeNaissance; }
        }

        public abstract string Afficher();
        public abstract double Salaire();
    }
}
