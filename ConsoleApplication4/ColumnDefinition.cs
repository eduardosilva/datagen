using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class ColumnDefinition
    {
        public string Name { get; set; }
        public int OrdinalPosition { get; set; }
        public string DefaultValue { get; set; }
        public bool IsNullable { get; set; }
        public string DataType { get; set; }
        public int? CharacterMaximumLength { get; set; }
        public byte? NumericPrecision { get; set; }
        public int? NumericScale { get; set; }
        public int? DatetimePrecision { get; set; }
    }
}
