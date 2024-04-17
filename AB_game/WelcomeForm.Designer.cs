namespace AB_game
{
    partial class WelcomeForm
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
            Group = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            gameToolStripMenuItem = new ToolStripMenuItem();
            codemakerToolStripMenuItem = new ToolStripMenuItem();
            codebreakerToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Group
            // 
            Group.AutoSize = true;
            Group.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Group.Location = new Point(389, 76);
            Group.Name = "Group";
            Group.Size = new Size(113, 36);
            Group.TabIndex = 0;
            Group.Text = "Group 9";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(314, 163);
            label1.Name = "label1";
            label1.Size = new Size(291, 38);
            label1.TabIndex = 1;
            label1.Text = "Katherine Lingenfelter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(360, 209);
            label2.Name = "label2";
            label2.Size = new Size(197, 38);
            label2.TabIndex = 2;
            label2.Text = "Uday Bilakhiya";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(377, 256);
            label3.Name = "label3";
            label3.Size = new Size(161, 38);
            label3.TabIndex = 3;
            label3.Text = "Hasan Zaidi";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gameToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(919, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            gameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { codemakerToolStripMenuItem, codebreakerToolStripMenuItem, toolStripMenuItem2, exitToolStripMenuItem });
            gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            gameToolStripMenuItem.Size = new Size(97, 29);
            gameToolStripMenuItem.Text = " Options";
            // 
            // codemakerToolStripMenuItem
            // 
            codemakerToolStripMenuItem.Name = "codemakerToolStripMenuItem";
            codemakerToolStripMenuItem.Size = new Size(270, 34);
            codemakerToolStripMenuItem.Text = "Codemaker";
            codemakerToolStripMenuItem.Click += codemakerToolStripMenuItem_Click;
            // 
            // codebreakerToolStripMenuItem
            // 
            codebreakerToolStripMenuItem.Name = "codebreakerToolStripMenuItem";
            codebreakerToolStripMenuItem.Size = new Size(270, 34);
            codebreakerToolStripMenuItem.Text = "Codebreaker";
            codebreakerToolStripMenuItem.Click += codebreakerToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(267, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(270, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Group);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Group;
        private Label label1;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem codemakerToolStripMenuItem;
        private ToolStripMenuItem codebreakerToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}