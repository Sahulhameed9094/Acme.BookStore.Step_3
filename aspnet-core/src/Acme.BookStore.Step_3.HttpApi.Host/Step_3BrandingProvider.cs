using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.BookStore.Step_3;

[Dependency(ReplaceServices = true)]
public class Step_3BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Step_3";
}
