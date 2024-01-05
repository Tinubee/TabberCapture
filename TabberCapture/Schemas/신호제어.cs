using Automation.BDaq;
using OpenCvSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabberCapture.Schemas
{
    public class 신호제어
    {
        // 이벤트
        //public event Global.BaseEvent 동작상태알림;
        //public event Global.BaseEvent 검사시작알림;
        public event Global.BaseEvent 입출변경알림;

        #region IO 관련 변수 및 Propertys
        private 입력신호분석 입력자료 = new 입력신호분석();
        //private 출력신호분석 출력자료 = new 출력신호분석();

        public enum 입력번호
        {
            [Translation("Input 0")]
            입력0번 = 0,
            [Translation("Input 1")]
            입력1번 = 1,
            [Translation("Input 2")]
            입력2번 = 2,
            [Translation("Input 3")]
            입력3번 = 3,
            [Translation("Input 4")]
            입력4번 = 4,
            [Translation("Input 5")]
            입력5번 = 5,
            [Translation("Input 6")]
            입력6번 = 6,
            [Translation("Input 7")]
            입력7번 = 7,
            [Translation("Input 8")]
            입력8번 = 8,
            [Translation("Input 9")]
            입력9번 = 9,
            [Translation("Input 10")]
            입력10번 = 10,
            [Translation("Input 11")]
            입력11번 = 11,
            [Translation("Input 12")]
            입력12번 = 12,
            [Translation("Input 13")]
            입력13번 = 13,
            [Translation("Input 14")]
            입력14번 = 14,
            [Translation("Input 15")]
            입력15번 = 15,
        }
        #endregion

        public InstantDiCtrl 모듈정보;
        public int 디바이스번호 { get; set; } = 0;
        public int 포트번호 { get; set; } = 0;
        public byte 포트데이터;
        public Boolean 정상여부 = false;
        public Boolean 동작여부 = false;
        public Int32 실행주기 = 5;
        public Boolean Init()
        {
            this.모듈정보 = new InstantDiCtrl();
            this.모듈정보.SelectedDevice = new DeviceInformation(디바이스번호);

            Debug.WriteLine($"PLC Module : {this.모듈정보.Module}");
            this.정상여부 = 모듈정보.Initialized;

            if (!this.정상여부) return false;

            return true;
        }
        public void Start()
        {
            Debug.WriteLine($"PLC Start !!");
            this.동작여부 = true;
            Task.Run(입출신호분석);
        }
        public Boolean Close()
        {
            return true;
        }

        private async void 입출신호분석()
        {
            while (this.동작여부)
            {
                Boolean 변경 = this.입출상태갱신();
                if (변경) this.입출변경알림?.Invoke();
                await Task.Delay(this.실행주기);
            }
            //Debug.WriteLine("IO 프로세스가 종료되었습니다.");
        }
        public Boolean 입력상태(입력번호 번호)
        {
            Boolean 상태 = this.입력자료.Get(번호);
            //if (번호 == 입력번호.제품감지1 || 번호 == 입력번호.제품감지2 || 번호 == 입력번호.제품감지3 || 번호 == 입력번호.제품감지4) return !상태;
            return 상태;
        }
        private Boolean 입출상태갱신()
        {
            Automation.BDaq.ErrorCode err = Automation.BDaq.ErrorCode.Success;

            err = this.모듈정보.Read(this.포트번호, out this.포트데이터);
            if (err != Automation.BDaq.ErrorCode.Success) { return false; }

            BitArray 입력 = new BitArray(this.포트데이터);

            Dictionary<입력번호, Boolean> 입력변경 = this.입력자료.Set(입력);

            Boolean 변경 = 입력변경.Count > 0;
            Debug.WriteLine($"입출상태 갱신 : {this.포트데이터} - {변경}");
            return 변경;
        }

        private class 신호정보
        {
            public Boolean 이전 { get; set; } = false;
            public Boolean 현재 { get; set; } = false;
            public Boolean 변경 { get { return 이전 != 현재; } }

            public Boolean Set(Boolean 상태)
            {
                이전 = 현재;
                현재 = 상태;
                return 변경;
            }
        }

        private class 입력신호분석 : Dictionary<입력번호, 신호정보>
        {
            public 입력신호분석()
            {
                foreach (입력번호 번호 in Enum.GetValues(typeof(입력번호)))
                    this.Add(번호, new 신호정보());
            }

            public Dictionary<입력번호, Boolean> Set(BitArray 입력)
            {
                Dictionary<입력번호, Boolean> 변경 = new Dictionary<입력번호, Boolean>();
                foreach (var 정보 in this)
                {
                    Int32 번호 = (int)정보.Key;
                    Boolean 상태 = 입력[번호];
                    if (정보.Value.Set(상태))
                        변경.Add(정보.Key, 상태);
                }
                return 변경;
            }

            public Boolean Get(입력번호 번호)
            {
                if (this.ContainsKey(번호)) return this[번호].현재;
                return false;
            }
        }
    }
}
