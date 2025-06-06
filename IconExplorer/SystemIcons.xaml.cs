using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentIcons.Common;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using Symbol = FluentIcons.Common.Symbol;

namespace IconExplorer;

public sealed partial class SystemIcons
{
    public IconVariant IconVariant
    {
        get;
        set
        {
            if (value == field)
                return;
            field = value;
            SetIconVariant(value);
            return;

            static async void SetIconVariant(IconVariant value)
            {
                await Task.Yield();
                foreach (var x in ItemSource)
                    x.IconVariant = value;
            }
        }
    }

    public SystemIcons() => InitializeComponent();

    private static SymbolModel[] ItemSource { get; } = Enum.GetValues<Symbol>().Select(t => new SymbolModel(t)).ToArray();

    private void UIElement_OnTapped2(object sender, TappedRoutedEventArgs e) => SetItemsSource(ItemSource);

    private FrozenDictionary<string, SymbolModel> Table { get; } =
        ItemSource.ToDictionary(x => x.Symbol.ToString().ToLower() + x.Symbol.ToString().Count(num => num is >= 'A' and <= 'Z'))
            .ToFrozenDictionary();

    private async void TextBox_OnTextChanged(TextBox textBox, TextBoxTextChangingEventArgs args)
    {
        await Task.Yield();
        if (textBox.Text is "")
        {
            SetItemsSource(ItemSource);
            return;
        }

        var text = textBox.Text.ToLower();
        if (Table.TryGetValue(text, out var v))
        {
            SetItemsSource([v]);
            return;
        }

        var view = new List<SymbolModel>();
        await Task.Run(() =>
        {
            foreach (var (key, value) in Table)
                if (key.Contains(text))
                    view.Add(value);
        });
        SetItemsSource(view);
    }

    private void SetItemsSource(IReadOnlyList<SymbolModel> source)
    {
        ItemsView.ItemsSource = source;
    }
}
