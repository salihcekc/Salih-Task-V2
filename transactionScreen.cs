using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Task_Level2_Test_App2
{
    public partial class transactionScreen : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;
        string connectSql = "Data Source=DESKTOP-B4D75DF;Initial Catalog=Document;Integrated Security=True";
        public transactionScreen()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string query = "select * from Employees";
            connection = new SqlConnection(connectSql);
            dataAdapter = new SqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            connection.Open();
            dataAdapter.Fill(dataSet, "Employees");
            dataTable.DataSource = dataSet.Tables["Employees"];
            dataTable.AllowUserToAddRows = false;
            connection.Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectSql);
            command = new SqlCommand();

            OpenFileDialog newFile = new OpenFileDialog();
            if (newFile.ShowDialog() == DialogResult.OK)
            {
                var employeeList = new List<Employee>();
                var xmlSerializer = new XmlSerializer(typeof(List<Employee>));
                using (var reader = new StreamReader(newFile.FileName))
                {
                    var employee = (List<Employee>)xmlSerializer.Deserialize(reader);
                    for (int i = 0; i < employee.Count; i++)
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandText = "select * from Employees where ID=" + employee[i].ID;
                        dataReader = command.ExecuteReader();
                        if (dataReader.Read())
                        {
                            command.CommandText = "update Employees set PersonalID=" + employee[i].PersonalID + ",LastName = '" + employee[i].LastName +
                            "',FirstName='" + employee[i].FirstName +
                            "',HireDate='" + employee[i].HireDate.ToString("yyyy-MM-dd") + "' where ID=" + employee[i].ID + "";
                            connection.Close();

                            connection.Open();
                            command.ExecuteNonQuery();

                            connection.Close();
                        }
                        else
                        {
                            command.CommandText = "insert into Employees(ID,LastName,FirstName,PersonalID,HireDate) values (" +
                                employee[i].ID + ",'" +
                                employee[i].LastName + "','" +
                                employee[i].FirstName + "'," +
                                employee[i].PersonalID + ",'" +
                                employee[i].HireDate.ToString("yyyy-MM-dd") + "')";
                            connection.Close();

                            connection.Open();
                            command.ExecuteNonQuery();

                            connection.Close();
                        }
                    }

                    btnView_Click(sender, e);
                }
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectSql);
            command = new SqlCommand();
            connection.Open();
            command.Connection = connection;

            if ((ID_txt != null) || (lastName_txt != null) || (firstName_txt != null) || (hireDate_txt != null))
            {
                command.CommandText = "insert into Employees(ID,LastName,FirstName,PersonalID,HireDate) values (" +
                    ID_txt.Text + ",'" +
                    lastName_txt.Text + "','" +
                    firstName_txt.Text + "'," +
                    personalID_txt.Text + ",'" +
                    hireDate_txt.Text + "')";
                command.ExecuteNonQuery();
                ID_txt.Clear();
                lastName_txt.Clear();
                firstName_txt.Clear();
                hireDate_txt.Clear();
                MessageBox.Show("Ekleme başarılı!");
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
            connection.Close();
            btnView_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectSql);
            command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            if (deleteID_txt != null)
            {
                command.CommandText = "delete from Employees where PersonalID=" + deleteID_txt.Text + "";
                command.ExecuteNonQuery();
                MessageBox.Show("Silme başarılı!");
            }
            else
            {
                MessageBox.Show("Silme başarısız!");
            }
            connection.Close();
            btnView_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectSql);
            command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            if (updatePid_txt != null)
            {
                command.CommandText = "update Employees set LastName ='" + updateLname_txt.Text +
                "',FirstName='" + updateFname_txt.Text +
                "',HireDate='" + updateHdate_txt.Text + "' where PersonalID=" + updatePid_txt.Text + "";
                command.ExecuteNonQuery();
                MessageBox.Show("Güncelleme başarılı!");
            }
            else
            {
                MessageBox.Show("Güncelleme başarısız!");
            }
            connection.Close();
            btnView_Click(sender, e);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectSql);
            command = new SqlCommand("select count(*) from Employees", connection);
            connection.Open();
            int rowCount = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();

            var employeeList = new List<Employee>();
            command = new SqlCommand("select * from Employees", connection);
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();

            for (int i = 0; i < rowCount; i++)
            {
                while (dataReader.Read())
                {
                    Employee employee = new Employee
                    {
                        ID = Convert.ToInt32(dataReader["ID"]),
                        LastName = dataReader["LastName"].ToString(),
                        FirstName = dataReader["FirstName"].ToString(),
                        PersonalID = Convert.ToInt32(dataReader["PersonalID"]),
                        HireDate = DateTime.Parse(dataReader["HireDate"].ToString())
                    };
                    employeeList.Add(employee);
                }
            }
            connection.Close();
            var xmlSerializer = new XmlSerializer(typeof(List<Employee>));
            //using (var writer = new StreamWriter(@"C:\Users\Salih\source\repos\Task-Level2-Test-App2\bin\Debug\Person.xml"))
            using (var writer = new StreamWriter(Application.StartupPath + "\\Person.xml"))
            {
                xmlSerializer.Serialize(writer, employeeList);
            }
            MessageBox.Show("Export başarılı.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            loginScreen giris = new loginScreen();
            giris.Show();
            this.Hide();
        }
    }
}
