namespace ABgame
{
    partial class codebreakerGamePlayLog
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
            codebreakerGameData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)codebreakerGameData).BeginInit();
            SuspendLayout();
            // 
            // codebreakerGameData
            // 
            codebreakerGameData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            codebreakerGameData.Location = new Point(12, 12);
            codebreakerGameData.Name = "codebreakerGameData";
            codebreakerGameData.RowHeadersWidth = 62;
            codebreakerGameData.Size = new Size(1370, 426);
            codebreakerGameData.TabIndex = 0;
            // 
            // codebreakerGamePlayLog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1394, 450);
            Controls.Add(codebreakerGameData);
            Name = "codebreakerGamePlayLog";
            Text = "codebreakerGamePlayLog";
            ((System.ComponentModel.ISupportInitialize)codebreakerGameData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView codebreakerGameData;
    }
}