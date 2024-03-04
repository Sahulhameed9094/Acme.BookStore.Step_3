using Acme.BookStore.Step_3.Samples;
using Xunit;

namespace Acme.BookStore.Step_3.EntityFrameworkCore.Domains;

[Collection(Step_3TestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<Step_3EntityFrameworkCoreTestModule>
{

}
