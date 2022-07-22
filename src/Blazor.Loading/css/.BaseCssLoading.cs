using Microsoft.AspNetCore.Components;

namespace Blazor.Loading;

public class BaseCssLoading : ComponentBase
{
    [Parameter] public int Size { get; set; } = 64;

    [Parameter] public string Color { get; set; } = "#FFF";

    protected virtual int OriginalSize { get; set; } = 80;
    protected int Convert(double value)
    {
        return (int)(value / OriginalSize * Size);
    }
}
