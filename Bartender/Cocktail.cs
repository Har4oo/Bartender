using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bartender
{
    internal class Cocktail
    {

        private string name;
        private ArrayList ingredients;

        public string Name { get => name; set => name = value; }
        public ArrayList Ingredients { get => ingredients; set => ingredients = value; }

        public Cocktail(string name, ArrayList ingredients)
        {
            this.Name = name;
            this.Ingredients = ingredients;
        }

        public Cocktail()
        {
        }

        public string assignCocktail()
        {
            StreamReader streamReader = new StreamReader("ten_random_cocktails.txt");

            string line = streamReader.ReadLine();
            string randomlyGivenCocktail = "";

            if (!string.IsNullOrEmpty(line))
            {
                string[] cocktails = line.Split(new string[] { " | " }, StringSplitOptions.None);

                Random rnd = new Random();

                randomlyGivenCocktail = cocktails[rnd.Next(cocktails.Length)];
            }
            this.Name = randomlyGivenCocktail;
            return randomlyGivenCocktail;
        }
    }
}
