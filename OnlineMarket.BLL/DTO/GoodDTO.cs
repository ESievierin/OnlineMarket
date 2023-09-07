﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.BLL.DTO
{
    public sealed class GoodDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public bool IsAvalaible { get; set; }

        public decimal Price { get; set; }
    }
}