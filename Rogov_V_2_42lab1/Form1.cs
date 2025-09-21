using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Rogov_V_2_42lab1
{
    public partial class Form1 : Form
    {
        private DataSet ds = new DataSet();
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            getTableNames();
        }

        private void getTableNames()
        {

            try {

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    DataTable tables = connection.GetSchema("Tables");
                    comboBox1.Items.Clear();

                    foreach (DataRow row in tables.Rows) 
                        comboBox1.Items.Add(row["TABLE_NAME"].ToString());

                    if (comboBox1.Items.Count > 0)
                        comboBox1.SelectedIndex = 0;
                }

            }
            catch (Exception ex) {

                MessageBox.Show($"Error loading tables: {ex.Message}");

            }


        }
        private void LoadTableContent(string tableName)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter($"SELECT * FROM {tableName}", conn))
                {

                    if (ds.Tables.Contains(tableName))
                    {
                        ds.Tables[tableName].Clear();
                    }
                    else
                    {
                        adapter.Fill(ds, tableName);
                    }
                       

                    dataGridView1.DataSource = ds.Tables[tableName];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading {tableName}: {ex.Message}");
            }

        }
        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                LoadTableContent(comboBox1.SelectedItem.ToString());
            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
