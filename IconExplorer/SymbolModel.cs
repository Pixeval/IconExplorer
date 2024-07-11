using CommunityToolkit.Mvvm.ComponentModel;
using Symbol = FluentIcons.Common.Symbol;
using FluentIcons.Common;

namespace IconExplorer;

public partial class SymbolModel(Symbol symbol) : ObservableObject
{
    public Symbol Symbol { get; } = symbol;

    [ObservableProperty] private bool _isFilled;


    [ObservableProperty] private bool _useMetric = true;

#pragma warning disable CA1822
    public IconVariant GetIconVariant(bool isFilled) => isFilled ? IconVariant.Filled : IconVariant.Regular;
#pragma warning restore CA1822
}