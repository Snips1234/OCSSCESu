using MySql.Data.MySqlClient;
using OCSSCESu.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCSSCESu.helper
{
    public class AsyncCRUD
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

        public async Task<bool> ExecuteNonQueryAsync(string sqlQuery, bool clearParams)
        {
            using (MySqlConnection connection = DatabaseHelper.DatabaseConnection())
            {
                if (connection != null)
                {
                    try
                    {

                        using (MySqlTransaction transaction = await connection.BeginTransactionAsync().ConfigureAwait(false))
                        {
                            try
                            {
                                using (MySqlCommand command = new MySqlCommand(sqlQuery, connection, transaction))
                                {
                                    if (sqlParameters?.Count > 0)
                                    {
                                        command.Parameters.AddRange(sqlParameters.ToArray());
                                    }

                                    int rowsAffected = await command.ExecuteNonQueryAsync().ConfigureAwait(false);
                                    await transaction.CommitAsync().ConfigureAwait(false);

                                    if (clearParams) sqlParameters.Clear();

                                    return rowsAffected > 0;
                                }
                            }
                            catch (Exception ex)
                            {
                                await transaction.RollbackAsync().ConfigureAwait(false);
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
                Console.WriteLine("Failed to establish a database connection.");
                return false;
            }
        }

        public async Task<DataTable> ReadDataAsync(string sqlQuery, bool clearParams)
        {
            dt = new DataTable();

            using (MySqlConnection connection = DatabaseHelper.DatabaseConnection())
            {
                if (connection != null)
                {
                    try
                    {

                        using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                        {
                            if (sqlParameters?.Count > 0)
                            {
                                command.Parameters.AddRange(sqlParameters.ToArray());
                            }

                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                            {
                                DbDataAdapter dbAdapter = adapter;
                                await Task.Run(() => dbAdapter.Fill(dt)).ConfigureAwait(false); 
                            }

                            if (clearParams) sqlParameters.Clear();
                            return dt.Rows.Count > 0 ? dt : null;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error while reading data: {ex.Message}");
                        return null;
                    }
                }

                Console.WriteLine("Failed to establish a database connection.");
                return null;
            }
        }

        public async Task<int> ExecuteScalarHelperAsync(string query)
        {
            using (MySqlConnection connection = DatabaseHelper.DatabaseConnection())
            {
                if (connection != null)
                {
                    try
                    {

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            if (sqlParameters?.Count > 0)
                            {
                                command.Parameters.AddRange(sqlParameters.ToArray());
                            }

                            object result = await command.ExecuteScalarAsync().ConfigureAwait(false);
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

        public async Task<bool> CallStoredProcedureAsync(string storedProcedureName, bool clearParams)
        {
            using (MySqlConnection connection = DatabaseHelper.DatabaseConnection())
            {
                if (connection != null)
                {
                    try
                    {

                        using (MySqlTransaction transaction = await connection.BeginTransactionAsync().ConfigureAwait(false))
                        {
                            try
                            {
                                using (MySqlCommand command = new MySqlCommand(storedProcedureName, connection, transaction))
                                {
                                    command.CommandType = CommandType.StoredProcedure;

                                    if (sqlParameters?.Count > 0)
                                    {
                                        command.Parameters.AddRange(sqlParameters.ToArray());
                                    }

                                    await command.ExecuteNonQueryAsync().ConfigureAwait(false);
                                    await transaction.CommitAsync().ConfigureAwait(false);

                                    if (clearParams) sqlParameters.Clear();

                                    return true;
                                }
                            }
                            catch (Exception spCall)
                            {
                                await transaction.RollbackAsync().ConfigureAwait(false);
                                SystemSounds.Hand.Play();
                                MessageBox.Show("An error occurred while calling a STORED PROCEDURE.", "SOMETHING WENT WRONG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Console.WriteLine($"CallStoredProcedure Error: {spCall.Message}");
                                return false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        SystemSounds.Hand.Play();
                        MessageBox.Show("Error starting transaction.", "SOMETHING WENT WRONG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine($"CallStoredProcedure Error: {ex.Message}");
                        return false;
                    }
                }

                Console.WriteLine("Failed to establish a database connection.");
                return false;
            }
        }
    }
}
