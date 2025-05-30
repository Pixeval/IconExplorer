using CommunityToolkit.Mvvm.ComponentModel;
using FluentIcons.Common;

namespace IconExplorer;

public partial class SymbolModel2(Icon symbol) : ObservableObject
{
    public Icon Icon { get; } = symbol;

    [ObservableProperty]
    public partial IconVariant IconVariant { get; set; }
}
