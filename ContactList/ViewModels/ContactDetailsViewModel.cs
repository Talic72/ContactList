using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactList.Services;

namespace ContactList.ViewModels;

public partial class ContactDetailsViewModel : ObservableObject
{
    private readonly ContactService _contactService;

    public ContactDetailsViewModel(ContactService contactService)
    {
        _contactService = contactService;
    }

    [ObservableProperty]
    private ContactList.Models.Contact? selectedContact;

    [ObservableProperty]
    private bool isEditing;

    [RelayCommand]
    private void Edit()
    {
        IsEditing = true;
    }

    [RelayCommand]
    private async Task SaveAsync()
    {
        IsEditing = false;

        // Nav added later
        await Task.CompletedTask;
    }

    [RelayCommand]
    private async Task BackAsync()
    {
        // Nav later
        await Task.CompletedTask;
    }
}