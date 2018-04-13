using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityGeneratorForm
{
    public class TableDesc
    {
        public string ColumnName { get; set; }
        public int MaxLength { get; set; }
        public string Precision { get; set; }
        public string Scale { get; set; }
        public bool IsNullable { get; set; }
        public string DataType { get; set; }
    }
}
