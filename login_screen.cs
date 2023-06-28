namespace SCIApp
{
    public partial class login_screen : Form
    {
        Connection _Database = new Connection();
        public login_screen()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            _LogIn();
        }

        private void inp_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                _LogIn();
            }
        }

        private void _LogIn()
        {
            int res = _Database.LogInSystem(inp_user.Text, inp_pass.Text);
            if (res == 1)
            {
                MessageBox.Show("Sesión Iniciada Correctamente", "Inicio de Sesión");
                inventory_index inv = new inventory_index();
                this.Hide();
                inv.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Inicio de Sesión");
                inp_user.Focus();
            }

        }
    }
}