using CommunityToolkit.Mvvm.ComponentModel;
using Symbol = FluentIcons.Common.Symbol;
using FluentIcons.Common;

namespace IconExplorer;

public partial class SymbolModel(Symbol symbol) : ObservableObject
{
    public Symbol Symbol { get; } = symbol;

    [ObservableProperty]
    public partial IconVariant IconVariant { get; set; }
}
