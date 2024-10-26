using OrarUniversitar.Models;
using OrarUniversitar.Services;
using System.Windows.Controls;

namespace OrarUniversitar.Views
{
    public partial class ProfesorUserControl : UserControl
    {
        private readonly IProfesorService _profesorService;

        public ProfesorUserControl()
        {
            InitializeComponent();
            _profesorService = new ProfesorService();
            IncarcaProfesori();
        }

        private void AdaugaProfesorButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var profesor = new Profesor
            {
                Id = int.Parse(IdTextBox.Text),
                Nume = NumeTextBox.Text,
                Prenume = PrenumeTextBox.Text,
                Departament = DepartamentTextBox.Text
            };

            _profesorService.AdaugaProfesor(profesor);
            IncarcaProfesori();
        }

        private void IncarcaProfesori()
        {
            ProfesorDataGrid.ItemsSource = _profesorService.ObtineProfesori();
        }
    }
}
