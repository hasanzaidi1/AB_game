namespace AB_game
{
    partial class Codemaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Codemaker));
            Num = new TextBox();
            GenerateNum = new Button();
            GuessLbl = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            MakeYourCodeBtn = new Button();
            SuspendLayout();
            // 
            // Num
            // 
            Num.Font = new Font("Segoe UI", 11F);
            Num.Location = new Point(249, 169);
            Num.Margin = new Padding(2);
            Num.Name = "Num";
            Num.Size = new Size(126, 27);
            Num.TabIndex = 0;
            // 
            // GenerateNum
            // 
            GenerateNum.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenerateNum.Location = new Point(255, 83);
            GenerateNum.Margin = new Padding(2);
            GenerateNum.Name = "GenerateNum";
            GenerateNum.Size = new Size(113, 53);
            GenerateNum.TabIndex = 1;
            GenerateNum.Text = "Generate Code";
            GenerateNum.UseVisualStyleBackColor = true;
            GenerateNum.Click += GenerateNum_Click;
            // 
            // GuessLbl
            // 
            GuessLbl.AutoSize = true;
            GuessLbl.BackColor = Color.Black;
            GuessLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            GuessLbl.ForeColor = SystemColors.ButtonFace;
            GuessLbl.Location = new Point(242, 25);
            GuessLbl.Margin = new Padding(2, 0, 2, 0);
            GuessLbl.Name = "GuessLbl";
            GuessLbl.Size = new Size(143, 32);
            GuessLbl.TabIndex = 3;
            GuessLbl.Text = "Codemaker";
            // 
            // MakeYourCodeBtn
            // 
            MakeYourCodeBtn.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MakeYourCodeBtn.Location = new Point(372, 83);
            MakeYourCodeBtn.Margin = new Padding(2);
            MakeYourCodeBtn.Name = "MakeYourCodeBtn";
            MakeYourCodeBtn.Size = new Size(113, 53);
            MakeYourCodeBtn.TabIndex = 4;
            MakeYourCodeBtn.Text = "Make Your Own Code";
            MakeYourCodeBtn.UseVisualStyleBackColor = true;
            // 
            // Codemaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(647, 270);
            Controls.Add(MakeYourCodeBtn);
            Controls.Add(GuessLbl);
            Controls.Add(GenerateNum);
            Controls.Add(Num);
            Margin = new Padding(2);
            Name = "Codemaker";
            Text = "Codemaker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Num;
        private Button GenerateNum;
        private Label GuessLbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button MakeYourCodeBtn;
    }
}
