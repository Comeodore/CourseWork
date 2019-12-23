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
    public partial class DeleteIngredients : Form
    {
        public DeleteIngredients()
        {
            InitializeComponent();
        }
        private void DeleteIngredientsButton_Click(object sender, EventArgs e)
        {
            if (CheckDeleteIngredientNameBoxForFill() || CheckDeleteNameIngredientForEmpty()) return;

            DataBase DeleteIngredient = new DataBase();
            MySqlCommand command = new MySqlCommand("DELETE FROM `ingredients` WHERE name = @DeleteIngredientName", DeleteIngredient.connectionStatus());

            command.Parameters.Add("@DeleteIngredientName", MySqlDbType.VarChar).Value = DeleteIngredientsBox.Text;

            DeleteIngredient.openConnection();
            if (command.ExecuteNonQuery() == 1) MessageBox.Show("Ингридиент удален");
            else MessageBox.Show("Произошла ошибка");
            DeleteIngredient.closeConnection();
        }
        public Boolean CheckDeleteIngredientNameBoxForFill()
        {
            if (DeleteIngredientsBox.Text == "")
            {
                MessageBox.Show("Вы не заполнили имя ингридиента, который хотите удалить, попробуйте еще раз");
                return true;
            }
            else return false;
        }
        public Boolean CheckDeleteNameIngredientForEmpty()
        {
            DataBase DeleteIngredient = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `ingredients` WHERE `name` = @DeleteIngredientName", DeleteIngredient.connectionStatus());

            command.Parameters.Add("@DeleteIngredientName", MySqlDbType.VarChar).Value = DeleteIngredientsBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Данного ингридиента не обнаружено, попробуйте еще раз");
                return true;
            }
            else return false;
        }
        private void ExitButtonDeleteIngredients_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel panel = new Panel();
            panel.Show();
        }
        private void ExitButton_MouseEnter(object sender, EventArgs e) => ExitButtonDeleteIngredients.ForeColor = Color.Red;
        private void ExitButton_MouseLeave(object sender, EventArgs e) => ExitButtonDeleteIngredients.ForeColor = Color.White;
        private void BackButton_MouseEnter(object sender, EventArgs e) => BackButton.ForeColor = Color.Red;
        private void BackButton_MouseLeave(object sender, EventArgs e) => BackButton.ForeColor = Color.White;
    }
}
