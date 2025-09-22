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
        private DataTable empTable, partTable;
        private MySqlDataAdapter empAdapter, partAdapter;
        private MySqlCommandBuilder empBuilder, partBuilder;

        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            LoadEmployeeTable();
            LoadParticipationTable();
        }

        public void LoadEmployeeTable()
        {

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    empAdapter = new MySqlDataAdapter("SELECT * FROM employee", conn);
                    empBuilder = new MySqlCommandBuilder(empAdapter);
                    empTable = new DataTable();
                    empAdapter.Fill(empTable);
                    dataGridView1.DataSource = empTable;
                    dataGridView1.AllowUserToAddRows = false;



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке таблицы: " + ex.Message);
            }
        }
        public void LoadParticipationTable()
        {
            try
            {
                using (MySqlConnection conn2 = new MySqlConnection(connectionString))
                {
                    partAdapter = new MySqlDataAdapter("SELECT * FROM participation", conn2);
                    partBuilder = new MySqlCommandBuilder(partAdapter);
                    partTable = new DataTable();
                    partAdapter.Fill(partTable);
                    dataGridView2.DataSource = partTable;
                    dataGridView2.AllowUserToAddRows = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке таблицы: " + ex.Message);
            }
        }
        

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
          
        }
    }
}
