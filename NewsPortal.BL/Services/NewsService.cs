using NewsPortal.BL.DTO;
using NewsPortal.BL.Interfaces;
using NewsPortal.DAL.Interfaces;

namespace NewsPortal.BL.Services
{
    public class NewsService : AbstractService, INewsService
    {
        public NewsService(IDALUnitOfWork uow) : base(uow)
        {
        }

        public NewsDTO CreateNews(NewsDTO news)
        {
            throw new System.NotImplementedException();
        }

        public NewsDTO EditNews(NewsDTO news)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteNews(NewsDTO news)
        {
            throw new System.NotImplementedException();
        }
    }
}