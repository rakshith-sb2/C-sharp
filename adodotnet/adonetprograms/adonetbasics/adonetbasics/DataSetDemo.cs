using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetbasics
{
    internal class DataSetDemo
    {
        internal static void demoDataSet()
        {
            Console.WriteLine("Enter Id Of an employee: ");
            int id = Convert.ToInt32(Console.ReadLine());
            string sql = "select * from employee_tbl where id =@id";
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlDataAdapter sda = new SqlDataAdapter();
            //sda.SelectCommand = new SqlCommand("spGetEmployees", con);
            sda.SelectCommand = new SqlCommand(sql, con);
            //sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@id", id);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", row[0], row[1], row[2], row[3], row[4], row[5]);
            }
            /**
            Console.WriteLine("---------DataTable----------------------");

            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", row[0], row[1], row[2], row[3], row[4], row[5]);
            }
            **/
            Console.ReadLine();

        }
    }
    }

