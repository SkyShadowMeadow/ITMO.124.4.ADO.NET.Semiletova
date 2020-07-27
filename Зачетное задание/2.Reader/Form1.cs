using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Reader
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection();
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=School;Integrated Security=True";
        
        
        public Form1()
        {
            InitializeComponent();
            this.connection.StateChange += new StateChangeEventHandler(this.connection_StateChange);
        }
        static string GetConnectionStringByName(string name)
        {
            string returnValue = null; ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }

        string connectionString = GetConnectionStringByName("DBConnect.SchoolConnectionString");
        private void connection_StateChange(object sender, StateChangeEventArgs e)
        {
            отключениеОтБДToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Closed);
            ассионхронноеПодключениеКБДToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Closed);
            ассинхронноеПодключениеКБДToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Open);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void подключениеКБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void отключениеОтБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connectionString;
                    connection.Open(); MessageBox.Show("Соединение с базой данных " + connection.Database + " выполнено успешно " + "\nСервер: " + connection.DataSource);
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch (SqlException XcpSQL)
            {
                foreach (SqlError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message, "Источник ошибки: " + se.Source,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                }
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ассинхронноеПодключениеКБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close(); MessageBox.Show("Соединение с базой данных закрыто");
            }
            else MessageBox.Show("Соединение с базой данных уже закрыто");
            
        }

        private async void ассионхронноеПодключениеКБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connectionString;
                    await connection.OpenAsync();
                    MessageBox.Show("Соединение с базой данных " + connection.Database + " выполнено успешно " + "\nСервер: " + connection.DataSource);
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с базой данных");
            }
        }

        private void списокПодключенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    string str = String.Format("Name = {0}\nProviderName = {1}\nConnectionString = {2}", 
                                                cs.Name, cs.ProviderName, cs.ConnectionString); MessageBox.Show(str, "Параметры подключений");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (connection)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Сначала подключитесь к базе");
                    return;
                }
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT COUNT(*) FROM Person";
                try
                {
                    int number = (int)command.ExecuteScalar();
                    label1.Text = number.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("SELECT PersonID, LastName, FirstName, EnrollmentDate FROM Person", connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        ListViewItem newItem = listView1.Items.Add(reader["LastName"].ToString());
                        newItem.SubItems.Add(reader["FirstName"].ToString());
                        newItem.SubItems.Add(reader["EnrollmentDate"].ToString());
                        newItem.SubItems.Add(reader["PersonID"].ToString());
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("select Person.PersonID, Person.FirstName, Person.LastName  from CourseInstructor " +
                        "join Course on(CourseInstructor.CourseID = Course.CourseID)" +
                        "join Person on(CourseInstructor.PersonID = Person.PersonID)" +
                        "where Course.Title = @CourseTitle", connection);
                    command.Parameters.Add("@CourseTitle", SqlDbType.NVarChar);
                    command.Parameters["@CourseTitle"].Value = courseName.Text;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        tutorNameLabel.Text = "Имя преподавателя: " + reader["FirstName"].ToString() + ' ' + reader["LastName"];
                    } else
                    {
                        tutorNameLabel.Text = "Имя преподавателя: ";
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
