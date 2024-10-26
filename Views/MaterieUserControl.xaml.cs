using OrarUniversitar.Models;
using OrarUniversitar.Services;
using System.Windows.Controls;

namespace OrarUniversitar.Views
{
    public partial class MaterieUserControl : UserControl
    {
        private readonly IMaterieService _materieService;

        public MaterieUserControl()
        {
            InitializeComponent();
            _materieService = new MaterieService();
            IncarcaMaterii();
        }

        private void AdaugaMaterieButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var materie = new Materie
            {
                Id = int.Parse(IdTextBox.Text),
                Nume = NumeMaterieTextBox.Text,
                Credite = int.Parse(CrediteTextBox.Text)
            };

            _materieService.AdaugaMaterie(materie);
            IncarcaMaterii();
        }

        private void IncarcaMaterii()
        {
            MaterieDataGrid.ItemsSource = _materieService.ObtineMaterii();
        }
    }
}
