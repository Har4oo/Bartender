using System;
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
    public partial class Main : Form
    {
        private Client client;
        private Queue<Client> clients = new Queue<Client>();
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(clients.Count > 4))
            {
                Cocktail cocktail = new Cocktail();

                cocktail.assignCocktail();

                client = new Client();

                client.assignRandomName();

                client.Cocktail = cocktail;

                richTextBox1.AppendText(client.Name + " : " + client.Cocktail.Name + "\n");

                richTextBox1.SelectAll();
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

                clients.Enqueue(client);
                label1.Text = client.Name+" ordered \n"+client.Cocktail.Name;

                client.Cocktail.assignCocktailIngredients();
            }
            else
            {
                label1.Text = "Prepare cocktails \nbefore \ninviting more clients";
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clients.Count <= 0) {
                label1.Text = "Invite some clients";
            } else {
                Prepare prepare = new Prepare(clients.Peek());

                prepare.Show();
            }
        }
        public static Client returnClientInfo(Client client)
        {
            return client;
        }

        private void button3_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
