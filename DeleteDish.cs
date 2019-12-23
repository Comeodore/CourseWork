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
    public partial class DeleteDish : Form
    {
        public DeleteDish()
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDeleteDish_Click(object sender, EventArgs e)
        {
            if (textBoxDeleteDish.Text == "")
            {
                MessageBox.Show("Вы ничего не ввели");
                return;
            }
            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `dishes` WHERE `namedish` = @namedish", dataBase.connectionStatus());

            command2.Parameters.Add("@namedish", MySqlDbType.VarChar).Value = textBoxDeleteDish.Text;

            adapter.SelectCommand = command2;
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Данного блюда не обнаружено, попробуйте еще раз");
                return;
            }
            MySqlCommand command = new MySqlCommand("DELETE FROM `dishes` WHERE `namedish` = @enternamedish", dataBase.connectionStatus());
            command.Parameters.Add("@enternamedish", MySqlDbType.VarChar).Value = textBoxDeleteDish.Text;
            if (command.ExecuteNonQuery() == 1) MessageBox.Show("Блюдо удалено из базы данных");
            else MessageBox.Show("Произошла ошибка");
        }
    }
}
