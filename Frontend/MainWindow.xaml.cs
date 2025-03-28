using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Frontend.Models;
using Frontend.Services;
using Frontend.Views;

namespace Frontend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly TarefasService _tarefasService;
        public MainWindow()
        {
            HttpClient client = new HttpClient();
            InitializeComponent();
            _tarefasService = new TarefasService(client);
            CarregaTarefas();
        }

        private async void CarregaTarefas()
        {
            ListaTarefas.ItemsSource = await _tarefasService.GetAllAsync();
        }

        private void AbrirTarefa_Click(object sender, RoutedEventArgs e)
        {
            TarefaCadastro tarefaCadastro = new TarefaCadastro();
            tarefaCadastro.ShowDialog();
        }

        private void AlterarTarefa_Click(Object sender, RoutedEventArgs e)
        {

        }
    }
}