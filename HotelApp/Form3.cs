using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Soba> list = new List<Soba>();
            SobaBusiness gostBusiness = new SobaBusiness();
            list = gostBusiness.GetSoba();
            listBox1.Items.Add("Information about rooms:\n");
            foreach (Soba s in list)
            {
                listBox1.Items.Add(s.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SobaBusiness sobaBusiness = new SobaBusiness();
            Soba s = new Soba(Convert.ToInt32(textBoxBrojSobe.Text), Convert.ToInt32(textBoxBrojSprata.Text), Convert.ToInt32(textBoxBrojOsoba.Text), Convert.ToInt32(textBoxKvadratura.Text));
            if (sobaBusiness.UpdateSoba(s) == true)
            {
                sobaBusiness.UpdateSoba(s);
                MessageBox.Show("You have changed successfully information about the room!");
            }

            else
                MessageBox.Show("You haven't succeed in!");
        }
    }
}
