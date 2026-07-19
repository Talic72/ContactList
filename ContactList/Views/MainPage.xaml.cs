using ContactList.ViewModels;

namespace ContactList.Views;

public partial class MainPage : ContentPage
{
    public MainPage(AddContactViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private async void ViewContacts_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ContactsPage));
    }
}