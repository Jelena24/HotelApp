using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HotelApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Gost> list = new List<Gost>();
            GostBusiness gostBusiness = new GostBusiness();
            list = gostBusiness.GetGost();
            listBox1.Items.Add("Informacije o gostima:\n");
            foreach (Gost g in list)
            {
                listBox1.Items.Add(g.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gost g = new Gost(textBoxBrojLicneKarte.Text, textBoxIme.Text, textBoxPrezime.Text, textBoxBrojTelefona.Text, Convert.ToInt32(textBoxBrojSobe.Text));
            List<Gost> lista = new List<Gost>();
            GostBusiness gostBusiness = new GostBusiness();
            lista = gostBusiness.GetGost();
            if (gostBusiness.InsertGost(g) == true)
                MessageBox.Show("Valid");
            else
                MessageBox.Show("Invalid");
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Gost> list = new List<Gost>();
            GostBusiness gostBusiness = new GostBusiness();
            list = gostBusiness.GetGost().Where(x => x.BrojSobe == Convert.ToInt32(textBoxBrojSobe.Text)).ToList();
            listBox1.Items.Add("Informacije o gostima:\n");
            foreach (Gost g in list)
            {
                listBox1.Items.Add(g.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gost g = new Gost();
            GostBusiness gostBusiness = new GostBusiness();
            string gid = textBoxBrojLicneKarte.Text;
            if (gostBusiness.DeleteGost(gid) == true)
                MessageBox.Show("Guest is deleted successfully!");
            else
                MessageBox.Show("Guest is not deleted!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
                Form3 f = new Form3();
                f.Show();
                this.Hide();   
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            GostBusiness gostBusiness = new GostBusiness();
            Gost g = new Gost(textBoxBrojLicneKarte.Text, textBoxIme.Text, textBoxPrezime.Text, textBoxBrojTelefona.Text, Convert.ToInt32(textBoxBrojSobe.Text));
            if (gostBusiness.UpdateGost(g) == true)
            {
                gostBusiness.UpdateGost(g);
                MessageBox.Show("You have changed successfully information about a guest!");
            }

            else
                MessageBox.Show("You haven't succeed in!");
        }
    }
}
