using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineMarket.API.Models;
using OnlineMarket.BLL.DTO;
using OnlineMarket.BLL.Interfaces;

namespace OnlineMarket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class GoodController : ControllerBase
    {
        private readonly IGoodService goodService;
        private readonly IMapper mapper;

        public GoodController(IGoodService goodService, IMapper mapper)
        {
            this.goodService = goodService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<GoodDTO[]> GetAllAsync() =>
            await goodService.GetAllAsync();

        [HttpGet("{id}")]
        public async Task<GoodDTO> GetAsync(int id) =>
            await goodService.GetAsync(id);

        [HttpPost]
        public async Task CreateAsync([FromBody] GoodRequest request) =>
            await goodService.CreateAsync(mapper.Map<GoodDTO>(request));

        [HttpPut]
        public async Task UpdateAsync([FromBody] GoodRequest request) =>
            await goodService.UpdateAsync(mapper.Map<GoodDTO>(request));

        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id) =>
            await goodService.DeleteAsync(id);
    }
}
