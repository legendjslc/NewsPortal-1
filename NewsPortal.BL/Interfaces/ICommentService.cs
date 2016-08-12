using NewsPortal.BL.DTO;

namespace NewsPortal.BL.Interfaces
{
    public interface ICommentService
    {
        CommentDTO CreateComment(CommentDTO comment);
        CommentDTO EditComment(CommentDTO comment);
        bool DeleteComment(CommentDTO comment);
    }
}