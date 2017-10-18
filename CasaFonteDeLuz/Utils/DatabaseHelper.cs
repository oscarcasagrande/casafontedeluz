using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;


namespace Utils
{
    public enum DatabaseType
    {
        MySQL = 1,
        SQL = 2
    }

    public static class DatabaseHelper
    {
        static AppSettingsReader reader = new AppSettingsReader();

        static DatabaseType databaseType = DatabaseType.MySQL;

        static DbConnection GetDatabaseConnection()
        {
            DbConnection connection = new SqlConnection();

            switch (databaseType)
            {
                case DatabaseType.MySQL:
                    connection = (MySqlConnection)DatabaseHelperMysql.GetDatabaseConnection();
                    break;
                case DatabaseType.SQL:
                    connection = DatabaseHelperSql.GetDatabaseConnection();
                    break;
                default:
                    throw new Exception("No database defined or defined database is not implemented.");
            }

            return connection;
        }

        public static IDataReader ExecuteReader(List<KeyValuePair<string, object>> parameters, string procedure)
        {
            IDataReader reader = null;

            switch (databaseType)
            {
                case DatabaseType.MySQL:
                    reader = DatabaseHelperMysql.ExecuteReader(parameters, procedure);
                    break;
                case DatabaseType.SQL:
                    reader = DatabaseHelperSql.ExecuteReader(parameters, procedure);
                    break;
                default:
                    break;
            }

            return reader;
        }

        public static object ExecuteNonQuery(List<KeyValuePair<string, object>> parameters, string procedure, Nullable<KeyValuePair<string, object>> outputParameter)
        {
            object result = null;

            switch (databaseType)
            {
                case DatabaseType.MySQL:
                    result = DatabaseHelperMysql.ExecuteNonQuery(parameters, procedure, outputParameter);
                    break;
                case DatabaseType.SQL:
                    result = DatabaseHelperSql.ExecuteNonQuery(parameters, procedure, outputParameter);
                    break;
                default:
                    break;
            }

            return result;
        }

        public static object ExecuteScalar(List<KeyValuePair<string, object>> parameters, string procedure, Nullable<KeyValuePair<string, object>> outputParameter)
        {
            object result = null;

            switch (databaseType)
            {
                case DatabaseType.MySQL:
                    result = DatabaseHelperMysql.ExecuteScalar(parameters, procedure, outputParameter);
                    break;
                case DatabaseType.SQL:
                    result = DatabaseHelperSql.ExecuteScalar(parameters, procedure, outputParameter);
                    break;
                default:
                    break;
            }

            return result;
        }

        public static DataTable ExecuteDataTable(List<KeyValuePair<string, object>> parameters, string procedure)
        {
            DataTable result = new DataTable();

            switch (databaseType)
            {
                case DatabaseType.MySQL:
                    result = DatabaseHelperMysql.ExecuteDataTable(parameters, procedure);
                    break;
                case DatabaseType.SQL:
                    result = DatabaseHelperSql.ExecuteDataTable(parameters, procedure);
                    break;
                default:
                    break;
            }

            return result;
        }
    }

    public static class DatabaseHelperSql
    {
        static AppSettingsReader reader = new AppSettingsReader();

        static string connectionString = reader.GetValue("databaseConnectionString", typeof(string)).ToString();

        public static DbConnection GetDatabaseConnection()
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = connectionString;
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Closed)
                {
                    throw new Exception("Database connection is closed.");
                }
            }

            return connection;
        }

        public static IDataReader ExecuteReader(List<KeyValuePair<string, object>> parameters, string procedure)
        {
            IDataReader reader = null;
            IDbCommand command = null;
            try
            {
                using (command = new SqlCommand(procedure, (SqlConnection)GetDatabaseConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    foreach (var p in parameters)
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = p.Key;
                        param.Value = p.Value;
                        param.SqlDbType = TypeToSqlDbType(p.Value.GetType());
                        command.Parameters.Add(param);
                    }
                    reader = command.ExecuteReader();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
            }

            return reader;
        }

        public static object ExecuteNonQuery(List<KeyValuePair<string, object>> parameters, string procedure, Nullable<KeyValuePair<string, object>> outputParameter)
        {
            IDbCommand command = null;
            object result = null;

            try
            {

                using (command = new SqlCommand(procedure, (SqlConnection)GetDatabaseConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    foreach (var p in parameters)
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = p.Key;
                        param.Value = p.Value;
                        param.SqlDbType = TypeToSqlDbType(p.Value.GetType());
                        command.Parameters.Add(param);
                    }


                    SqlParameter outputParam = new SqlParameter();
                    if (outputParameter.HasValue)
                    {
                        outputParam.ParameterName = outputParameter.Value.Key;
                        outputParam.Value = outputParameter.Value.Value;
                        outputParam.SqlDbType = TypeToSqlDbType(outputParameter.Value.Value.GetType());
                        outputParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(outputParam);
                    }

                    result = command.ExecuteNonQuery();

                    if (outputParam.Value != DBNull.Value)
                    {
                        result = outputParam.Value;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Dispose();
            }

            return result;
        }

        public static object ExecuteScalar(List<KeyValuePair<string, object>> parameters, string procedure, Nullable<KeyValuePair<string, object>> outputParameter)
        {
            IDbCommand command = null;
            object result = null;

            try
            {

                using (command = new SqlCommand(procedure, (SqlConnection)GetDatabaseConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    foreach (var p in parameters)
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = p.Key;
                        param.Value = p.Value;
                        param.SqlDbType = TypeToSqlDbType(p.Value.GetType());
                        command.Parameters.Add(param);
                    }

                    SqlParameter outputParam = new SqlParameter();
                    if (outputParameter.HasValue)
                    {
                        outputParam.ParameterName = outputParameter.Value.Key;
                        outputParam.Value = outputParameter.Value.Value;
                        outputParam.SqlDbType = TypeToSqlDbType(outputParameter.Value.Value.GetType());
                        outputParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(outputParam);
                    }

                    result = command.ExecuteScalar();

                    if (outputParam.Value != DBNull.Value)
                    {
                        result = outputParam.Value;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Dispose();
            }

            return result;
        }

        public static DataTable ExecuteDataTable(List<KeyValuePair<string, object>> parameters, string procedure)
        {
            DataTable result = new DataTable();
            IDbCommand command = null;
            IDataReader reader = null;

            try
            {
                using (command = new SqlCommand(procedure, (SqlConnection)GetDatabaseConnection()))
                {
                    using (reader = command.ExecuteReader())
                    {
                        result.Load(reader);
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                command.Dispose();
                reader.Dispose();
            }

            return result;
        }

        private static SqlDbType TypeToSqlDbType(Type t)
        {
            String name = t.Name;
            SqlDbType result = SqlDbType.VarChar; // default value
            try
            {
                if (name.Contains("16") || name.Contains("32") || name.Contains("64"))
                {
                    name = name.Substring(0, name.Length - 2);
                }
                result = (SqlDbType)Enum.Parse(typeof(SqlDbType), name, true);
            }
            catch (Exception)
            {
                // add error handling to suit your taste
            }

            return result;
        }
    }

    public static class DatabaseHelperMysql
    {
        static AppSettingsReader reader = new AppSettingsReader();

        static string connectionString = reader.GetValue("mySqlDatabaseConnectionString", typeof(string)).ToString();

        public static DbConnection GetDatabaseConnection()
        {
            MySqlConnection connection = new MySqlConnection();

            try
            {
                connection.ConnectionString = connectionString;
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Closed)
                {
                    throw new Exception("Database MySQL connection is closed.");
                }
            }

            return connection;

        }

        public static IDataReader ExecuteReader(List<KeyValuePair<string, object>> parameters, string procedure)
        {
            IDataReader reader = null;
            IDbCommand command = null;
            try
            {
                using (command = new MySqlCommand(procedure, (MySqlConnection)GetDatabaseConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    foreach (var p in parameters)
                    {
                        MySqlParameter param = new MySqlParameter();
                        param.ParameterName = p.Key;
                        param.Value = p.Value;
                        param.MySqlDbType = TypeToMySqlDbType(p.Value.GetType());
                        command.Parameters.Add(param);
                    }
                    reader = command.ExecuteReader();
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
            }

            return reader;
        }

        public static object ExecuteNonQuery(List<KeyValuePair<string, object>> parameters, string procedure, Nullable<KeyValuePair<string, object>> outputParameter)
        {
            IDbCommand command = null;
            object result = null;

            try
            {

                using (command = new MySqlCommand(procedure, (MySqlConnection)GetDatabaseConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    foreach (var p in parameters)
                    {
                        MySqlParameter param = new MySqlParameter();
                        param.ParameterName = p.Key;
                        param.Value = p.Value;
                        param.MySqlDbType = TypeToMySqlDbType(p.Value.GetType());
                        command.Parameters.Add(param);
                    }


                    MySqlParameter outputParam = new MySqlParameter();
                    if (outputParameter.HasValue)
                    {
                        outputParam.ParameterName = outputParameter.Value.Key;
                        outputParam.Value = outputParameter.Value.Value;
                        outputParam.MySqlDbType = TypeToMySqlDbType(outputParameter.Value.Value.GetType());
                        outputParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(outputParam);
                    }

                    result = command.ExecuteNonQuery();

                    if (outputParam.Value != DBNull.Value)
                    {
                        result = outputParam.Value;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Dispose();
            }

            return result;
        }

        public static object ExecuteScalar(List<KeyValuePair<string, object>> parameters, string procedure, Nullable<KeyValuePair<string, object>> outputParameter)
        {
            IDbCommand command = null;
            object result = null;

            try
            {

                using (command = new MySqlCommand(procedure, (MySqlConnection)GetDatabaseConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    foreach (var p in parameters)
                    {
                        MySqlParameter param = new MySqlParameter();
                        param.ParameterName = p.Key;
                        param.Value = p.Value;
                        param.MySqlDbType = TypeToMySqlDbType(p.Value.GetType());
                        command.Parameters.Add(param);
                    }

                    MySqlParameter outputParam = new MySqlParameter();
                    if (outputParameter.HasValue)
                    {
                        outputParam.ParameterName = outputParameter.Value.Key;
                        outputParam.Value = outputParameter.Value.Value;
                        outputParam.MySqlDbType = TypeToMySqlDbType(outputParameter.Value.Value.GetType());
                        outputParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(outputParam);
                    }

                    result = command.ExecuteScalar();

                    if (outputParam.Value != DBNull.Value)
                    {
                        result = outputParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
            }

            return result;
        }

        public static DataTable ExecuteDataTable(List<KeyValuePair<string, object>> parameters, string procedure)
        {
            DataTable result = new DataTable();
            IDbCommand command = null;
            IDataReader reader = null;

            try
            {
                using (command = new MySqlCommand(procedure, (MySqlConnection)GetDatabaseConnection()))
                {
                    using (reader = command.ExecuteReader())
                    {
                        result.Load(reader);
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                command.Dispose();
                reader.Dispose();
            }

            return result;
        }

        private static MySqlDbType TypeToMySqlDbType(Type t)
        {
            String name = t.Name;
            MySqlDbType result = MySqlDbType.VarChar; // default value
            try
            {
                if (name.Contains("16") || name.Contains("32") || name.Contains("64"))
                {
                    name = name.Substring(0, name.Length - 2);
                }
                result = (MySqlDbType)Enum.Parse(typeof(MySqlDbType), name, true);
            }
            catch (Exception)
            {
                // add error handling to suit your taste
            }

            return result;
        }
    }
}
