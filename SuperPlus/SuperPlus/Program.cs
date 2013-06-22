using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace SuperPlus
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

<<<<<<< HEAD
            //Application.Run(new xLogin());// login
            Application.Run(new SuperMain()); //this for main superplus
=======
            Application.Run(new xLogin());// login
            //Application.Run(new SuperMain()); //this for main superplus
>>>>>>> 36922ce6cc82a0c772f05d00b7dab770bdba8ace
        }
    }
}