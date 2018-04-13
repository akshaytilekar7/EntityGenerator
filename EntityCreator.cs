using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityGeneratorForm
{
    public class EntityCreator
    {
        public string Path { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ConnectionName">you can give from web.config file like  @"Data Source=DE\SQLSERVER2016;Initial Catalog=dbname;User ID=userid;Password=pass;Integrated Security=False";</param>
        /// <param name="NameSpace">name of namespace for your entities</param>
        /// <param name="path">Ex : @"C:\Training\"  full path from where you want to create all entities</param>
        public EntityCreator(string ConnectionName, string NameSpace, string path = @"C:\Training\")
        {
            Path = path;
            DatabaseHelper databaseHelper = new DatabaseHelper(ConnectionName);

            foreach (var tableName in databaseHelper.GetListOfTables())
            {
                List<string> lst = new List<string>();
                List<TableDesc> tableDetails = databaseHelper.GetColumnsWithDataType(tableName);
                var fileStream = CreateFile(tableName);
                lst.Add("using System;");
                lst.Add(string.Empty);
                lst.Add("namespace " + NameSpace);
                lst.Add("{");
                lst.Add(GenerateClass(tableName, fileStream));
                lst.Add("    {");
                lst.AddRange(GenerateProperties(tableDetails, fileStream));
                lst.Add("    }");
                lst.Add("}");
                File.WriteAllLines(path + "\\" + tableName + ".cs", lst.ToArray());
            }
        }

        private string GenerateClass(string tableName, FileStream fileStream)
        {
            return "    public class " + tableName;
        }

        public FileStream CreateFile(string tableName)
        {
            string fileName = Path + "\\" + tableName + ".cs";
            FileInfo fileInfo = new FileInfo(fileName);
            FileStream fs = fileInfo.Create();
            fs.Close();
            fs.Dispose();
            return fs;
        }

        public List<string> GenerateProperties(List<TableDesc> tableDetails, FileStream fileStream)
        {
            try
            {
                List<string> lst = new List<string>();
                foreach (var tableDetail in tableDetails)
                {
                    string PropertyType = EvaluateDataType(tableDetail);
                    string PropertyName = tableDetail.ColumnName;
                    string PropertyText = GenerateProperty(PropertyName, PropertyType);
                    lst.Add(PropertyText);
                    lst.Add(string.Empty);
                }
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string EvaluateDataType(TableDesc tableDetail)
        {
            if (tableDetail.DataType == "text" || tableDetail.DataType == "ntext" || tableDetail.DataType == "nvarchar(1)" || tableDetail.DataType == "nchar(1)" || tableDetail.DataType == "nvarchar" || tableDetail.DataType == "varchar" || tableDetail.DataType == "nchar" || tableDetail.DataType == "sysname" || tableDetail.DataType == "xml" || tableDetail.DataType == "image")
            {
                return "string";
            }
            else if (tableDetail.DataType == "bigint" || tableDetail.DataType == "int" || tableDetail.DataType == "smallint")
            {
                if (tableDetail.IsNullable)
                    return "int?";
                return "int";
            }
            else if (tableDetail.DataType == "datetime" || tableDetail.DataType == "smalldatetime" || tableDetail.DataType == "date")
            {
                if (tableDetail.IsNullable)
                    return "DateTime?";
                return "DateTime";
            }
            else if (tableDetail.DataType == "datetimeoffset")
            {
                if (tableDetail.IsNullable)
                    return "DateTimeOffset?";
                return "DateTimeOffset";

            }
            else if (tableDetail.DataType == "bit")
            {
                return "bool";
            }
            else if (tableDetail.DataType == "numeric" || tableDetail.DataType == "decimal" || tableDetail.DataType == "smallmoney" || tableDetail.DataType == "money")
            {
                if (tableDetail.IsNullable)
                    return "decimal?";
                return "decimal";
            }
            else if (tableDetail.DataType == "float")
            {
                if (tableDetail.IsNullable)
                    return "float?";
                return "float";
            }
            else if (tableDetail.DataType == "rowversion" || tableDetail.DataType == "varbinary(1)" || tableDetail.DataType == "binary(1)" || tableDetail.DataType == "varbinary" || tableDetail.DataType == "blob" || tableDetail.DataType == "binary") // check for blob
            {
                if (tableDetail.IsNullable)
                    return "Byte[]?";
                return "Byte[]";
            }
            else if (tableDetail.DataType == "uniqueidentifier")
            {
                if (tableDetail.IsNullable)
                    return "Guid?";
                return "Guid";
            }
            else if (tableDetail.DataType == "tinyint")
            {
                if (tableDetail.IsNullable)
                    return "byte?";
                return "byte";
            }
            else if (tableDetail.DataType == "char")
            {
                if (tableDetail.IsNullable)
                    return "char?";
                return "char";
            }
            else if (tableDetail.DataType == "sql_variant" || tableDetail.DataType == "real")
            {
                return "object";
            }
            else
            {
                throw new Exception("Error in EvaluateDataType " + tableDetail.DataType);
            }
        }

        public string GenerateProperty(string PropertyName, string PropertyType)
        {
            return "        public " + PropertyType + " " + PropertyName + " " + "{ get; set; }";
        }
    }
}



/*
      Use like following : 
      string conStr = @"Data Source=DESKTOP-56LHB1E\SQLSERVER2016;Initial Catalog=VeyeZR_Prototype;User ID=veyezeruser;Password=password.2;Integrated Security=False";
      EntityCreator entityCreator = new EntityCreator(conStr,"Model");
 */
