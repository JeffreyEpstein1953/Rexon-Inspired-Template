using Photon.Pun;
using StupidTemplate.Classes;
using StupidTemplate.Mods;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            //Happy Pasting! 😄

            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Basic Mods", method =()=> Main.buttonsType= 1, isTogglable=false },
                new ButtonInfo { buttonText = "Rig Mods", method =()=> Main.buttonsType= 2, isTogglable=false },
                new ButtonInfo { buttonText = "Tag Mods", method =()=> Main.buttonsType= 3, isTogglable=false },
                new ButtonInfo { buttonText = "Visual Mods", method =()=> Main.buttonsType= 4, isTogglable=false },
                new ButtonInfo { buttonText = "Safety Mods", method =()=> Main.buttonsType= 5, isTogglable=false },
                new ButtonInfo { buttonText = "World Mods", method =()=> Main.buttonsType= 6, isTogglable=false },
                new ButtonInfo { buttonText = "Projectile Mods", method =()=> Main.buttonsType= 7, isTogglable=false },
                new ButtonInfo { buttonText = "<color=red>OP</color> Mods", method =() => SettingsMods.EnterSettings(), isTogglable=false },

            },

            new ButtonInfo[] { // basic
                new ButtonInfo { buttonText = "Return to Main Menu", method =() => Global.ReturnHome(), isTogglable = false},
                new ButtonInfo { buttonText = "Switch Menu Hands", enableMethod =() => SettingsMods.LeftHand(), disableMethod =() => SettingsMods.RightHand()},


            },

            new ButtonInfo[] { // rig
                new ButtonInfo { buttonText = "Return to Main Menu", method =() => Global.ReturnHome(), isTogglable = false},

            },

            new ButtonInfo[] { // tag
                new ButtonInfo { buttonText = "Return to Main Menu", method =() => Global.ReturnHome(), isTogglable = false},

            },

            new ButtonInfo[] { // visuals
                new ButtonInfo { buttonText = "Return to Main Menu", method =() => Global.ReturnHome(), isTogglable = false},

            },
            new ButtonInfo[] { // safe
                new ButtonInfo { buttonText = "Return to Main Menu", method =() => Global.ReturnHome(), isTogglable = false},

            },
            new ButtonInfo[] { // world
                new ButtonInfo { buttonText = "Return to Main Menu", method =() => Global.ReturnHome(), isTogglable = false},

            },
            new ButtonInfo[] { // proj
                new ButtonInfo { buttonText = "Return to Main Menu", method =() => Global.ReturnHome(), isTogglable = false},

            },
            new ButtonInfo[] { // opd
                new ButtonInfo { buttonText = "Return to Main Menu", method =() => Global.ReturnHome(), isTogglable = false},

            },


            new ButtonInfo[] { // ignore
                new ButtonInfo { buttonText = "Disconnect", method =() => PhotonNetwork.Disconnect(), isTogglable = false},
                new ButtonInfo { buttonText = "Gun1", method =() => Global.Gun1(), isTogglable = true},
                new ButtonInfo { buttonText = "Gun2", method =() => Global.Gun2(), isTogglable = true},

            },
        };
    }
}
