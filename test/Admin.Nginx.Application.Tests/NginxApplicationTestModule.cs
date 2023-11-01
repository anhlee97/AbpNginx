using Volo.Abp.Modularity;

namespace Admin.Nginx;

[DependsOn(
    typeof(NginxApplicationModule),
    typeof(NginxDomainTestModule)
    )]
public class NginxApplicationTestModule : AbpModule
{

}
