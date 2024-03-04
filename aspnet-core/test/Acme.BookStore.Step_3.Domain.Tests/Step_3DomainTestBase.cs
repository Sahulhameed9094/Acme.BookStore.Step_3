using Volo.Abp.Modularity;

namespace Acme.BookStore.Step_3;

/* Inherit from this class for your domain layer tests. */
public abstract class Step_3DomainTestBase<TStartupModule> : Step_3TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
