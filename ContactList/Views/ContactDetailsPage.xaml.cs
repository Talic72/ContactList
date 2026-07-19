using ContactList.ViewModels;

namespace ContactList.Views;

public partial class ContactDetailsPage : ContentPage
{
    public ContactDetailsPage(ContactDetailsViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}