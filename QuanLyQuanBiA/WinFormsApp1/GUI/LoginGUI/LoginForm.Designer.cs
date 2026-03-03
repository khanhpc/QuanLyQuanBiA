namespace WinFormsApp1.GUI
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
            panel1 = new Panel();
            panel2 = new Panel();
            txtPassWord = new TextBox();
            txtUserName = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 398);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtPassWord);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(458, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 398);
            panel2.TabIndex = 1;
            // 
            // txtPassWord
            // 
            txtPassWord.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassWord.Location = new Point(3, 186);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.Size = new Size(293, 42);
            txtPassWord.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(3, 116);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(293, 42);
            txtUserName.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 64, 0);
            btnLogin.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(3, 255);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(293, 45);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 50);
            label1.Name = "label1";
            label1.Size = new Size(223, 48);
            label1.TabIndex = 0;
            label1.Text = "Đăng Nhập";
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 422);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtPassWord;
        private TextBox txtUserName;
        private Button btnLogin;
        private Label label1;
    }
}