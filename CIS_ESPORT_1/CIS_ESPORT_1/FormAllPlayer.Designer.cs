namespace CIS_ESPORT_1
{
    partial class FormAllPlayer
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
            dataGridView1 = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnLname = new DataGridViewTextBoxColumn();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnField = new DataGridViewTextBoxColumn();
            ColumnGname = new DataGridViewTextBoxColumn();
            ColumnMail = new DataGridViewTextBoxColumn();
            ColumnTel = new DataGridViewTextBoxColumn();
            ColumnAge = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            playerToolStripMenuItem = new ToolStripMenuItem();
            newPlayerToolStripMenuItem1 = new ToolStripMenuItem();
            button1 = new Button();
            textBoxGname = new TextBox();
            label5 = new Label();
            textBoxMajor = new TextBox();
            label4 = new Label();
            textBoxID = new TextBox();
            label3 = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnName, ColumnLname, ColumnID, ColumnField, ColumnGname, ColumnMail, ColumnTel, ColumnAge });
            dataGridView1.Location = new Point(0, 30);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(993, 448);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumnName
            // 
            ColumnName.DataPropertyName = "name";
            ColumnName.HeaderText = "Name";
            ColumnName.MinimumWidth = 8;
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            ColumnName.Width = 150;
            // 
            // ColumnLname
            // 
            ColumnLname.DataPropertyName = "lname";
            ColumnLname.HeaderText = "LastName";
            ColumnLname.MinimumWidth = 8;
            ColumnLname.Name = "ColumnLname";
            ColumnLname.ReadOnly = true;
            ColumnLname.Width = 150;
            // 
            // ColumnID
            // 
            ColumnID.DataPropertyName = "id";
            ColumnID.HeaderText = "ID";
            ColumnID.MinimumWidth = 8;
            ColumnID.Name = "ColumnID";
            ColumnID.ReadOnly = true;
            ColumnID.Width = 150;
            // 
            // ColumnField
            // 
            ColumnField.DataPropertyName = "field";
            ColumnField.HeaderText = "Major";
            ColumnField.MinimumWidth = 8;
            ColumnField.Name = "ColumnField";
            ColumnField.ReadOnly = true;
            ColumnField.Width = 150;
            // 
            // ColumnGname
            // 
            ColumnGname.DataPropertyName = "gname";
            ColumnGname.HeaderText = "GameName";
            ColumnGname.MinimumWidth = 8;
            ColumnGname.Name = "ColumnGname";
            ColumnGname.ReadOnly = true;
            ColumnGname.Width = 150;
            // 
            // ColumnMail
            // 
            ColumnMail.DataPropertyName = "mail";
            ColumnMail.HeaderText = "Mail";
            ColumnMail.MinimumWidth = 8;
            ColumnMail.Name = "ColumnMail";
            ColumnMail.ReadOnly = true;
            ColumnMail.Width = 150;
            // 
            // ColumnTel
            // 
            ColumnTel.DataPropertyName = "tel";
            ColumnTel.HeaderText = "Tel";
            ColumnTel.MinimumWidth = 8;
            ColumnTel.Name = "ColumnTel";
            ColumnTel.ReadOnly = true;
            ColumnTel.Width = 150;
            // 
            // ColumnAge
            // 
            ColumnAge.DataPropertyName = "age";
            ColumnAge.HeaderText = "Age";
            ColumnAge.MinimumWidth = 8;
            ColumnAge.Name = "ColumnAge";
            ColumnAge.ReadOnly = true;
            ColumnAge.Width = 150;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, playerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 1, 0, 1);
            menuStrip1.Size = new Size(1237, 26);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, saveFileToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(155, 26);
            openFileToolStripMenuItem.Text = "Open File";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(155, 26);
            saveFileToolStripMenuItem.Text = "Save File";
            saveFileToolStripMenuItem.Click += saveFileToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(155, 26);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // playerToolStripMenuItem
            // 
            playerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newPlayerToolStripMenuItem1 });
            playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            playerToolStripMenuItem.Size = new Size(63, 24);
            playerToolStripMenuItem.Text = "Player";
            // 
            // newPlayerToolStripMenuItem1
            // 
            newPlayerToolStripMenuItem1.Name = "newPlayerToolStripMenuItem1";
            newPlayerToolStripMenuItem1.Size = new Size(166, 26);
            newPlayerToolStripMenuItem1.Text = "New Player";
            newPlayerToolStripMenuItem1.Click += newPlayerToolStripMenuItem1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1114, 275);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(89, 27);
            button1.TabIndex = 38;
            button1.Text = "ยืนยัน";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxGname
            // 
            textBoxGname.Location = new Point(1097, 232);
            textBoxGname.Margin = new Padding(2, 3, 2, 3);
            textBoxGname.Name = "textBoxGname";
            textBoxGname.Size = new Size(121, 27);
            textBoxGname.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1011, 232);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 37;
            label5.Text = "ชื่อในเกม";
            // 
            // textBoxMajor
            // 
            textBoxMajor.Location = new Point(1097, 192);
            textBoxMajor.Margin = new Padding(2, 3, 2, 3);
            textBoxMajor.Name = "textBoxMajor";
            textBoxMajor.Size = new Size(121, 27);
            textBoxMajor.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1011, 192);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 36;
            label4.Text = "สาขา";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(1097, 152);
            textBoxID.Margin = new Padding(2, 3, 2, 3);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(121, 27);
            textBoxID.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1011, 152);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 35;
            label3.Text = "รหัสนักศึกษา";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(1097, 111);
            textBoxName.Margin = new Padding(2, 3, 2, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(121, 27);
            textBoxName.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1011, 111);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 31;
            label1.Text = "ชื่อ";
            // 
            // FormAllPlayer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 450);
            Controls.Add(button1);
            Controls.Add(textBoxGname);
            Controls.Add(label5);
            Controls.Add(textBoxMajor);
            Controls.Add(label4);
            Controls.Add(textBoxID);
            Controls.Add(label3);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Name = "FormAllPlayer";
            Text = "FormAllPlayer";
            Load += FormAllPlayer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem playerToolStripMenuItem;
        private ToolStripMenuItem newPlayerToolStripMenuItem1;
        private Button button1;
        private TextBox textBoxGname;
        private Label label5;
        private TextBox textBoxMajor;
        private Label label4;
        private TextBox textBoxID;
        private Label label3;
        private TextBox textBoxName;
        private Label label1;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnLname;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnField;
        private DataGridViewTextBoxColumn ColumnGname;
        private DataGridViewTextBoxColumn ColumnMail;
        private DataGridViewTextBoxColumn ColumnTel;
        private DataGridViewTextBoxColumn ColumnAge;
    }
}