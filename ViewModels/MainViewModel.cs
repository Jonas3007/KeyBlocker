using CommunityToolkit.Mvvm.ComponentModel;
using System;
using CommunityToolkit.Mvvm.Input;
using KeyBlocker.Models;
namespace KeyBlocker.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string? _pressedKeys;

    [RelayCommand]
    private void AddKeyCombo()
    {
        PressedKeys += KeyLogger.getKeyCombination();
    }
}
