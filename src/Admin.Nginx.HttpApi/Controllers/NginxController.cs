using Admin.Nginx.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Admin.Nginx.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class NginxController : AbpControllerBase
{
    protected NginxController()
    {
        LocalizationResource = typeof(NginxResource);
    }
}
