namespace TODOS_MVC.Models
{
    public sealed class TodoViewModel
    {
        public readonly List<Todo> Todos = new List<Todo>();

        public TodoViewModel()
        {
            Todos = Database.Instance.Todos.ToList();
        }
    }
}
