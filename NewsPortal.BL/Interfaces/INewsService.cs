using NewsPortal.BL.DTO;

namespace NewsPortal.BL.Interfaces
{
    public interface INewsService
    {
        NewsDTO CreateNews(NewsDTO news);
        NewsDTO EditNews(NewsDTO news);
        bool DeleteNews(NewsDTO news);
    }
}