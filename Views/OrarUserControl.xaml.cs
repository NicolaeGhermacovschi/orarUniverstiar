using OrarUniversitar.Models;
using OrarUniversitar.Services;
using System.Windows.Controls;

namespace OrarUniversitar.Views
{
    public partial class OrarUserControl : UserControl
    {
        private readonly IOrarService _orarService;

        public OrarUserControl()
        {
            InitializeComponent();
            _orarService = new OrarService();
              IncarcaOrar();
        }

        private void AdaugaOrarButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var orar = new Orar
            {
                Id = int.Parse(IdTextBox.Text),
                ProfesorId = int.Parse(ProfesorIdTextBox.Text),
                MaterieId = int.Parse(MaterieIdTextBox.Text),
                SalaId = int.Parse(SalaIdTextBox.Text),
                IntervalOrar = IntervalOrarTextBox.Text
            };

            _orarService.AdaugaOrar(orar);
            IncarcaOrar();
        }

        private void IncarcaOrar()
        {
            OrarDataGrid.ItemsSource = _orarService.ObtineOrar();
        }
    }

    public class UserControl
    {
    }
}