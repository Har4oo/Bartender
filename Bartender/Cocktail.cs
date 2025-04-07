using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bartender {
    public class Cocktail {

        private string name;
        private ArrayList ingredients;

        public string Name { get => name; set => name = value; }
        public ArrayList Ingredients { get => ingredients; set => ingredients = value; }

        public Cocktail(string name, ArrayList ingredients) {
            this.Name = name;
            this.Ingredients = ingredients;
        }

        public Cocktail() {
        }

        public string assignCocktail() {
            StreamReader streamReader = new StreamReader("ten_random_cocktails.txt");

            string line = streamReader.ReadLine();
            string randomlyGivenCocktail = "";

            if (!string.IsNullOrEmpty(line)) {
                string[] cocktails = line.Split(new string[] { " | " }, StringSplitOptions.None);

                Random rnd = new Random();

                randomlyGivenCocktail = cocktails[rnd.Next(cocktails.Length)];
            }
            this.Name = randomlyGivenCocktail;
            return randomlyGivenCocktail;
        }
        public ArrayList assignCocktailIngredients() {
            if (this.name.Equals("Mojito")) {
                this.ingredients = new ArrayList();
                ingredients.Add("Rum");
                ingredients.Add("Lemon");
                ingredients.Add("Mint");
                ingredients.Add("Ice");
            } else if (this.name.Equals("Gin and Tonic")) {
                this.ingredients = new ArrayList();
                ingredients.Add("Gin");
                ingredients.Add("Club Soda");
                ingredients.Add("Ice");
            } else if (this.name.Equals("Paloma")) {
                this.ingredients = new ArrayList();
                ingredients.Add("Tequila");
                ingredients.Add("Club Soda");
                ingredients.Add("Juice");
            } else if (this.name.Equals("German Vacation")) {
                this.ingredients = new ArrayList();
                ingredients.Add("Jagermeister");
                ingredients.Add("Juice");
                ingredients.Add("Ice");
            } else if (this.name.Equals("Jagermeister Rum Punch")) {
                this.ingredients = new ArrayList();
                ingredients.Add("Jagermeister");
                ingredients.Add("Rum");
                ingredients.Add("Juice");
            } else if (this.name.Equals("Ranch Water")) {
                this.ingredients = new ArrayList();
                ingredients.Add("Tequila");
                ingredients.Add("Club Soda");
                ingredients.Add("Lemon");
            } else if (this.name.Equals("Daiquiri")) {
                this.ingredients = new ArrayList();
                ingredients.Add("Rum");
                ingredients.Add("Juice");
                ingredients.Add("Simple Syrup");
            } else if (this.name.Equals("Long Island")) {
                this.ingredients = new ArrayList();
                ingredients.Add("Vodka");
                ingredients.Add("Rum");
                ingredients.Add("Tequila");
                ingredients.Add("Gin");
                ingredients.Add("Lemon");
                ingredients.Add("Club Soda");
                ingredients.Add("Ice");
            } else if (this.name.Equals("Vodka with Ice")) {
                this.ingredients = new ArrayList();
                ingredients.Add("Vodka");
                ingredients.Add("Ice");
            } else if (this.name.Equals("Tequila Shots")) {
                this.ingredients = new ArrayList();
                ingredients.Add("Tequila");
                ingredients.Add("Lemon");
            } else if (this.name.Equals("German Vacation")) {
                this.ingredients = new ArrayList();
                ingredients.Add("Rum");
                ingredients.Add("Club Soda");
                ingredients.Add("Ice");
                ingredients.Add("Lemon");
            }else if (this.name.Equals("German Vacation")) {
                this.ingredients = new ArrayList();
                ingredients.Add("Rum");
                ingredients.Add("Club Soda");
                ingredients.Add("Ice");
                ingredients.Add("Lemon");
            } else if (this.name.Equals("Cuba Libre")){
                this.ingredients = new ArrayList();
                ingredients.Add("Rum");
                ingredients.Add("Club Soda");
                ingredients.Add("Ice");
                ingredients.Add("Lemon");
            }
            return ingredients;
        }
    }
}
