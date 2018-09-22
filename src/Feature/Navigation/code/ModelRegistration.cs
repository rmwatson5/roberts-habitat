
using System.Collections.Generic;
using System.Linq;
using Sitecore.Foundation.DataAccess;

namespace Sitecore.Feature.Navigation
{
    public class ModelRegistration : FeatureModelRegistration
    {
        protected override IEnumerable<string> IncludedTemplates => base.IncludedTemplates.Union(ExtraTemplates);
        protected IEnumerable<string> ExtraTemplates => new List<string> { "/sitecore/templates/system/Language" };
    }
}
