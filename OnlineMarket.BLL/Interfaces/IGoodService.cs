using OnlineMarket.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.BLL.Interfaces
{
    public interface IGoodService
    {
        IEnumerable<GoodDTO> GetAll();

        GoodDTO Get(int id);

        void Create(GoodDTO good);

        void Update(GoodDTO newGood);

        Task Delete(int id);
    }
}
