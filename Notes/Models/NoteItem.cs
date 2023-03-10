using Notes.Models.Contex;

namespace Notes.Models
{
    public class NoteItem
    {
        public NoteItem(NoteDb noteDb)
        {
            Title = noteDb.Title;
            Description = noteDb.Description;
            CreatedAt = noteDb.CreatedAt;
            ExecuteAt = noteDb.Execute_at;
            IsDone = noteDb.IsDone;
            Type = noteDb.Type;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ExecuteAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDone { get; set; }

        //возможно тут лучше enum
        public string Type { get; set; }
    }
}
