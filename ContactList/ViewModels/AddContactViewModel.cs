using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactList.Services;


namespace ContactList.ViewModels;

public partial class AddContactViewModel : ObservableObject
{
    private readonly ContactService _contactService;

    public AddContactViewModel(ContactService contactService)
    {
        _contactService = contactService;
    }

    [ObservableProperty]
    private string name = string.Empty;

    [ObservableProperty]
    private string email = string.Empty;

    [ObservableProperty]
    private string phoneNumber = string.Empty;

    [ObservableProperty]
    private string description = string.Empty;

    [RelayCommand]
    private async Task Save()
    {
        ContactList.Models.Contact newContact = new()
        {
            Name = Name,
            Email = Email,
            PhoneNumber = PhoneNumber,
            Description = Description
        };

        _contactService.Contacts.Add(newContact);

        Name = string.Empty;
        Email = string.Empty;
        PhoneNumber = string.Empty;
        Description = string.Empty;

        await Shell.Current.GoToAsync(nameof(Views.ContactsPage));
    }
}