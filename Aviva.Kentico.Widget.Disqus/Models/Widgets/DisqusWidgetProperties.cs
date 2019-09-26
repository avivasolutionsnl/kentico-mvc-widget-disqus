using System.ComponentModel.DataAnnotations;

using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Components.Web.Mvc.FormComponents;
using System.Collections.Generic;

namespace Aviva.Kentico.Widget.Disqus.Models.Widgets
{
    /// <summary>
    /// Disqus widget properties.
    /// </summary>
    public class DisqusWidgetProperties : IWidgetProperties
    {
        [Required]
        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "{$Aviva.Kentico.Mvc.Widget.Disqus.DisqusShortName$}", Order = 1)]
        public string DisqusShortName { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "{$Aviva.Kentico.Mvc.Widget.Disqus.PageUrl$}", Order = 2)]
        public string PageUrl { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "{$Aviva.Kentico.Mvc.Widget.Disqus.PageIdentifier$}", Order = 3)]
        public string PageIdentifier { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "{$Aviva.Kentico.Mvc.Widget.Disqus.PageTitle$}", Order = 4)]
        public string PageTitle { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "{$Aviva.Kentico.Mvc.Widget.Disqus.PageCategoryId$}", Order = 5)]
        public string PageCategoryId { get; set; }
    }
}