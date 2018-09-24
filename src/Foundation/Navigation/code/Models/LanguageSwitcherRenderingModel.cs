using System.Collections.Generic;
using Sitecore.Foundation.DataAccess.Models;
using Synthesis;

namespace Sitecore.Feature.Navigation.Models
{
    public class LanguageSwitcherRenderingModel : SynthesisRenderingModel<IStandardTemplateItem>
    {
        public IEnumerable<SwitchableLanguage> SwitchableLanguages { get; set; }
    }
}
