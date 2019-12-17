using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String loginUser = LoginBox.Text;
            String passwordUser = PasswordBox.Text;

            DataBase database = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @userlogin AND `password` = @userpassword", database.connectionStatus()); // команда выборки елементов с БД

            command.Parameters.Add("@userlogin", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@userpassword", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = command; // выполнение команды выборки елементов с БД
            adapter.Fill(table); // заполнение считанных данных в табличку

            if (table.Rows.Count > 0)
            {
                this.Hide();
                Panel authorized = new Panel();
                authorized.Show();
            }
            else MessageBox.Show("Логин или пароль были введены неверно");
        }

        private void ExitButtonLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
