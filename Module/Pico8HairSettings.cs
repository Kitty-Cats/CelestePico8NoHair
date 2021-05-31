using Celeste.Mod;
using Microsoft.Xna.Framework.Input;
using YamlDotNet.Serialization;

namespace Celeste.Mod.Pico8NoHair.Module
{
    // If no SettingName is applied, it defaults to
    // modoptions_[typename without settings]_title
    // The value is then used to look up the UI text in the dialog files.
    // If no dialog text can be found, Everest shows a prettified mod name instead.
    [SettingName("modoptions_pico8nohair_title")]
    public class Pico8HairModuleSettings : EverestModuleSettings
    {

        // SettingName also works on props, defaulting to
        // modoptions_[typename without settings]_[propname]

        // Example ON / OFF property with a default value.
        public bool DrawHair { get; set; } = true;

    }
}