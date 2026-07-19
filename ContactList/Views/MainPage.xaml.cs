using ContactList.ViewModels;

namespace ContactList.Views;

public partial class MainPage : ContentPage
{
    public MainPage(AddContactViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}