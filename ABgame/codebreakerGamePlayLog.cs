using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABgame
{
    public partial class codebreakerGamePlayLog : Form
    {
        public codebreakerGamePlayLog()
        {
            InitializeComponent();
            LoadGameData();
        }

        private void LoadGameData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CodebreakerDB ORDER BY PlayDateTime DESC", conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                codebreakerGameData.DataSource = dataTable; // Make sure dataGridView is the correct DataGridView control name
            }
        }
    }
}