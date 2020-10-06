namespace BlazorDesk.Components
{
    public enum ContainerType //.container, .container-fluid, .container-sm, .container-md, .container-lg, .container-xl
    {
        [Style("")]
        Normal,
        [Style("fluid")]
        Fluid,
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
