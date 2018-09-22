using Sitecore.Globalization;
using Sitecore.Links;

namespace Sitecore.Feature.Navigation.Models
{
    public class SwitchableLanguage
    {
        public readonly Language Language;
        public bool IsCurrent => Context.Language == Language;

        public SwitchableLanguage(Language language)
        {
            this.Language = language;
        }
        
        public string GenerateUrl()
        {
            var options = LinkManager.GetDefaultUrlOptions();
            options.Language = Language;
            return LinkManager.GetItemUrl(Context.Item, options);
        }
    }
}
