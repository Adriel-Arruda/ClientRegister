namespace ClientRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register regist = new Register(txbName.Text, txbEmail.Text);
            MessageBox.Show(regist.message);
           
        }
    }
}