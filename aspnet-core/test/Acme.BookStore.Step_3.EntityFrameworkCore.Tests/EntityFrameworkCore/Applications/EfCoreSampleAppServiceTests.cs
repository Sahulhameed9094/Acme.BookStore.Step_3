using Acme.BookStore.Step_3.Samples;
using Xunit;

namespace Acme.BookStore.Step_3.EntityFrameworkCore.Applications;

[Collection(Step_3TestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<Step_3EntityFrameworkCoreTestModule>
{

}
