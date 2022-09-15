using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace adonetbasics
{
    internal class CRUDWithConfigurationManager
    {
        internal static void EmployeeCRUD()
        {
            //string cs = "Data Source=RAGHUPRASAD;Initial Catalog=flatworldsep2022;Integrated Security=true;";
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = null;
            try
            {
               // SqlConnection con = new SqlConnection(cs);
                using (con = new SqlConnection(cs))
                {
                    //Console.WriteLine("Employee Id: ");
                    //string id = Console.ReadLine();
                    Console.WriteLine("Employee Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Employee Gender: ");
                    string gender = Console.ReadLine();
                    Console.WriteLine("Employee Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Employee Salary: ");
                    decimal salary = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Employee City: ");
                    string city = Console.ReadLine();

                    string query = "insert into employee_tbl values(@name,@gender,@age,@salary,@city)";
                    //string query = "update employee_tbl set name = @name, gender = @gender, age = @age, salary = @salary, city = @city where id = @id";
                    //string query = "delete from employee_tbl where id = @id";
                    //string query = "select sum(salary) from employee_tbl";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@name",name);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@salary", salary);
                    cmd.Parameters.AddWithValue("@city", city);
                    con.Open();
                    int status= cmd.ExecuteNonQuery();
                    if (status>0)
                    {
                        Console.WriteLine("Insertion successful");
                    }
                    else
                    {
                        Console.WriteLine("Insertion failed");
                    }
                    //int a = (int)cmd.ExecuteScalar();
                    //Console.WriteLine(a);
                    //if (a > 0)
                    //{
                    //    Console.WriteLine("Data has been Deleted Successfully.");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Data Deletion Failed..");
                    //}

                    //string query = "spGetEmployees";
                    //SqlCommand cmd = new SqlCommand(query,con);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //con.Open();
                    //SqlDataReader dr = cmd.ExecuteReader();
                    //while(dr.Read())
                    //{
                    //    Console.WriteLine("Id= " + dr["id"] + " Name= " + dr["name"] + " Gender= " + dr["gender"] + " Age= " + dr["age"] + " Salary= " + dr["salary"] + " City= " + dr["city"]);

                    //}
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

