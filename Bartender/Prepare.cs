using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bartender
{
    public partial class Prepare : Form
    {
        private Client client;
        private Queue<Client> clients;
        private Cocktail expectedCocktail;
        public Prepare(Client client)
        {
            InitializeComponent();

            expectedCocktail = new Cocktail();
            expectedCocktail.Ingredients = new ArrayList();

            button9.FlatStyle = FlatStyle.Flat;
            button9.FlatAppearance.BorderColor = Color.FromArgb(247, 55, 79);
            button9.FlatAppearance.BorderSize = 2;

            this.client = client;
            label1.Text = "You are preparing for \n" + client.Name + "\nwho wants \n" + client.Cocktail.Name;


            string ingredients = string.Join(", ", client.Cocktail.Ingredients.ToArray());

            label4.Text = "Ingredients: " + ingredients;


        }
        public Prepare(Client client, Queue<Client> clients)
        {
            InitializeComponent();

            expectedCocktail = new Cocktail();
            expectedCocktail.Ingredients = new ArrayList();

            button9.FlatStyle = FlatStyle.Flat;
            button9.FlatAppearance.BorderColor = Color.FromArgb(247, 55, 79);
            button9.FlatAppearance.BorderSize = 2;

            this.client = client;
            label1.Text = "You are preparing for \n" + client.Name + "\nwho wants \n" + client.Cocktail.Name;


            string ingredients = string.Join(", ", client.Cocktail.Ingredients.ToArray());

            label4.Text = "Ingredients: " + ingredients;

            this.clients = new Queue<Client>(clients);
        }


        private void AddVodka(object sender, EventArgs e)
        {
            if (client.Cocktail.Ingredients.Contains("Vodka"))
            {
                expectedCocktail.Ingredients.Add("Vodka");
                label3.Text = "Vodka added";
            }
            else
            {
                label3.Text = "Vodka should\nnot be added";
            }
            checkIngredientsAndExpected(client.Cocktail, expectedCocktail);
        }

        private void AddTequila(object sender, EventArgs e)
        {
            if (client.Cocktail.Ingredients.Contains("Tequila"))
            {
                expectedCocktail.Ingredients.Add("Tequila");
                label3.Text = "Tequila added";
            }
            else
            {
                label3.Text = "Tequila should\nnot be added";
            }
            checkIngredientsAndExpected(client.Cocktail, expectedCocktail);
        }

        private void AddRum(object sender, EventArgs e)
        {
            if (client.Cocktail.Ingredients.Contains("Rum"))
            {
                expectedCocktail.Ingredients.Add("Rum");
                label3.Text = "Rum added";
            }
            else
            {
                label3.Text = "Rum should\nnot be added";
            }
            checkIngredientsAndExpected(client.Cocktail, expectedCocktail);
        }

        private void AddGin(object sender, EventArgs e)
        {
            if (client.Cocktail.Ingredients.Contains("Gin"))
            {
                expectedCocktail.Ingredients.Add("Gin");
                label3.Text = "Gin added";
            }
            else
            {
                label3.Text = "Gin should\nnot be added";
            }
            checkIngredientsAndExpected(client.Cocktail, expectedCocktail);
        }

        private void AddLemon(object sender, EventArgs e)
        {
            if (client.Cocktail.Ingredients.Contains("Lemon"))
            {
                expectedCocktail.Ingredients.Add("Lemon");
                label3.Text = "Lemon added";
            }
            else
            {
                label3.Text = "Lemon should\nnot be added";
            }
            checkIngredientsAndExpected(client.Cocktail, expectedCocktail);
        }

        private void AddMint(object sender, EventArgs e)
        {
            if (client.Cocktail.Ingredients.Contains("Mint"))
            {
                expectedCocktail.Ingredients.Add("Mint");
                label3.Text = "Mint added";
            }
            else
            {
                label3.Text = "Mint should\nnot be added";
            }
            checkIngredientsAndExpected(client.Cocktail, expectedCocktail);
        }

        private void AddClubSoda(object sender, EventArgs e)
        {
            if (client.Cocktail.Ingredients.Contains("Club Soda"))
            {
                expectedCocktail.Ingredients.Add("Club Soda");
                label3.Text = "Club soda added";
            }
            else
            {
                label3.Text = "Club soda should\nnot be added";
            }
            checkIngredientsAndExpected(client.Cocktail, expectedCocktail);
        }

        private void AddIce(object sender, EventArgs e)
        {
            if (client.Cocktail.Ingredients.Contains("Ice"))
            {
                expectedCocktail.Ingredients.Add("Ice");
                label3.Text = "Ice added";
            }
            else
            {
                label3.Text = "Ice should not be added";
            }
            checkIngredientsAndExpected(client.Cocktail, expectedCocktail);
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddJuice(object sender, EventArgs e)
        {
            if (client.Cocktail.Ingredients.Contains("Juice"))
            {
                expectedCocktail.Ingredients.Add("Juice");
                label3.Text = "Juice added";
            }
            else
            {
                label3.Text = "Juice should\nnot be added";
            }
            checkIngredientsAndExpected(client.Cocktail, expectedCocktail);
        }

        private void AddSyrup(object sender, EventArgs e)
        {
            if (client.Cocktail.Ingredients.Contains("Simple Syrup"))
            {
                expectedCocktail.Ingredients.Add("Simple Syrup");
                label3.Text = "Simple Syrup added";
            }
            else
            {
                label3.Text = "Simple Syrup should\nnot be added";
            }
            checkIngredientsAndExpected(client.Cocktail, expectedCocktail);
        }

        private void AddWhiskey(object sender, EventArgs e)
        {
            if (client.Cocktail.Ingredients.Contains("Whiskey"))
            {
                expectedCocktail.Ingredients.Add("Whiskey");
                label3.Text = "Whiskey added";
            }
            else
            {
                label3.Text = "Whiskey should\nnot be added";
            }
            checkIngredientsAndExpected(client.Cocktail, expectedCocktail);
        }

        private void AddJeger(object sender, EventArgs e)
        {
            if (client.Cocktail.Ingredients.Contains("Jagermeister"))
            {
                expectedCocktail.Ingredients.Add("Jagermeister");
                label3.Text = "Jager added";
            }
            else
            {
                label3.Text = "Jager should\nnot be added";
            }
            checkIngredientsAndExpected(client.Cocktail, expectedCocktail);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Refresh();
            label2.Text = "Vodka";
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            Refresh();
            label2.Text = "Tequilla";
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            Refresh();
            label2.Text = "Rum";
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            Refresh();
            label2.Text = "Gin";
        }

        private void button11_MouseHover(object sender, EventArgs e)
        {
            Refresh();
            label2.Text = "Whiskey";
        }

        private void button12_MouseHover(object sender, EventArgs e)
        {
            Refresh();
            label2.Text = "Jegermaister";
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            Refresh();
            label2.Text = "Lemon";
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            Refresh();
            label2.Text = "Club Soda";
        }

        private void button13_MouseHover(object sender, EventArgs e)
        {
            Refresh();
            label2.Text = "Simple Syrup";
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            Refresh();
            label2.Text = "Juice";
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            Refresh();
            label2.Text = "Mint";
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            Refresh();
            label2.Text = "Ice";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void checkIngredientsAndExpected(Cocktail clientCocktail, Cocktail expectedCocktail)
        {
            var clientSet = new HashSet<string>(clientCocktail.Ingredients.Cast<string>());
            var expectedSet = new HashSet<string>(expectedCocktail.Ingredients.Cast<string>());

            if (clientSet.SetEquals(expectedSet))
            {
                this.Close();
                clients.Dequeue();
                Main main = new Main(clients);
                main.Show();
            }
        }
    }
}
