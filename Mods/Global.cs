using GunLib;
using UnityEngine.InputSystem;
using static StupidTemplate.Menu.Main;

namespace StupidTemplate.Mods
{
    internal class Global
    {
        public static void ReturnHome()
        {
            buttonsType = 0;
        }

        //how to use gunlib
        public static void Gun1()
        {
            //no need to hold any button because gun always shows on vr, hold rmb to show gun on pc
            GunTemplate.StartBothGuns(() =>
            {


            }, true);
        }

        public static void Gun2()
        {
            if (!ControllerInputPoller.instance.rightGrab && !Mouse.current.rightButton.isPressed) return; //requires rg or rmb to be pressed to show gun

            GunTemplate.StartBothGuns(() =>
            {

            }, true);
        }

    }
}
