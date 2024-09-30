using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class TaskContext : DbContext
{
    public TaskContext(DbContextOptions<TaskContext> options) : base(options)
    {

    }

    public DbSet<Task> Tasks { get; set; }
}

public class Task
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool Completed { get; set; }
    public string Priority { get; set; } // low, medium, high
    public string Recurrence { get; set; } // daily, weekly, monthly
}
