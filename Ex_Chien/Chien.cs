using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chien
{
    class UnChien
    {
        // attributs privés par convention, leur nom commence par "_"
        private string _nom;
        private string _race;
        private uint _age;
        private bool _enOrdreDeVaccin;
        private bool _puce;
        private bool _sterelise;
        private string _genre;
        private bool _aveugle;
        private bool _sourd;
        private bool _dresser;

        // méthodes publiques
        public string Nom
        {
            get { return _genre; }
            set { _genre = value; }
        }
        public uint Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
        public bool EnOrdeDeVaccin
        {
            get { return _enOrdreDeVaccin; }
            set { _enOrdreDeVaccin = value; }
        }
        public bool Puce
        {
            get { return _puce; }
            set { _puce = value; }
        }
        public bool Sterelise
        {
            get { return _puce; }
            set { _puce = value; }
        }
        public bool Aveugle
        {
            get { return _aveugle; }
            set { _aveugle = value; }
        }
        public bool Sourd
        {
            get { return _sourd; }
            set { _sourd = value; }
        }
        public bool Dresser
        {
            get { return _dresser; }
            set { _dresser = value; }
        }









        // le constructeur (toujours le même nom que la classe)
        public UnChien(string nom,string race, uint age, bool enOrdreDeVaccin, bool puce, bool sterelise, string genre, bool aveugle, bool sourd, bool dresser)
        {
            _nom = nom;
            _race = race;
            _age = age;
            _enOrdreDeVaccin = enOrdreDeVaccin;
            _puce = puce;
            _sterelise = sterelise;
            _genre = genre;
            _aveugle = aveugle;
            _sourd = sourd;
            _dresser = dresser;
        }

        // une méthode pour formater les attributs d'un chien d'un string
        public string AfficherCaractéristiques()
        {
            string chaine = " - Nom : " + _nom + " - Age : " + _age + " - Race : " + _race + " - En Ordre de Vaccin : " + _enOrdreDeVaccin + " - Puce présente ? : " + _puce + " - Sterelisé ? : " + _race + " - Race : " + _race + " - Race : " + _race;
            return chaine;
        }
    }
}
