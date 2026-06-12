using System.Collections.Generic;
using SoundBoard.PluginApi;

namespace HorrorOccultThemePlugin;

/// <summary>
/// Horror &amp; Occult theme pack — two selectable palettes for horror RPG
/// sessions. Each appears as its own entry in the host's theme dropdown,
/// prefixed with the pack name ("Horror &amp; Occult: The Sanitarium",
/// "Horror &amp; Occult: The Eldritch Void").
///
/// <list type="bullet">
///   <item><b>The Sanitarium</b> (fog &amp; ash) — waking up in an
///   abandoned, fog-covered hospital or a bleak Victorian winter. Cold
///   ash-gray, muted slate, and sterile off-white surfaces; faded ghostly
///   blue primary, rusted muted crimson for destructive actions.</item>
///   <item><b>The Eldritch Void</b> (velvet &amp; blood) — a vampire's
///   sanctum or a cultist's midnight ritual. Abyssal midnight black and
///   deep sickly indigo surfaces; vibrant blood red primary, toxic
///   unearthly slime green secondary.</item>
/// </list>
///
/// <para>Each palette is a flat set of colours; the host has no Dark/Light toggle.</para>
/// </summary>
public sealed class HorrorOccultThemePlugin : IThemePlugin
{
    public string Id => "theme.horror-occult";
    public string Name => "Horror & Occult";
    public string Version => PluginVersion.OfAssembly(typeof(HorrorOccultThemePlugin));
    public string Author => "Devin Sanders";
    public string Description => "Two Horror & Occult palettes: The Sanitarium (fog & ash) and The Eldritch Void (velvet & blood).";

    public void Initialize(IPluginContext context) { }
    public void Shutdown() { }

    public IEnumerable<ThemePalette> GetPalettes() => new[]
    {
        new ThemePalette("sanitarium",    "The Sanitarium",
            new[] { "avares://HorrorOccultThemePlugin/Themes/Sanitarium.axaml" }),
        new ThemePalette("eldritch-void", "The Eldritch Void",
            new[] { "avares://HorrorOccultThemePlugin/Themes/EldritchVoid.axaml" }),
    };
}
