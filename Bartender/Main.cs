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
                label1.Text = client.Name+" ordered "+client.Cocktail.Name;

                
            }
            else
            {
                label1.Text = "Prepare cocktails \nbefore inviting more clients";
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prepare prepare = new Prepare(clients.Peek());

            prepare.Show();
        }
        public static Client returnClientInfo(Client client)
        {
            return client;
        }
    }
}
