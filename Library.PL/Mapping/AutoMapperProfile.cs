using AutoMapper;
using Library.BLL.Models;
using Library.DAL.Entities;

namespace Library.PL.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Book, BookModel>().ReverseMap();
            CreateMap<Member, MemberModel>().ReverseMap();
            CreateMap<Loan, LoanModel>().ReverseMap();
        }
    }
}
