using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bartender
{
    internal class Client
    {
        private string name;
        private Cocktail cocktail;

        public Client() {
        }

        public Client(string name, Cocktail cocktail) {
            this.Name = name;
            this.Cocktail = cocktail;
        }

        public string Name { get => name; set => name = value; }
        internal Cocktail Cocktail { get => cocktail; set => cocktail = value; }
    }
}
