namespace NewsPortal.BL.Interfaces
{
    public interface IBLUnitOfWork
    {
        ICommentService CommentService { get; }
        INewsService NewsService { get; }
        IRoleService RoleService { get; }
        IUserService UserService { get; } 
    }
}