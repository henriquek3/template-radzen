using Microsoft.AspNetCore.Components;

namespace Front.Components.Pages.Components.Analise;

public partial class AreasFieldsetComponent : ComponentBase
{
    private List<string> soloPredominante = new()
    {
        "Argiloso",
        "Argilo-Arenoso",
        "Arenoso",
        "Arenoso-Argiloso"
    };
}