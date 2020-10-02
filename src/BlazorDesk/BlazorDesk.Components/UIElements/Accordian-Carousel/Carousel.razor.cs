using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorDesk.Components
{
    public class CarouselItem
    {
        public string Image { get; set; }
        public string Alt { get; set; }
    }

    public class CarouselItemCollection : List<CarouselItem>
    {

    }

    public partial class Carousel
    {
    }
}
