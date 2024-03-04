using Volo.Abp.Modularity;

namespace Acme.BookStore.Step_3;

[DependsOn(
    typeof(Step_3DomainModule),
    typeof(Step_3TestBaseModule)
)]
public class Step_3DomainTestModule : AbpModule
{

}
