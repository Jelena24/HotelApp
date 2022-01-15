using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;

namespace HotelWebApplication
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_ServerClick(object sender, EventArgs e)
        {
            string email = emailId.Value;
            string password = passwordId.Value;
            RadnikBusiness radnikBusiness = new RadnikBusiness();
            List<Radnik> lista = new List<Radnik>();
            lista = radnikBusiness.GetRadnik();
            foreach (Radnik r in lista)
            {
                if ((email == r.Email || email==r.Username) && password == r.Password)
                {
                    Response.Redirect("Home.aspx");
                }
            }
        }
    }
}