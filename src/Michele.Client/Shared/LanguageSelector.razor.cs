using System.Globalization;
using Microsoft.AspNetCore.Components;

namespace Michele.Client.Shared;

public partial class LanguageSelector
{
    private readonly CultureInfo[] _supportedCultures = new[]
    {
        new CultureInfo("fr-CA"),
        new CultureInfo("en-US")
    };

    [Inject]
    private NavigationManager Navigation { get; set; } = default!;

    protected override void OnInitialized()
    {
        Culture = CultureInfo.CurrentCulture;
    }

    private CultureInfo Culture
    {
        get => CultureInfo.CurrentCulture;
        set
        {
            if (Equals(CultureInfo.CurrentCulture, value)) return;
            
            /*
            var uri = new Uri(Navigation.Uri).GetComponents(UriComponents.PathAndQuery, UriFormat.Unescaped);
            var cultureEscaped = Uri.EscapeDataString(value.Name);
            var uriEscaped = Uri.EscapeDataString(uri);

            Navigation.NavigateTo($"Culture/Set?culture={cultureEscaped}&redirectUri={uriEscaped}", forceLoad: true);
            */
        }
    }
}