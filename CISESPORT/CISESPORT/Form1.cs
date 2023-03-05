namespace CISESPORT
{
    public partial class FormInfo : Form
    {
        private Player _newPlayer;

        public FormInfo()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string lastName = tbLname.Text;
            string studentid = tbID.Text;
            string mail = tbEmail.Text;
            string Phone = tbPhone.Text;
            string major = tbClass.Text;
            string displayname = tbGame.Text;
            int iage = 0;
            try
            {
                string age = tbOld.Text;
                iage = Int32.Parse(age);
            }
            catch (FormatException )
            {
                MessageBox.Show("คุณใส่ผิด");
                return;
            }
            catch (Exception )
            {
            
            }

            _newPlayer = new Player(name, lastName, studentid, major, displayname, mail, Phone , iage);
            
            

            finally { }
            
            this.DialogResult = DialogResult.OK;

        }
        public Player getPlayer() { return _newPlayer; }
    }
}