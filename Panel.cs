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
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }


        private void ExitButtonPanel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonAddAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAdmin newadmin = new AddAdmin();
            newadmin.Show();
        }

        private void ButtonAddIngredient_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddIngredient add = new AddIngredient();
            add.Show();
        }

        private void ButtonDeleteIngredient_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteIngredients delete = new DeleteIngredients();
            delete.Show();
        }

        private void ButtonShowIngredient_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowAllIngredients showAllIngredients = new ShowAllIngredients();
            showAllIngredients.Show();
        }

        private void ButtonEditIngredient_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditIngredients editIngredients = new EditIngredients();
            editIngredients.Show();
        }

        private void ButtonReturnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
