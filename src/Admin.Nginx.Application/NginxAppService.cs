using System;
using System.Collections.Generic;
using System.Text;
using Admin.Nginx.Localization;
using Volo.Abp.Application.Services;

namespace Admin.Nginx;

/* Inherit your application services from this class.
 */
public abstract class NginxAppService : ApplicationService
{
    protected NginxAppService()
    {
        LocalizationResource = typeof(NginxResource);
    }
}
