﻿using OnlineMarket.BLL.DTO;

namespace OnlineMarket.BLL.Interfaces
{
    public interface IOrderService
    {
        Task<OrderDTO> GetAsync(int id);

        Task CreateAsync(OrderDTO order, int[] goodsids);


        Task UpdateAsync(OrderDTO newOrder);

        Task DeleteAsync(int id);
    }
}
