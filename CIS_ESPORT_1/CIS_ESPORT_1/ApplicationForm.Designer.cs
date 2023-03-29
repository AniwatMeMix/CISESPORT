namespace CIS_ESPORT_1
{
    partial class ApplicationForm
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
            menuStrip1 = new MenuStrip();
            playerToolStripMenuItem = new ToolStripMenuItem();
            allTeamToolStripMenuItem = new ToolStripMenuItem();
            allPlayerToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { playerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // playerToolStripMenuItem
            // 
            playerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allTeamToolStripMenuItem, allPlayerToolStripMenuItem, closeToolStripMenuItem });
            playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            playerToolStripMenuItem.Size = new Size(63, 24);
            playerToolStripMenuItem.Text = "Player";
            // 
            // allTeamToolStripMenuItem
            // 
            allTeamToolStripMenuItem.Name = "allTeamToolStripMenuItem";
            allTeamToolStripMenuItem.Size = new Size(224, 26);
            allTeamToolStripMenuItem.Text = "All Team";
            allTeamToolStripMenuItem.Click += allTeamToolStripMenuItem_Click;
            // 
            // allPlayerToolStripMenuItem
            // 
            allPlayerToolStripMenuItem.Name = "allPlayerToolStripMenuItem";
            allPlayerToolStripMenuItem.Size = new Size(224, 26);
            allPlayerToolStripMenuItem.Text = "All Player";
            allPlayerToolStripMenuItem.Click += allPlayerToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(224, 26);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // ApplicationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "ApplicationForm";
            Text = "ApplicationForm";
            Load += ApplicationForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem playerToolStripMenuItem;
        private ToolStripMenuItem allTeamToolStripMenuItem;
        private ToolStripMenuItem allPlayerToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}