namespace MinimalTodoApi.Models;

public class Todo
{
    // Unique identifier for the Todo item
    public Guid Id { get; set; }

    // Name or description of the Todo item
    public string? Name { get; set; }

    // Indicates whether the Todo item is complete
    public bool IsComplete { get; set; }
}