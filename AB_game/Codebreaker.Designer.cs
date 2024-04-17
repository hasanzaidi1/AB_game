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
            SuspendLayout();
            // 
            // GuessBtn
            // 
            GuessBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GuessBtn.Location = new Point(645, 246);
            GuessBtn.Name = "GuessBtn";
            GuessBtn.Size = new Size(112, 47);
            GuessBtn.TabIndex = 0;
            GuessBtn.Text = "Guess";
            GuessBtn.UseVisualStyleBackColor = true;
            // 
            // GuessTxtBox
            // 
            GuessTxtBox.Font = new Font("Segoe UI", 14F);
            GuessTxtBox.Location = new Point(422, 245);
            GuessTxtBox.Name = "GuessTxtBox";
            GuessTxtBox.Size = new Size(150, 45);
            GuessTxtBox.TabIndex = 1;
            GuessTxtBox.TextChanged += GuessTxtBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(350, 88);
            label1.Name = "label1";
            label1.Size = new Size(317, 45);
            label1.TabIndex = 2;
            label1.Text = "Codebreakers Guess:";
            // 
            // Codebreaker
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(898, 465);
            Controls.Add(label1);
            Controls.Add(GuessTxtBox);
            Controls.Add(GuessBtn);
            Name = "Codebreaker";
            Text = "Codebreaker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GuessBtn;
        private TextBox GuessTxtBox;
        private Label label1;
    }
}