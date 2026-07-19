using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactList.Services;

namespace ContactList.ViewModels;

public partial class ContactDetailsViewModel : ObservableObject
{
    [ObservableProperty]
    private ContactList.Models.Contact? selectedContact;

    [RelayCommand]
    private async Task Back()
    {
        await Shell.Current.GoToAsync("..");
    }

public ContactDetailsViewModel(ContactService contactService)
    {
        SelectedContact = contactService.SelectedContact;
    }
}