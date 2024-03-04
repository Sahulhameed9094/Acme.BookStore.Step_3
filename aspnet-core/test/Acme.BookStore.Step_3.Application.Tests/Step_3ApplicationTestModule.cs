using Volo.Abp.Modularity;

namespace Acme.BookStore.Step_3;

[DependsOn(
    typeof(Step_3ApplicationModule),
    typeof(Step_3DomainTestModule)
)]
public class Step_3ApplicationTestModule : AbpModule
{

}
