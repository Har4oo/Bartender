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

                Client client = new Client();

                client.assignRandomName();

                client.Cocktail = cocktail;

                richTextBox1.AppendText(client.Name + " : " + client.Cocktail.Name + "\n");

                clients.Enqueue(client);

            }
            else
            {
                label1.Text = "Prepare cocktails \nbefore inviting more clients";
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prepare prepare = new Prepare();

            prepare.Show();
        }
    }
}
