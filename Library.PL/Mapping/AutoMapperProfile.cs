using AutoMapper;
using Library.BLL.Models;
using Library.DAL.Entities;
using Library.PL.Models.ViewModels;

namespace Library.PL.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Book, BookModel>().ReverseMap();
            CreateMap<Member, MemberModel>().ReverseMap();
            CreateMap<Loan, LoanModel>().ReverseMap();
            CreateMap<MemberModel, MemberViewModel>().ReverseMap();
            CreateMap<LoanModel, LoanViewModel>().ReverseMap();
            CreateMap<BookModel, BookViewModel>().ReverseMap();
        }
    }
}
