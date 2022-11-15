
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoFinalProject.Model
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string? Title { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
        [Column(TypeName = "BIT")]
        public bool Completed { get; set; }
        [Column(TypeName = "BIT")]
        public bool Important { get; set; }
    }

}