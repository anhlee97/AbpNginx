using Admin.Nginx.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Admin.Nginx.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class NginxPageModel : AbpPageModel
{
    protected NginxPageModel()
    {
        LocalizationResourceType = typeof(NginxResource);
    }
}
