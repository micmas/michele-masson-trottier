using Microsoft.AspNetCore.Components;

namespace Michele.Client.Pages;

public partial class Acceuil
{
    private const string Name = "Michèle Masson-Trottier";
    private const string Description = "Michèle Masson-Trottier's website to showcase her portfolio, personal projects, and much more.";
    
    private readonly IEnumerable<string> Keywords = new List<string> 
    {
        "Michèle Masson-Trottier", "Michèle", "Masson-Trottier", "Orthophoniste"
    };
    
    [Inject]
    private NavigationManager Navigation { get; set; } = default!;

    private void NavigateToBiographieComponent()
    {
        Navigation.NavigateTo("biographie");
    }
    
    private void NavigateToCliniqueComponent()
    {
        Navigation.NavigateTo("clinique");
    }

    private void NavigateToRechercheComponent()
    {
        Navigation.NavigateTo("recherche");
    }
}