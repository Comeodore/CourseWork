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
    public partial class EditDish : Form
    {
        DataBase database = new DataBase();
        public EditDish()
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

        public Boolean CheckForSimilarName()
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `dishes` WHERE `namedish` = @enternname", database.connectionStatus());

            command.Parameters.Add("@enternname", MySqlDbType.VarChar).Value = textBoxOld.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Введенное старое название блюда не найдено");
                return true;
            }
            else return false;
        }
        public Boolean CheckForSimilarIngr()
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `dishes` WHERE `ingrdish` = @enteriingr", database.connectionStatus());

            command.Parameters.Add("@enteriingr", MySqlDbType.VarChar).Value = textBoxOld.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Введенные старые ингридиенты блюда не найдены");
                return true;
            }
            else return false;
        }
        public Boolean CheckForSimilarWeight()
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `dishes` WHERE `weight` = @enterwweight", database.connectionStatus());

            command.Parameters.Add("@enterwweight", MySqlDbType.VarChar).Value = textBoxOld.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Введенный старый вес блюда не найден");
                return true;
            }
            else return false;
        }
        public Boolean CheckForSimilarPrice()
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `dishes` WHERE `price` = @enterpprice", database.connectionStatus());

            command.Parameters.Add("@enterpprice", MySqlDbType.VarChar).Value = textBoxOld.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Введенная старая цена блюда не найдена");
                return true;
            }
            else return false;
        }
        public Boolean CheckTextBoxOldForFill()
        {
            if (textBoxOld.Text == "")
            {
                MessageBox.Show("Вы не заполнили поле старого значения, попробуйте еще раз");
                return true;
            }
            else return false;
        }
        public Boolean CheckTextBoxNewForFill()
        {
            if (textBoxNew.Text == "")
            {
                MessageBox.Show("Вы не заполнили поле нового значения, попробуйте еще раз");
                return true;
            }
            else return false;
        }

        private void buttonChangesDone_Click(object sender, EventArgs e)
        {
            database.openConnection();
            Boolean StartSQL = true;
            if (radioButtonName.Checked)
                StartSQL = CheckForSimilarName();
            else if (radioButtonIngr.Checked)
                StartSQL = CheckForSimilarIngr();
            else if (radioButtonWeight.Checked)
                StartSQL = CheckForSimilarWeight();
            else if (radioButtonPrice.Checked)
                StartSQL = CheckForSimilarPrice();
            if (StartSQL || CheckTextBoxNewForFill() || CheckTextBoxOldForFill()) return;

            string queryString = "";
            if (radioButtonName.Checked) queryString = "UPDATE `dishes` SET `namedish` = @entername WHERE `namedish` = @oldname";
            else if (radioButtonIngr.Checked) queryString = "UPDATE `dishes` SET `ingrdish` = @enteringr WHERE `ingrdish` = @oldingr";
            else if (radioButtonWeight.Checked) queryString = "UPDATE `dishes` SET `weight` = @enterweight WHERE `weight` = @oldweight";
            else if (radioButtonPrice.Checked) queryString = "UPDATE `dishes` SET `price` = @enterprice WHERE `price` = @oldprice";

            MySqlCommand command = new MySqlCommand(queryString, database.connectionStatus());

            if (radioButtonName.Checked)
            {
                command.Parameters.Add("@entername", MySqlDbType.VarChar).Value = textBoxNew.Text.ToLower();
                command.Parameters.Add("@oldname", MySqlDbType.VarChar).Value = textBoxOld.Text;
            }
            else if (radioButtonIngr.Checked)
            {
                command.Parameters.Add("@enteringr", MySqlDbType.VarChar).Value = textBoxNew.Text.ToLower();
                command.Parameters.Add("@oldprice", MySqlDbType.VarChar).Value = textBoxOld.Text;
            }
            else if (radioButtonWeight.Checked)
            {
                command.Parameters.Add("@enterweight", MySqlDbType.Float).Value = textBoxNew.Text;
                command.Parameters.Add("@oldweight", MySqlDbType.Float).Value = textBoxOld.Text;
            }
            else if (radioButtonPrice.Checked)
            {
                command.Parameters.Add("@enterprice", MySqlDbType.Float).Value = textBoxNew.Text;
                command.Parameters.Add("@oldprice", MySqlDbType.Float).Value = textBoxOld.Text;
            }
            try
            {
                if (command.ExecuteNonQuery() == 1) MessageBox.Show("Изменения внесены");
                else MessageBox.Show("Произошла ошибка");
            }
            catch
            {
                MessageBox.Show("Введены неверные данные, попробуйте еще раз");
            }
            database.closeConnection();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
