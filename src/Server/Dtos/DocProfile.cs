using AutoMapper;
using BlazorDocs.Database;

namespace Server
{
    public class DocProfile : Profile
    {
        public DocProfile()
        {
            CreateMap<DocDto, Doc>();
            CreateMap<Doc, DocDto>();
        }
    }
}