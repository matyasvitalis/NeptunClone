namespace Neptun.Login
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
            userID_InputBox = new TextBox();
            userPassword_InputBox = new TextBox();
            LoginText = new Label();
            IDLabel = new Label();
            PasswordLabel = new Label();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // userID_InputBox
            // 
            userID_InputBox.Location = new Point(266, 135);
            userID_InputBox.Name = "userID_InputBox";
            userID_InputBox.Size = new Size(148, 23);
            userID_InputBox.TabIndex = 0;
            // 
            // userPassword_InputBox
            // 
            userPassword_InputBox.Location = new Point(266, 189);
            userPassword_InputBox.Name = "userPassword_InputBox";
            userPassword_InputBox.Size = new Size(148, 23);
            userPassword_InputBox.TabIndex = 1;
            // 
            // LoginText
            // 
            LoginText.AutoSize = true;
            LoginText.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            LoginText.Location = new Point(174, 51);
            LoginText.Name = "LoginText";
            LoginText.Size = new Size(263, 54);
            LoginText.TabIndex = 2;
            LoginText.Text = "Bejelentkezés";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(174, 138);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(60, 15);
            IDLabel.TabIndex = 3;
            IDLabel.Text = "Azonosító";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(183, 192);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(37, 15);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Jelszó";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(234, 249);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(125, 23);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Bejelentkezés";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 389);
            Controls.Add(LoginButton);
            Controls.Add(PasswordLabel);
            Controls.Add(IDLabel);
            Controls.Add(LoginText);
            Controls.Add(userPassword_InputBox);
            Controls.Add(userID_InputBox);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userID_InputBox;
        private TextBox userPassword_InputBox;
        private Label LoginText;
        private Label IDLabel;
        private Label PasswordLabel;
        private Button LoginButton;
    }
}