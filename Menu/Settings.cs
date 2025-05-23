﻿using StupidTemplate.Classes;
using UnityEngine;
using static StupidTemplate.Menu.Main;

namespace StupidTemplate
{
    internal class Settings
    {
        public static ExtGradient backgroundColor = new ExtGradient{isRainbow = false};
        public static ExtGradient[] buttonColors = new ExtGradient[]
        {
            new ExtGradient{colors = GetSolidGradient(new Color32(22,15,85,255))}, // Disabled
            new ExtGradient{colors = GetSolidGradient(Color.blue)}, // Enabled
            new ExtGradient{colors = GetSolidGradient(new Color32(136,16,228,255))}, // Page Buttons
            new ExtGradient{colors = GetSolidGradient(new Color32(48,14,137,255))} // Disconnect


        };
        public static Color[] textColors = new Color[]
        {
            Color.white, // Disabled
            Color.white // Enabled
        };

        public static Font currentFont = (Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font);

        public static bool fpsCounter = false;
        public static bool disconnectButton = true;
        public static bool rightHanded = true;
        public static bool disableNotifications = true;

        public static KeyCode keyboardButton = KeyCode.Q;

        public static Vector3 menuSize = new Vector3(0.1f, 1f, 0.98f); // Depth, Width, Height
        public static int buttonsPerPage = 7;
    }
}
