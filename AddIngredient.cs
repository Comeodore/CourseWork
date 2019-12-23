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
    public partial class AddIngredient : Form
    {
        public AddIngredient()
        {
            InitializeComponent();
        }

        private void ExitButtonAddIngredients_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AddIngredientButton_Click(object sender, EventArgs e)
        {
            if (CheckNameBoxForFill() || CheckWeightForFill() || CheckPriceForFill() || CheckNameIngredientForRepeat()) return;

            DataBase AddIngredients = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `ingredients` (`name`, `weight`, `price`) VALUES (@AddIngredientName, @AddIngredientWeight, @AddIngredientPrice)", AddIngredients.connectionStatus());

            command.Parameters.Add("@AddIngredientName", MySqlDbType.VarChar).Value = AddIngredientNameBox.Text.ToLower();
            command.Parameters.Add("@AddIngredientWeight", MySqlDbType.Float).Value = AddIngredientWeightBox.Text;
            command.Parameters.Add("@AddIngredientPrice", MySqlDbType.Float).Value = AddIngredientPriceBox.Text;

            AddIngredients.openConnection();
            if (command.ExecuteNonQuery() == 1) MessageBox.Show("Ингридиент добавлен");
            else MessageBox.Show("Произошла ошибка");
            AddIngredients.closeConnection();
        }
        public Boolean CheckNameBoxForFill()
        {
            if (AddIngredientNameBox.Text == "")
            {
                MessageBox.Show("Вы не заполнили имя ингридиента, попробуйте еще раз");
                return true;
            }
            else return false;
        }
        public Boolean CheckWeightForFill()
        {
            if (AddIngredientWeightBox.Text == "")
            {
                MessageBox.Show("Вы не заполнили вес ингридиента, попробуйте еще раз");
                return true;
            }
            else return false;
        }
        public Boolean CheckPriceForFill()
        {
            if (AddIngredientPriceBox.Text == "")
            {
                MessageBox.Show("Вы не заполнили цену ингридиента, попробуйте еще раз");
                return true;
            }
            else return false;
        }
        public Boolean CheckNameIngredientForRepeat()
        {
            DataBase AddIngredients = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `ingredients` WHERE `name` = @AddIngredientName", AddIngredients.connectionStatus());

            command.Parameters.Add("@AddIngredientName", MySqlDbType.VarChar).Value = AddIngredientNameBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Даннoe имя ингридиента уже используется, попробуйте другое");
                return true;
            }
            else return false;
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel panel = new Panel();
            panel.Show();
        }
        private void ExitButton_MouseEnter(object sender, EventArgs e) => ExitButtonAddIngredients.ForeColor = Color.Red;
        private void ExitButton_MouseLeave(object sender, EventArgs e) => ExitButtonAddIngredients.ForeColor = Color.White;
        private void BackButton_MouseEnter(object sender, EventArgs e) => BackButton.ForeColor = Color.Red;
        private void BackButton_MouseLeave(object sender, EventArgs e) => BackButton.ForeColor = Color.White;
    }
}
