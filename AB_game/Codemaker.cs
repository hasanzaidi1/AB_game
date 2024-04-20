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
    public partial class Codemaker : Form
    {
        public string secretNumber;

        public Codemaker(string secretNum)
        {
            InitializeComponent();
            this.secretNumber = secretNum;
        }

        private void GenerateNum_Click(object sender, EventArgs e)
        {
            Num.Text = secretNumber.ToString();
        }



    }
}