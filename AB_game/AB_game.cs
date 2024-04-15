namespace AB_game
{
    public partial class AB_game : Form
    {

        public int currAttempts = 10;
        public string enteredNum;
        List<string> enteredNumList = new List<string>();

        public AB_game()
        {
            InitializeComponent();
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
            string joinedString = string.Join(Environment.NewLine, enteredNumList);
            HistoryBox.Text = joinedString;
        }

        private void HistoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
