namespace ABgame
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
            components = new System.ComponentModel.Container();
            NameLbl = new Label();
            Nametxtbox = new TextBox();
            DateLbl = new Label();
            StopwatchLbl = new Label();
            EnteredHints = new Label();
            ATxtBox = new TextBox();
            BTxtBox = new TextBox();
            Albl = new Label();
            Blbl = new Label();
            GenerateNum = new Button();
            GeneratedNum = new Label();
            EnterHintsBtn = new Button();
            timer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            AttemptsLbl = new Label();
            FinishBtn = new Button();
            GameScore = new Label();
            ScoreL = new Label();
            SuspendLayout();
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            NameLbl.Location = new Point(30, 29);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(68, 28);
            NameLbl.TabIndex = 1;
            NameLbl.Text = "Name";
            // 
            // Nametxtbox
            // 
            Nametxtbox.Location = new Point(104, 29);
            Nametxtbox.Name = "Nametxtbox";
            Nametxtbox.Size = new Size(150, 31);
            Nametxtbox.TabIndex = 2;
            // 
            // DateLbl
            // 
            DateLbl.AutoSize = true;
            DateLbl.Font = new Font("Segoe UI", 10F);
            DateLbl.Location = new Point(31, 76);
            DateLbl.Name = "DateLbl";
            DateLbl.Size = new Size(53, 28);
            DateLbl.TabIndex = 10;
            DateLbl.Text = "Date";
            // 
            // StopwatchLbl
            // 
            StopwatchLbl.AutoSize = true;
            StopwatchLbl.Font = new Font("Segoe UI", 10F);
            StopwatchLbl.Location = new Point(31, 115);
            StopwatchLbl.Name = "StopwatchLbl";
            StopwatchLbl.Size = new Size(61, 28);
            StopwatchLbl.TabIndex = 11;
            StopwatchLbl.Text = "Timer";
            // 
            // EnteredHints
            // 
            EnteredHints.AutoSize = true;
            EnteredHints.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            EnteredHints.Location = new Point(313, 276);
            EnteredHints.Name = "EnteredHints";
            EnteredHints.Size = new Size(123, 28);
            EnteredHints.TabIndex = 12;
            EnteredHints.Text = "Enter Hints:";
            // 
            // ATxtBox
            // 
            ATxtBox.Location = new Point(442, 276);
            ATxtBox.Name = "ATxtBox";
            ATxtBox.Size = new Size(37, 31);
            ATxtBox.TabIndex = 13;
            // 
            // BTxtBox
            // 
            BTxtBox.Location = new Point(510, 276);
            BTxtBox.Name = "BTxtBox";
            BTxtBox.Size = new Size(37, 31);
            BTxtBox.TabIndex = 14;
            // 
            // Albl
            // 
            Albl.AutoSize = true;
            Albl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Albl.Location = new Point(476, 282);
            Albl.Name = "Albl";
            Albl.Size = new Size(28, 30);
            Albl.TabIndex = 15;
            Albl.Text = "A";
            // 
            // Blbl
            // 
            Blbl.AutoSize = true;
            Blbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Blbl.Location = new Point(549, 281);
            Blbl.Name = "Blbl";
            Blbl.Size = new Size(27, 30);
            Blbl.TabIndex = 16;
            Blbl.Text = "B";
            // 
            // GenerateNum
            // 
            GenerateNum.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            GenerateNum.Location = new Point(351, 101);
            GenerateNum.Name = "GenerateNum";
            GenerateNum.Size = new Size(197, 85);
            GenerateNum.TabIndex = 17;
            GenerateNum.Text = "Generate Number";
            GenerateNum.UseVisualStyleBackColor = true;
            GenerateNum.Click += GenerateNum_Click;
            // 
            // GeneratedNum
            // 
            GeneratedNum.AutoSize = true;
            GeneratedNum.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            GeneratedNum.Location = new Point(430, 214);
            GeneratedNum.Name = "GeneratedNum";
            GeneratedNum.Size = new Size(36, 32);
            GeneratedNum.TabIndex = 18;
            GeneratedNum.Text = "??";
            // 
            // EnterHintsBtn
            // 
            EnterHintsBtn.Location = new Point(582, 278);
            EnterHintsBtn.Name = "EnterHintsBtn";
            EnterHintsBtn.Size = new Size(112, 34);
            EnterHintsBtn.TabIndex = 20;
            EnterHintsBtn.Text = "Enter Hints";
            EnterHintsBtn.UseVisualStyleBackColor = true;
            EnterHintsBtn.Click += EnterHintsBtn_Click;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(366, 345);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 21;
            label1.Text = "Attempts:";
            // 
            // AttemptsLbl
            // 
            AttemptsLbl.AutoSize = true;
            AttemptsLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AttemptsLbl.Location = new Point(476, 345);
            AttemptsLbl.Name = "AttemptsLbl";
            AttemptsLbl.Size = new Size(19, 25);
            AttemptsLbl.TabIndex = 22;
            AttemptsLbl.Text = "-";
            // 
            // FinishBtn
            // 
            FinishBtn.Location = new Point(682, 176);
            FinishBtn.Name = "FinishBtn";
            FinishBtn.Size = new Size(135, 70);
            FinishBtn.TabIndex = 23;
            FinishBtn.Text = "Code Cracked! END";
            FinishBtn.UseVisualStyleBackColor = true;
            FinishBtn.Click += FinishBtn_Click;
            // 
            // GameScore
            // 
            GameScore.AutoSize = true;
            GameScore.Font = new Font("Segoe UI", 10F);
            GameScore.Location = new Point(30, 158);
            GameScore.Name = "GameScore";
            GameScore.Size = new Size(121, 28);
            GameScore.TabIndex = 24;
            GameScore.Text = "Game Score:";
            // 
            // ScoreL
            // 
            ScoreL.AutoSize = true;
            ScoreL.Font = new Font("Segoe UI", 10F);
            ScoreL.Location = new Point(157, 158);
            ScoreL.Name = "ScoreL";
            ScoreL.Size = new Size(20, 28);
            ScoreL.TabIndex = 25;
            ScoreL.Text = "-";
            // 
            // Codebreaker
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 450);
            Controls.Add(ScoreL);
            Controls.Add(GameScore);
            Controls.Add(FinishBtn);
            Controls.Add(AttemptsLbl);
            Controls.Add(label1);
            Controls.Add(EnterHintsBtn);
            Controls.Add(GeneratedNum);
            Controls.Add(GenerateNum);
            Controls.Add(Blbl);
            Controls.Add(Albl);
            Controls.Add(BTxtBox);
            Controls.Add(ATxtBox);
            Controls.Add(EnteredHints);
            Controls.Add(StopwatchLbl);
            Controls.Add(DateLbl);
            Controls.Add(Nametxtbox);
            Controls.Add(NameLbl);
            Name = "Codebreaker";
            Text = "Codebreaker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLbl;
        private TextBox Nametxtbox;
        private Label DateLbl;
        private Label StopwatchLbl;
        private Label EnteredHints;
        private TextBox ATxtBox;
        private TextBox BTxtBox;
        private Label Albl;
        private Label Blbl;
        private Button GenerateNum;
        private Label GeneratedNum;
        private Button EnterHintsBtn;
        private System.Windows.Forms.Timer timer;
        private Label label1;
        private Label AttemptsLbl;
        private Button FinishBtn;
        private Label GameScore;
        private Label ScoreL;
    }
}