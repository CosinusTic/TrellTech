# TrellTech - Technical documentation

[![Nuget](https://img.shields.io/nuget/v/BlazorBindings.Maui)](https://www.nuget.org/packages/BlazorBindings.Maui/)
[![Join Discord](https://img.shields.io/badge/discord-join%20chat-46BC99)](https://discord.com/channels/732297728826277939/734865521400610856)

## Getting Started

Check out the documentation for how to build your first app: https://dreamescaper.github.io/MobileBlazorBindingsDocs

## What is it?

Maui Blazor Bindings enable developers to build native and hybrid mobile apps using C# and .NET for Android, iOS, Windows, macOS, and Tizen using familiar web programming patterns. This means you can use the Blazor programming model and Razor syntax to define UI components and behaviors of an application. The UI components that are included are based on MAUI native UI controls, which results in beautiful native mobile apps.

Here is a sample Counter component that renders native UI, which may look familiar to Blazor developers, that increments a value on each button press:

```xml
<StackLayout>
    <Label FontSize="30">You pressed @count times </Label>
    <Button Text="+1" OnClick="@HandleClick" />
</StackLayout>

@code {
    int count;

    void HandleClick()
    {
        count++;
    }
}
```

Notice that the Blazor model is present with code sitting side by side the user interface markup that leverages Razor syntax with mobile specific components. This will feel very natural for any web developer that has ever used Razor syntax in the past. Now with the Experimental Mobile Blazor Bindings you can leverage your existing web skills and knowledge to build native and hybrid mobile apps using C# and .NET for Android, iOS, Windows, macOS, and Tizen.

Here is the code above running in the Android Emulator:

<img src="https://devblogs.microsoft.com/aspnet/wp-content/uploads/sites/16/2020/01/blazor-android-counter-2.gif" alt="Clicking increment button in Android emulator" width="300" height="533" class="aligncenter size-full wp-image-23061" />


### Recommendations
This project is intended to be run in both Android Mobile and Desktop formats natively. For this reason, we recomment installing [Android Studio](https://developer.android.com/studio/install) on your machine in order to emulate the app, otherwise you won't be able to run it. 


[.NET-MAUI](https://techcommunity.microsoft.com/t5/educator-developer-blog/net-maui-on-linux-with-visual-studio-code/ba-p/3982195) is a Multi-platform native app development framework (.NET family) intended to be developped in a Microsoft environment, please follow the link above to download .NET MAUI on a Linux operating system.

We strongly recommend using specialised IDEs like [Jetbrains'Rider](https://www.google.com/url?sa=t&source=web&rct=j&opi=89978449&url=https://www.jetbrains.com/fr-fr/rider/&ved=2ahUKEwiMncq-342FAxVlUqQEHbFyCxgQFnoECAYQAQ&usg=AOvVaw3-bC_BsCu8o0jRamzNURUR) or [Visual-Studio](https://www.google.com/url?sa=t&source=web&rct=j&opi=89978449&url=https://learn.microsoft.com/fr-fr/visualstudio/install/install-visual-studio%3Fview%3Dvs-2022&ved=2ahUKEwivopnL342FAxXGVqQEHXwHCfYQFnoECCEQAQ&usg=AOvVaw3Mp2MaKegsbQ6ffFBEuVgO) (exclusively for Windows and Linux) for .NET MAUI projects for their functionalities to enhance productivity, provide secure and best-practice development hints, and their building, and running functionnalities. 

Visual Studio code is also possible to be used with .NET MAUI with [this-link](https://techcommunity.microsoft.com/t5/educator-developer-blog/net-maui-on-linux-with-visual-studio-code/ba-p/3982195) (follow tutorial).

The .NET Sdk also provides CLI tools for running, debugging, and building .NET MAUI apps, please refer to their official [Documentation](https://learn.microsoft.com/fr-fr/dotnet/maui/what-is-maui?view=net-maui-8.0).

### Authors
- Nathan Delmarche, Software developer
- Armel de Marsac, Software developer