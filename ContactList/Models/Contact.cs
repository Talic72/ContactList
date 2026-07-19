using CommunityToolkit.Mvvm.ComponentModel;

namespace ContactList.Models;

public partial class Contact : ObservableObject
{
    [ObservableProperty]
    private string name = string.Empty;

    [ObservableProperty]
    private string email = string.Empty;

    [ObservableProperty]
    private string phoneNumber = string.Empty;

    [ObservableProperty]
    private string description = string.Empty;
}