using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using TrelloApp.ApiTrello.DI;

namespace TrelloApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => { fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"); });

        builder.Services.AddMauiBlazorWebView();

#if DEBUG
        builder.Services.AddMudServices();
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif
        builder.Services.AddTrelloApi("fd575d9a5f2d9bb06f42aa9d79715b9a", "ATTAb438ee0ec502aa69140fb45e1df85b17453894a8e9bacaf903b52c48b565817cE97CF035");

        return builder.Build();
    }
}