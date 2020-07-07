using System.Threading.Tasks;
using Abp.Application.Services;
using template.Sessions.Dto;

namespace template.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
