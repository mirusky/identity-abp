using System.Threading.Tasks;
using Abp.Application.Services;
using template.Authorization.Accounts.Dto;

namespace template.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
