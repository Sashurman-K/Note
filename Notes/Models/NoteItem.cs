namespace Notes.Models
{
    public class NoteItem
    {
        public string? Title { get; set; }
        public string? Text { get; set; }
        public DateTime TimeToDo { get; set; }
        public DateTime TimeOfCreate { get; set; }
        public bool IsDone { get; set; }
        public string? TypeOfTodo { get; set; }
    }
}
