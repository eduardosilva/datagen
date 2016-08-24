using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication4.Forms
{
    public partial class GeneratorForm : Form
    {
        public GeneratorForm()
        {
            InitializeComponent();
        }

        private void GeneratorForm_Load(object sender, EventArgs e)
        {
            LoadTables();
        }

        private void LoadTables()
        {
            using (var context = new DbContext("DataContext"))
            {
                context.Database.Log = (s) => Console.WriteLine(s);

                var result = context.Database.SqlQuery<DataTable>("SELECT TABLE_NAME AS TableName FROM INFORMATION_SCHEMA.TABLES").ToArray();

                int x = 0;
            }
        }
    }
}
