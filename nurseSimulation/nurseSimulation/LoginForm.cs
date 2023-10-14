using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nurseSimulation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool hasClearedInput = false;

        private void usernameInput_Click(object sender, EventArgs e)
        {
            if (!hasClearedInput)
            {
                usernameInput.Text = string.Empty;
            }
        }

        private void passwordInput_Click(object sender, EventArgs e)
        {
            if (!hasClearedInput)
            {
                passwordInput.Text = string.Empty;
            }
        }
    }
}
