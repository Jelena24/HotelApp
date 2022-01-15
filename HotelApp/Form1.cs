using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Radnik> lista = new List<Radnik>();
            RadnikBusiness radnikBusiness = new RadnikBusiness();
            lista = radnikBusiness.GetRadnik();
            foreach (Radnik r in lista)
            {
                if ((textBox1.Text == r.Username || textBox1.Text == r.Email) && textBox2.Text == r.Password)
                {
                    Form2 f = new Form2();
                    f.Show();
                    this.Hide();
                }
             
            }
        }
    }
}
