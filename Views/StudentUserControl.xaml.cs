using OrarUniversitar.Models;
using OrarUniversitar.Services;
using System.Windows.Controls;

namespace OrarUniversitar.Views
{
    public partial class StudentUserControl : UserControl
    {
        private readonly IStudentService _studentService;

        public StudentUserControl()
        {
            InitializeComponent();
            _studentService = new StudentService();
            IncarcaStudenti();
        }

        private void AdaugaStudentButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var student = new Student
            {
                Id = int.Parse(IdTextBox.Text),
                Nume = NumeTextBox.Text,
                Prenume = PrenumeTextBox.Text,
                Facultate = FacultateTextBox.Text
            };

            _studentService.AdaugaStudent(student);
            IncarcaStudenti();
        }

        private void IncarcaStudenti()
        {
            StudentDataGrid.ItemsSource = _studentService.ObtineStudenti();
        }
    }
}
