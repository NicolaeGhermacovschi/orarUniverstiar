using OrarUniversitar.Models;
using OrarUniversitar.Services;
using System.Windows.Controls;

namespace OrarUniversitar.Views
{
    public partial class SalaUserControl : UserControl
    {
        private readonly ISalaService _salaService;

        public SalaUserControl()
        {
            InitializeComponent();
            _salaService = new SalaService();
            IncarcaSali();
        }

        private void AdaugaSalaButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var sala = new Sala
            {
                Id = int.Parse(IdTextBox.Text),
                Numar = NumarSalaTextBox.Text,
                Capacitate = int.Parse(CapacitateTextBox.Text)
            };

            _salaService.AdaugaSala(sala);
            IncarcaSali();
        }

        private void IncarcaSali()
        {
            SalaDataGrid.ItemsSource = _salaService.ObtineSali();
        }
    }
}
