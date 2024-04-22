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
    public partial class PlayersInfo : Form
    {

        public string TeamName { get; private set; }
        public string GameMode { get; private set; }


        public PlayersInfo()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(teamNameTxtBox.Text))
            {
                MessageBox.Show("Please enter a team name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ModeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a game mode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TeamName = teamNameTxtBox.Text;
            GameMode = ModeComboBox.SelectedItem.ToString();

            this.Close();
        }
    }
}
