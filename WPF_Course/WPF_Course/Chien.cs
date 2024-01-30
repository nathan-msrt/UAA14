using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF_Course
{
    internal class Chien
    {
        protected int _numeroChien;

		public int NumeroChien
		{
			get { return _numeroChien; }
			set { _numeroChien = value; }

		}
        protected int _longueurPiste;

		public int LongueurPiste
		{
			get { return _longueurPiste; }
			set { _longueurPiste = value; }
		}

		protected Image _imageChien;

		public Image ImageChien
		{
			get { return _imageChien; }
			set { _imageChien = value; }
		}


		protected int[] _positionCourante;

		public int[]  PositionCourante
		{
			get { return _positionCourante; }
			set { _positionCourante = value; }
		}
		public  Chien (int numeroChien, int longueurPiste, Image imageChien, int[] positionCourante)
		{
			_numeroChien =numeroChien;
			_longueurPiste = longueurPiste;
			_imageChien =imageChien;
			_positionCourante = positionCourante;

		}



    }
}
