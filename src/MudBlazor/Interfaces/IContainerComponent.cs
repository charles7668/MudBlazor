namespace MudBlazor;

internal interface IContainerComponent
{
    public void Register(object item);
    public void Unregister(object item);
}
