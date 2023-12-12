using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CeUAA14Partie2_dec23_Massart
{
    internal class PaintBallGun
    {
		private uint _balleIn;

		public uint balleIn
		{
			get { return _balleIn; }
			set { _balleIn = value; }
		}

		private uint _balleOut;

		public uint balleOut
		{
			get { return _balleOut; }
			set { _balleOut = value; }
		}

		private uint _balleStock;

		public uint balleStock
		{
			set { _balleStock = value; }
		}

		public PaintBallGun(uint balleIn, uint balleOut,uint balleStock)
		{
			_balleIn = balleIn;
			_balleOut = balleOut;
			_balleStock = balleStock;
		}
		public void Recharger(uint balleIn, uint balleOut, uint balleStock)
		{
			if (balleIn == 16)
			{
                Console.WriteLine( "Vous avez déjà le chargeur rempli");
			}
			else
			{
                while (balleIn != 16)
                {
                    if (balleStock == 0)
                    {
                        Console.WriteLine( "Vous n'avez plus assez de balle en réserve mais vous avez " + _balleIn +" dans votre chargeur");
                    }
                    _balleStock -= 1;
					_balleStock += balleIn;
					_balleStock = balleStock - balleOut;
                    Console.WriteLine( "Votre avez un total de " + _balleStock + " dans votre poche et "+ _balleIn +" balle(s) dans le chargeur.");
                }
            }
		}
		public void Tirer(uint balleIn, uint balleOut)
		{
			if (balleIn == 0)
			{
                Console.WriteLine( "Vous n'avez pas assez de munitions veuillez recharger");
			}
			else
			{
                _balleIn -= balleIn;
                _balleOut += balleOut;
                Console.WriteLine( " ====> Tir effectué !Votre avez un total de " + _balleStock + " dans votre poche et "+ _balleIn +" balle(s) dans le chargeur."); 
            }
        }
        public void Restock()
        {
            if (true)
            {
                _balleStock += 30;
            }
        }
		public string AfficherArme()
		{
			return "Votre arme a " + balleIn + " balle(s) dans son chargeur, " + balleOut + " balle(s) tirées et " + _balleStock + " balle(s) en stock";
		}


	}
}
