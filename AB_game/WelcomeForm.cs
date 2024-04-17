using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AB_game
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void codemakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Codemaker maker = new Codemaker();


            maker.Show();
        }

        private void codebreakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Codebreaker breaker = new Codebreaker();


            breaker.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
