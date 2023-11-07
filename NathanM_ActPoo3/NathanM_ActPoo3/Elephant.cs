using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NathanM_ActPoo3
{
    internal class Elephant
    {
		private string _nom;

		public string Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}

		private uint _tailleOreilles;

		public uint TaillleOreilles
		{
			get { return _tailleOreilles; }
			set { _tailleOreilles = value; }
		}
        public Elephant(string nom, uint tailleOreille)
        {
            _tailleOreilles = tailleOreille;
            _nom = nom;
        }


        public void EcouteMessage(string message, Elephant quiDit)
        {
            Console.WriteLine(_nom + " a entendu un message \n" + quiDit._nom + " a dit : " + message);
        }
        public void EnvoieMessage(string message, Elephant quiRecoit)
        {
            quiRecoit.EcouteMessage(message, this);
        }
		public string AfficheQuiJeSuis()
		{
			string Jesuis = "Je m'appelle " + _nom + ".\nMes oreilles mesurent "+ _tailleOreilles +"cm.";
			return Jesuis;	
		}

    }
}
