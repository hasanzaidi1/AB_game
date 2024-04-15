namespace AB_game
{
    public partial class AB_game : Form
    {

        public int currAttempts = 10;
        public string enteredNum;
        List<string> enteredNumList = new List<string>();
        public string fourDigitNumber;

        public AB_game()
        {
            InitializeComponent();
            fourDigitNumber = CreateFourDigitNumber();
        }

        private string CreateFourDigitNumber()
        {
            Random random = new Random();
            int randomNumber1 = random.Next(10);
            int randomNumber2 = random.Next(10);
            int randomNumber3 = random.Next(10);
            int randomNumber4 = random.Next(10);

            // Ensure randomNumber2 is different from randomNumber1
            while (randomNumber2 == randomNumber1)
            {
                randomNumber2 = random.Next(10);
            }

            // Ensure randomNumber3 is different from randomNumber1 and randomNumber2
            while (randomNumber3 == randomNumber1 || randomNumber3 == randomNumber2)
            {
                randomNumber3 = random.Next(10);
            }

            // Ensure randomNumber4 is different from randomNumber1, randomNumber2, and randomNumber3
            while (randomNumber4 == randomNumber1 || randomNumber4 == randomNumber2 || randomNumber4 == randomNumber3)
            {
                randomNumber4 = random.Next(10);
            }
            string concatRandUniqueNums = randomNumber1.ToString() + randomNumber2.ToString() +
                randomNumber3.ToString() + randomNumber4.ToString();

            return concatRandUniqueNums;
        }

        private void AttemptsLeft_Click(object sender, EventArgs e)
        {

        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Enter a numerical value");
            }
            else
            {
                enteredNum = (textBox1.Text).ToString();
                enteredNumList.Add(enteredNum);
                currAttempts -= 1;
            }
            AttemptsLeft.Text = currAttempts.ToString();

            if (currAttempts == 0) { Submitbtn.Enabled = false; }

            textBox1.Text = string.Empty;
            UpdateHistoryBox();
        }

        private void UpdateHistoryBox()
        {
            HistoryBox.Items.Clear();
            foreach (string num in enteredNumList)
            {
                HistoryBox.Items.Add(num);
            }
        }

        private void HistoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RevealBtn_Click(object sender, EventArgs e)
        {
            label2.Text = fourDigitNumber.ToString();
            label2.Visible = true;
        }
    }
}
