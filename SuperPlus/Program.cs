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

            //Application.Run(new xLogin());// login
            //Application.Run(new SuperMain()); //this for main superplus
            //Application.Run(new Login());// login
            Application.Run(new DBConfig()); //test db coonfig form
            //Application.Run(new SuperMain()); //this for main superplus
        }
    }
}