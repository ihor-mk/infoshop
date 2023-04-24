using AutoMapper;
using InfoShop.Core.DAL.Context;

namespace InfoShop.Core.BLL.Services.Abstract
{
    public abstract class BaseService
    {
        private protected readonly InfoShopCoreContext _context;
        private protected readonly IMapper _mapper;

        public BaseService(InfoShopCoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
