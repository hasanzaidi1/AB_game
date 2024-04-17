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
            SuspendLayout();
            // 
            // Num
            // 
            Num.Font = new Font("Segoe UI", 11F);
            Num.Location = new Point(356, 281);
            Num.Name = "Num";
            Num.Size = new Size(178, 37);
            Num.TabIndex = 0;
            // 
            // GenerateNum
            // 
            GenerateNum.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenerateNum.Location = new Point(364, 138);
            GenerateNum.Name = "GenerateNum";
            GenerateNum.Size = new Size(162, 89);
            GenerateNum.TabIndex = 1;
            GenerateNum.Text = "Generate Code";
            GenerateNum.UseVisualStyleBackColor = true;
            
            // 
            // GuessLbl
            // 
            GuessLbl.AutoSize = true;
            GuessLbl.BackColor = Color.Black;
            GuessLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            GuessLbl.ForeColor = SystemColors.ButtonFace;
            GuessLbl.Location = new Point(345, 41);
            GuessLbl.Name = "GuessLbl";
            GuessLbl.Size = new Size(209, 48);
            GuessLbl.TabIndex = 3;
            GuessLbl.Text = "Codemaker";
            // 
            // Codemaker
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(924, 450);
            Controls.Add(GuessLbl);
            Controls.Add(GenerateNum);
            Controls.Add(Num);
            Name = "Codemaker";
            Text = "Codemaker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Num;
        private Button GenerateNum;
        private Label GuessLbl;
    }
}
