using Acme.BookStore.Step_3.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStore.Step_3.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Step_3Controller : AbpControllerBase
{
    protected Step_3Controller()
    {
        LocalizationResource = typeof(Step_3Resource);
    }
}
