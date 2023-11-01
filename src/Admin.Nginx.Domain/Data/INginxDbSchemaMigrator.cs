using System.Threading.Tasks;

namespace Admin.Nginx.Data;

public interface INginxDbSchemaMigrator
{
    Task MigrateAsync();
}
