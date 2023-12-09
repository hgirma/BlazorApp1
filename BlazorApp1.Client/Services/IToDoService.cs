namespace BlazorApp1.Client.Services
{
    public interface IToDoService
    {
        Task<string[]?> GetToDosAsync();
    }
}