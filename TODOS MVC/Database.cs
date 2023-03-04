using Microsoft.EntityFrameworkCore;

namespace TODOS_MVC
{
    public sealed class Todo
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public bool IsCompleted { get; private set; }

        public Todo(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }

    public sealed class Database : DbContext
    {
        public static readonly Database Instance = new Database();

        public DbSet<Todo> Todos => Set<Todo>();

        public Database()
        {
            Database.EnsureCreated();

            var todoHomework = new Todo("Homework", "Make math and physics.");
            TryAdd(todoHomework);

            var todoCleaning = new Todo("Cleaning", "Clean the room.");
            TryAdd(todoCleaning);
        }

        public void TryAdd(Todo newTodo)
        {
            var todos = Todos.ToList();

            var doesExist = todos.Any(todo => todo.Title == newTodo.Title);
            if (doesExist)
                return;

            Todos.Add(newTodo);
            SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source = todos.db");
        }
    }
}
