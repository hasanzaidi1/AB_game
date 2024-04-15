namespace AB_game
{
    partial class ABresults
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
            HintLbl = new Label();
            HintResult = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // HintLbl
            // 
            HintLbl.AutoSize = true;
            HintLbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            HintLbl.Location = new Point(716, 54);
            HintLbl.Name = "HintLbl";
            HintLbl.Size = new Size(58, 30);
            HintLbl.TabIndex = 0;
            HintLbl.Text = "Hint";
            // 
            // HintResult
            // 
            HintResult.AutoSize = true;
            HintResult.Font = new Font("Segoe UI", 10F);
            HintResult.Location = new Point(716, 122);
            HintResult.Name = "HintResult";
            HintResult.Size = new Size(65, 28);
            HintResult.TabIndex = 1;
            HintResult.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 125);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // ABresults
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 450);
            Controls.Add(label1);
            Controls.Add(HintResult);
            Controls.Add(HintLbl);
            Name = "ABresults";
            Text = "ABresults";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HintLbl;
        private Label HintResult;
        private Label label1;
    }
}