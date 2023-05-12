using InfoShop.Core.Common.DTO.Isp;

namespace InfoShop.Core.BLL.Interfaces
{
    public interface IIspService
    {
        Task<ICollection<IspDto>> GetAllIspAsync();
        Task<IspDto> GetIspAsync(long id);
        Task<NewIspDto> CreateIspAsync(NewIspDto ispDto);
    }
}