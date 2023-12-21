using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TabberCapture.Schemas;

namespace TabberCapture
{
    public enum 동작구분
    {
        Live = 0,
        LocalTest = 2
    }
    public class Global
    {
        public static MainForm MainForm = null;
        public delegate void BaseEvent();
        public static event EventHandler<Boolean> Initialized;

        public static 그랩제어 그랩제어;
        public static 조명제어 조명제어;
        public static 모델자료 모델자료;
        public static 환경설정 환경설정;
        public static 신호제어 신호제어;

        public static class 장치상태
        {
            public static Boolean 정상여부 { get { return true; } }
            public static Boolean 카메라1 { get { return Global.그랩제어?.카메라1?.상태 ?? false; } }
            public static Boolean 카메라2 { get { return Global.그랩제어?.카메라2?.상태 ?? false; } }
            public static Boolean 카메라3 { get { return Global.그랩제어?.카메라3?.상태 ?? false; } }
            public static Boolean 카메라4 { get { return Global.그랩제어?.카메라4?.상태 ?? false; } }
            public static Boolean 카메라5 { get { return Global.그랩제어?.카메라5?.상태 ?? false; } }
        }
        public static Boolean Init()
        {
            Debug.WriteLine(GetGuid(), "Process GUID");
            try
            {
                그랩제어 = new 그랩제어();
                환경설정 = new 환경설정();
                모델자료 = new 모델자료();
                신호제어 = new 신호제어();

                그랩제어.Init();
                환경설정.Init();
                모델자료.Init();
                신호제어.Init();
                Initialized.Invoke(null, true);
                return true;
            }
            catch (Exception ex)
            {
                //Utils.DebugException(ex, 3);
                //Global.오류로그(로그영역, "초기화 오류", "시스템 초기화에 실패하였습니다.\n" + ex.Message, true);
            }
            Initialized.Invoke(null, false);
            return false;
        }

        public static void Start()
        {
            if (Global.환경설정.동작구분 != 동작구분.Live) return;

            신호제어.Start();
        }
        public static Boolean Close()
        {
            //Global.정보로그(로그영역, "종료", "시스템을 종료 합니다.", false);
            try
            {
                그랩제어?.Close();
                조명제어?.Close();
                환경설정?.Close();
                신호제어?.Close();
                Properties.Settings.Default.Save();
                Debug.WriteLine("시스템 종료");
                return true;
            }
            catch (Exception ex)
            {
                //return Utils.ErrorMsg("프로그램 종료 중 오류가 발생하였습니다.\n" + ex.Message);
                return false;
            }
        }

        public static void DxLocalization()
        {
            if (Localization.CurrentLanguage != Language.KO) return;
            MvUtils.Localization.CurrentLanguage = MvUtils.Localization.Language.KO;
            MvUtils.DxDataGridLocalizer.Enable();
            MvUtils.DxEditorsLocalizer.Enable();
            MvUtils.DxDataFilteringLocalizer.Enable();
            MvUtils.DxLayoutLocalizer.Enable();
            MvUtils.DxBarLocalizer.Enable();
        }
        public static String GetGuid()
        {
            Assembly assembly = typeof(Program).Assembly;
            GuidAttribute attribute = assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0] as GuidAttribute;
            return attribute.Value;
        }
    }
}
