using AutoMapper;
using Bmerketo_WebApp.Models;
using Bmerketo_WebApp.Models.Entities;
using Bmerketo_WebApp.Models.Navigation;
using Bmerketo_WebApp.Models.Partials;

namespace Bmerketo_WebApp.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() 
        {
            CreateMap<NavLinkEntity, NavLinkModel>().ReverseMap();
            CreateMap<ImageEntity, ImageModel>().ReverseMap();
            CreateMap<ShowcaseEntity, ShowcaseModel>().ReverseMap();
            CreateMap<ProductReviewModel, ProductReviewEntity>().ReverseMap();
            CreateMap<ProductCardEntity, ProductCardModel>().ReverseMap();
        }
    }
}
