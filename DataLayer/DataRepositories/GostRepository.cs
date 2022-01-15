using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataLayer.DataRepositories
{
    public class GostRepository
    {
        public List<Gost> GetGost()
        {
            List<Gost> list = new List<Gost>();
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string command = "Select * FROM Gosti";
                SqlCommand com = new SqlCommand(command, con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new Gost(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), Convert.ToInt32(dr.GetString(4))));
                }
            }

            return list;
        }

        public int InsertGost(Gost g)
        {
            int result;
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string command = "Insert Into Gosti(BrojLicneKarte, Ime, Prezime, BrojTelefona, BrojSobe) VALUES(@BrojLicneKarte, @Ime, @Prezime, @BrojTelefona, @BrojSobe)";
                SqlCommand com = new SqlCommand(command, con);
                com.Parameters.AddWithValue("@BrojLicneKarte", g.BrojLicneKarte);
                com.Parameters.AddWithValue("@Ime", g.Ime);
                com.Parameters.AddWithValue("@Prezime", g.Prezime);
                com.Parameters.AddWithValue("@BrojTelefona", g.BrojTelefona);
                com.Parameters.AddWithValue("@BrojSobe", g.BrojSobe);
                result = com.ExecuteNonQuery();
            }

            return result;
        }

        public int UpdateGost(Gost g)
        {
            int result;
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string command = "Update Gosti SET Ime= @Ime, Prezime=@Prezime, BrojTelefona=@BrojTelefona, BrojSobe=@BrojSobe where BrojLicneKarte = @BrojLicneKarte";
                SqlCommand com = new SqlCommand(command, con);
                com.Parameters.AddWithValue("@BrojLicneKarte", g.BrojLicneKarte);
                com.Parameters.AddWithValue("@Ime", g.Ime);
                com.Parameters.AddWithValue("@Prezime", g.Prezime);
                com.Parameters.AddWithValue("@BrojTelefona", g.BrojTelefona);
                com.Parameters.AddWithValue("@BrojSobe", g.BrojSobe);
                result = com.ExecuteNonQuery();
            }

            return result;
        }

        public int DeleteGost(string gid)
        {
            int result;
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string command = "Delete From Gosti where BrojLicneKarte=@BrojLicneKarte";
                SqlCommand com = new SqlCommand(command, con);
                com.Parameters.AddWithValue("@BrojLicneKarte", gid);
                result = com.ExecuteNonQuery();
            }

            return result;
        }
    }
}

