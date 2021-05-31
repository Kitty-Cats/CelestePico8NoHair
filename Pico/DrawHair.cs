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
using Celeste.Pico8;
using Celeste.Mod.Pico8NoHair.Module;

namespace Celeste.Mod.Pico8NoHair.Pico
{
    public class DrawHair
    {
        public static void Load()
        {
            On.Celeste.Pico8.Classic.player_hair.draw_hair += OnDrawHair;
        }
        public static void Unload()
        {
            On.Celeste.Pico8.Classic.player_hair.draw_hair -= OnDrawHair;
        }
        private static void OnDrawHair(On.Celeste.Pico8.Classic.player_hair.orig_draw_hair orig, Classic.player_hair self, Classic.ClassicObject obj, int facing, int djump)
        {
            if (Pico8HairModule.Instance.Settings.DrawHair == false)
            {
                return;
            } orig(self, obj, facing, djump);

            /*int num = (djump == 1) ? 8 : ((djump == 2) ? (7 + this.E.flr((float)(this.G.frames / 3 % 2)) * 4) : 12);
            Vector2 vector;
            vector..ctor(obj.x + 4f - (float)(facing * 2), obj.y + (float)(this.E.btn(this.G.k_down) ? 4 : 3));
            foreach (Classic.player_hair.node node in this.hair)
            {
                node.x += (vector.X - node.x) / 1.5f;
                node.y += (vector.Y + 0.5f - node.y) / 1.5f;
                this.E.circfill(node.x, node.y, node.size, (float)num);
                vector..ctor(node.x, node.y);
            } */
        }
    }
}

