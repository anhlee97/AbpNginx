using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Admin.Nginx.Data;

/* This is used if database provider does't define
 * INginxDbSchemaMigrator implementation.
 */
public class NullNginxDbSchemaMigrator : INginxDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
