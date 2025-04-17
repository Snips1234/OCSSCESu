using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using OCSSCESu.helper;
using System.Media;
using OCSSCESu.Helper;

namespace OCSSCESu.helper
{

    public class CRUD
    {

        public DataTable dt = new DataTable();
        public List<MySqlParameter> sqlParameters = new List<MySqlParameter>();


        public void ClearSqlParameters()
        {
           sqlParameters.Clear();
        }

        public void AddParameters(string name, object value, DbType type = DbType.String)
        {
            var parameter = new MySqlParameter
            {
                ParameterName = name,
                Value = value,
                DbType = type
            };

            sqlParameters.Add(parameter);
        }

        public bool ExecuteNonQuery(string sqlQuery, bool clearParams)
        {
            using (MySqlConnection connection = DatabaseHelper.DatabaseConnection())
            {
                if (connection != null)
                {
                    try
                    {
                        using (MySqlTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                using (MySqlCommand command = new MySqlCommand(sqlQuery, connection, transaction))
                                {
                                    if (sqlParameters != null && sqlParameters.Count > 0)
                                    {
                                        command.Parameters.AddRange(sqlParameters.ToArray());
                                    }

                                    int rowsAffected = command.ExecuteNonQuery();

                                    transaction.Commit();

                                    if (clearParams)
                                    {
                                       sqlParameters.Clear();
                                    }

                                    return rowsAffected > 0;
                                }
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                Console.WriteLine("Error during database operation: " + ex.Message);
                                return false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error starting transaction: " + ex.Message);
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Failed to establish a database connection.");
                    return false;
                }
            }
        }


        public DataTable ReadData(string sqlQuery, bool clearParams)
        {

            dt = new DataTable() ;

            using (MySqlConnection connection = DatabaseHelper.DatabaseConnection())
            {
                if (connection != null)
                {
                    try
                    {
                        using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                        {

                            if (sqlParameters != null && sqlParameters.Count > 0)
                            {
                                command.Parameters.AddRange(sqlParameters.ToArray());
                            }

                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                            {
                                adapter.Fill(dt);
                            }
                            

                            if (clearParams)
                            {
                                sqlParameters.Clear();
                            }


                            if (dt.Rows.Count == 0)
                            {
                                return null;
                            }

                            return dt;

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error while reading data: {ex.Message}");
                        return null;
                    }
                }
                else
                {
                    Console.WriteLine("Failed to establish a database connection.");
                    return null;
                }
             
            }
        }

        public int ExecuteScalarHelper(string query)
        {
            using (MySqlConnection connection = DatabaseHelper.DatabaseConnection())
            {
                if (connection != null)
                {
                    try
                    {
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            if (sqlParameters != null &&sqlParameters.Count > 0)
                            {
                                command.Parameters.AddRange(sqlParameters.ToArray());
                            }

                            object result = command.ExecuteScalar();
                            return Convert.ToInt32(result);
                        }
                    }
                    finally
                    {
                        sqlParameters?.Clear(); 
                    }
                }
                throw new Exception("Failed to establish database connection");
            }
        }

        public bool CallStoredProcedure(string storedProcedureName, bool clearParams)
        {
            using (MySqlConnection connection = DatabaseHelper.DatabaseConnection())
            {
                if (connection != null)
                {
                    try
                    {
                        using (MySqlTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                using (MySqlCommand command = new MySqlCommand(storedProcedureName, connection, transaction))
                                {
                                    command.CommandType = CommandType.StoredProcedure;
                                    if (sqlParameters != null && sqlParameters.Count > 0)
                                    {
                                        command.Parameters.AddRange(sqlParameters.ToArray());
                                    }

                                    command.ExecuteNonQuery();
                                }

                                transaction.Commit();

                                if (clearParams)
                                {
                                    sqlParameters.Clear();
                                }

                                return true;

                               
                            }
                            catch (Exception spCall)
                            {
                                if (transaction != null)
                                {
                                    transaction.Rollback();
                                }

                                SystemSounds.Hand.Play();
                                MessageBox.Show("An error occur while calling a STORED PROCEDURE.", "SOMETHIGN WENT WRONG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Console.WriteLine($"CallStoredProcedure Error: {spCall.Message}");

                                return false;
                            }
                        }
                    }
                    catch (Exception startingTransaction)
                    {
                        SystemSounds.Hand.Play();
                        MessageBox.Show("Error starting transaction.", "SOMETHIGN WENT WRONG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine($"CallStoredProcedure Error: {startingTransaction.Message}");
                        return false;
                    }

                }
                else
                {
                    Console.WriteLine("Failed to establish a database connection.");
                    return false;
                }
            }
        }
    }
}
