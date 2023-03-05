using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISESPORT
{
    public partial class FormAllplayer : Form
    {
       
        public FormAllplayer()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();

            if(formInfo.DialogResult== DialogResult.OK )
            {
                Player newPlayer = formInfo.getPlayer();
                this.listPlayer.add(newPlayer);

                this.dataGridView1.DataSource = null;
                
                formInfo.Close();
            }
        }
    }
}
