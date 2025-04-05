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
    public partial class Prepare : Form
    {
        private Client client;
        public Prepare(Client client)
        {
            InitializeComponent();
            this.client = client;
            label1.Text = "You are preparing for \n" + client.Name;
        }

        private void AddVodka(object sender, EventArgs e)
        {
            
        }

        private void AddTequila(object sender, EventArgs e)
        {

        }

        private void AddRum(object sender, EventArgs e)
        {

        }

        private void AddGin(object sender, EventArgs e)
        {

        }

        private void AddLemon(object sender, EventArgs e)
        {

        }

        private void AddMint(object sender, EventArgs e)
        {

        }

        private void AddClubSoda(object sender, EventArgs e)
        {

        }

        private void AddIce(object sender, EventArgs e)
        {

        }

        private void Exit(object sender, EventArgs e)
        {

        }

        private void Prepare_Load(object sender, EventArgs e) {

        }

        private void AddJuice(object sender, EventArgs e) {

        }

        private void AddSyrup(object sender, EventArgs e) {

        }

        private void AddWhiskey(object sender, EventArgs e) {

        }

        private void AddJeger(object sender, EventArgs e) {

        }

        private void button1_MouseHover(object sender, EventArgs e) {
            Refresh();
            label2.Text = "Vodka";
        }

        private void button2_MouseHover(object sender, EventArgs e) {
            Refresh();
            label2.Text = "Tequilla";
        }

        private void button3_MouseHover(object sender, EventArgs e) {
            Refresh();
            label2.Text = "Rum";
        }

        private void button4_MouseHover(object sender, EventArgs e) {
            Refresh();
            label2.Text = "Gin";
        }

        private void button11_MouseHover(object sender, EventArgs e) {
            Refresh();
            label2.Text = "Whiskey";
        }

        private void button12_MouseHover(object sender, EventArgs e) {
            Refresh();
            label2.Text = "Jegermaister";
        }

        private void button8_MouseHover(object sender, EventArgs e) {
            Refresh();
            label2.Text = "Lemon";
        }

        private void button5_MouseHover(object sender, EventArgs e) {
            Refresh();
            label2.Text = "Club Soda";
        }

        private void button13_MouseHover(object sender, EventArgs e) {
            Refresh();
            label2.Text = "Simple Syrup";
        }

        private void button10_MouseHover(object sender, EventArgs e) {
            Refresh();
            label2.Text = "Juice";
        }

        private void button6_MouseHover(object sender, EventArgs e) {
            Refresh();
            label2.Text = "Mint";
        }

        private void button7_MouseHover(object sender, EventArgs e) {
            Refresh();
            label2.Text = "Ice";
        }
    }
}
