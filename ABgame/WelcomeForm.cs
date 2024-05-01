using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CIS3433;

namespace ABgame
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void codemakerMenuStrip_Click(object sender, EventArgs e)
        {
            Codemaker codemaker = new Codemaker();
            codemaker.Show();
        }

        private void codebreakerMenuStrip_Click(object sender, EventArgs e)
        {
            Codebreaker codebreaker = new Codebreaker();
            codebreaker.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CodemakerBtn_Click(object sender, EventArgs e)
        {
            Codemaker codemaker = new Codemaker();
            codemaker.Show();
        }

        private void CodebreakerBtn_Click(object sender, EventArgs e)
        {
            Codebreaker codebreaker = new Codebreaker();
            codebreaker.Show();
        }

        private void codemakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Codemaker codemaker = new Codemaker();
            codemaker.Show();
        }

        private void codebreakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Codebreaker codebreaker = new Codebreaker();
            codebreaker.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
