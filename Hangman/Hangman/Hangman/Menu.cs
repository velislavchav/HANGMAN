using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Компютърът избира една дума, а ти трябва да я познаеш от 7 опита и да спасиш човека. Ако я познаеш - печелиш точки и спасяваш човека.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Game hangman = new Game();
            hangman.ShowDialog();
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Само за админи!");
            Login goToLogin = new Login();
            goToLogin.ShowDialog();
        }
    }
}
