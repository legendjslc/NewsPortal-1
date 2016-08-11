using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsPortal.DAL.Entities
{
    public class Comment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("Id")]
        public virtual User User { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTime CommentTime { get; set; }
    }
}
