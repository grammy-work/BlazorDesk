using Microsoft.AspNetCore.Components;

namespace BlazorDesk.Components
{
    partial class TabList
    {
        [Parameter]
        public string Identifier { get; set; }
        /// <summary>
        /// Whether or not the tabs shown will be controlled by Javascript or Blazor
        /// </summary>
        [Parameter]
        public bool ControlleredByBlazor { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
