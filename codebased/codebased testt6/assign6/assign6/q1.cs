using System.Data;

using System.Data.SqlClient;
class Program

{
    private static object employeeTable;

    static void Main(string[] args)

    {

        // Connection string for your SQL Server database

        string connectionString = "Data Source=ICS-LT-987J8G3;Initial Catalog=exam;Integrated Security=True";


        // Assuming you have a SqlConnection connection already set up



        // Insert a new employee using the stored procedure

        using (SqlCommand cmd = new SqlCommand("AddEmployee", connection))

        {

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@empname", "Jane Smith");

            cmd.Parameters.AddWithValue("@empsal", 28000.50);

            cmd.Parameters.AddWithValue("@emptype", "P");



            connection.Open();

            cmd.ExecuteNonQuery();

            connection.Close();

        }



        // Display all records

        using (SqlCommand cmd = new SqlCommand("SELECT * FROM CodeEmployee", connection))

        {

            connection.Open();

            using (SqlDataReader reader = cmd.ExecuteReader())

            {

                while (reader.Read())

                {

                    Console.WriteLine($"{reader["empno"]}, {reader["empname"]}, {reader["empsal"]}, {reader["emptype"]}");

                }

            }

            connection.Close();

        }
    }
}