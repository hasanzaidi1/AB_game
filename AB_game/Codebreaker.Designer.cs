namespace AB_game
{
    partial class Codebreaker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Codebreaker));
            GuessBtn = new Button();
            GuessTxtBox = new TextBox();
            label1 = new Label();
            hintLabel = new Label();
            histBox = new ListBox();
            attemptsLeftLabel = new Label();
            SuspendLayout();
            // 
            // GuessBtn
            // 
            GuessBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GuessBtn.Location = new Point(452, 148);
            GuessBtn.Margin = new Padding(2);
            GuessBtn.Name = "GuessBtn";
            GuessBtn.Size = new Size(78, 28);
            GuessBtn.TabIndex = 0;
            GuessBtn.Text = "Guess";
            GuessBtn.UseVisualStyleBackColor = true;
            GuessBtn.Click += GuessBtn_Click;
            // 
            // GuessTxtBox
            // 
            GuessTxtBox.Font = new Font("Segoe UI", 14F);
            GuessTxtBox.Location = new Point(295, 147);
            GuessTxtBox.Margin = new Padding(2);
            GuessTxtBox.Name = "GuessTxtBox";
            GuessTxtBox.Size = new Size(106, 32);
            GuessTxtBox.TabIndex = 1;
            GuessTxtBox.TextChanged += GuessTxtBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(245, 53);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(217, 30);
            label1.TabIndex = 2;
            label1.Text = "Codebreakers Guess:";
            // 
            // hintLabel
            // 
            hintLabel.AutoSize = true;
            hintLabel.Font = new Font("Segoe UI", 16F);
            hintLabel.Location = new Point(311, 105);
            hintLabel.Name = "hintLabel";
            hintLabel.Size = new Size(0, 30);
            hintLabel.TabIndex = 3;
            // 
            // histBox
            // 
            histBox.FormattingEnabled = true;
            histBox.ItemHeight = 15;
            histBox.Location = new Point(41, 34);
            histBox.Name = "histBox";
            histBox.Size = new Size(132, 184);
            histBox.TabIndex = 4;
            // 
            // attemptsLeftLabel
            // 
            attemptsLeftLabel.AutoSize = true;
            attemptsLeftLabel.Location = new Point(443, 178);
            attemptsLeftLabel.Name = "attemptsLeftLabel";
            attemptsLeftLabel.Size = new Size(97, 15);
            attemptsLeftLabel.TabIndex = 5;
            attemptsLeftLabel.Text = "Attempts Left: 10";
            // 
            // Codebreaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(629, 279);
            Controls.Add(attemptsLeftLabel);
            Controls.Add(histBox);
            Controls.Add(hintLabel);
            Controls.Add(label1);
            Controls.Add(GuessTxtBox);
            Controls.Add(GuessBtn);
            Margin = new Padding(2);
            Name = "Codebreaker";
            Text = "Codebreaker";
            Load += Codebreaker_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GuessBtn;
        private TextBox GuessTxtBox;
        private Label label1;
        private Label hintLabel;
        private ListBox histBox;
        private Label attemptsLeftLabel;
    }
}