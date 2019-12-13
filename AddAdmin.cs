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
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void ButtonRegisterAddAdmin_Click(object sender, EventArgs e)
        {
            if (CheckLoginBoxForFill() || CheckPasswordBoxForFill() || CheckLoginForRepeat()) return;

            DataBase NewAdmin = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`) VALUES (@LoginAddAdmin, @PasswordAddAdmin)", NewAdmin.connectionStatus());

            command.Parameters.Add("@LoginAddAdmin", MySqlDbType.VarChar).Value = LoginAddAdminBox.Text;
            command.Parameters.Add("@PasswordAddAdmin", MySqlDbType.VarChar).Value = PasswordAddAdminBox.Text;

            NewAdmin.openConnection();
            if (command.ExecuteNonQuery() == 1) MessageBox.Show("Администратор добавлен");
            else MessageBox.Show("Произошла ошибка");
            NewAdmin.closeConnection();
        }
        public Boolean CheckLoginBoxForFill()
        {
            if (LoginAddAdminBox.Text == "")
            {
                MessageBox.Show("Вы не заполнили поле логина, попробуйте еще раз");
                return true;
            }
            else return false;
        }
        public Boolean CheckPasswordBoxForFill()
        {
            if (PasswordAddAdminBox.Text == "")
            {
                MessageBox.Show("Вы не заполнили поле пароля, попробуйте еще раз");
                return true;
            }
            else return false;
        }
        public Boolean CheckLoginForRepeat()
        {
            DataBase database = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @userlogin", database.connectionStatus());

            command.Parameters.Add("@userlogin", MySqlDbType.VarChar).Value = LoginAddAdminBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Данный логин уже используется, попробуйте другой");
                return true;
            }
            else return false;
        }

        private void ExitButtonAddAdmin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonReturnToPanelAddAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel panel = new Panel();
            panel.Show();
        }

        private void ButtonReturnToPanelAddAdmin_Click_1(object sender, EventArgs e)
        {

        }
    }
}
