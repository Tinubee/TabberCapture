using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabberCapture.Schemas
{
    public enum 모델구분
    {
        [ListBindable(false)]
        None,
        [DXDescription("Tabber Line 1"), Description("Tabber Line 1")]
        TabberLine1,
        [DXDescription("Tabber Line 2"), Description("Tabber Line 2")]
        TabberLine2,
        [DXDescription("Tabber Line 3"), Description("Tabber Line 3")]
        TabberLine3,
        [DXDescription("Tabber Line 4"), Description("Tabber Line 4")]
        TabberLine4,
        [DXDescription("Tabber Line 5"), Description("Tabber Line 5")]
        TabberLine5,
        [DXDescription("Tabber Line 6"), Description("Tabber Line 6")]
        TabberLine6,
        [DXDescription("Tabber Line 7"), Description("Tabber Line 7")]
        TabberLine7,
        [DXDescription("Tabber Line 8"), Description("Tabber Line 8")]
        TabberLine8,
    }
    public class 모델정보
    {
        [JsonProperty("type"), Translation("Model", "모델")]
        public 모델구분 모델구분 { get; set; } = 모델구분.None;
        [JsonIgnore]
        public Int32 모델번호 { get { return (Int32)this.모델구분; } }
        public 모델정보(모델구분 구분)
        {
            this.모델구분 = 구분;
        }
    }

    public class 모델자료 : BindingList<모델정보>
    {
        private String 저장파일 { get { return Path.Combine(Global.환경설정.기본경로, $"Models.json"); } }
        public 모델정보 선택모델 { get { return this.GetItem(Global.환경설정.선택모델); } }

        public void Init()
        {
            this.Load();
            this.BaseModel();
        }
        public void Close()
        {
            this.Save();
            //foreach (모델정보 모델 in this)
            //    모델.Close();
        }
        public void Save()
        {
            File.WriteAllText(저장파일, JsonConvert.SerializeObject(this, Formatting.Indented));
        }
        private void Load()
        {
            if (!File.Exists(저장파일))
            {
                //Global.정보로그(로그영역.GetString(), "자료로드", "저장파일이 없습니다.", false);
                return;
            }
            try
            {
                List<모델정보> 자료 = JsonConvert.DeserializeObject<List<모델정보>>(File.ReadAllText(저장파일));
                if (자료 == null) return;
                자료.Sort((a, b) => a.모델번호.CompareTo(b.모델번호));
                자료.ForEach(e => this.Add(e));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                //Global.오류로그(로그영역.GetString(), "자료로드", ex.Message, false);
            }

            if (this.GetItem(Global.환경설정.선택모델) == null)
                if (this.Count > 0) Global.환경설정.선택모델 = this[0].모델구분;
        }

        private void BaseModel()
        {
            foreach (모델구분 구분 in typeof(모델구분).GetEnumValues())
            {
                if (구분 == 모델구분.None) continue;
                모델정보 모델 = this.GetItem(구분);
                if (모델 == null) this.Add(new 모델정보(구분));
                //else 모델.모델설명 = 모델정보.GetModelDescription(구분);
            }
            if (this.선택모델 == null) Global.환경설정.선택모델 = 모델구분.None;
        }

        public 모델정보 GetItem(모델구분 모델코드)
        {
            return this.Where(e => e.모델구분 == 모델코드).FirstOrDefault();
        }
    }
}
