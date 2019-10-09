using System.Web.Mvc;
using Aviva.Kentico.Widget.Disqus.Controllers.Widgets;
using Aviva.Kentico.Widget.Disqus.Models.Widgets;
using Kentico.PageBuilder.Web.Mvc;

[assembly:RegisterWidget("Kentico.Widget.Disqus", typeof(DisqusWidgetController), "{$Aviva.Kentico.Mvc.Widget.Disqus.Name$}", Description = "{$Aviva.Kentico.Mvc.Widget.Disqus.Description$}", IconClass = "icon-bubbles")]
namespace Aviva.Kentico.Widget.Disqus.Controllers.Widgets
{
    public class DisqusWidgetController : WidgetController<DisqusWidgetProperties>
    {
        public ActionResult Index()
        {
            var properties = GetProperties();
            var viewModel = new DisqusWidgetViewModel
            {
                DisqusShortName = properties.DisqusShortName,
                PageUrl = properties.PageUrl,
                PageIdentifier = properties.PageIdentifier,
                PageTitle = properties.PageTitle,
                PageCategoryId = properties.PageCategoryId
            };

            return PartialView("~/Views/Shared/Widgets/DisqusWidget/_DisqusWidget.cshtml", viewModel);
        }
    }
}