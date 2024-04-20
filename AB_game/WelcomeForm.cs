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
        public string secretNumber;
        public WelcomeForm()
        {
            InitializeComponent();
            secretNumber = GenerateSecretNumber();

        }

        private void codemakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Codemaker codemaker = new Codemaker(secretNumber);
            codemaker.Show();
        }

        private void codebreakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Codebreaker breaker = new Codebreaker(secretNumber);
            breaker.Show();
        }

        private string GenerateSecretNumber()
        {
            Random random = new Random();
            List<int> digits = new List<int>();

            while (digits.Count < 4)
            {
                int num = random.Next(0, 10); // Generate a number between 0 and 9
                if (!digits.Contains(num))    // Ensure there are no duplicates
                {
                    digits.Add(num);
                }
            }

            return string.Join("", digits);  // Convert List<int> to string
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}