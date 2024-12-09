using Microsoft.AspNetCore.Components;
using RadzenBlazorDemos.Models.Northwind;

namespace Front.Components.Pages.Components.Analise;

public partial class BensCreditosFieldsetComponent : ComponentBase
{
    IEnumerable<Employee> _employees;

    public BensCreditosFieldsetComponent()
    {
        _employees = Enumerable.Empty<Employee>();
    }
}