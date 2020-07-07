using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace template.Controllers
{
    public abstract class templateControllerBase: AbpController
    {
        protected templateControllerBase()
        {
            LocalizationSourceName = templateConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
