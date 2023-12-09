using System.Net.Http.Json;

namespace BlazorApp1.Client.Services
{
    public class ToDoService(HttpClient httpClient) : IToDoService
    {
        private readonly HttpClient _httpClient = httpClient;

        public async Task<string[]?> GetToDosAsync()
        {
            return await _httpClient.GetFromJsonAsync<string[]>("api/todo-items");
        }
    }
}
