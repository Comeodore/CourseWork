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
    public partial class AddDish : Form
    {
        public AddDish()
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
        public string str = "";
        public int i = 0;
        private void buttonAddDishIngr_Click(object sender, EventArgs e)
        {
            string[] repeat = str.Split(',');
            foreach (var word in repeat)
            {
                if (word == textBoxAddDishIngr.Text.ToLower())
                {
                    MessageBox.Show("Ингридиент " + textBoxAddDishIngr.Text + " уже использован, попробуйте другой");
                    return;
                }
            }
            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `ingredients` WHERE `name` = @entername", dataBase.connectionStatus());
            command.Parameters.Add("@entername", MySqlDbType.VarChar).Value = textBoxAddDishIngr.Text;

            adapter.SelectCommand = command; // присвоение адаптеру команды MySQL
            adapter.Fill(table); // заполнение считанных данных в табличку
            if (table.Rows.Count > 0)
            {
                str += textBoxAddDishIngr.Text.ToLower() + ",";
                label3.Text += " " + textBoxAddDishIngr.Text.ToLower() + ",";
                i++;
            }
            else MessageBox.Show("Данный ингридиент отсутствует в базе данных");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Выбранные ингридиенты:";
            str = "";
            i = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(str == "")
            {
                MessageBox.Show("Вы ничего не ввели в поле ингридиентов");
                return;
            }
            if(i<2)
            {
                MessageBox.Show("Создать блюдо можно только от 2-х ингридиентов");
                return;
            }
            if(textBoxName.Text == "")
            {
                MessageBox.Show("Вы не заполнили поле названия блюда");
                return;
            }
            float dishweight = 0, dishprice = 0;
            string strfinal = str.Substring(0, str.Length - 1);
            string[] mystring = strfinal.Split(',');
            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `ingredients`", dataBase.connectionStatus());
            MySqlDataReader reader = command1.ExecuteReader();
            List<string[]> datasql = new List<string[]>();
            while (reader.Read())
            {
                datasql.Add(new string[3]);

                datasql[datasql.Count - 1][0] = reader[1].ToString();
                datasql[datasql.Count - 1][1] = reader[2].ToString();
                datasql[datasql.Count - 1][2] = reader[3].ToString();
            }
            for (int j = 0; j<i; j++)
            {
                for(int o=0; o<i; o++)
                {
                    if (mystring[j] == datasql[o][0])
                    {
                        dishweight += float.Parse(datasql[o][1]);
                        dishprice += float.Parse(datasql[o][2]);
                    }
                }
            }
            reader.Close();
            MySqlCommand command = new MySqlCommand("INSERT INTO `dishes` (`namedish`, `ingrdish`, `weight`, `price`) VALUES (@namedish, @ingrdish, @weightdish, @pricedish);", dataBase.connectionStatus());
            command.Parameters.Add("@namedish", MySqlDbType.VarChar).Value = textBoxName.Text.ToLower();
            command.Parameters.Add("@ingrdish", MySqlDbType.VarChar).Value = strfinal;
            command.Parameters.Add("@weightdish", MySqlDbType.Float).Value = dishweight;
            command.Parameters.Add("@pricedish", MySqlDbType.Float).Value = dishprice;
            if (command.ExecuteNonQuery() == 1) MessageBox.Show("Блюдо добавлено в базу данных");
            else MessageBox.Show("Произошла ошибка");
            dataBase.closeConnection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxAddDishIngr.Text = "";
            textBoxName.Text = "";
        }

    }
}
