using AutoMapper;
using Core.Domain.User;
using Infrastructure.Data.Entities.Product;

namespace Infrastructure.Repository;
public class MyMapper : Profile
{
      public MyMapper()
      {
        CreateMap<MProduct,TblProduct>().
        ForMember(destinationMember => destinationMember.SubmitDate, 
        opt => opt.MapFrom(src => src.SubmitDate.PersianDateToMiladiDate()));

        CreateMap<TblProduct,MProduct>().
        ForMember(destinationMember => destinationMember.SubmitDate,
        Opt => Opt.MapFrom(src => src.SubmitDate.ConvertToJalali()));
      }
}