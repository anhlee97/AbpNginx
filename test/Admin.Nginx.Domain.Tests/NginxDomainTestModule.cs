using Admin.Nginx.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Admin.Nginx;

[DependsOn(
    typeof(NginxEntityFrameworkCoreTestModule)
    )]
public class NginxDomainTestModule : AbpModule
{

}
