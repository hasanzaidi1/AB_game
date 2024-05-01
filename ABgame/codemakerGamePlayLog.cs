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
    public partial class codemakerGamePlayLog : Form
    {
        public codemakerGamePlayLog()
        {
            InitializeComponent();
            LoadGameData();
        }

        public void LoadGameData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CodemakerDB ORDER BY PlayDateTime DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                codemakerGameData.DataSource = dataTable; // Assuming codemakerGameData is your DataGridView
            }
        }
    }
    }
