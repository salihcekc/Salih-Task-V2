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

namespace Task_Level2_Test_App2
{
    public partial class loginScreen : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;
        string connectSql;
        public loginScreen()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            connectSql = "Data Source=DESKTOP-B4D75DF;Initial Catalog=Document;Integrated Security=True";
            connection = new SqlConnection(connectSql);
            command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "select * from Users where UserName='" + UserName_txt.Text + "' and " +
                "Password='" + Password_txt.Text + "'";
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                transactionScreen tranScreen = new transactionScreen();
                tranScreen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre.\nLütfen tekrar deneyiniz.");
            }
            connection.Close();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginScreen_Load(object sender, EventArgs e)
        {
            Password_txt.UseSystemPasswordChar = true;
        }
    }
}
