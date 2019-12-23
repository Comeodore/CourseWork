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
    public partial class ShowAllDish : Form
    {
        private void ExitButton_MouseEnter(object sender, EventArgs e) => ExitButton.ForeColor = Color.Red;
        private void ExitButton_MouseLeave(object sender, EventArgs e) => ExitButton.ForeColor = Color.White;
        private void BackButton_MouseEnter(object sender, EventArgs e) => BackButton.ForeColor = Color.Red;
        private void BackButton_MouseLeave(object sender, EventArgs e) => BackButton.ForeColor = Color.White;

        public ShowAllDish()
        {
            InitializeComponent();
            DataBase data = new DataBase();
            data.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM dishes ORDER BY namedish", data.connectionStatus());
            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> datasql = new List<string[]>();

            while (reader.Read()) // пока не закончатся строки вызванные MYSQL запросом
            {
                datasql.Add(new string[4]);

                datasql[datasql.Count - 1][0] = reader[1].ToString();
                datasql[datasql.Count - 1][1] = reader[2].ToString();
                datasql[datasql.Count - 1][2] = reader[3].ToString();
                datasql[datasql.Count - 1][3] = reader[4].ToString();
            }
            reader.Close();
            data.closeConnection();

            foreach (string[] s in datasql)
                dataGridViewIngredients.Rows.Add(s);

        }

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
    }
}
