using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.BookStore.Step_3.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStore.Step_3.EntityFrameworkCore;

public class EntityFrameworkCoreStep_3DbSchemaMigrator
    : IStep_3DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreStep_3DbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the Step_3DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Step_3DbContext>()
            .Database
            .MigrateAsync();
    }
}
