using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentIcons.Common;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;

namespace IconExplorer;

public sealed partial class FluentIcons
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

    public FluentIcons() => InitializeComponent();

    private static SymbolModel2[] ItemSource { get; } = Enum.GetValues<Icon>().Select(t => new SymbolModel2(t)).ToArray();

    private void UIElement_OnTapped2(object sender, TappedRoutedEventArgs e) => SetItemsSource(ItemSource);

    private FrozenDictionary<string, SymbolModel2> Table { get; } =
        ItemSource.ToDictionary(x => x.Icon.ToString().ToLower() + x.Icon.ToString().Count(num => num is >= 'A' and <= 'Z'))
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

        var view = new List<SymbolModel2>();
        await Task.Run(() =>
        {
            foreach (var (key, value) in Table)
                if (key.Contains(text))
                    view.Add(value);
        });
        SetItemsSource(view);
    }

    private void SetItemsSource(IReadOnlyList<SymbolModel2> source)
    {
        ItemsView.ItemsSource = source;
    }
}
