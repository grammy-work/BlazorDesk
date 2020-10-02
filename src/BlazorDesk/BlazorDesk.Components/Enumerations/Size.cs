using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorDesk.Components
{
    public enum Size
    {
        [Style("")]
        ExtraSmall,
        [Style("sm")]
        Small,
        [Style("md")]
        Medium,
        [Style("lg")]
        Large,
        [Style("xl")]
        ExtraLarge
    }
}
