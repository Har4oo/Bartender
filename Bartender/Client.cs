using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bartender
{
    public class Client
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

        public string assignRandomName()
        {
            StreamReader streamReader = new StreamReader("ten_random_client_names.txt");

            string line = streamReader.ReadLine();
            string randomlyGivenName = "";

            if (!string.IsNullOrEmpty(line))
            {
                string[] names = line.Split(new string[] { " | " }, StringSplitOptions.None);

                Random rnd = new Random();

                randomlyGivenName = names[rnd.Next(names.Length)];
            }
            this.Name = randomlyGivenName;
            return randomlyGivenName;
        }
        
    }
}
