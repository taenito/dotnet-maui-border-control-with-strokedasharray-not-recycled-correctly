using CommunityToolkit.Mvvm.ComponentModel;

namespace App;

public partial class ItemViewModel : ObservableObject
{
    [ObservableProperty]
    string? _text;
		
    [ObservableProperty]
    Color? _cardBackgroundColor;
		
    [ObservableProperty]
    Color? _cardBorderColor;
		
    [ObservableProperty]
    DoubleCollection? _cardBorderDash;
}