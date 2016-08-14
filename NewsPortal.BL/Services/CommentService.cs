using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using NewsPortal.BL.DTO;
using NewsPortal.BL.Interfaces;
using NewsPortal.DAL.Interfaces;

namespace NewsPortal.BL.Services
{
    public class CommentService : AbstractService, ICommentService
    {
        public CommentService(IDALUnitOfWork uow) : base(uow)
        {
        }

        public CommentDTO CreateComment(CommentDTO comment)
        {
            throw new System.NotImplementedException();
        }

        public CommentDTO EditComment(CommentDTO comment)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteComment(CommentDTO comment)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CommentDTO> GetCommentsForNews(Guid newsId)
        {
            var comments = Database.CommentRepository.All().Where(com => com.NewsId == newsId);
            return Mapper.Map<IEnumerable<CommentDTO>>(comments);
        }
    }
}