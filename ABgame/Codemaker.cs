using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Formats.Asn1.AsnWriter;

namespace ABgame
{
    public partial class Codemaker : Form
    {
        public string secretNumber;
        public Stopwatch stopwatch = new Stopwatch();
        public int guessCount = 0;  // Counter for the number of guesses

        public Codemaker()
        {
            InitializeComponent();
            timer.Start();
        }

        public void LogGameplay()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hassa\\Downloads\\ABgameUpdatedDB\\ABgame\\ABgame\\ABgame.mdf;Integrated Security=True";

            // Calculate game score each time before logging
            int totalSeconds = (int)stopwatch.Elapsed.TotalSeconds;
            int gameScore = CalculateGameScore(guessCount, totalSeconds);
            ScoreLbl.Text = "Score: " + gameScore;

            string query = @"INSERT INTO CodemakerDB (PlayerName, GameMode, PlayDateTime, NumberOfAttempts, TotalSeconds, Guesses, Hints, GameScore)
                     VALUES (@PlayerName, @GameMode, @PlayDateTime, @NumberOfAttempts, @TotalSeconds, @Guesses, @Hints, @GameScore)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@PlayerName", Nametxtbox.Text);
                    command.Parameters.AddWithValue("@GameMode", "Codemaker");
                    command.Parameters.AddWithValue("@PlayDateTime", DateTime.Now);
                    command.Parameters.AddWithValue("@NumberOfAttempts", guessCount);
                    command.Parameters.AddWithValue("@TotalSeconds", totalSeconds);
                    command.Parameters.AddWithValue("@Guesses", GuessTxtBox.Text);
                    command.Parameters.AddWithValue("@Hints", HintLbl.Text);
                    command.Parameters.AddWithValue("@GameScore", gameScore);

                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }



        public void GenerateSecretNumBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> digits = Enumerable.Range(1, 9).ToList();
            secretNumber = digits[rnd.Next(0, digits.Count)].ToString();
            digits = Enumerable.Range(0, 10).Except(new int[] { int.Parse(secretNumber) }).ToList();

            while (secretNumber.Length < 4)
            {
                int index = rnd.Next(0, digits.Count);
                secretNumber += digits[index];
                digits.RemoveAt(index);
            }

            SecretNumberlbl.Text = secretNumber;  // Display secret number
        }

        public void SecretNumberlbl_Click(object sender, EventArgs e)
        {
            SecretNumberlbl.Text = secretNumber;
        }

        public bool firstGuess = true;
        public void GuessTxtBox_TextChanged(object sender, EventArgs e)
        {
            string guess = ((TextBox)sender).Text;

            if (guess.Length == 4)  // Only process when a full guess is made
            {
                if (firstGuess)
                {
                    LogGameplay();
                    DateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd"); // Set the current date on the first guess
                    stopwatch.Restart(); // Start the stopwatch on the first valid guess
                    firstGuess = false;
                }

                // Prepare hint display
                HintLbl.Text = GenerateHint(guess);
            }
        }






        public string GenerateHint(string guess)
        {
            int A = 0, B = 0;
            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == secretNumber[i])
                {
                    A++;
                }
                else if (secretNumber.Contains(guess[i]))
                {
                    B++;
                }
            }
            return $"{A}A{B}B";
        }


        public void timer_Tick(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                StopwatchLbl.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
            }
        }

        private int CalculateGameScore(int totalTries, int totalSeconds)
        {
            // Game score = 10 x (10 - total tries + 1) - (total seconds taken / 10)
            int scorePart1 = 10 * (10 - totalTries + 1);
            int scorePart2 = totalSeconds / 10;  // Integer division
            int score = scorePart1 - scorePart2;

            return score;
        }

        private void EndGame()
        {
            int totalSeconds = (int)stopwatch.Elapsed.TotalSeconds;
            int score = CalculateGameScore(guessCount, totalSeconds);
            ScoreLbl.Text = "Score: " + score;

            // Show the game over message with the score
            MessageBox.Show("Game Over! Time: " + StopwatchLbl.Text + "\nScore: " + ScoreLbl.Text);

            // Log the final gameplay state
            LogGameplay();

            // Stop the stopwatch and update the UI
            stopwatch.Stop();
            StopwatchLbl.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss");

            // Show the game log form
            ShowGameLog();
        }

        private void ShowGameLog()
        {
            codemakerGamePlayLog logForm = new codemakerGamePlayLog();
            logForm.ShowDialog();
        }



        private void Nametxtbox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Implement logic as needed when name text changes
        }

        private void EnterGuessBtn_Click(object sender, EventArgs e)
        {
            string guess = GuessTxtBox.Text.Trim();

            if (guess.Length == 4 && int.TryParse(guess, out _))

            {
                guessCount++;  // Increment the guess count correctly before logging
                AttemptsLbl.Text = "Attempts: " + guessCount;

                // Update hint before logging
                HintLbl.Text = GenerateHint(guess);

                // Log each guess with the current state
                LogGameplay();

                // Check for game ending conditions
                if (guess == secretNumber || guessCount >= 10)
                {
                    EndGame(); // Calculate score, log final state, and show the game log form
                    GuessTxtBox.Enabled = false;  // Disable the input field
                }

                GuessTxtBox.Clear();  // Clear the textbox for the next guess if the game continues
            }
            else
            {
                MessageBox.Show("Please enter a valid 4-digit number.");
            }
        }

    }
}

