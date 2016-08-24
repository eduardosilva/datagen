using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication4.Forms
{
    public partial class ConnectorForm : Form
    {
        public ConnectorForm()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ServerName.Text))
            {
                connectorErrorProvider.SetError(ServerName, "Required Field");
                return;
            }


            connectorErrorProvider.Clear();
        }

        private void AuthenticationMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Login.Enabled = Password.Enabled = AuthenticationMode.SelectedIndex == 0;
        }
    }
}
