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

        

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            DataRow newRow = empTable.NewRow();
            empTable.Rows.Add(newRow);
        }
        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    dataGridView1.EndEdit();
                    empAdapter = new MySqlDataAdapter("SELECT * FROM employee", connection);
                    MySqlCommandBuilder CommandBuilder = new MySqlCommandBuilder(empAdapter);
                    int rowsAffected = empAdapter.Update(empTable);
                    MessageBox.Show($"Обновлено {rowsAffected} сотрудников.");
                    LoadEmployeeTable();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка! " + ex.Message );
            }
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            DataRow newRow = partTable.NewRow();
            partTable.Rows.Add(newRow);

        }

        private void btnUpdatePart_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    dataGridView2.EndEdit();
                    partAdapter = new MySqlDataAdapter("SELECT * FROM participation", connection);
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(partAdapter);
                    int rowsAffected = partAdapter.Update(partTable);
                    MessageBox.Show($"Обновлено {rowsAffected} строк состояния участия.");
                    LoadParticipationTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! " + ex.Message);
            }
        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    empAdapter = new MySqlDataAdapter("SELECT * FROM employee", conn);
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(empAdapter);
                    int rowIndex = dataGridView1.CurrentRow.Index;

                    empTable.Rows[rowIndex].Delete();

                    int rowsAffected = empAdapter.Update(empTable);
                    MessageBox.Show($"Удалено {rowsAffected} сотрудников");

                    LoadEmployeeTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! " + ex.Message );
            }
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            try
            {
                using(MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    partAdapter = new MySqlDataAdapter("SELECT * FROM participation", conn);
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(partAdapter);
                    int rowIndex = dataGridView2.CurrentRow.Index;
                    partTable.Rows[rowIndex].Delete();
                    int rowsAffected = partAdapter.Update(partTable);
                    MessageBox.Show($"Удалено {rowsAffected} состояний участия");

                    LoadParticipationTable();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Ошибка! " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
