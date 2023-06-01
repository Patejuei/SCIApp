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

            if (_Database.LogInSystem(inp_user.Text, inp_pass.Text))
            {
                inventory_index inv = new inventory_index();
                this.Hide();
                inv.Show();
            }
            else
            {
                inp_user.Focus();
            }
        }
    }
}