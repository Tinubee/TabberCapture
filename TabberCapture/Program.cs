﻿using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace TabberCapture
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Boolean createdNew = false;
            Mutex mtx = new Mutex(true, Global.GetGuid(), out createdNew);
            // 뮤텍스를 얻지 못하면 에러
            if (!createdNew)
            {
                //Utils.ErrorMsg("프로그램이 이미 실행중입니다.");
                Application.Exit();
                return;
            }

            #pragma warning disable
            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
            DevExpress.XtraEditors.WindowsFormsSettings.LoadApplicationSettings();
            DevExpress.XtraEditors.WindowsFormsSettings.FormThickBorder = false;
            //DevExpress.XtraEditors.WindowsFormsSettings.ForceDirectXPaint();
            DevExpress.Skins.SkinManager.EnableFormSkins();

            if (!String.IsNullOrEmpty(Properties.Settings.Default.SkinName))
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("The Bezier", Properties.Settings.Default.SvgPaletteName);//Properties.Settings.Default.SkinName
            DevExpress.LookAndFeel.UserLookAndFeel.Default.StyleChanged += Default_StyleChanged;
            //Debug.WriteLine($"{Properties.Settings.Default.SkinName}, {Properties.Settings.Default.SvgPaletteName}");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Global.MainForm = new MainForm();
            Application.Run(Global.MainForm);
        }

        private static void Default_StyleChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSvgPaletteName, DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName);
            Properties.Settings.Default.SkinName = DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName;
            Properties.Settings.Default.SvgPaletteName = DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSvgPaletteName;
            Properties.Settings.Default.Save();
        }
    }
}
