namespace ABgame
{
    partial class WelcomeForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            menuStrip1 = new MenuStrip();
            gameOptionsToolStripMenuItem = new ToolStripMenuItem();
            codemakerMenuStrip = new ToolStripMenuItem();
            codebreakerMenuStrip = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            Group = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CodemakerBtn = new Button();
            CodebreakerBtn = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            codemakerToolStripMenuItem = new ToolStripMenuItem();
            codebreakerToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gameOptionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(962, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gameOptionsToolStripMenuItem
            // 
            gameOptionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { codemakerMenuStrip, codebreakerMenuStrip, toolStripMenuItem1, exitToolStripMenuItem });
            gameOptionsToolStripMenuItem.Name = "gameOptionsToolStripMenuItem";
            gameOptionsToolStripMenuItem.Size = new Size(143, 29);
            gameOptionsToolStripMenuItem.Text = "Game Options";
            // 
            // codemakerMenuStrip
            // 
            codemakerMenuStrip.Name = "codemakerMenuStrip";
            codemakerMenuStrip.Size = new Size(215, 34);
            codemakerMenuStrip.Text = "Codemaker";
            codemakerMenuStrip.Click += codemakerMenuStrip_Click;
            // 
            // codebreakerMenuStrip
            // 
            codebreakerMenuStrip.Name = "codebreakerMenuStrip";
            codebreakerMenuStrip.Size = new Size(215, 34);
            codebreakerMenuStrip.Text = "Codebreaker";
            codebreakerMenuStrip.Click += codebreakerMenuStrip_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(212, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(215, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Group
            // 
            Group.AutoSize = true;
            Group.BackColor = SystemColors.ScrollBar;
            Group.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Group.Location = new Point(385, 53);
            Group.Name = "Group";
            Group.Size = new Size(107, 32);
            Group.TabIndex = 1;
            Group.Text = "Group 9";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(380, 173);
            label3.Name = "label3";
            label3.Size = new Size(138, 32);
            label3.TabIndex = 6;
            label3.Text = "Hasan Zaidi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(364, 141);
            label2.Name = "label2";
            label2.Size = new Size(169, 32);
            label2.TabIndex = 5;
            label2.Text = "Uday Bilakhiya";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(326, 109);
            label1.Name = "label1";
            label1.Size = new Size(251, 32);
            label1.TabIndex = 4;
            label1.Text = "Katherine Lingenfelter";
            // 
            // CodemakerBtn
            // 
            CodemakerBtn.BackColor = SystemColors.ScrollBar;
            CodemakerBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            CodemakerBtn.Location = new Point(176, 230);
            CodemakerBtn.Name = "CodemakerBtn";
            CodemakerBtn.Size = new Size(191, 54);
            CodemakerBtn.TabIndex = 7;
            CodemakerBtn.Text = "Codemaker";
            CodemakerBtn.UseVisualStyleBackColor = false;
            CodemakerBtn.Click += CodemakerBtn_Click;
            // 
            // CodebreakerBtn
            // 
            CodebreakerBtn.BackColor = SystemColors.ScrollBar;
            CodebreakerBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            CodebreakerBtn.Location = new Point(521, 230);
            CodebreakerBtn.Name = "CodebreakerBtn";
            CodebreakerBtn.Size = new Size(191, 54);
            CodebreakerBtn.TabIndex = 8;
            CodebreakerBtn.Text = "Codebreaker";
            CodebreakerBtn.UseVisualStyleBackColor = false;
            CodebreakerBtn.Click += CodebreakerBtn_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { codemakerToolStripMenuItem, codebreakerToolStripMenuItem, toolStripMenuItem2, exitToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(186, 106);
            // 
            // codemakerToolStripMenuItem
            // 
            codemakerToolStripMenuItem.Name = "codemakerToolStripMenuItem";
            codemakerToolStripMenuItem.Size = new Size(185, 32);
            codemakerToolStripMenuItem.Text = "Codemaker";
            codemakerToolStripMenuItem.Click += codemakerToolStripMenuItem_Click;
            // 
            // codebreakerToolStripMenuItem
            // 
            codebreakerToolStripMenuItem.Name = "codebreakerToolStripMenuItem";
            codebreakerToolStripMenuItem.Size = new Size(185, 32);
            codebreakerToolStripMenuItem.Text = "Codebreaker";
            codebreakerToolStripMenuItem.Click += codebreakerToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(182, 6);
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(185, 32);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 450);
            Controls.Add(CodebreakerBtn);
            Controls.Add(CodemakerBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Group);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "WelcomeForm";
            Text = "Form1";
            Load += WelcomeForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gameOptionsToolStripMenuItem;
        private ToolStripMenuItem codemakerMenuStrip;
        private ToolStripMenuItem codebreakerMenuStrip;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label Group;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button CodemakerBtn;
        private Button CodebreakerBtn;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem codemakerToolStripMenuItem;
        private ToolStripMenuItem codebreakerToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem exitToolStripMenuItem1;
    }
}
