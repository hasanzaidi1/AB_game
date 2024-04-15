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
            textBox1.Location = new Point(368, 221);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // Submitbtn
            // 
            Submitbtn.Location = new Point(541, 221);
            Submitbtn.Name = "Submitbtn";
            Submitbtn.Size = new Size(112, 34);
            Submitbtn.TabIndex = 1;
            Submitbtn.Text = "Submit";
            Submitbtn.UseVisualStyleBackColor = true;
            // 
            // HistoryBox
            // 
            HistoryBox.FormattingEnabled = true;
            HistoryBox.ItemHeight = 25;
            HistoryBox.Location = new Point(709, 62);
            HistoryBox.Name = "HistoryBox";
            HistoryBox.Size = new Size(180, 204);
            HistoryBox.TabIndex = 2;
            // 
            // GuessLbl
            // 
            GuessLbl.AutoSize = true;
            GuessLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            GuessLbl.Location = new Point(326, 129);
            GuessLbl.Name = "GuessLbl";
            GuessLbl.Size = new Size(244, 32);
            GuessLbl.TabIndex = 3;
            GuessLbl.Text = "Codebreakers Guess";
            // 
            // Attempts
            // 
            Attempts.AutoSize = true;
            Attempts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Attempts.Location = new Point(626, 312);
            Attempts.Name = "Attempts";
            Attempts.Size = new Size(148, 28);
            Attempts.TabIndex = 4;
            Attempts.Text = "Attempts Left:";
            // 
            // AttemptsLeft
            // 
            AttemptsLeft.AutoSize = true;
            AttemptsLeft.Font = new Font("Segoe UI", 10F);
            AttemptsLeft.Location = new Point(780, 312);
            AttemptsLeft.Name = "AttemptsLeft";
            AttemptsLeft.Size = new Size(20, 28);
            AttemptsLeft.TabIndex = 5;
            AttemptsLeft.Text = "-";
            // 
            // ABgame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 450);
            Controls.Add(AttemptsLeft);
            Controls.Add(Attempts);
            Controls.Add(GuessLbl);
            Controls.Add(HistoryBox);
            Controls.Add(Submitbtn);
            Controls.Add(textBox1);
            Name = "ABgame";
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
