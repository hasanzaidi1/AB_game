namespace AB_game
{
    public partial class Codemaker : Form
    {

        public int currAttempts = 10;
        //List<string> enteredNumList;
        public string secretNumber; 

        WelcomeForm welcomeForm = new WelcomeForm();


        public Codemaker()
        {
            secretNumber = GenerateSecretNumber();
            InitializeComponent();
        }

        // Generate a random four-digit number with no repeating digits
        public string GenerateSecretNumber()
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

        private void GenerateNum_Click(object sender, EventArgs e)
        {
            Num.Text = secretNumber.ToString();
            GenerateNum.Enabled = false;
        }

        public void CompareNum(string guessedNum)
        {
            if(secretNumber.Equals(guessedNum))
            {
                MessageBox.Show("Correct");
            } 
            else
            {
                MessageBox.Show("Not Correct ");
            }
        }

    }
}
