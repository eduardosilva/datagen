using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class DataTableConfiguration : DataTable
    {
        public DataTableConfiguration(string tableName)
            : base(tableName)
        { }

        internal IEnumerable<IDbCommand> GenerateCommand(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                var columns = Columns.Cast<ConfigurationColumn>();
                var command = new SqlCommand();

                command.CommandText = "INSERT " + TableName;
                command.CommandText += String.Format(" ({0})", String.Join(", ", columns.Select(c => c.ColumnName).ToArray()));
                command.CommandText += " VALUES ";
                command.CommandText += String.Format(" ({0})", String.Join(", ", columns.Select(c => "@" + c.ColumnName).ToArray()));

                foreach (var c in columns)
                {
                    command.Parameters.AddWithValue("@" + c.ColumnName, c.GenerateValue());
                }

                yield return command;
            }
        }
    }
}
