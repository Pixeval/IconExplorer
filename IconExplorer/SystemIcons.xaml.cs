using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using Symbol = FluentIcons.Common.Symbol;

namespace IconExplorer;

public sealed partial class SystemIcons
{
    public bool IsFilled
    {
        get;
        set
        {
            if (value == field)
                return;
            field = value;
            SetFilled(value);
            return;

            static async void SetFilled(bool value)
            {
                await Task.Yield();
                foreach (var x in ItemSource)
                    x.IsFilled = value;
            }
        }
    }

    public bool UseMetric
    {
        get;
        set
        {
            if (value == field)
                return;
            field = value;
            SetMetric(value);
            return;

            static async void SetMetric(bool value)
            {
                await Task.Yield();
                foreach (var x in ItemSource)
                    x.UseMetric = value;
            }
        }
    } = true;

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