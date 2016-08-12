using System;
using System.Collections.Generic;

namespace NewsPortal.BL.DTO
{
    public class NewsDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string AuthorName { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime EditTime { get; set; }
    }
}