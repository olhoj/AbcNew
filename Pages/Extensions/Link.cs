namespace Abc.Pages.Extensions
{
    public class Link
    {
        public Link(string displayName, string url, string propertyName = null)
        {
            DisplayName = displayName;
            Url = url;
            PropertyName = propertyName ?? displayName;
        }
        public string DisplayName { get; }
        public string Url { get; }
        public string PropertyName { get; }
    }
}
