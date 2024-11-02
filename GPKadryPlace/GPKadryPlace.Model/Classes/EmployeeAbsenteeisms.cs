using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace GPKadryPlace.Model
{
    public class EmployeeAbsenteeisms : List<EmployeeAbsenteeism>
    {
        private string _connectionString;

        public EmployeeAbsenteeisms(string connectionString)
        {
            _connectionString = connectionString;
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT [ID_employee_absenteeism], [short_name], [name], [avilable] FROM [dbo].[employee_absenteeism]";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmployeeAbsenteeism absenteeism = new EmployeeAbsenteeism
                            {
                                IDEmployeeAbsenteeism = reader.GetInt32(0),
                                ShortName = reader.GetString(1),
                                Name = reader.GetString(2),
                                Available = reader.GetBoolean(3)
                            };
                            this.Add(absenteeism);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (log error, rethrow, etc.)
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
