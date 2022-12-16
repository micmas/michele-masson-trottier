using Microsoft.AspNetCore.Components;

namespace Michele.Client.Pages;

public partial class Acceuil
{
    [Inject]
    private NavigationManager Navigation { get; set; } = default!;

    private void NavigateToCliniqueComponent()
    {
        Navigation.NavigateTo("clinique");
    }

    private void NavigateToRechercheComponent()
    {
        Navigation.NavigateTo("recherche");
    }
}