using Microsoft.AspNetCore.Components;

namespace Blazor.Loading;

public class BaseSvgLoading : ComponentBase
{
    [Parameter] public int Size { get; set; } = 200;
}
