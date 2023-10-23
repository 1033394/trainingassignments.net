using System;

using System.Data;

using System.Data.SqlClient;

 

class Program

{

    static void Main(string[] args)

    {

        // Connection string for your SQL Server database

        string connectionString = "Data Source=YourServer;Initial Catalog=YourDatabase;Integrated Security=True";



        // Create a SQL connection

        using (SqlConnection connection = new SqlConnection(connectionString))

        {

            try

            {

                connection.Open();



                // Step 2: Retrieve employees from Department 19

                string selectQuery = "SELECT EmployeeID, Salary FROM Employees WHERE DepartmentID = 10";



                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))

                {

                    using (SqlDataAdapter adapter = new SqlDataAdapter(selectCommand))

                    {

                        DataTable employeesTable = new DataTable();

                        adapter.Fill(employeesTable);



                        // Step 3: Update salaries by 15%

                        foreach (DataRow row in employeesTable.Rows)

                        {

                            int employeeID = Convert.ToInt32(row["EmployeeID"]);

                            decimal currentSalary = Convert.ToDecimal(row["Salary"]);

                            decimal updatedSalary = currentSalary * 1.15M; // Increase salary by 15%



                            // Step 4: Execute update SQL command

                            string updateQuery = "UPDATE Employees SET Salary = @UpdatedSalary WHERE EmployeeID = @EmployeeID";



                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))

                            {

                                updateCommand.Parameters.AddWithValue("@UpdatedSalary", updatedSalary);

                                updateCommand.Parameters.AddWithValue("@EmployeeID", employeeID);



                                int rowsAffected = updateCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)

                                {

                                    Console.WriteLine($"Employee ID {employeeID}: Salary updated to {updatedSalary:C}");

                                }

                            }

                        }

                    }

                }

            }

            catch (Exception ex)

            {

                Console.WriteLine("Error: " + ex.Message);

            }

            finally

            {

                connection.Close();

            }

        }

    }

}

