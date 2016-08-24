using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class NumberConfigurarionColumn : ConfigurationColumn<int>
    {
        public int MinNumber { get; set; }
        public int MaxNumber { get; set; }

        protected override object GenerateTypedValue()
        {
            return Random.Next(MinNumber, MaxNumber);
        }
    }
}
