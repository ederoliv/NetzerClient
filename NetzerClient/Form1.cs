namespace NetzerClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblComputerNameField.Text = Environment.MachineName;
            lblUserNameField.Text = Environment.UserName;

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
