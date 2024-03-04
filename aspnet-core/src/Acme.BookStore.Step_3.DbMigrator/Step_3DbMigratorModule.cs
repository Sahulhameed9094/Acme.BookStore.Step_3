using Acme.BookStore.Step_3.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.BookStore.Step_3.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Step_3EntityFrameworkCoreModule),
    typeof(Step_3ApplicationContractsModule)
)]
public class Step_3DbMigratorModule : AbpModule
{
}
