using FinalApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FinalApp.Helpers
{
    public static class ApiCaller
    {
        private readonly static Uri BASE_ADDRESS = new Uri("http://gsuite.azurewebsites.net/");

        public static ObservableCollection<Tarefa> GetTarefas()
        {
            var result = new ObservableCollection<Models.Tarefa>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = BASE_ADDRESS;
                HttpResponseMessage response = client.GetAsync("api/tarefasservice").Result;

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    return result = JsonConvert.DeserializeObject<ObservableCollection<Tarefa>>(json);

                }

                else
                {
                    return result = new ObservableCollection<Models.Tarefa>();
                }
            }
        }

        public static Tarefa GetTarefa(int id)
        {
            var result = new Tarefa();
            using (var client = new HttpClient())
            {
                client.BaseAddress = BASE_ADDRESS;
                HttpResponseMessage response = client.GetAsync($"api/tarefaservice/{id}").Result;

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    result = JsonConvert.DeserializeObject<Tarefa>(json);
                    return result;

                }
                else
                {
                    return result = new Tarefa();
                }
            }
        }

        public static async Task<Tarefa> CreateTarefa(Tarefa tarefa)
        {
            var json = JsonConvert.SerializeObject(tarefa);
            using (var client = new HttpClient())
            {
                client.BaseAddress = BASE_ADDRESS;
                var response = await client.PostAsync("api/tarefasservice", new StringContent(json, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<Tarefa>(content);
                    return result;
                }
                else
                {
                    return null;
                }
            }
        }

        public static void Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = BASE_ADDRESS;
                var response = client.DeleteAsync($"api/tarefasservice/{id}").Result;

                if (response.IsSuccessStatusCode)
                {
                    System.Diagnostics.Debug.WriteLine("Success");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error");
                }
            }
        }

        public static async Task<Tarefa> Put(Tarefa tarefa)
        {
            var json = JsonConvert.SerializeObject(tarefa);
            using (var client = new HttpClient())
            {
                client.BaseAddress = BASE_ADDRESS;
                var response = await client.PutAsync($"api/tarefasservice/{tarefa.TarefaID}", new StringContent(json, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<Tarefa>(content);
                    return result;
                }
                else
                {
                    return null;
                }

            }
        }
    }
}
