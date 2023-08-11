using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Michele.Client.Shared;

public partial class CultureSelector
{
    // inject jsruntime to call javascript code
    [Inject] 
    public IJSRuntime JSRuntime { get; set; }

    // hold the callback selected value
    public string SelectedValue { get; set; }

    // call the javascript method to init the select picker
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender) // only needs to be called once per page render
        {
            await JSRuntime.InvokeVoidAsync("InitSelectPicker", DotNetObjectReference.Create(this), "OnSelectedValue", ".selectpicker");
        }
    }

    // method which will be triggered by javascript, need to pass the method name
    [JSInvokable]
    public void OnSelectedValue(string val)
    {
        SelectedValue = val;
        StateHasChanged();
    }
}