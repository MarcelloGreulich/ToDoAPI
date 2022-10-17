namespace TodoApi.Models
{
    public class TodoItemDTO
    {
        // Contains Id of the TodoItemDTO
        public long Id { get; set; }
        // Contains Name of the TodoItemDTO
        public string? Name { get; set; }
        // Indicates if the TodoItemDTO is complete
        public bool IsComplete { get; set; }
    }
}
