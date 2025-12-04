using Microsoft.JSInterop;
using SweetAlert2.Blazor.Models;

namespace SweetAlert2.Blazor.Services;

public interface ISweetAlert2Service
{
    ValueTask<SweetAlert2Return> Alert(SweetAlert2Model alert);
}

public class SweetAlert2Service(IJSRuntime js) : ISweetAlert2Service, IAsyncDisposable
{
    private readonly Lazy<Task<IJSObjectReference>> moduleTask = new(
        () => js.InvokeAsync<IJSObjectReference>(
            "import", "./_content/SweetAlert2.Blazor/sweetalert-wrapper.js").AsTask());

    public async ValueTask<SweetAlert2Return> Alert(SweetAlert2Model alert)
    {
        try
        {
            var module = await moduleTask.Value;
            return await module.InvokeAsync<SweetAlert2Return>("sweetAlert", alert);
        }
        catch (TaskCanceledException)
        {
            return new SweetAlert2Return { IsDismissed = true };
        }
    }

    public async ValueTask DisposeAsync()
    {
        if (moduleTask.IsValueCreated)
        {
            var module = await moduleTask.Value;
            await module.DisposeAsync();
        }
        GC.SuppressFinalize(this);
    }
}
