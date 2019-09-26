namespace Aviva.Kentico.Widget.Disqus.Models.Widgets
{
    /// <summary>
    /// View model for disqus widget.
    /// </summary>
    public class DisqusWidgetViewModel
    {
        public string DisqusShortName { get; set; }
        public string PageUrl { get; set; }
        public string PageIdentifier { get; set; }
        public string PageTitle { get; set; }
        public string PageCategoryId { get; set; }
    }
}