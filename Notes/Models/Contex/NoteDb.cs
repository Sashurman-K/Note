using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Notes.Models.Contex
{
    //позволил немного хамства в чужом проекте и попереименовывал все :)
    [Table("notes")]
    public class NoteDb
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("title")]
        public string Title { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Required]
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("type")]
        public string Type { get; set; }

        [Column("execute_at")]
        public DateTime Execute_at { get; set; }

        [Required]
        [Column("is_done")]
        public bool IsDone { get; set; }
    }
}

