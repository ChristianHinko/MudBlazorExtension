using System.Diagnostics.CodeAnalysis;

namespace MudBlazorExtensionLibrary
{
    /// <summary>
    /// Collection of custom icons.
    /// 
    /// NOTE: Some of these strings are standalone SVGs (containing the svg tag themselves) even though MudIcon does
    /// not expect this. MudIcon wraps your Icon in an svg tag already, resulting in our svg tags getting nested
    /// within MudIcon's svg tag. This sounds bad.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public partial class MBELIcons
    {
    }
}
