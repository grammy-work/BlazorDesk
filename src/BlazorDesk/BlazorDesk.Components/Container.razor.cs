using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorDesk.Components
{
    public partial class Container
    {
        [Parameter]
        public ContainerType Type { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        public string DisplayContainerType {
            get {
				switch (Type)
				{
					case ContainerType.Normal:
                        return $"container";
					default:
                        return $"container-{Type.GetDescription<StyleAttribute>()}";
                }
            } 
        }
    }
}
