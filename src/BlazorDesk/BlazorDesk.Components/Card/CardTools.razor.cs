﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;

namespace BlazorDesk.Components
{
    partial class CardTools : ICardTools
    {
        [CascadingParameter(Name = "ToolOptions")]
        public CardToolOptions ToolOptions { get; set; }
        
        [Parameter]
        public EventCallback<Tuple<ICardTools, MouseEventArgs>> OnRefresh { get; set; }
        [Parameter]
        public EventCallback<Tuple<ICardTools, MouseEventArgs>> OnMaximize { get; set; }

        public bool IsMaximized { get; private set; } = false;

        private bool ShowOnRefresh => OnRefresh.HasDelegate;

        private void DoOnRefresh(MouseEventArgs args)
        {
            OnRefresh.InvokeAsync(new Tuple<ICardTools, MouseEventArgs>(this, args));
        }

        private void DoOnMaximize(MouseEventArgs args)
        {
            IsMaximized = !IsMaximized;
            OnRefresh.InvokeAsync(new Tuple<ICardTools, MouseEventArgs>(this, args));
        }

        private CardToolOptions Options => ToolOptions ?? new CardToolOptions();

        [Parameter]
        public RenderFragment CustomTools { get; set; }
    }
}
