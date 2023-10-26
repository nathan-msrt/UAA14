using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NathanM_ActPOO2
{
    internal class SandwichMaker
    {
        private string[] _proteine = { "jambon", "fromage", "roast beef", "salami" };
        private string[] _condiments = { "moutarde", "mayonnaise", "ketchup", "andalouse" };
        private string[] _pain = { "pain blanc", "pain complet", "baguette", "pain aux céréales" };
        private string[] _crudites = { "laitue", "tomate", "oignon", "concombre" };

        public SandwichMaker() { }
        public string[] Crudites
        {
            get { return _crudites; }

        }
        public string[] Pain
        {
            get { return _pain; }

        }
        public string[] Condiments
        {
            get { return _condiments; }

        }
        public string[] Proteine
        {
            get { return _proteine; }

        }


        public string Compose()
        {
            string sandwich = "Voici votre sandwich : ";
            Random alea = new Random();
            sandwich += _pain[alea.Next(0, 4)] + ", ";
            sandwich += _proteine[alea.Next(0, 4)] + ", ";
            sandwich += _crudites[alea.Next(0, 4)] + ", ";
            sandwich += _condiments[alea.Next(0, 4)];
            return sandwich;

        }
    }
}
