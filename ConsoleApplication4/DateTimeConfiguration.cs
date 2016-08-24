using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class DateTimeConfigurarionColumn : ConfigurationColumn<DateTime>
    {
        public DateTime MinDateTime { get; set; }
        public DateTime MaxDateTime { get; set; }

        protected override object GenerateTypedValue()
        {
            var diff = MaxDateTime.Subtract(MinDateTime).Days;
            var day = Random.Next(0, diff);

            return MinDateTime.AddDays(day);
        }
    }

    public class FloatConfigurationColumn : ConfigurationColumn<decimal>
    {
        public decimal MinFloat { get; set; }
        public decimal MaxFloat { get; set; }

        protected override object GenerateTypedValue()
        {
            return Random.NextDecimal();
        }
    }

    public class BooleanConfigurationColumn : ConfigurationColumn<bool>
    {
        protected override object GenerateTypedValue()
        {
            return Random.GetRandomBool();
        }
    }
}
