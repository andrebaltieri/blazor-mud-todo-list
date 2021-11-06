using System.ComponentModel.DataAnnotations;

namespace MyTodo.Models;

public class TodoItem
{
    public int Id { get; set; } = 1;

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Title { get; set; }

    public bool Done { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}