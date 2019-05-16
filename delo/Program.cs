using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.Threading;

namespace delo
{
    static class Program
    {
        private static bool InstanceExists()
        {
            bool createdNew;
            new Mutex(false, "OneInstanceApplication", out createdNew);
            return (!createdNew);
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (InstanceExists())
            {
                MessageBox.Show("Программа уже запущенна");
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("Stardust");
            Application.Run(new authentification());
            if (Globals.iii == 0)
            { Application.Run(new Main()); }
                 if (Globals.iii == 1)
             { Application.Run(new Main1()); }
                 if (Globals.iii == 2)
                 { Application.Run(new Main2()); }
            //
        }
    }
}