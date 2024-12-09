namespace MudBlazor;

internal interface IContainerComponent
{
    public Task Register(object item);
    public Task Unregister(object item);
}
