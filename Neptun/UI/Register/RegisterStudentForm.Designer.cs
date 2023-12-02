namespace Neptun
{
    partial class RegisterStudentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TitleText = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            AzonositoTextBox = new TextBox();
            label7 = new Label();
            vezetekNev_textBox = new TextBox();
            keresztNev_TextBox = new TextBox();
            kor_TextBox = new TextBox();
            email_textBox = new TextBox();
            szak_ListBox = new ListBox();
            register_Button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(285, 68);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // TitleText
            // 
            TitleText.AutoSize = true;
            TitleText.Location = new Point(25, 25);
            TitleText.Name = "TitleText";
            TitleText.Size = new Size(132, 15);
            TitleText.TabIndex = 1;
            TitleText.Text = "Neptun diákregisztráció";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Azonosító";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 103);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 3;
            label3.Text = "Vezetéknév";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 128);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 4;
            label4.Text = "Keresztnév";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 154);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 5;
            label5.Text = "Kor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 179);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 6;
            label6.Text = "E-mail";
            // 
            // AzonositoTextBox
            // 
            AzonositoTextBox.Location = new Point(103, 68);
            AzonositoTextBox.MaxLength = 6;
            AzonositoTextBox.Name = "AzonositoTextBox";
            AzonositoTextBox.Size = new Size(100, 23);
            AzonositoTextBox.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 242);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 8;
            label7.Text = "Szak";
            // 
            // vezetekNev_textBox
            // 
            vezetekNev_textBox.Location = new Point(103, 99);
            vezetekNev_textBox.Name = "vezetekNev_textBox";
            vezetekNev_textBox.Size = new Size(100, 23);
            vezetekNev_textBox.TabIndex = 9;
            // 
            // keresztNev_TextBox
            // 
            keresztNev_TextBox.Location = new Point(103, 128);
            keresztNev_TextBox.Name = "keresztNev_TextBox";
            keresztNev_TextBox.Size = new Size(100, 23);
            keresztNev_TextBox.TabIndex = 10;
            // 
            // kor_TextBox
            // 
            kor_TextBox.Location = new Point(103, 157);
            kor_TextBox.Name = "kor_TextBox";
            kor_TextBox.Size = new Size(100, 23);
            kor_TextBox.TabIndex = 11;
            // 
            // email_textBox
            // 
            email_textBox.Location = new Point(103, 186);
            email_textBox.Name = "email_textBox";
            email_textBox.Size = new Size(100, 23);
            email_textBox.TabIndex = 12;
            // 
            // szak_ListBox
            // 
            szak_ListBox.FormattingEnabled = true;
            szak_ListBox.ItemHeight = 15;
            szak_ListBox.Location = new Point(93, 227);
            szak_ListBox.Name = "szak_ListBox";
            szak_ListBox.Size = new Size(120, 94);
            szak_ListBox.TabIndex = 13;
            szak_ListBox.SelectedValueChanged += szak_ListBox_SelectedValueChanged;
            // 
            // register_Button
            // 
            register_Button.Location = new Point(103, 350);
            register_Button.Name = "register_Button";
            register_Button.Size = new Size(75, 23);
            register_Button.TabIndex = 14;
            register_Button.Text = "Regisztrál";
            register_Button.UseVisualStyleBackColor = true;
            register_Button.Click += register_Button_Click;
            // 
            // RegisterStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 450);
            Controls.Add(register_Button);
            Controls.Add(szak_ListBox);
            Controls.Add(email_textBox);
            Controls.Add(kor_TextBox);
            Controls.Add(keresztNev_TextBox);
            Controls.Add(vezetekNev_textBox);
            Controls.Add(label7);
            Controls.Add(AzonositoTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TitleText);
            Controls.Add(label1);
            Name = "RegisterStudentForm";
            Text = "Diák regisztráció";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label TitleText;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        public TextBox AzonositoTextBox;
        private Label label7;
        public TextBox vezetekNev_textBox;
        public TextBox keresztNev_TextBox;
        public TextBox kor_TextBox;
        public TextBox email_textBox;
        public ListBox szak_ListBox;
        private Button register_Button;
    }
}