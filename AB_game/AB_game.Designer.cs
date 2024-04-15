namespace AB_game
{
    partial class AB_game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            Submitbtn = new Button();
            HistoryBox = new ListBox();
            GuessLbl = new Label();
            Attempts = new Label();
            AttemptsLeft = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(258, 133);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 23);
            textBox1.TabIndex = 0;
            // 
            // Submitbtn
            // 
            Submitbtn.Location = new Point(379, 133);
            Submitbtn.Margin = new Padding(2);
            Submitbtn.Name = "Submitbtn";
            Submitbtn.Size = new Size(78, 20);
            Submitbtn.TabIndex = 1;
            Submitbtn.Text = "Submit";
            Submitbtn.UseVisualStyleBackColor = true;
            Submitbtn.Click += Submitbtn_Click;
            // 
            // HistoryBox
            // 
            HistoryBox.FormattingEnabled = true;
            HistoryBox.ItemHeight = 15;
            HistoryBox.Location = new Point(496, 37);
            HistoryBox.Margin = new Padding(2);
            HistoryBox.Name = "HistoryBox";
            HistoryBox.Size = new Size(127, 124);
            HistoryBox.TabIndex = 2;
            HistoryBox.SelectedIndexChanged += HistoryBox_SelectedIndexChanged;
            // 
            // GuessLbl
            // 
            GuessLbl.AutoSize = true;
            GuessLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            GuessLbl.Location = new Point(228, 77);
            GuessLbl.Margin = new Padding(2, 0, 2, 0);
            GuessLbl.Name = "GuessLbl";
            GuessLbl.Size = new Size(162, 21);
            GuessLbl.TabIndex = 3;
            GuessLbl.Text = "Codebreakers Guess";
            // 
            // Attempts
            // 
            Attempts.AutoSize = true;
            Attempts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Attempts.Location = new Point(438, 187);
            Attempts.Margin = new Padding(2, 0, 2, 0);
            Attempts.Name = "Attempts";
            Attempts.Size = new Size(103, 19);
            Attempts.TabIndex = 4;
            Attempts.Text = "Attempts Left:";
            // 
            // AttemptsLeft
            // 
            AttemptsLeft.AutoSize = true;
            AttemptsLeft.Font = new Font("Segoe UI", 10F);
            AttemptsLeft.Location = new Point(546, 187);
            AttemptsLeft.Margin = new Padding(2, 0, 2, 0);
            AttemptsLeft.Name = "AttemptsLeft";
            AttemptsLeft.Size = new Size(15, 19);
            AttemptsLeft.TabIndex = 5;
            AttemptsLeft.Text = "-";
            AttemptsLeft.Click += AttemptsLeft_Click;
            // 
            // AB_game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 270);
            Controls.Add(AttemptsLeft);
            Controls.Add(Attempts);
            Controls.Add(GuessLbl);
            Controls.Add(HistoryBox);
            Controls.Add(Submitbtn);
            Controls.Add(textBox1);
            Margin = new Padding(2);
            Name = "AB_game";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button Submitbtn;
        private ListBox HistoryBox;
        private Label GuessLbl;
        private Label Attempts;
        private Label AttemptsLeft;
    }
}
