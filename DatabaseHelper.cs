using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityGeneratorForm
{
    public class DatabaseHelper
    {
        public DatabaseHelper(string name)
        {
            connectionString = name;
        }

        public string connectionString { get; set; }

        public IEnumerable<string> GetListOfTables()
        {
            List<string> lstTableNames = new List<string>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT* FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' and Table_name <> 'sysdiagrams'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lstTableNames.Add(rdr["TABLE_NAME"].ToString());
                }
                con.Close();
            }
            return lstTableNames;
        }

        public List<TableDesc> GetColumnsWithDataType(string tableName)
        {
            List<TableDesc> lstTableDesc = new List<TableDesc>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT c.name ColumnName ,c.max_length as MaxLength,c.precision as Precision ,c.scale as Scale,c.is_nullable as IsNullable,t.name as DataType FROM sys.columns c  JOIN sys.types t ON c.user_type_id = t.user_type_id WHERE c.object_id = Object_id('" + tableName + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    TableDesc tableDesc = new TableDesc()
                    {
                        ColumnName = rdr["ColumnName"].ToString(),
                        MaxLength = Convert.ToInt32(rdr["MaxLength"]),
                        IsNullable = Convert.ToBoolean(rdr["IsNullable"]),
                        DataType = rdr["DataType"].ToString(),
                        Precision = rdr["Precision"].ToString(),
                        Scale = rdr["Scale"].ToString()
                    };

                    lstTableDesc.Add(tableDesc);
                }
                con.Close();
            }
            return lstTableDesc;
        }

        public IEnumerable<string> GetListOfDatabase()
        {
            try
            {
                List<string> lstDBNames = new List<string>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT name FROM master.dbo.sysdatabases order by name";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        lstDBNames.Add(rdr["Name"].ToString());
                    }
                    con.Close();
                }
                return lstDBNames;
            }
            catch (Exception ex)
            {
                throw ex;
            }
         
        }
    }
}
