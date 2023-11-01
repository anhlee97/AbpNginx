using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Admin.Nginx.Web;

[Dependency(ReplaceServices = true)]
public class NginxBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Nginx";
}
