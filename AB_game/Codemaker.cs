namespace AB_game
{
    public partial class Codemaker : Form
    {

        public int currAttempts = 10;
        public string enteredNum;
        List<string> enteredNumList;
        public string fourDigitNumber;

        public string SecretNumber { get; private set; }

        public Codemaker()
        {
            InitializeComponent();
        }

        // Generate a random four-digit number with no repeating digits
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

        private void GenerateNum_Click(object sender, EventArgs e)
        {
            SecretNumber = GenerateSecretNumber();
            Num.Text = SecretNumber.ToString();
            GenerateNum.Enabled = false;
        }
    }
}
