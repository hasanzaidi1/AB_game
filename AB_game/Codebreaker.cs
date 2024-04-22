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
    public partial class Codebreaker : Form
    {
        public int currAttempts = 10;
        public string enteredNum;
        List<string> enteredNumList = new List<string>();
        private string secretNumber;



        public Codebreaker(string secretNumber)
        {
            InitializeComponent();
            this.secretNumber = secretNumber;
        }

        private void GuessBtn_Click(object sender, EventArgs e)
        {
            string guessedNum = GuessTxtBox.Text;
            string histBoxEntry;

            if (IsNumSame(guessedNum))
            {
                hintLabel.Text = CalculateHint(guessedNum);
                histBoxEntry = guessedNum.ToString() + "   " + CalculateHint(guessedNum);
                histBox.Items.Add(histBoxEntry.ToString());
                MessageBox.Show("Correct");
            }
            else
            {
                currAttempts -= 1;
                attemptsLeftLabel.Text = "Attempts Left: " + currAttempts.ToString();
                hintLabel.Text = CalculateHint(guessedNum);
                histBoxEntry = guessedNum.ToString() + "   " + CalculateHint(guessedNum);
                histBox.Items.Add(histBoxEntry.ToString());
                MessageBox.Show("Try Again");
            }

            if(currAttempts == 0)
            {
                GuessBtn.Enabled = false;
            }

        }

        private bool IsNumSame(string guessedNum)
        {
            return guessedNum == secretNumber;
        }

        private void GuessTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (GuessTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Enter a numerical value");
            }
            else
            {
                enteredNum = (GuessTxtBox.Text).ToString();
                enteredNumList.Add(enteredNum);
                
            }
        }

        private void Codebreaker_Load(object sender, EventArgs e)
        {

        }

        private string CalculateHint(string guessedNum)
        {
            if (guessedNum.Length != secretNumber.Length)
            {
                throw new ArgumentException("The length of the guessed number must match the length of the secret number.");
            }

            int correctPos = 0;
            int correctNum = 0;

            Dictionary<char, int> guessedNumCounts = new Dictionary<char, int>();
            Dictionary<char, int> secretNumCounts = new Dictionary<char, int>();

            for (int i = 0; i < guessedNum.Length; i++)
            {
                char guessedDigit = guessedNum[i];
                char secretDigit = secretNumber[i];

                if (guessedDigit == secretDigit)
                {
                    correctPos++;
                }
                else
                {
                    guessedNumCounts.TryGetValue(guessedDigit, out int guessedCount);
                    secretNumCounts.TryGetValue(secretDigit, out int secretCount);

                    guessedNumCounts[guessedDigit] = guessedCount + 1;
                    secretNumCounts[secretDigit] = secretCount + 1;
                }
            }

            foreach (var kvp in guessedNumCounts)
            {
                char digit = kvp.Key;
                int guessedCount = kvp.Value;

                if (secretNumCounts.TryGetValue(digit, out int secretCount))
                {
                    correctNum += Math.Min(guessedCount, secretCount);
                }
            }

            return $"{correctPos}A{correctNum}B";
        }


    }
}