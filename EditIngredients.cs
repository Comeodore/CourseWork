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
    public partial class EditIngredients : Form
    {
        DataBase database = new DataBase();
        public EditIngredients()
        {
            InitializeComponent();
        }

        private void ExitButtonEditIngredientsHelp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Boolean CheckForSimilarName()
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `ingredients` WHERE `name` = @entername", database.connectionStatus());

            command.Parameters.Add("@entername", MySqlDbType.VarChar).Value = EditIngredientsTextBoxOld.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Введенное старое название ингридиента не найдено");
                return true;
            }
            else return false;
        }
        public Boolean CheckForSimilarWeight()
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `ingredients` WHERE `weight` = @enterweight", database.connectionStatus());

            command.Parameters.Add("@enterweight", MySqlDbType.VarChar).Value = EditIngredientsTextBoxOld.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Введенный старый вес ингридиента не найден");
                return true;
            }
            else return false;
        }
        public Boolean CheckForSimilarPrice()
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `ingredients` WHERE `price` = @enterprice", database.connectionStatus());

            command.Parameters.Add("@enterprice", MySqlDbType.VarChar).Value = EditIngredientsTextBoxOld.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Введенная старая цена ингридиента не найдена");
                return true;
            }
            else return false;
        }
        public Boolean CheckTextBoxOldForFill()
        {
            if (EditIngredientsTextBoxOld.Text == "")
            {
                MessageBox.Show("Вы не заполнили поле старого значения, попробуйте еще раз");
                return true;
            }
            else return false;
        }
        public Boolean CheckTextBoxNewForFill()
        {
            if (EditIngredientsTextBoxNew.Text == "")
            {
                MessageBox.Show("Вы не заполнили поле нового значения, попробуйте еще раз");
                return true;
            }
            else return false;
        }
        private void EditIngredientsButtonChangesDone_Click(object sender, EventArgs e)
        {
            database.openConnection();
            Boolean StartSQL = true;
            if (radioButtonName.Checked)
                StartSQL = CheckForSimilarName();
            else if (radioButtonWeight.Checked)
                StartSQL = CheckForSimilarWeight();
            else if (radioButtonPrice.Checked)
                StartSQL = CheckForSimilarPrice();
            if (StartSQL || CheckTextBoxNewForFill() || CheckTextBoxOldForFill()) return;

            string queryString = "";
            if (radioButtonName.Checked) queryString = "UPDATE ingredients SET name = @entername WHERE name = @oldname";
            else if (radioButtonWeight.Checked) queryString = "UPDATE ingredients SET weight = @enterweight WHERE weight = @oldweight";
            else if (radioButtonPrice.Checked) queryString = "UPDATE ingredients SET price = @enterprice WHERE price = @oldprice";

            MySqlCommand command = new MySqlCommand(queryString, database.connectionStatus());

            if(radioButtonName.Checked)
            {
                command.Parameters.Add("@entername", MySqlDbType.VarChar).Value = EditIngredientsTextBoxNew.Text.ToLower();
                command.Parameters.Add("@oldname", MySqlDbType.VarChar).Value = EditIngredientsTextBoxOld.Text;
            }
            else if (radioButtonWeight.Checked)
            {
                command.Parameters.Add("@enterweight", MySqlDbType.VarChar).Value = EditIngredientsTextBoxNew.Text.ToLower();
                command.Parameters.Add("@oldweight", MySqlDbType.VarChar).Value = EditIngredientsTextBoxOld.Text;
            }
            else if (radioButtonPrice.Checked)
            {
                command.Parameters.Add("@enterprice", MySqlDbType.VarChar).Value = EditIngredientsTextBoxNew.Text.ToLower();
                command.Parameters.Add("@oldprice", MySqlDbType.VarChar).Value = EditIngredientsTextBoxOld.Text;
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
        private void ExitButton_MouseEnter(object sender, EventArgs e) => ExitButtonEditIngredients.ForeColor = Color.Red;
        private void ExitButton_MouseLeave(object sender, EventArgs e) => ExitButtonEditIngredients.ForeColor = Color.White;
        private void BackButton_MouseEnter(object sender, EventArgs e) => BackButton.ForeColor = Color.Red;
        private void BackButton_MouseLeave(object sender, EventArgs e) => BackButton.ForeColor = Color.White;

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel panel = new Panel();
            panel.Show();
        }
    }
}
