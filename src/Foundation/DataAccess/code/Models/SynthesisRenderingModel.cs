using Sitecore.Mvc.Presentation;
using Synthesis;

namespace Sitecore.Foundation.DataAccess.Models
{
    public abstract class SynthesisRenderingModel<TPageItem>
    where TPageItem : class, IStandardTemplateItem
    {
        public TPageItem PageItem => Context.Item.As<TPageItem>();
    }

    public abstract class SynthesisRenderingModel<TPageItem, TRenderingItem> : SynthesisRenderingModel<TPageItem>
        where TPageItem : class, IStandardTemplateItem
        where TRenderingItem : class, IStandardTemplateItem
    {
        public TRenderingItem RenderingItem => RenderingContext.Current.ContextItem.As<TRenderingItem>();
    }
}
