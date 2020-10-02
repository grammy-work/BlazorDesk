﻿using Microsoft.AspNetCore.Components;
using System;

namespace BlazorDesk.Components
{
    public partial class SmallBox
    {
        [Parameter] 
        public RenderFragment Title { get; set; } 
        [Parameter] 
        public RenderFragment Value { get; set; } 
        [Parameter] 
        public string Icon { get; set; }
        [Parameter] 
        public Color BackgroundColor { get; set; }
        [Parameter]
        public Gradient Gradient { get; set; }
        [Parameter]
        public LoadingState LoadingState { get; set; }
        [Parameter]
        public RenderFragment Footer { get; set; }     

        private string DisplayBackgroundColor =>
           BackgroundColor == Color.Default ?
           string.Empty :
           $"{GradientPrefix}{BackgroundColor.GetDescription<StyleAttribute>()}";
        private string GradientPrefix =>
               Gradient == Gradient.None ?
               string.Empty :
               $"{Gradient.GetDescription<StyleAttribute>()}-";
    }
}