using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStore.Step_3.Data;

/* This is used if database provider does't define
 * IStep_3DbSchemaMigrator implementation.
 */
public class NullStep_3DbSchemaMigrator : IStep_3DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
