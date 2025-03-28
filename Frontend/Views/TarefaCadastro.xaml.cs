using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Frontend.Models;
using Frontend.Services;

namespace Frontend.Views
{
    /// <summary>
    /// Lógica interna para TarefaCadastro.xaml
    /// </summary>
    public partial class TarefaCadastro : Window
    {
        public int idTarefa { get; set; }
        public bool editar { get; set; } = false;
        public TarefaCadastro()
        {
            InitializeComponent();
            cmbStatus.SelectedItem = TarefaStatus.Pendente;
        }

        public TarefaCadastro(int id)
        {
            InitializeComponent();
            idTarefa = id;
        }

        private bool ValidaTitulo()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("O campo Nome da Tarefa não pode ser vazio!", "Atenção", MessageBoxButton.OK);
                return valido;
            }
            else if (txtNome.Text.Length > 100)
            {
                MessageBox.Show("O campo Nome da Tarefa não pode exceder 100 caracteres", "Atenção", MessageBoxButton.OK);
                return valido;
            }
            return valido;
        }

        private bool ValidaDatas()
        {
            bool valido = true;
            if (dtpCriacao.SelectedDate == null || dtpConclusao.SelectedDate == null)
            {
                MessageBox.Show("As datas não podem estar vazias!", "Atenção", MessageBoxButton.OK);
                return false;
            }

            DateTime dataCriacao = dtpCriacao.SelectedDate.Value;
            DateTime dataConclusao = dtpConclusao.SelectedDate.Value;

            if (dataConclusao < dataCriacao)
            {
                MessageBox.Show("A data de conclusão não pode ser menor que a data de criação!", "Atenção", MessageBoxButton.OK);
                return false;
            }
            return valido;
        }

        private async Task CriarTarefaAsync()
        {
            HttpClient client = new HttpClient();

            string titulo = txtNome.Text;
            string descricao = txtDescricao.Text;
            DateTime dataCriacao = dtpCriacao.SelectedDate.Value;
            DateTime dataConclusao = dtpConclusao.SelectedDate.Value;
            var tarefa = new Tarefa
            {
                Titulo = titulo,
                Descricao = descricao,
                CriadoEm = dataCriacao,
                ConcluidoEm = dataConclusao
            };

            var tarefaService = new TarefasService(client);
            await tarefaService.CreateAsync(tarefa);
        }

        private async Task EditarTarefaAsync(int id)
        {
            HttpClient client = new HttpClient();

            string titulo = txtNome.Text;
            string descricao = txtDescricao.Text;
            DateTime dataCriacao = dtpCriacao.SelectedDate.Value;
            DateTime dataConclusao = dtpConclusao.SelectedDate.Value;

            var tarefa = new Tarefa
            {
                Titulo = titulo,
                Descricao = descricao,
                CriadoEm = dataCriacao,
                ConcluidoEm = dataConclusao
            };
        }

        private async void Gravar_Click(object sender,  RoutedEventArgs e)
        {
            if (ValidaTitulo() && ValidaDatas())
            {
                await CriarTarefaAsync();
                MessageBox.Show("Tarefa criada com sucesso!", "Sucesso", MessageBoxButton.OK);
                this.Close();
            }
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
