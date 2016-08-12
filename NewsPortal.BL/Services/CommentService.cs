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
    }
}