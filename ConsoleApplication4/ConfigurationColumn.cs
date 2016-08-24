using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public abstract class ConfigurationColumn : DataColumn
    {
        protected Random Random { get; private set; }

        public ConfigurationColumn()
        {
            Random = new Random();
            AllowDBNull = false;
        }

        public virtual object GenerateValue() { return null; }
        protected abstract object GenerateTypedValue();
    }

    public abstract class ConfigurationColumn<T> : ConfigurationColumn
    {
        private IEnumerable<T> queryOptions;
        private IEnumerable<object> listOptions;

        protected virtual IEnumerable<T> GetUniqueValues() { throw new NotImplementedException(); }

        public string FromQuery { get; set; }
        public string FromList { get; set; }

        public override object GenerateValue()
        {
            if (AllowDBNull && Random.GetRandomBool())
                return null;

            if (!String.IsNullOrEmpty(FromQuery))
                return GenerateByQuery();

            if (!String.IsNullOrEmpty(FromList))
                return GenerateByList();

            return GenerateTypedValue();
        }

        private object GenerateByList()
        {
            if (listOptions != null)
                return listOptions.GetElementRandom();

            listOptions = FromList.Split(';').Select(c => (object)c);
            return listOptions.GetElementRandom();
        }

        private object GenerateByQuery()
        {
            if (queryOptions != null)
                return queryOptions.GetElementRandom();

            using (var context = new DbContext("DataContext"))
            {
                context.Database.Log = (s) => Console.WriteLine(s);
                queryOptions = context.Database.SqlQuery<T>(FromQuery).ToArray();
            }

            return queryOptions.GetElementRandom();
        }
    }
}
