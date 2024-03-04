using Acme.BookStore.Step_3.Localization;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Step_3;

/* Inherit your application services from this class.
 */
public abstract class Step_3AppService : ApplicationService
{
    protected Step_3AppService()
    {
        LocalizationResource = typeof(Step_3Resource);
    }
}
