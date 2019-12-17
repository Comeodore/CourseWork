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
        public int ChoseEditIngredient;
        public EditIngredients()
        {
            InitializeComponent();
        }

        private void ReturnPanelEditIngredients_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel EditIngredientsReturnPanel = new Panel();
            EditIngredientsReturnPanel.Show();
        }

        public void ButtonChoseEditIngredientsName_Click(object sender, EventArgs e)
        {
            ChoseEditIngredient = 0;
            this.Hide();
            EditIngredientsHelp ingredientsHelp0 = new EditIngredientsHelp(ChoseEditIngredient);
            ingredientsHelp0.Show();
        }

        private void ButtonChoseEditIngredientsWeight_Click(object sender, EventArgs e)
        {
            ChoseEditIngredient = 1;
            this.Hide();
            EditIngredientsHelp ingredientsHelp1 = new EditIngredientsHelp(ChoseEditIngredient);
            ingredientsHelp1.Show();
        }

        private void ButtonChoseEditIngredientsPrice_Click(object sender, EventArgs e)
        {
            ChoseEditIngredient = 2;
            this.Hide();
            EditIngredientsHelp ingredientsHelp2 = new EditIngredientsHelp(ChoseEditIngredient);
            ingredientsHelp2.Show();
        }
    }
}
