using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactList.Services;

namespace ContactList.ViewModels;

public partial class ContactsViewModel : ObservableObject
{
    private readonly ContactService _contactService;

    public ContactsViewModel(ContactService contactService)
    {
        _contactService = contactService;
    }

    public System.Collections.ObjectModel.ObservableCollection<ContactList.Models.Contact> Contacts
        => _contactService.Contacts;

    [ObservableProperty]
    private ContactList.Models.Contact? selectedContact;

    partial void OnSelectedContactChanged(ContactList.Models.Contact? value)
    {
        if (value != null)
        {
            OpenContactCommand.Execute(value);
        }
    }

    
    [RelayCommand]
    private async Task OpenContact(ContactList.Models.Contact contact)
    {
        _contactService.SelectedContact = contact;

        await Shell.Current.GoToAsync(nameof(Views.ContactDetailsPage));

        SelectedContact = null;
    }

    [RelayCommand]
    private async Task AddContact()
    {
        await Shell.Current.GoToAsync("..");
    }
}