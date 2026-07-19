using Microsoft.Extensions.Logging;
using ContactList.Services;
using ContactList.ViewModels;
using ContactList.Views;


namespace ContactList
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            //Register foir injection
            builder.Services.AddSingleton<ContactService>();          
            builder.Services.AddTransient<AddContactViewModel>();
            builder.Services.AddTransient<ContactsViewModel>();
            builder.Services.AddTransient<ContactDetailsViewModel>();    
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<ContactsPage>();
            builder.Services.AddTransient<ContactDetailsPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
