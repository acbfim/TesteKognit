using AutoMapper;
using kognito.domain;
using kognito.domain.Dtos;

namespace kognito.api.Helpers;


public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<User, CreateUser>().ReverseMap();
        CreateMap<Wallet, CreateWallet>().ReverseMap();

    }

}
