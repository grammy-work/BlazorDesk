using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorDesk.Components
{
    public enum LoadingState
    {
        [Style("")]
        None,
        [Style("overlay")]
        Normal,
        [Style("overlay dark")]
        Dark
    }
}
