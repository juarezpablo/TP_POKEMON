namespace TP_POKEMON_FORM
{
    public partial class Form_principal : Form
    {
        Login_Form formularioLogin;
        public Form_principal()
        {
            InitializeComponent();
            formularioLogin = new Login_Form();
        }

        private void buttonPrincipalLogin_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioLogin.ShowDialog();

        }
    }
}