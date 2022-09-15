using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetbasics
{
    internal class BasicCRUD
    {
        internal static SqlConnection GetConnection()
        {
            string cs = "Data Source=RAGHUPRASAD;Initial Catalog=flatworldsep2022;Integrated Security=true;";
            SqlConnection con = new SqlConnection(cs);
            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Connection has been created successfully");
                }
                else
                {
                    Console.WriteLine("Failed to establish the connection");
                }

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
               // con.Close();
            }
            return con;

        }

        internal static void ReadData()
        {
            string query = "select * from products";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Code: " + dr[0] +" Name : " + dr[1] +" Manufacturer :" + dr[2]+ " Price : " + dr[3]);
            }
            conn.Close();
        }

        internal static void InsertData()
        {
            string query = "insert into products values (2,'TV','Sony',60000)";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataReader dr = cmd.ExecuteReader();
            int status = cmd.ExecuteNonQuery();
            if (status>0)
            {
                Console.WriteLine("Insertion successful");
            }
            else
            {
                Console.WriteLine("Insertion failed");
            }
            conn.Close();
        }


        internal static void UpdateData()
        {

            Console.WriteLine("Update Data");
            Console.WriteLine("Enter product code to update price");
            int code = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter updated price");

            decimal price = Convert.ToDecimal(Console.ReadLine());
            
            string query = "update products set price = @price where code=@code";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataReader dr = cmd.ExecuteReader();
            // int status = cmd.ExecuteNonQuery();
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@price", price);
            //int status = (int)cmd.ExecuteScalar();
            int status = cmd.ExecuteNonQuery();
            if (status > 0)
            {
                Console.WriteLine("Updated successful");
            }
            else
            {
                Console.WriteLine("Updation failed");
            }
            conn.Close();
        }

    }


}
