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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ExitButtonMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonLoginAdm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void ExitButton_MouseEnter(object sender, EventArgs e) => ExitButtonMain.ForeColor = Color.Red;
        private void ExitButton_MouseLeave(object sender, EventArgs e) => ExitButtonMain.ForeColor = Color.White;

        private void ButtonShowMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
