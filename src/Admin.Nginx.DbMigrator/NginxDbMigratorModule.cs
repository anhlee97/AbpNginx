using Admin.Nginx.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Admin.Nginx.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NginxEntityFrameworkCoreModule),
    typeof(NginxApplicationContractsModule)
    )]
public class NginxDbMigratorModule : AbpModule
{
}
