using adonetbasics;
using System;
using System.Data.SqlClient;

// Multiple delegates
public delegate void Calculate(int n1, int n2);
public delegate void Display();

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("ADO .NET");
        //Connection();
        //BasicCRUD.GetConnection();       
        //BasicCRUD.ReadData();
        //BasicCRUD.InsertData();
        //BasicCRUD.UpdateData();
        //       CRUDWithConfigurationManager.EmployeeCRUD();
        // Single Cast Delegate
        Calculate obj = new Calculate(DelegateDemo.Addition);
        obj.Invoke(10,20);

        obj = new Calculate(DelegateDemo.Multiplication);
        obj.Invoke(10, 20);
        obj = DelegateDemo.Division;
        obj(10, 5);

        Display dsp = new Display(DelegateDemo.show);
        dsp();
        Console.WriteLine("Multi Cast Delegate");
        // Multi cast delegates
        Calculate objmul = new Calculate(DelegateDemo.Addition);
        objmul += DelegateDemo.Multiplication;
        objmul(10,5);
        AnonymousNLambdaFunctions.AnonymousDemo();
        EventDemo.testEvent();
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