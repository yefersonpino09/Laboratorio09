namespace SampleWebApi.Models;

public class TodoItemm
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Descripcion { get; set; }
    public int? Price { get; set; }
    public bool IsComplete { get; set; }
}