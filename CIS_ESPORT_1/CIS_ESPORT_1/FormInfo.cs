namespace CIS_ESPORT_1
{
    public partial class FormInfo : Form
    {
        private Player _newPlayer;
        public FormInfo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string lastname = textBoxLname.Text;
            string ID = textBoxID.Text;
            string Major = textBoxField.Text;
            string gname = textBoxGName.Text;
            string mail = textBoxMail.Text;
            string tel = textBoxTel.Text;
            int iage = 0;
            try
            {
                string age = textBoxAge.Text;
                iage = Int32.Parse(age);
            }
            catch (FormatException ex)
            {
                //Do something if have some exception
                MessageBox.Show("คุณใสข้อมูลผิด");
                return;
            }
            _newPlayer = new Player(name, lastname, ID, Major, gname, mail, tel, iage);

            this.DialogResult = DialogResult.OK;
        }

        public Player GetPlayer() { return _newPlayer; }
    }
}