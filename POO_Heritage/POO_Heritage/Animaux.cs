using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heritage
{
    internal class Animaux
    {
		protected string _nom;

		public string Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}

		protected DateTime _dateDeNaissance;

		public DateTime DateDeNaissance
		{
			get { return _dateDeNaissance; }
			set { _dateDeNaissance = value; }
		}
		protected double _numeroPuce;

		public double NumeroPuce
		{
			get { return _numeroPuce; }
			set { _numeroPuce = value; }
		}
		protected double _taille;

		public double Taille
		{
			get { return _taille; }
			set { _taille = value; }
		}
		protected bool _animauxConcours;

		public bool AnimauxConcours
		{
			get { return _animauxConcours; }
			set { _animauxConcours = value; }
		}

        public Animaux(string nom, DateTime dateDeNaissance, double numeroPuce, double taille, bool animauxConcours)
        {
            _nom = nom;
			_dateDeNaissance = dateDeNaissance;
			_numeroPuce = numeroPuce;
			_taille = taille;
			_animauxConcours = animauxConcours;
        }
        public virtual string Affiche()
        {
            string affiche = "Mon statut: \n Nom : " + _nom + ".\nMa date de naissance : " + _dateDeNaissance + "\n Numéro de puce : "+ _numeroPuce +"\n Taille : "+ _taille +"\n Animal de concours : "+ _animauxConcours +".";
            return affiche;
        }
		public string Manger()
		{
			return "Il mange ";                           
		}
		public string Dormir()
		{
			return "ROMPISH ";

		}


    }
}
