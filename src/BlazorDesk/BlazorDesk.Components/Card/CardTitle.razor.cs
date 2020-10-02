using Microsoft.AspNetCore.Components;

namespace BlazorDesk.Components
{
    partial class CardTitle
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
