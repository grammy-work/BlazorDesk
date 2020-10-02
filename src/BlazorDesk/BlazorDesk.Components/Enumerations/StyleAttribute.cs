using System;

namespace BlazorDesk.Components
{
    public class StyleAttribute : Attribute, IDescription
    {
        public string Description { get; set; }

        public StyleAttribute(string description)
        {
            Description = description;
        }
    }
}
