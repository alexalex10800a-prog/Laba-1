using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Rogov_V_2_42lab1
{
    public partial class Form1 : Form
    {
        private DataTable empTable, partTable, spTable, projTable, contTable;
        private MySqlDataAdapter empAdapter, partAdapter, spAdapter, projAdapter, contAdapter;

        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            LoadEmployeeTable();
            LoadParticipationTable();
            LoadSpecialtyTable();
            LoadProjectTable();
            LoadContractTable();
            p1.Click += p1_Click;
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
                    dataGridView5.DataSource = empTable;
                    dataGridView5.AllowUserToAddRows = false;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке таблицы: " + ex.Message);
            }
        }
        public void LoadSpecialtyTable()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    spAdapter = new MySqlDataAdapter("SELECT * FROM specialty", conn);
                    spTable = new DataTable();
                    spAdapter.Fill(spTable);
                    dataGridView3.DataSource = spTable;
                    dataGridView3.AllowUserToAddRows = false;

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

        public void LoadProjectTable()
        {
            try
            {
                using (MySqlConnection conn2 = new MySqlConnection(connectionString))
                {
                    projAdapter = new MySqlDataAdapter("SELECT * FROM project", conn2);
                    projTable = new DataTable();
                    projAdapter.Fill(projTable);
                    dataGridView6.DataSource = projTable;
                    dataGridView6.AllowUserToAddRows = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке таблицы: " + ex.Message);
            }
        }
        public void LoadContractTable()
        {
            try
            {
                using (MySqlConnection conn2 = new MySqlConnection(connectionString))
                {
                    contAdapter = new MySqlDataAdapter("SELECT * FROM contract", conn2);
                    contTable = new DataTable();
                    contAdapter.Fill(contTable);
                    dataGridView7.DataSource = contTable;
                    dataGridView7.AllowUserToAddRows = false;
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

        private void q1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand("SELECT s.specialty_name, COUNT(e.employee_id) " +
                                                            "AS \"Количество сотрудников\" FROM Specialty s LEFT JOIN Employee e ON e.specialty_code_FK1 = s.specialty_code " +
                                                            "GROUP BY s.specialty_name;", conn);
                    MySqlDataReader dataReader = command.ExecuteReader();
                    DataTable dataTable1 = new DataTable("query1");
                    dataTable1.Columns.Add("specialty_name");
                    dataTable1.Columns.Add("Количество сотрудников");
                    while (dataReader.Read())
                    {
                        DataRow row = dataTable1.NewRow();
                        row["specialty_name"] = dataReader["specialty_name"];
                        row["Количество сотрудников"] = dataReader["Количество сотрудников"];
                        dataTable1.Rows.Add(row);
                    }
                    dataReader.Close();
                    dataGridView4.DataSource = dataTable1;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка. " + ex.Message );
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
        private void p1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("get_projects_by_contract", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                 
                        cmd.Parameters.AddWithValue("@p_contract_code", Convert.ToInt32(textBox2.Text));

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView8.DataSource = null;
                        dataGridView8.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
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
