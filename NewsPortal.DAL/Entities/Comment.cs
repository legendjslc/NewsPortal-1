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
        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTime CommentTime { get; set; }
        public Guid NewsId { get; set; }
        [ForeignKey("NewsId")]
        public virtual News News { get; set; }
    }
}
