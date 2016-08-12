using AutoMapper;
using NewsPortal.BL.DTO;
using NewsPortal.BL.Util;
using NewsPortal.DAL.Entities;

namespace NewsPortal.BL.Infrastructure
{
    public class BLAutoMapperProfile : Profile
    {
        public BLAutoMapperProfile()
        {
            Mapper.Initialize(cfg =>
            {
                CreateMap<Comment, CommentDTO>().ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.Name)).IgnoreAllNonExisting();
                CreateMap<CommentDTO, Comment>().IgnoreAllNonExisting();
                CreateMap<News, NewsDTO>().ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.Name)).IgnoreAllNonExisting();
                CreateMap<NewsDTO, News>().IgnoreAllNonExisting();
                CreateMap<Role, RoleDTO>().IgnoreAllNonExisting();
                CreateMap<RoleDTO, Role>().IgnoreAllNonExisting();
                CreateMap<User, UserDTO>().IgnoreAllNonExisting();
                CreateMap<UserDTO, User>().IgnoreAllNonExisting();
            });
        }
    }
}
