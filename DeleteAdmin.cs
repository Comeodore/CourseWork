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
    public partial class DeleteAdmin : Form
    {
        public DeleteAdmin()
        {
            InitializeComponent();
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e) => ExitButton.ForeColor = Color.Red;
        private void ExitButton_MouseLeave(object sender, EventArgs e) => ExitButton.ForeColor = Color.White;
        private void BackButton_MouseEnter(object sender, EventArgs e) => BackButton.ForeColor = Color.Red;
        private void BackButton_MouseLeave(object sender, EventArgs e) => BackButton.ForeColor = Color.White;

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel panel = new Panel();
            panel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxDeleteAdmin.Text == "")
            {
                MessageBox.Show("Вы ничего не ввели");
                return;
            }
            if (textBoxDeleteAdmin.Text == "system")
            {
                MessageBox.Show("Администраторский профиль System удалить нельзя");
                return;
            }
            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @enterlogin", dataBase.connectionStatus());

            command2.Parameters.Add("@enterlogin", MySqlDbType.VarChar).Value = textBoxDeleteAdmin.Text;

            adapter.SelectCommand = command2;
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Данного администратора не обнаружено, попробуйте еще раз");
                return;
            }
            MySqlCommand command = new MySqlCommand("DELETE FROM `users` WHERE `login` = @login", dataBase.connectionStatus());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBoxDeleteAdmin.Text;
            if (command.ExecuteNonQuery() == 1) MessageBox.Show("Администратор удален из базы данных");
            else MessageBox.Show("Произошла ошибка");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
