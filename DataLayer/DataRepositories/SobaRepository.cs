using DataLayer.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataLayer.DataRepositories
{
    public class SobaRepository
    {
        public List<Soba> GetSoba()
        {
            List<Soba> list = new List<Soba>();
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string command = "Select * FROM Sobe";
                SqlCommand com = new SqlCommand(command, con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new Soba(dr.GetInt32(0), dr.GetInt32(1), dr.GetInt32(2), dr.GetInt32(3)));
                }
            }
            return list;
        }

        public int InsertSoba(Soba s)
        {
            int result;
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string command = "Insert Into Sobe(BrojSobe, BrojSprata, BrojOsoba, Kvadratura) VALUES(@BrojSobe, @BrojSprata, @BrojOsoba, @Kvadratura)";
                SqlCommand com = new SqlCommand(command, con);
                com.Parameters.AddWithValue("@BrojSobe", s.BrojSobe);
                com.Parameters.AddWithValue("@BrojSprata", s.BrojSprata);
                com.Parameters.AddWithValue("@BrojOsoba", s.BrojOsoba);
                com.Parameters.AddWithValue("@Kvadratura", s.Kvadratura);
                result = com.ExecuteNonQuery();
            }

            return result;
        }

        public int UpdateSoba(Soba s)
        {
            int result;
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string command = "Update Sobe SET BrojSprata= @BrojSprata, BrojOsoba=@BrojOsoba, Kvadratura=@Kvadratura where BrojSobe =@BrojSobe";
                SqlCommand com = new SqlCommand(command, con);
                com.Parameters.AddWithValue("@BrojSobe", s.BrojSobe);
                com.Parameters.AddWithValue("@BrojSprata", s.BrojSprata);
                com.Parameters.AddWithValue("@BrojOsoba", s.BrojOsoba);
                com.Parameters.AddWithValue("@Kvadratura", s.Kvadratura);
                result = com.ExecuteNonQuery();
            }

            return result;
        }

        public int DeleteSoba(int sid)
        {
            int result;
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string command = "Delete From Sobe where BrojSobe=@BrojSobe";
                SqlCommand com = new SqlCommand(command, con);
                com.Parameters.AddWithValue("@BrojSobe", sid);
                result = com.ExecuteNonQuery();
            }

            return result;
        }
    }
}