using Sitecore.Data.Items;
using Sitecore.Layouts;
using SitecoreContentEditorTabs.Models;

namespace SitecoreContentEditorTabs.Interfaces
{
    public interface IComponentMapper
    {
        Component MapToComponent(RenderingReference renderingReference, Item datasource);
    }
}