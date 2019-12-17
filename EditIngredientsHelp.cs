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
    public partial class EditIngredientsHelp : Form
    {
        public int ChoseEditIngredient;
        public EditIngredientsHelp(int a)
        {
            InitializeComponent();
            ChoseEditIngredient = a;
        }

        private void ExitButtonEditIngredientsHelp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReturnPanelEditIngredients_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel EditIngredientsHelpReturnPanel = new Panel();
            EditIngredientsHelpReturnPanel.Show();
        }
        public Boolean CheckForSimilarName()
        {
            DataBase database = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `ingredients` WHERE `name` = @entername", database.connectionStatus());

            command.Parameters.Add("@entername", MySqlDbType.VarChar).Value = EditIngredientsTextBoxOld.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Введенное старое имя ингридиента не найдено");
                return true;
            }
            else return false;
        }
        public Boolean CheckForSimilarWeight()
        {
            DataBase database = new DataBase();
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
            DataBase database = new DataBase();
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
            Boolean StartSQL = true;
            if (ChoseEditIngredient == 0)
                StartSQL = CheckForSimilarName();
            else if (ChoseEditIngredient == 1)
                StartSQL = CheckForSimilarWeight();
            else if (ChoseEditIngredient == 2)
                StartSQL = CheckForSimilarPrice();
            if (StartSQL || CheckTextBoxNewForFill() || CheckTextBoxOldForFill()) return;

            DataBase EditIngredient = new DataBase();

            string queryString = "";
            if (ChoseEditIngredient == 0) queryString = "UPDATE ingredients SET name = @entername WHERE name = @oldname";
            else if (ChoseEditIngredient == 1) queryString = "UPDATE ingredients SET weight = @enterweight WHERE weight = @oldweight";
            else if (ChoseEditIngredient == 2) queryString = "UPDATE ingredients SET price = @enterprice WHERE price = @oldprice";

            MySqlCommand command = new MySqlCommand(queryString,EditIngredient.connectionStatus());

            if(ChoseEditIngredient == 0)
            {
                command.Parameters.Add("@entername", MySqlDbType.VarChar).Value = EditIngredientsTextBoxNew.Text;
                command.Parameters.Add("@oldname", MySqlDbType.VarChar).Value = EditIngredientsTextBoxOld.Text;
            }
            else if (ChoseEditIngredient == 1)
            {
                command.Parameters.Add("@enterweight", MySqlDbType.VarChar).Value = EditIngredientsTextBoxNew.Text;
                command.Parameters.Add("@oldweight", MySqlDbType.VarChar).Value = EditIngredientsTextBoxOld.Text;
            }
            else if (ChoseEditIngredient == 2)
            {
                command.Parameters.Add("@enterprice", MySqlDbType.VarChar).Value = EditIngredientsTextBoxNew.Text;
                command.Parameters.Add("@oldprice", MySqlDbType.VarChar).Value = EditIngredientsTextBoxOld.Text;
            }
            try
            {
                EditIngredient.openConnection();
                if (command.ExecuteNonQuery() == 1) MessageBox.Show("Изменения внесены");
                else MessageBox.Show("Произошла ошибка");
                EditIngredient.closeConnection();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные, попробуйте еще раз");
            }
        }
    }
}
