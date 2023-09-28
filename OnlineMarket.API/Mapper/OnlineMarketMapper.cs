using AutoMapper;
using OnlineMarket.API.Models;
using OnlineMarket.BLL.DTO;
using OnlineMarket.DAL.Entities;

namespace OnlineMarket.API.Mapper
{
    public sealed class OnlineMarketMapper : Profile
    {
        public OnlineMarketMapper()
        {
            CreateMap<Good, GoodDTO>().ReverseMap();
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<Order,OrderDTO>().ReverseMap();
            CreateMap<GoodRequest, GoodDTO>();
            CreateMap<CustomerRequest, CustomerDTO>();
            CreateMap<OrderRequest, OrderDTO>();
            CreateMap<GoodRequest[], GoodDTO[]>();
        }
    }
}
