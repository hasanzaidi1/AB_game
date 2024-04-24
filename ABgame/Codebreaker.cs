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
using CIS3433;
using System.Data.SqlClient;
using System.Configuration;


namespace ABgame
{
    public partial class Codebreaker : Form
    {
        public CodebreakerLogic codebreaker;
        public System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
        public int hintCount = 0;

        public Codebreaker()
        {
            InitializeComponent();
            codebreaker = new CodebreakerLogic();
            timer.Start();
        }

        public void LogGameplay(string guess)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            string hint = ATxtBox.Text + "A | " + BTxtBox.Text + "B";

            // Calculate the game score
            int totalSeconds = (int)stopwatch.Elapsed.TotalSeconds;
            int gameScore = CalculateGameScore(hintCount, totalSeconds); // Ensure this method returns the score correctly
            ScoreL.Text = "Score: " + gameScore; // Assuming ScoreLbl is your score display label

            string query = @"INSERT INTO CodebreakerDB (PlayerName, GameMode, PlayDateTime, NumberOfAttempts, TotalSeconds, Guesses, Hints, GameScore)
                     VALUES (@PlayerName, @GameMode, @PlayDateTime, @NumberOfAttempts, @TotalSeconds, @Guesses, @Hints, @GameScore)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@PlayerName", Nametxtbox.Text);
                    command.Parameters.AddWithValue("@GameMode", "Codebreaker");
                    command.Parameters.AddWithValue("@PlayDateTime", DateTime.Now);
                    command.Parameters.AddWithValue("@NumberOfAttempts", hintCount);
                    command.Parameters.AddWithValue("@TotalSeconds", totalSeconds);
                    command.Parameters.AddWithValue("@Guesses", guess);
                    command.Parameters.AddWithValue("@Hints", hint);
                    command.Parameters.AddWithValue("@GameScore", gameScore);  // Add the game score parameter

                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }



        public void GenerateNum_Click(object sender, EventArgs e)
        {
            if (!stopwatch.IsRunning)
            {
                stopwatch.Start();
                DateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }


            string generatedNumber = codebreaker.GenerateNumber();
            if (string.IsNullOrEmpty(generatedNumber))
            {
                MessageBox.Show("No numbers left to generate.");
                FinishGame();
                return;
            }

            GeneratedNum.Text = generatedNumber;
        }

        private void EnterHintsBtn_Click(object sender, EventArgs e)
        {
            int correctPositions, wrongPositions;
            if (int.TryParse(ATxtBox.Text, out correctPositions) && int.TryParse(BTxtBox.Text, out wrongPositions))
            {
                hintCount++;
                AttemptsLbl.Text = " " + (0 + hintCount) + " ";
                if (codebreaker.ApplyHints(correctPositions, wrongPositions))
                {
                    MessageBox.Show($"Filtered to {codebreaker.PossibleNumbers.Count} possible numbers.");
                    LogGameplay(GeneratedNum.Text); // Log every hint input right after processing
                    if (codebreaker.PossibleNumbers.Count == 0)
                    {
                        FinishGame();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid hint combination entered, please check and retry.");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for hints.");
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                StopwatchLbl.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
            }
        }

        private void FinishGame()
        {
            stopwatch.Stop();
            StopwatchLbl.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
            MessageBox.Show("Game Over! Time: " + StopwatchLbl.Text + "\nScore: " + ScoreL.Text);
            ShowGameLog();  // Open the log form and display the game results
            ResetGameState();
        }

        private int CalculateGameScore(int totalTries, int totalSeconds)
        {
            // Game score = 10 x (10 - total tries + 1) - (total seconds taken / 10)
            int scorePart1 = 10 * (10 - totalTries + 1);
            int scorePart2 = totalSeconds / 10;  // Integer division
            int score = scorePart1 - scorePart2;

            return score;
        }

        private void ShowGameLog()
        {
            codebreakerGamePlayLog logForm = new codebreakerGamePlayLog();
            logForm.ShowDialog();
        }



        private void FinishBtn_Click(object sender, EventArgs e)
        {
            FinishGame(); 
            ResetGameState();
        }

        private void ResetGameState()
        {
            hintCount = 0;
            //AttemptsLbl.Text = "10 attempts remaining";
            GeneratedNum.Text = ""; // Clear the last generated number
            ATxtBox.Clear();
            BTxtBox.Clear();
        }
    }

}
