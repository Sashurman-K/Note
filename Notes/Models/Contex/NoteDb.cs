using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Notes.Models.Contex
{
    public class NoteDb
    {
        [Table("notes")]
        public class TodoItemDb
        {
            [Key]
            [Column("id")]
            public int Id { get; set; }
            [Required]
            [Column("title")]
            public string? Title { get; set; }
            [Column("texttodo")]
            public string? Text { get; set; }
            [Required]
            [Column("timeofcreate")]
            public DateTime TimeOfCreate { get; set; }
            [Column("typeofnote")]
            public string? TypeOfNote { get; set; }
            [Column("timetodo")]
            public DateTime TimeToTodo { get; set; }
            [Required]
            [Column("isdone")]
            public bool IsDone { get; set; }
        }
    }
}
