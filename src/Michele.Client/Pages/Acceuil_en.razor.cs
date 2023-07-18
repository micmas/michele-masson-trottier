using Microsoft.AspNetCore.Components;

namespace Michele.Client.Pages;

public partial class Acceuil
{
    [Inject]
    private NavigationManager Navigation { get; set; } = default!;

    private void NavigateToClinicalComponent()
    {
        Navigation.NavigateTo("clinique_en");
    }

    private void NavigateToResearchComponent()
    {
        Navigation.NavigateTo("recherche_en");
    }
    private void NavigateToBiographyComponent()
    {
        Navigation.NavigateTo("biographie_en");
    }
}