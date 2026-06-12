using Avalonia;
using Avalonia.Headless;
using HorrorOccultThemePlugin.Tests;

// Wires every [AvaloniaFact]/[AvaloniaTheory] in this assembly to a headless
// Avalonia app, so loading the embedded avares:// palette dictionaries has an
// initialized runtime to resolve against.
[assembly: AvaloniaTestApplication(typeof(TestApp))]

namespace HorrorOccultThemePlugin.Tests;

public sealed class TestApp : Application
{
    public static AppBuilder BuildAvaloniaApp() =>
        AppBuilder.Configure<TestApp>().UseHeadless(new AvaloniaHeadlessPlatformOptions());
}
