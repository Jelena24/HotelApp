using DataLayer.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataLayer.DataRepositories
{
    public class RadnikRepository
    {
        public List<Radnik> GetRadnik()
        {
            List<Radnik> list = new List<Radnik>();
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string command = "Select * FROM Radnici";
                SqlCommand com = new SqlCommand(command, con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new Radnik(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7)));
                }
            }
            return list;
        }

        public int InsertRadnik(Radnik r)
        {
            int result;
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string command = "Insert Into Radnici(BrojLicneKarte, Ime, Prezime, BrojTelefona, StrucnaSprema, Username, Email, Password) VALUES(@BrojLicneKarte, @Ime, @Prezime, @BrojTelefona, @StrucnaSprema, @Username, @Email, @Password)";
                SqlCommand com = new SqlCommand(command, con);
                com.Parameters.AddWithValue("@BrojLicneKarte", r.BrojLicneKarte);
                com.Parameters.AddWithValue("@Ime", r.Ime);
                com.Parameters.AddWithValue("@Prezime", r.Prezime);
                com.Parameters.AddWithValue("@BrojTelefona", r.BrojTelefona);
                com.Parameters.AddWithValue("@StrucnaSprema", r.StrucnaSprema);
                com.Parameters.AddWithValue("@Username", r.Username);
                com.Parameters.AddWithValue("@Email", r.Email);
                com.Parameters.AddWithValue("@Password", r.Password);
                result = com.ExecuteNonQuery();
            }

            return result;
        }

        public int UpdateRadnik(Radnik r)
        {
            int result;
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cons))
            {
                string command = "Update Radnici SET Ime= @Ime, Prezime=@Prezime, BrojTelefona=@BrojTelefona, StrucnaSprema=@StrucnaSprema, Username=@Username, Password=@Password, Email=@Email where BrojLicneKarte =@BrojLicneKarte";
                SqlCommand com = new SqlCommand(command, con);
                com.Parameters.AddWithValue("@Ime", r.Ime);
                com.Parameters.AddWithValue("@Prezime", r.Prezime);
                com.Parameters.AddWithValue("@BrojTelefona", r.BrojTelefona);
                com.Parameters.AddWithValue("@StrucnaSprema", r.StrucnaSprema);
                com.Parameters.AddWithValue("@Username", r.Username);
                com.Parameters.AddWithValue("@Email", r.Email);
                com.Parameters.AddWithValue("@Password", r.Password);
                result = com.ExecuteNonQuery();
            }

            return result;
        }

        public int DeleteRadnik(string rid)
        {
            int result;
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string command = "Delete From Radnici where BrojLicneKarte=@BrojLicneKarte";
                SqlCommand com = new SqlCommand(command, con);
                com.Parameters.AddWithValue("@BrojLicneKarte", rid);
                result = com.ExecuteNonQuery();
            }

            return result;
        }
    }
}