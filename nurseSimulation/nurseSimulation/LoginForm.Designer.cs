namespace nurseSimulation
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LoginPanel = new Panel();
            label1 = new Label();
            loginButton = new Button();
            usernameInput = new TextBox();
            passwordInput = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = Color.DarkGreen;
            LoginPanel.Controls.Add(label2);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(loginButton);
            LoginPanel.Controls.Add(usernameInput);
            LoginPanel.Controls.Add(passwordInput);
            LoginPanel.Controls.Add(pictureBox1);
            LoginPanel.Location = new Point(0, -2);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(800, 454);
            LoginPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(503, 282);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(182, 23);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(503, 175);
            usernameInput.Multiline = true;
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(182, 23);
            usernameInput.TabIndex = 2;
            usernameInput.TabStop = false;
            usernameInput.Text = "Username";
            usernameInput.Click += usernameInput_Click;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(503, 223);
            passwordInput.Multiline = true;
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(182, 23);
            passwordInput.TabIndex = 1;
            passwordInput.TabStop = false;
            passwordInput.Text = "Password";
            passwordInput.Click += passwordInput_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(111, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(503, 102);
            label2.Name = "label2";
            label2.Size = new Size(181, 32);
            label2.TabIndex = 4;
            label2.Text = "Member Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginPanel);
            Name = "LoginForm";
            Text = "LoginForm";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginPanel;
        private Label label1;
        private Button loginButton;
        private TextBox usernameInput;
        private TextBox passwordInput;
        private PictureBox pictureBox1;
        private Label label2;
    }
}