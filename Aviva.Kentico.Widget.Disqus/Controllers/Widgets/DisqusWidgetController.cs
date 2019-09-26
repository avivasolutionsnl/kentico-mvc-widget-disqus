using System;
using System.Linq;
using System.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using Aviva.Kentico.Widget.Disqus.Controllers.Widgets;
using Aviva.Kentico.Widget.Disqus.Models.Widgets;
using System.Configuration;
using System.Text;
using CMS.Membership;

[assembly: RegisterWidget("Kentico.Widget.Disqus", typeof(DisqusWidgetController), "{$Aviva.Kentico.Mvc.Widget.Disqus.Name$}", Description = "{$Aviva.Kentico.Mvc.Widget.Disqus.Description$}", IconClass = "icon-bubbles")]

namespace Aviva.Kentico.Widget.Disqus.Controllers.Widgets
{
    public class DisqusWidgetController : WidgetController<DisqusWidgetProperties>
    {
        public ActionResult Index()
        {
            var properties = GetProperties();

            UserInfo user = UserInfoProvider.GetUserInfo(User.Identity.Name);

            var viewModel = new DisqusWidgetViewModel
            {
                DisqusShortName = properties.DisqusShortName,
                PageUrl = properties.PageUrl,
                PageIdentifier = properties.PageIdentifier,
                PageTitle = properties.PageTitle,
                PageCategoryId = properties.PageCategoryId,
            };
            
            return PartialView("~/Views/Shared/Widgets/DisqusWidget/_DisqusWidget.cshtml", viewModel);
        }
    }
}
