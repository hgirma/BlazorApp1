namespace BlazorApp1.Client.Services
{
    public class NoOpService : INoOpService
    {
        public void NoOp()
        {
            Console.WriteLine("NoOp");
        }
    }
}
