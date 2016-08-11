using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsPortal.DAL.Entities
{
    public class News
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Content { get; set; }
        [ForeignKey("Id")]
        public User Author { get; set; }
        [Required]
        public DateTime CreateTime { get; set; }
        public DateTime EditTime { get; set; }
        public virtual IEnumerable<Comment> Comments { get; set; }
    }
}
