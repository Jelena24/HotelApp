using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Web.UI.HtmlControls;

namespace HotelWebApplication
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void getId_ServerClick(object sender, EventArgs e)
        {
            List<Gost> lista = new List<Gost>();
            GostBusiness gostBusiness = new GostBusiness();
            lista = gostBusiness.GetGost();
            HtmlGenericControl guestList = new HtmlGenericControl("UL");
            foreach(Gost g in lista)
            {
                HtmlGenericControl guest = new HtmlGenericControl("LI");
                guest.InnerText = g.ToString();
                guestList.Controls.Add(guest);
            }

            allguests.Controls.Add(guestList);
        }

        protected void checkInId_ServerClick(object sender, EventArgs e)
        {
            GostBusiness gostBusiness = new GostBusiness();
            string brojLicneKarte = BrojLicneKarte.Value;
            string ime = Ime.Value;
            string prezime = Prezime.Value;
            string brojTelefona = BrojTelefona.Value;
            int brojSobe = Convert.ToInt32(BrojSobe.Value);
            Gost g = new Gost(brojLicneKarte, ime, prezime, brojTelefona, brojSobe);
            gostBusiness.InsertGost(g);
        }

        protected void updateId_ServerClick(object sender, EventArgs e)
        {
            GostBusiness gostBusiness = new GostBusiness();
            string brojLicneKarte = BrojLicneKarte.Value;
            string ime = Ime.Value;
            string prezime = Prezime.Value;
            string brojTelefona = BrojTelefona.Value;
            int brojSobe = Convert.ToInt32(BrojSobe.Value);
            Gost g = new Gost(brojLicneKarte, ime, prezime, brojTelefona, brojSobe);
            gostBusiness.UpdateGost(g);
        }

        protected void deleteId_ServerClick(object sender, EventArgs e)
        {
            GostBusiness gostBusiness = new GostBusiness();
            string brojLicneKarte = BrojLicneKarte.Value;
            gostBusiness.DeleteGost(brojLicneKarte);
        }
    }
}