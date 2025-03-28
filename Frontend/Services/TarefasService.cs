using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Frontend.Models;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace Frontend.Services
{
    public class TarefasService
    {
        private readonly HttpClient _httpClient;
        private string url = "http://localhost:5043/api/tarefa";

        public TarefasService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<List<Tarefa>> GetAllAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync(url);
                if(!response.IsSuccessStatusCode)
                    throw new HttpRequestException($"Erro ao buscar tarefas. Status: {response.StatusCode}");

                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Tarefa>>(json);
            }
            catch(HttpRequestException e)
            {
                throw new Exception("Não foi possível obter a lista de tarefas, tente novamente mais tarde!");
            }
        }

        private async Task UpdateAsync(int id, Tarefa tarefa)
        {
            try
            {

            }
            catch (HttpRequestException e)
            {

            }
        }

        public async Task CreateAsync(Tarefa product)
        {
            try
            {
                var json = JsonConvert.SerializeObject(product);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(url, content);
                if (!response.IsSuccessStatusCode)
                    throw new HttpRequestException($"Erro ao buscar tarefas. Status: {response.StatusCode}");
            }
            catch (HttpRequestException e)
            {
                throw new Exception("Falha ao criar tarefa, tente novamente mais tarde!");
            }
        }
    }
}
