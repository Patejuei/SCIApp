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
            int res = _Database.LogInSystem(inp_user.Text, inp_pass.Text);
            if (res == 1)
            {
                MessageBox.Show("Sesi�n Iniciada Correctamente", "Inicio de Sesi�n");
                inventory_index inv = new inventory_index();
                this.Hide();
                inv.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Inicio de Sesi�n");
                inp_user.Focus();
            }
        }
    }
}