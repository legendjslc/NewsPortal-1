using NewsPortal.BL.Interfaces;
using NewsPortal.DAL.Interfaces;

namespace NewsPortal.BL.Services
{
    public class BLUnitOfWork : IBLUnitOfWork
    {
        private ICommentService _commentService;
        private INewsService _newsService;
        private IRoleService _roleService;
        private IUserService _userService;

        private IDALUnitOfWork _uowDAL;

        public BLUnitOfWork(IDALUnitOfWork uowDAL)
        {
            _uowDAL = uowDAL;
        }

        public ICommentService CommentService
        {
            get { return _commentService ?? (_commentService = new CommentService(_uowDAL)); }
        }

        public INewsService NewsService
        {
            get { return _newsService ?? (_newsService = new NewsService(_uowDAL)); }
        }

        public IRoleService RoleService
        {
            get { return _roleService ?? (_roleService = new RoleService(_uowDAL));  }
        }

        public IUserService UserService
        {
            get { return _userService ?? (_userService = new UserService(_uowDAL)); }
        }
    }
}