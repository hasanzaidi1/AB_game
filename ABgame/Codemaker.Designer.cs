namespace ABgame
{
    partial class Codemaker
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Codemaker));
            NameLbl = new Label();
            Nametxtbox = new TextBox();
            SecretNumber = new Label();
            GenerateSecretNumBtn = new Button();
            SecretNumberlbl = new Label();
            EnteredGuess = new Label();
            Hint = new Label();
            GuessTxtBox = new TextBox();
            HintLbl = new Label();
            DateLbl = new Label();
            StopwatchLbl = new Label();
            label1 = new Label();
            AttemptsLbl = new Label();
            timer = new System.Windows.Forms.Timer(components);
            GameScore = new Label();
            ScoreLbl = new Label();
            EnterGuessBtn = new Button();
            SuspendLayout();
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            NameLbl.Location = new Point(57, 39);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(68, 28);
            NameLbl.TabIndex = 0;
            NameLbl.Text = "Name";
            // 
            // Nametxtbox
            // 
            Nametxtbox.Location = new Point(131, 39);
            Nametxtbox.Name = "Nametxtbox";
            Nametxtbox.Size = new Size(150, 31);
            Nametxtbox.TabIndex = 1;
            Nametxtbox.TextChanged += Nametxtbox_TextChanged;
            // 
            // SecretNumber
            // 
            SecretNumber.AutoSize = true;
            SecretNumber.Font = new Font("Segoe UI", 10F);
            SecretNumber.Location = new Point(229, 214);
            SecretNumber.Name = "SecretNumber";
            SecretNumber.Size = new Size(147, 28);
            SecretNumber.TabIndex = 2;
            SecretNumber.Text = "Secret Number:";
            // 
            // GenerateSecretNumBtn
            // 
            GenerateSecretNumBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            GenerateSecretNumBtn.Location = new Point(360, 109);
            GenerateSecretNumBtn.Name = "GenerateSecretNumBtn";
            GenerateSecretNumBtn.Size = new Size(186, 89);
            GenerateSecretNumBtn.TabIndex = 3;
            GenerateSecretNumBtn.Text = "Generate Secret Number";
            GenerateSecretNumBtn.UseVisualStyleBackColor = true;
            GenerateSecretNumBtn.Click += GenerateSecretNumBtn_Click;
            // 
            // SecretNumberlbl
            // 
            SecretNumberlbl.AutoSize = true;
            SecretNumberlbl.Font = new Font("Segoe UI", 11F);
            SecretNumberlbl.Location = new Point(418, 214);
            SecretNumberlbl.Name = "SecretNumberlbl";
            SecretNumberlbl.Size = new Size(93, 30);
            SecretNumberlbl.TabIndex = 4;
            SecretNumberlbl.Text = "Secret #";
            SecretNumberlbl.Click += SecretNumberlbl_Click;
            // 
            // EnteredGuess
            // 
            EnteredGuess.AutoSize = true;
            EnteredGuess.Font = new Font("Segoe UI", 10F);
            EnteredGuess.Location = new Point(229, 279);
            EnteredGuess.Name = "EnteredGuess";
            EnteredGuess.Size = new Size(139, 28);
            EnteredGuess.TabIndex = 5;
            EnteredGuess.Text = "Entered Guess:";
            // 
            // Hint
            // 
            Hint.AutoSize = true;
            Hint.Font = new Font("Segoe UI", 10F);
            Hint.Location = new Point(229, 352);
            Hint.Name = "Hint";
            Hint.Size = new Size(53, 28);
            Hint.TabIndex = 6;
            Hint.Text = "Hint:";
            // 
            // GuessTxtBox
            // 
            GuessTxtBox.Font = new Font("Segoe UI", 11F);
            GuessTxtBox.Location = new Point(379, 279);
            GuessTxtBox.Name = "GuessTxtBox";
            GuessTxtBox.Size = new Size(150, 37);
            GuessTxtBox.TabIndex = 7;
            GuessTxtBox.TextChanged += GuessTxtBox_TextChanged;
            // 
            // HintLbl
            // 
            HintLbl.AutoSize = true;
            HintLbl.Font = new Font("Segoe UI", 11F);
            HintLbl.Location = new Point(418, 350);
            HintLbl.Name = "HintLbl";
            HintLbl.Size = new Size(53, 30);
            HintLbl.TabIndex = 8;
            HintLbl.Text = "Hint";
            // 
            // DateLbl
            // 
            DateLbl.AutoSize = true;
            DateLbl.Font = new Font("Segoe UI", 10F);
            DateLbl.Location = new Point(773, 26);
            DateLbl.Name = "DateLbl";
            DateLbl.Size = new Size(53, 28);
            DateLbl.TabIndex = 9;
            DateLbl.Text = "Date";
            // 
            // StopwatchLbl
            // 
            StopwatchLbl.AutoSize = true;
            StopwatchLbl.Font = new Font("Segoe UI", 10F);
            StopwatchLbl.Location = new Point(773, 88);
            StopwatchLbl.Name = "StopwatchLbl";
            StopwatchLbl.Size = new Size(61, 28);
            StopwatchLbl.TabIndex = 10;
            StopwatchLbl.Text = "Timer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 405);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 11;
            label1.Text = "Attempts:";
            // 
            // AttemptsLbl
            // 
            AttemptsLbl.AutoSize = true;
            AttemptsLbl.Location = new Point(412, 405);
            AttemptsLbl.Name = "AttemptsLbl";
            AttemptsLbl.Size = new Size(86, 25);
            AttemptsLbl.TabIndex = 12;
            AttemptsLbl.Text = "Attempts";
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // GameScore
            // 
            GameScore.AutoSize = true;
            GameScore.Font = new Font("Segoe UI", 10F);
            GameScore.Location = new Point(675, 139);
            GameScore.Name = "GameScore";
            GameScore.Size = new Size(121, 28);
            GameScore.TabIndex = 13;
            GameScore.Text = "Game Score:";
            // 
            // ScoreLbl
            // 
            ScoreLbl.AutoSize = true;
            ScoreLbl.Font = new Font("Segoe UI", 10F);
            ScoreLbl.Location = new Point(814, 139);
            ScoreLbl.Name = "ScoreLbl";
            ScoreLbl.Size = new Size(20, 28);
            ScoreLbl.TabIndex = 14;
            ScoreLbl.Text = "-";
            // 
            // EnterGuessBtn
            // 
            EnterGuessBtn.Location = new Point(558, 281);
            EnterGuessBtn.Name = "EnterGuessBtn";
            EnterGuessBtn.Size = new Size(112, 34);
            EnterGuessBtn.TabIndex = 15;
            EnterGuessBtn.Text = "Enter";
            EnterGuessBtn.UseVisualStyleBackColor = true;
            EnterGuessBtn.Click += EnterGuessBtn_Click;
            // 
            // Codemaker
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(904, 450);
            Controls.Add(EnterGuessBtn);
            Controls.Add(ScoreLbl);
            Controls.Add(GameScore);
            Controls.Add(AttemptsLbl);
            Controls.Add(label1);
            Controls.Add(StopwatchLbl);
            Controls.Add(DateLbl);
            Controls.Add(HintLbl);
            Controls.Add(GuessTxtBox);
            Controls.Add(Hint);
            Controls.Add(EnteredGuess);
            Controls.Add(SecretNumberlbl);
            Controls.Add(GenerateSecretNumBtn);
            Controls.Add(SecretNumber);
            Controls.Add(Nametxtbox);
            Controls.Add(NameLbl);
            Name = "Codemaker";
            Text = "Codemaker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLbl;
        private TextBox Nametxtbox;
        private Label SecretNumber;
        private Button GenerateSecretNumBtn;
        private Label SecretNumberlbl;
        private Label EnteredGuess;
        private Label Hint;
        private TextBox GuessTxtBox;
        private Label HintLbl;
        private Label DateLbl;
        private Label StopwatchLbl;
        private Label label1;
        private Label AttemptsLbl;
        private System.Windows.Forms.Timer timer;
        private Label GameScore;
        private Label ScoreLbl;
        private Button EnterGuessBtn;
    }
}