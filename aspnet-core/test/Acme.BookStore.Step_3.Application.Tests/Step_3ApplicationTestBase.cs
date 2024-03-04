using Volo.Abp.Modularity;

namespace Acme.BookStore.Step_3;

public abstract class Step_3ApplicationTestBase<TStartupModule> : Step_3TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
