using ConsoleApplication4.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GeneratorForm());

            Console.Read();

            Database.SetInitializer<DbContext>(null);

            var start = DateTime.Now;

            var tableName = "TBTC_CLIENTE";
            var dataTable = new DataTableConfiguration(tableName);
            dataTable.Columns.Add(new NumberConfigurarionColumn
            {
                ColumnName = "cd_cliente",
                MinNumber = 8881004,
                MaxNumber = 9999999,
                MaxLength = 9999999,
                AllowDBNull = false,
                Unique = true
            });


            dataTable.Columns.Add(new StringConfigurationColumn
            {
                ColumnName = "nm_cliente",
                SType = StringConfigurationColumn.StringType.Company,
                AllowDBNull = false
            });

            dataTable.Columns.Add(new StringConfigurationColumn
            {
                ColumnName = "apelido",
                SType = StringConfigurationColumn.StringType.Name
            });

            dataTable.Columns.Add(new NumberConfigurarionColumn
            {
                ColumnName = "cd_agente_compensacao",
                FromList = "114;1346;84;2028",
                AllowDBNull = false
            });

            dataTable.Columns.Add(new NumberConfigurarionColumn
            {
                ColumnName = "cd_cliente_custodia",
                MinNumber = 1,
                MaxNumber = 100,
                AllowDBNull = false
            });

            dataTable.Columns.Add(new NumberConfigurarionColumn
            {
                ColumnName = "cd_carteira",
                FromList = "2801",
                AllowDBNull = false
            });

            dataTable.Columns.Add(new NumberConfigurarionColumn
            {
                ColumnName = "cd_carteira_retorno",
                MinNumber = 2801,
                MaxNumber = 2801,
                AllowDBNull = false
            });

            dataTable.Columns.Add(new NumberConfigurarionColumn
            {
                ColumnName = "cd_conta_mae",
                FromQuery = "SELECT CD_CLIENTE FROM TBTC_CLIENTE WHERE tipoConta = 1",
            });

            dataTable.Columns.Add(new NumberConfigurarionColumn
            {
                ColumnName = "cd_usuario",
                FromList = "1",
                AllowDBNull = false
            });

            dataTable.Columns.Add(new BooleanConfigurationColumn
            {
                ColumnName = "tipoConta",
                AllowDBNull = false
            });

            dataTable.Columns.Add(new NumberConfigurarionColumn
            {
                ColumnName = "cd_usuario_inclusao",
                FromList = "1",
                AllowDBNull = false
            });


            dataTable.Columns.Add(new DateTimeConfigurarionColumn
            {
                ColumnName = "dt_inclusao",
                MinDateTime = DateTime.Now,
                MaxDateTime = DateTime.Now,
                AllowDBNull = false
            });

            dataTable.Columns.Add(new BooleanConfigurationColumn
            {
                ColumnName = "in_qualificado",
                AllowDBNull = false
            });

            dataTable.Columns.Add(new BooleanConfigurationColumn
            {
                ColumnName = "in_opera_btc",
                AllowDBNull = false
            });

            dataTable.Columns.Add(new StringConfigurationColumn
            {
                ColumnName = "ds_situacao_bolsa",
                FromList = "A",
                AllowDBNull = false
            });

            dataTable.Columns.Add(new NumberConfigurarionColumn
            {
                ColumnName = "cd_carteira_doador",
                FromList = "2801",
                AllowDBNull = false
            });


            dataTable.Columns.Add(new NumberConfigurarionColumn
            {
                ColumnName = "cd_carteira_retorno_doador",
                FromList = "2801",
                AllowDBNull = false
            });

            dataTable.Columns.Add(new NumberConfigurarionColumn
            {
                ColumnName = "vl_limite_boleta",
                FromList = "1500000",
                AllowDBNull = false
            });


            dataTable.Columns.Add(new BooleanConfigurationColumn
            {
                ColumnName = "in_margem_credito",
                AllowDBNull = false
            });

            dataTable.Columns.Add(new BooleanConfigurationColumn
            {
                ColumnName = "in_cotovelo",
                AllowDBNull = false
            });

            dataTable.Columns.Add(new NumberConfigurarionColumn
            {
                ColumnName = "cd_participante",
                FromList = "114",
                AllowDBNull = false
            });

            dataTable.Columns.Add(new NumberConfigurarionColumn
            {
                ColumnName = "cd_agente_custodia",
                MinNumber = 10,
                MaxNumber = 20000,
                AllowDBNull = false
            });

            var qtdScripts = 75000;
            var scripts = dataTable.GenerateCommand(qtdScripts);

            var maxTasks = 4;
            var chunkSize = 1000;

            Parallel.ForEach(scripts.Chunk(chunkSize), new ParallelOptions { MaxDegreeOfParallelism = maxTasks }, (chunk) =>
            {
                using (var context = new DbContext("DataContext"))
                {
                    context.Database.Log = (s) => Console.WriteLine(s);

                    foreach (var command in chunk)
                    {
                        try
                        {
                            var parameters = command.Parameters.Cast<SqlParameter>().Select(c => new SqlParameter(c.ParameterName, c.Value ?? DBNull.Value)).ToArray();
                            context.Database.ExecuteSqlCommand(command.CommandText, parameters);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }

                    }
                }
            });

            Console.WriteLine("");
            Console.WriteLine("Done! - Start:{1}, End:{0}", DateTime.Now, start);
            Console.Read();
        }

        private static ColumnDefinition[] GetColumns(string tableName)
        {
            using (var connection = new DbContext("DataContext"))
            {
                return connection.Database.SqlQuery<ColumnDefinition>(@"SELECT 
                                                                            COLUMN_NAME as Name,
                                                                            ORDINAL_POSITION as OrdinalPosition,
                                                                            COLUMN_DEFAULT as DefaultValue,
                                                                            CAST(CASE WHEN IS_NULLABLE = 'YES' THEN 1 ELSE 0 END as bit) AS IsNullable,
                                                                            DATA_TYPE as DataType,
                                                                            CHARACTER_MAXIMUM_LENGTH as CharacterMaximumLength,
                                                                            NUMERIC_PRECISION as NumericPrecision,
                                                                            NUMERIC_SCALE as NumericScale,
                                                                            DATETIME_PRECISION
                                                                        FROM
                                                                            INFORMATION_SCHEMA.COLUMNS
                                                                        WHERE
                                                                            TABLE_NAME = '" + tableName + "'").ToArray();
            }
        }
    }
}