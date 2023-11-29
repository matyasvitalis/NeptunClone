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
            linkLabel1 = new LinkLabel();
            RegisterorLoginText = new Label();
            PasswordConfirmLabel = new Label();
            userPasswordConfirm_TextBox = new TextBox();
            SuspendLayout();
            // 
            // userID_InputBox
            // 
            userID_InputBox.Location = new Point(266, 135);
            userID_InputBox.MaxLength = 6;
            userID_InputBox.Name = "userID_InputBox";
            userID_InputBox.Size = new Size(148, 23);
            userID_InputBox.TabIndex = 0;
            // 
            // userPassword_InputBox
            // 
            userPassword_InputBox.Location = new Point(266, 169);
            userPassword_InputBox.MaxLength = 25;
            userPassword_InputBox.Name = "userPassword_InputBox";
            userPassword_InputBox.PasswordChar = '*';
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
            IDLabel.Location = new Point(152, 138);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(60, 15);
            IDLabel.TabIndex = 3;
            IDLabel.Text = "Azonosító";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(152, 172);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(37, 15);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Jelszó";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(242, 249);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(125, 23);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Bejelentkezés";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(351, 287);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Regisztrálj!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // RegisterorLoginText
            // 
            RegisterorLoginText.AutoSize = true;
            RegisterorLoginText.Location = new Point(210, 287);
            RegisterorLoginText.Name = "RegisterorLoginText";
            RegisterorLoginText.Size = new Size(124, 15);
            RegisterorLoginText.TabIndex = 8;
            RegisterorLoginText.Text = "Még nincs Neptunod?";
            // 
            // PasswordConfirmLabel
            // 
            PasswordConfirmLabel.AutoSize = true;
            PasswordConfirmLabel.Location = new Point(150, 207);
            PasswordConfirmLabel.Name = "PasswordConfirmLabel";
            PasswordConfirmLabel.Size = new Size(110, 15);
            PasswordConfirmLabel.TabIndex = 9;
            PasswordConfirmLabel.Text = "Jelszó megerősítése";
            PasswordConfirmLabel.Visible = false;
            // 
            // userPasswordConfirm_TextBox
            // 
            userPasswordConfirm_TextBox.Location = new Point(266, 204);
            userPasswordConfirm_TextBox.MaxLength = 25;
            userPasswordConfirm_TextBox.Name = "userPasswordConfirm_TextBox";
            userPasswordConfirm_TextBox.PasswordChar = '*';
            userPasswordConfirm_TextBox.Size = new Size(148, 23);
            userPasswordConfirm_TextBox.TabIndex = 10;
            userPasswordConfirm_TextBox.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 389);
            Controls.Add(userPasswordConfirm_TextBox);
            Controls.Add(PasswordConfirmLabel);
            Controls.Add(RegisterorLoginText);
            Controls.Add(linkLabel1);
            Controls.Add(LoginButton);
            Controls.Add(PasswordLabel);
            Controls.Add(IDLabel);
            Controls.Add(LoginText);
            Controls.Add(userPassword_InputBox);
            Controls.Add(userID_InputBox);
            Name = "LoginForm";
            Text = "Bejelentkezés";
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
        private LinkLabel linkLabel1;
        private Label RegisterorLoginText;
        private Label PasswordConfirmLabel;
        private TextBox userPasswordConfirm_TextBox;
    }
}