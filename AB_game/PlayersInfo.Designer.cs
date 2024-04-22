namespace AB_game
{
    partial class PlayersInfo
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
            teamNameTxtBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ModeComboBox = new ComboBox();
            submitBtn = new Button();
            SuspendLayout();
            // 
            // teamNameTxtBox
            // 
            teamNameTxtBox.Location = new Point(192, 48);
            teamNameTxtBox.Name = "teamNameTxtBox";
            teamNameTxtBox.Size = new Size(141, 23);
            teamNameTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 51);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 5;
            label1.Text = "Team Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 86);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 6;
            label2.Text = "Breaker/Maker:";
            // 
            // ModeComboBox
            // 
            ModeComboBox.FormattingEnabled = true;
            ModeComboBox.Items.AddRange(new object[] { "Code Maker", "Code Breaker" });
            ModeComboBox.Location = new Point(192, 83);
            ModeComboBox.Name = "ModeComboBox";
            ModeComboBox.Size = new Size(121, 23);
            ModeComboBox.TabIndex = 7;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(67, 132);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(75, 23);
            submitBtn.TabIndex = 8;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // PlayersInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 196);
            Controls.Add(submitBtn);
            Controls.Add(ModeComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(teamNameTxtBox);
            Name = "PlayersInfo";
            Text = "PlayersInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameTxtBox;
        private Label label1;
        private Label label2;
        private ComboBox ModeComboBox;
        private Button submitBtn;
    }
}