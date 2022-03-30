using GRC.Connect.Libraries.CoreLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRC.Connect.Libraries.PowerBILib
{
    public class DataContext
    {
        private static string ConnectionString
        {
            get
            {
                return UtilDB.ConnectionString;
            }
        }
        
        //Main Methods
        internal static DataTable Execute(string commandName, CommandType commandType, params SqlParameter[] parameters)
        {
            var connectionString = ConnectionString;
            DataTable dt = new DataTable();
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = commandName;
                        cmd.CommandType = commandType;
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                                cmd.Parameters.Add(param);
                        }

                        using (var reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        internal static int ExecuteScalar(string commandName, CommandType commandType, params SqlParameter[] parameters)
        {
            var connectionString = ConnectionString;
            var dt = new DataTable();
            int insertedID = -1;
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = commandName;
                        cmd.CommandType = commandType;
                        if (parameters != null)
                            foreach (var param in parameters)
                                cmd.Parameters.Add(param);

                        insertedID = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }

            return insertedID;
        }

    }
}
