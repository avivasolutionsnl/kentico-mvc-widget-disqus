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
        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "{$Aviva.Kentico.Mvc.Widget.Disqus.DisqusShortName$}", ExplanationText = "{$Aviva.Kentico.Mvc.Widget.Disqus.DisqusShortNameExplanation$}", Order = 1)]
        public string DisqusShortName { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "{$Aviva.Kentico.Mvc.Widget.Disqus.PageUrl$}", ExplanationText = "{$Aviva.Kentico.Mvc.Widget.Disqus.PageUrlExplentation$}", Order = 2)]
        public string PageUrl { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "{$Aviva.Kentico.Mvc.Widget.Disqus.PageIdentifier$}", ExplanationText = "{$Aviva.Kentico.Mvc.Widget.Disqus.PageIdentifierExplanation$}", Order = 3)]
        public string PageIdentifier { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "{$Aviva.Kentico.Mvc.Widget.Disqus.PageTitle$}", ExplanationText = "{$Aviva.Kentico.Mvc.Widget.Disqus.PageTitleExplanation$}", Order = 4)]
        public string PageTitle { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "{$Aviva.Kentico.Mvc.Widget.Disqus.PageCategoryId$}", ExplanationText = "{$Aviva.Kentico.Mvc.Widget.Disqus.PageCategoryIdExplanation$}", Order = 5)]
        public string PageCategoryId { get; set; }
    }
}