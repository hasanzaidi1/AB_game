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

        public Codebreaker()
        {
            InitializeComponent();
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
                currAttempts -= 1;
            }

        }

        private void GuessBtn_Click(object sender, EventArgs e)
        {
            enteredNum = GuessTxtBox.Text.ToString();
            Codemaker cm = new Codemaker();
            cm.CompareNum(enteredNum);
            
        }
    }
}
