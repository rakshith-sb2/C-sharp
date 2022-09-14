using System.Data.SqlClient;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Connection();
    }

    static void Connection()
    {
        string cs = "Data Source=RAGHUPRASAD;Initial Catalog=flatworldsep2022;Integrated Security=true;";
        SqlConnection con = new SqlConnection(cs);
        try
        {
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Connection has beeen successfully created");
            }
        }catch(SqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            con.Close();
        }
    }
}