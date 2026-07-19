namespace ContactList
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.ContactsPage), typeof(Views.ContactsPage));
            Routing.RegisterRoute(nameof(Views.ContactDetailsPage), typeof(Views.ContactDetailsPage));
        }
    }
}
