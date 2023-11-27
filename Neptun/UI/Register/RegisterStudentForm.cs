using Neptun.Data;

namespace Neptun
{
    public partial class RegisterStudentForm : Form
    {
        public void LoadingSpecialisation()
        {
            szak_ListBox.Items.AddRange(typeof(Student.Specialisation).GetEnumNames());
        }
        public RegisterStudentForm()
        {
            InitializeComponent();
            LoadingSpecialisation();
        }

        private void register_Button_Click(object sender, EventArgs e)
        {
            AddingStudents.TextBoxID(AzonositoTextBox.Text);
            AddingStudents.FirstName(vezetekNev_textBox.Text);
            AddingStudents.LastName(keresztNev_TextBox.Text);
            AddingStudents.Age(Convert.ToInt32(kor_TextBox.Text));
            AddingStudents.Email(email_textBox.Text);
            AddingStudents.SelectedSpecialisation((string)szak_ListBox.SelectedItem);
            AddingStudents.AddStudent();
            LoadingStudents.GetTextBox(label1);
            LoadingStudents.LoadStudents();
        }

        private void szak_ListBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}