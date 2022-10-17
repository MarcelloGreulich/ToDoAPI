namespace TodoApi.Models
{
    public class TodoItem
    {
        // Contains Id of the TodoItem
        public long Id { get; set; }
        // Contains Name of the TodoItem
        public string? Name { get; set; }
        // Indicates if the TodoItem is complete
        public bool IsComplete { get; set; }
        // Contains secret string of the TodoItem
        public string? Secret { get; set; }
    }
}