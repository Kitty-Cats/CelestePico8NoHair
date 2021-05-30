// Example usings.
using Celeste.Mod.UI;
using FMOD.Studio;
using Microsoft.Xna.Framework;
using Monocle;
using Celeste;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Celeste.Mod.Pico8NoHair.Pico;

namespace Celeste.Mod.Pico8NoHair.Module
{
    public class Pico8HairModule : EverestModule
    {

        // Only one alive module instance can exist at any given time.
        public static Pico8HairModule Instance;

        public Pico8HairModule()
        {
            Instance = this;
        }

        // Check the next section for more information about mod settings, save data and session.
        // Those are optional: if you don't need one of those, you can remove it from the module.

        // If you need to store settings:
        //public override Type SettingsType => typeof(ExampleModuleSettings);
        //public static ExampleModuleSettings Settings => (ExampleModuleSettings)Instance._Settings;

        // If you need to store save data:
        //public override Type SaveDataType => typeof(ExampleModuleSaveData);
        //public static ExampleModuleSaveData SaveData => (ExampleModuleSaveData)Instance._SaveData;

        // If you need to store session data:
        //public override Type SessionType => typeof(ExampleModuleSession);
       // public static ExampleModuleSession Session => (ExampleModuleSession)Instance._Session;

        // Set up any hooks, event handlers and your mod in general here.
        // Load runs before Celeste itself has initialized properly.
        public override void Load()
        {
            DrawHair.Load();
        }

        // Optional, initialize anything after Celeste has initialized itself properly.
        public override void Initialize()
        {
        }

        // Optional, do anything requiring either the Celeste or mod content here.
        public override void LoadContent(bool firstLoad)
        {
        }

        // Unload the entirety of your mod's content. Free up any native resources.
        public override void Unload()
        {
            DrawHair.Unload();
        }

    }
}