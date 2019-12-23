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

        private void ExitButton_MouseEnter(object sender, EventArgs e) => ExitButtonPanel.ForeColor = Color.Red;
        private void ExitButton_MouseLeave(object sender, EventArgs e) => ExitButtonPanel.ForeColor = Color.White;
        private void BackButton_MouseEnter(object sender, EventArgs e) => BackButton.ForeColor = Color.Red;
        private void BackButton_MouseLeave(object sender, EventArgs e) => BackButton.ForeColor = Color.White;

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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void ButtonAddDish_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDish addDish = new AddDish();
            addDish.Show();
        }

        private void ButtonDeleteAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteAdmin deleteAdmin = new DeleteAdmin();
            deleteAdmin.Show();
        }

        private void ButtonDeleteDish_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteDish deleteDish = new DeleteDish();
            deleteDish.Show();
        }

        private void ButtonEditDish_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditDish editDish = new EditDish();
            editDish.Show();
        }

        private void ButtonShowDish_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowAllDish showAllDish = new ShowAllDish();
            showAllDish.Show();
        }
    }
}
