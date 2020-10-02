﻿using Microsoft.AspNetCore.Components;

namespace BlazorDesk.Components
{
    public interface ICard
    {
        RenderFragment Header { get; set; }
        RenderFragment Body { get; set; }
        Color HeaderBackgroundColor { get; set; }
        LoadingState LoadingState { get; set; }
        CardStyle[] Styles { get; set; }
        RenderFragment Title { get; set; }
        CardType Type { get; set; }
    }
}