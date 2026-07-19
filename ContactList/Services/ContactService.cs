using System.Collections.ObjectModel;
using ContactList.Models;

namespace ContactList.Services;

public class ContactService
{
    public ObservableCollection<ContactList.Models.Contact> Contacts { get; } = new();
}