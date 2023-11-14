using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineMarket.API.Models;
using OnlineMarket.BLL.DTO;
using OnlineMarket.BLL.Interfaces;

namespace OnlineMarket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;
        private readonly IMapper mapper;

        public OrderController(IOrderService orderService, IMapper mapper)
        {
            this.orderService = orderService;
            this.mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<OrderDTO> GetAsync(int id) =>
            await orderService.GetAsync(id);

        [HttpPost]
        public async Task CreateAsync([FromBody] OrderRequest request) =>
            await orderService.CreateAsync(mapper.Map<OrderDTO>(request), request.GoodsIds);

        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id) =>
            await orderService.DeleteAsync(id);
    }
}
