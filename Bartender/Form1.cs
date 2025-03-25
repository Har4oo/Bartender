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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Lines.Count() < 6)
            {
                Cocktail cocktail = new Cocktail();

                cocktail.assignCocktail();

                Client client = new Client();

                client.assignRandomName();

                client.Cocktail = cocktail;

                richTextBox1.AppendText(client.Name + " : " + client.Cocktail.Name + "\n");

            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
