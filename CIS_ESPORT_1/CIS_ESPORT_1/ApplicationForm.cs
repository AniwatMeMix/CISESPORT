using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_ESPORT_1
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void allPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAllPlayer formAllPlayer = new FormAllPlayer();
            formAllPlayer.MdiParent = this;
            formAllPlayer.Show();
        }

        private void allTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAllTeam formAllTeam = new FormAllTeam();
            formAllTeam.MdiParent = this;
            formAllTeam.Show();
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
