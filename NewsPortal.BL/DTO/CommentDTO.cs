using System;

namespace NewsPortal.BL.DTO
{
    public class CommentDTO
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
        public DateTime CommentTime { get; set; }
    }
}