namespace nurseSimulation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm() { TopLevel = false, TopMost = true };
            loginForm.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(loginForm);
            loginForm.Location = new Point(375, 200);
            loginForm.Show();
        }
    }
}