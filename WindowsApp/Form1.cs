namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            string email = textEmail.Text;
            string password = textPassword.Text;
            string passwordRepeat = textPasswordRepeat.Text;
            labelMessage.Text = "";

            if (email.Contains("@") == false)
                labelMessage.Text = "Nieprawidlowy adres email";

            else if (password == "")
                labelMessage.Text = "Podaj haslo!\n";

            else if (passwordRepeat == "")
                labelMessage.Text = "Powtorz haslo!";

            else if (password != passwordRepeat)
                labelMessage.Text = "Nieprawidlowe haslo\n";
            else
                labelMessage.Text = "Witaj: " + email;

        }

        private void labelMessage_Click(object sender, EventArgs e)
        {

        }
    }
}