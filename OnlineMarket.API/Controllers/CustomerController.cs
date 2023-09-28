using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineMarket.API.Models;
using OnlineMarket.BLL.DTO;
using OnlineMarket.BLL.Interfaces;

namespace OnlineMarket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;
        private readonly IMapper mapper;

        public CustomerController(ICustomerService customerservice, IMapper mapper)
        {
            customerService = customerservice;
            this.mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<CustomerDTO> GetAsync(int id) =>
            await customerService.GetAsync(id);

        [HttpPost("create")]
        public async Task CreateAsync([FromBody] CustomerRequest request) =>
            await customerService.CreateAsync(mapper.Map<CustomerDTO>(request));

        [HttpPut("update")]
        public async Task UpdateAsync([FromBody] CustomerRequest request) =>
            await customerService.UpdateAsync(mapper.Map<CustomerDTO>(request));

        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id) =>
            await customerService.DeleteAsync(id);
    }
}
