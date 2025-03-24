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
            Cocktail cocktail = new Cocktail();

            cocktail.assignCocktail();

            Client client = new Client();

            client.Name = "Gosho";
            client.Cocktail = cocktail;

            richTextBox1.AppendText(client.Name + " : " + client.Cocktail.Name + "\n");
            
            
        }
    }
}
