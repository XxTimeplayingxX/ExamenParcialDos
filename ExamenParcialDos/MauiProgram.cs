using CommunityToolkit.Maui;
using ExamenParcialDos.Services;
using ExamenParcialDos.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace ExamenParcialDos
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<Views.LoginPage>();
            builder.Services.AddSingleton<Views.Encuesta>();

            builder.Services.AddSingleton<ViewModels.LoginPageViewModel>();
            builder.Services.AddSingleton<ViewModels.EncuestaViewModel>();

            builder.Services.AddSingleton<IInicioDeSesion, InicioDeSesion>();
            builder.Services.AddSingleton<IEncuesta, Encuesta>();
            return builder.Build();
        }
    }
}