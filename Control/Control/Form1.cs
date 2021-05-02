using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace Control {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        // 網外 59.124.226.9:6592
        // 網內 192.168.101.234:50100
        private string ip = "192.168.101.234";
        private string port = "50100";
        private string AGV_Name = "";
        private string AGV_Code = "";
        private float AGV_R = 0;
        private char AGV_Y = ' ';
        private bool AGV_isCharging = false;
        private bool AGV_isLiftUp = false;
        private string[] CARS = new string[] { "ITRI_3-1", "ITRI_3-2", "ITRI_3-3" };
        private string[] CARS_Code = new string[3];
        private Point[] CARS_P = new Point[3];
        public class Point
        {
            public int col { get; set; }
            public int row { get; set; }
        }
        private Point AGV_Point = new Point();
        private Point p (int c, int r)
        {
            Point x = new Point();
            x.col = c;
            x.row = r;
            return x;
        }
        // 地圖點
        public class Dot
        {
            public string code { get; set; }
            public bool isClear { get; set; }
            public bool isCar { get; set; }
        }
        // 地圖
        private Dot[,] map = new Dot[7, 7];
        // 障礙物
        private string[] obstacle = new string[] {
            "000000", "010000", "020000",
            "030000", "040000", "050000",
            "060000", "010010", "020010",
            "030010", "000040", "000050",
            "000060", "050060", "060060"};
        private List<string> shelves = new List<string>
        {
            "060010", "050010", "050030", "040030"
        };
        private string lift;
        // 充電站
        private string charger = "060050";
        public class Position {
            public float x { get; set; }
            public float y { get; set; }
            public float a { get; set; }
        } // 位址
        public class RunPara {
            public float speed { get; set; }
            public float acceleration { get; set; } // 加速度
            public float deceleration { get; set; } // 減速度
            public float jerk { get; set; }
        } // 移動數據
        public class Attitude
        {
            public float x { get; set; }
            public float y { get; set; }
            public float yaw { get; set; } // 偏角
            public string code { get; set; }
        } // 姿勢
        public class Shelves
        {
            public float x { get; set; }
            public float y { get; set; }
            public float yaw { get; set; } // 偏角
            public string code { get; set; }
        } // 層架
        public class Status
        {
            public string state { get; set; }
            public bool isJogSearch { get; set; }
            public bool isLiftUp { get; set; } // 舉起
            public bool isMoving { get; set; }
            public bool isAxisReady { get; set; } // 軸
            public bool isTurnAxisReady { get; set; }
            public bool isLiftAxisReady { get; set; }
            public bool isAxisMoving { get; set; }
            public bool isTurnAxisMoving { get; set; }
            public bool isScriptCmd { get; set; }
            public bool isLiftAxisMoving { get; set; }
            public bool isAxisCoupling { get; set; } // 連接
            public bool isTurnAxisCoupling { get; set; }
            public bool isAxis3Coupling { get; set; }
            public bool isServoON { get; set; }
            public bool isReady { get; set; }
            public bool isError { get; set; }
            public bool isLaserStop { get; set; }
            public bool isChargeing { get; set; }
            public bool isLaserEnable { get; set; }
            public bool isEmergencyStop { get; set; }
            public bool isVirAxisReady { get; set; }
            public bool isLeftAxisReady { get; set; }
            public bool isRightAxisReady { get; set; }
            public bool isLeftMotorGearIN { get; set; }
            public bool isRightMotorGearIN { get; set; }
            public bool isScriptStart { get; set; }
            public bool isScriptFinish { get; set; }
            public bool isScriptPause { get; set; }
            public bool isScriptStop { get; set; }
            public bool isUpdatePos { get; set; }
        } //狀態
        public class AGV_LogIndex
        {
            public bool isProgress { get; set; }
            public int scriptIdx { get; set; }
            public int runIdx { get; set; }
            public int errorIdx { get; set; }
        }
        public class AGV_Script
        {
            public int type { get; set; }
            public int parameter { get; set; }
            public int code { get; set; }
        }
        public class AGV {
            public Position pos { get; set; }
            public RunPara runPara { get; set; }
            public Attitude attitude { get; set; }
            public Shelves shelves { get; set; }
            public Status status { get; set; }
            public string battery { get; set; }
            public AGV_LogIndex agvLogIndex { get; set; }
            public AGV_Script[] agvScript { get; set; }
        }
        public class Result
        {
            public int statusCode { get; set; }
            public AGV config { get; set; }
        }
        // 初始化(AGV List, Map)
        private void Form1_Load(object sender, EventArgs e) {
            listbox_AGV.Items.Add("ITRI_3-1");
            listbox_AGV.Items.Add("ITRI_3-2");
            listbox_AGV.Items.Add("ITRI_3-3");
            ShelvesReload();
            MapReload();
            Log("［" + ip + "：" + port + "］", 0);
            ScriptSelectorReload();
            ScriptReload();
        }
        // 層架更新
        private void ShelvesReload()
        {
            listbox_shelves.Items.Clear();
            foreach (string s in shelves)
            {
                listbox_shelves.Items.Add(s);
            }
            listbox_shelves.ClearSelected();
        } 

    // 選擇AGV
    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listbox_AGV.SelectedItem == null)
            {
                listbox_AGVinfo.Items.Clear();
                AGV_Name = "";
                AGV_Code = "";
                AGV_R = 0;
            }
            else
            {
                AGV_Name = listbox_AGV.SelectedItem.ToString();
                isInfoUpdate = true;
            }
            isMapUpdate = true;
        }
        // 傳送指令(AGV_Name, CMD, 參數)
        private Result SendCmd(string name, string cmd, int[] param)
        {
            string json = "";
            try
            {
                // 設定連線位址
                string url = "http://" + ip + ":" + port + "/AGV/SendAgvCmd";
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                // 資料型態與存取方法
                req.ContentType = "application/json";
                req.Method = "POST";
                /* 設定命令
                   { "Name": "AGV名稱",
                     "Cmd": "命令代碼",
                     "Param": [參數1, ...]
                   }    */
                JObject sendCmd = new JObject();
                sendCmd.Add(new JProperty("Name", name));
                sendCmd.Add(new JProperty("Cmd", cmd));
                sendCmd.Add(new JProperty("Param", param));
                // 命令轉成byteArray
                byte[] byteArray = Encoding.UTF8.GetBytes(sendCmd.ToString());
                // 發送請求
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(byteArray, 0, byteArray.Length);
                }// end using
                // 接收回傳值
                string resStr = "";
                using (WebResponse response = req.GetResponse())
                {
                    using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                    {
                        resStr = sr.ReadToEnd();
                    }// end using
                }// end using
                json = resStr;
            }
            catch
            {
                json = "{statusCode:100, config: null}";
            }
            // 反序列化
            Result res = JsonConvert.DeserializeObject<Result>(json);
            return res;
        }
        // 指令狀態
        private bool Log(string descript, int statusCode)
        {
            bool result = false;
            string msg = DateTime.Now.ToString("HH：mm（ss）") + "　" + descript + "：　";
            switch (statusCode){
                case 0:
                    msg += "正常";
                    result = true;
                    break;
                case 100:
                    msg += $"{statusCode}　API 連線錯誤";
                    break;
                case 900:
                    msg += $"{statusCode}　AGV 忙碌中";
                    break;
                case 902:
                    msg += $"{statusCode}　AGV 名稱不存在";
                    break;
                case 905:
                case 906:
                case 907:
                case 908:
                    msg += $"{statusCode}　AGV 連線異常";
                    break;
                case 909:
                    msg += $"{statusCode}　AGV 無效參數";
                    break;
                case 910:
                    msg += $"{statusCode}　JSON 格式錯誤";
                    break;
                case 911:
                    msg += $"{statusCode}　AGV 命令代碼";
                    break;
                case 912:
                    msg += $"{statusCode}　AGV 參數錯誤";
                    break;
                case 921:
                    msg += $"{statusCode}　Web　Service 異常";
                    break;
                case 10:
                    msg += $"{statusCode}　無法執行";
                    break;
                default:
                    msg += $"{statusCode}　例外錯誤";
                    break;
            }
            listbox_Log.Items.Add(msg);
            listbox_Log.SetSelected(listbox_Log.Items.Count - 1, true);
            
            return result;
        }
        // 取得AGV資訊
        private void AGV_Info() {
            listbox_AGVinfo.Items.Clear();
            for (int i = 0; i < 3; i++)
            {
                Result info = SendCmd(CARS[i], "500", new int[] { });
                if(info.config != null)
                {
                    CARS_Code[i] = info.config.attitude.code;
                    if (AGV_Name.Equals(CARS[i]))
                    {
                        if(Log("Get　" + AGV_Name + "　Info", info.statusCode))
                        {
                            AGV agv = info.config;
                            listbox_AGVinfo.Items.Add("Position：");
                            listbox_AGVinfo.Items.Add("\tX：" + agv.pos.x.ToString());
                            listbox_AGVinfo.Items.Add("\tY：" + agv.pos.y.ToString());
                            listbox_AGVinfo.Items.Add("\tA：" + agv.pos.a.ToString());
                            listbox_AGVinfo.Items.Add("RunPara：");
                            listbox_AGVinfo.Items.Add("\tSpeed：" + agv.runPara.speed.ToString());
                            listbox_AGVinfo.Items.Add("\tAcceleration：" + agv.runPara.acceleration.ToString());
                            listbox_AGVinfo.Items.Add("\tDeceleration：" + agv.runPara.deceleration.ToString());
                            listbox_AGVinfo.Items.Add("\tJerk：" + agv.runPara.jerk.ToString());
                            listbox_AGVinfo.Items.Add("Attitude：");
                            AGV_Code = agv.attitude.code;
                            AGV_R = agv.attitude.yaw;
                            AGV_Y = Yaw2Str(AGV_R);
                            listbox_AGVinfo.Items.Add("\tX：" + agv.attitude.x);
                            listbox_AGVinfo.Items.Add("\tY：" + agv.attitude.y);
                            listbox_AGVinfo.Items.Add("\tYaw：" + AGV_R);
                            listbox_AGVinfo.Items.Add("\tCode：" + AGV_Code);
                            listbox_AGVinfo.Items.Add("Shelves：");
                            listbox_AGVinfo.Items.Add("\tX：" + agv.shelves.x.ToString());
                            listbox_AGVinfo.Items.Add("\tY：" + agv.shelves.y.ToString());
                            listbox_AGVinfo.Items.Add("\tYaw：" + agv.shelves.yaw.ToString());
                            listbox_AGVinfo.Items.Add("\tCode：" + agv.shelves.code);
                            listbox_AGVinfo.Items.Add("Status：");
                            listbox_AGVinfo.Items.Add("\tState：" + agv.status.state);
                            listbox_AGVinfo.Items.Add("\tIsJogSearch：" + agv.status.isJogSearch.ToString());
                            AGV_isLiftUp = agv.status.isLiftUp;
                            listbox_AGVinfo.Items.Add("\tIsLiftUp：" + agv.status.isLiftUp.ToString());
                            listbox_AGVinfo.Items.Add("\tisMoving：" + agv.status.isMoving.ToString());
                            listbox_AGVinfo.Items.Add("\tIsAxisReady：" + agv.status.isAxisReady.ToString());
                            listbox_AGVinfo.Items.Add("\tIsTurnAxisReady：" + agv.status.isTurnAxisReady.ToString());
                            listbox_AGVinfo.Items.Add("\tIsLiftAxisReady：" + agv.status.isLiftAxisReady.ToString());
                            listbox_AGVinfo.Items.Add("\tIsAxisMoving：" + agv.status.isAxisMoving.ToString());
                            listbox_AGVinfo.Items.Add("\tIsTurnAxisMoving：" + agv.status.isTurnAxisMoving.ToString());
                            listbox_AGVinfo.Items.Add("\tIsScriptCmd：" + agv.status.isScriptCmd.ToString());
                            listbox_AGVinfo.Items.Add("\tIsLiftAxisMoving：" + agv.status.isLiftAxisMoving.ToString());
                            listbox_AGVinfo.Items.Add("\tIsAxisCoupling：" + agv.status.isAxisCoupling.ToString());
                            listbox_AGVinfo.Items.Add("\tIsTurnAxisCoupling：" + agv.status.isTurnAxisCoupling.ToString());
                            listbox_AGVinfo.Items.Add("\tIsAxis3Coupling：" + agv.status.isAxis3Coupling.ToString());
                            listbox_AGVinfo.Items.Add("\tIsServoON：" + agv.status.isServoON.ToString());
                            listbox_AGVinfo.Items.Add("\tIsReady：" + agv.status.isReady.ToString());
                            listbox_AGVinfo.Items.Add("\tIsError：" + agv.status.isError.ToString());
                            listbox_AGVinfo.Items.Add("\tIsLaserStop：" + agv.status.isLaserStop.ToString());
                            AGV_isCharging = agv.status.isChargeing;
                            listbox_AGVinfo.Items.Add("\tIsChargeing：" + AGV_isCharging.ToString());
                            listbox_AGVinfo.Items.Add("\tIsLaserEnable：" + agv.status.isLaserEnable.ToString());
                            listbox_AGVinfo.Items.Add("\tIsEmergencyStop：" + agv.status.isEmergencyStop.ToString());
                            listbox_AGVinfo.Items.Add("\tIsVirAxisReady：" + agv.status.isVirAxisReady.ToString());
                            listbox_AGVinfo.Items.Add("\tIsLeftAxisReady：" + agv.status.isLeftAxisReady.ToString());
                            listbox_AGVinfo.Items.Add("\tIsRightAxisReady：" + agv.status.isRightAxisReady.ToString());
                            listbox_AGVinfo.Items.Add("\tIsLeftMotorGearIN：" + agv.status.isLeftMotorGearIN.ToString());
                            listbox_AGVinfo.Items.Add("\tIsRightMotorGearIN：" + agv.status.isRightMotorGearIN.ToString());
                            listbox_AGVinfo.Items.Add("\tIsScriptStart：" + agv.status.isScriptStart.ToString());
                            listbox_AGVinfo.Items.Add("\tIsScriptFinish：" + agv.status.isScriptFinish.ToString());
                            listbox_AGVinfo.Items.Add("\tIsScriptPause：" + agv.status.isScriptPause.ToString());
                            listbox_AGVinfo.Items.Add("\tIsScriptStop：" + agv.status.isScriptStop.ToString());
                            listbox_AGVinfo.Items.Add("\tIsUpdatePos：" + agv.status.isUpdatePos.ToString());
                            listbox_AGVinfo.Items.Add("Battery：" + agv.battery);
                            listbox_AGVinfo.Items.Add("AGV_LogIndex：");
                            listbox_AGVinfo.Items.Add("\tIsProgress：" + agv.agvLogIndex.isProgress.ToString());
                            listbox_AGVinfo.Items.Add("\tScriptIdx：" + agv.agvLogIndex.scriptIdx.ToString());
                            listbox_AGVinfo.Items.Add("\tRunIdx：" + agv.agvLogIndex.runIdx.ToString());
                            listbox_AGVinfo.Items.Add("\tErrorIdx：" + agv.agvLogIndex.errorIdx.ToString());
                            listbox_AGVinfo.Items.Add("AgvScript：");
                            foreach (AGV_Script script in agv.agvScript)
                            {
                                listbox_AGVinfo.Items.Add("\tType：" + script.type.ToString());
                                listbox_AGVinfo.Items.Add("\tParameter：" + script.parameter.ToString());
                                listbox_AGVinfo.Items.Add("\tCode：" + script.code.ToString());
                            }
                        }
                    }
                }
                
            }
        }
        // 重載地圖
        private void MapReload()
        {
            DGV_map.Columns.Clear();
            for (int i = 0; i < 7; i++)
                DGV_map.Columns.Add(i.ToString(), i.ToString());
            for (int i = 0; i < 7; i++)
                DGV_map.Rows.Add();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {   
                    // 更改陣列數值
                    map[i, j] = new Dot();
                    Dot d = map[i, j];
                    d.code = $"0{j}00{i}0";
                    d.isClear = Array.IndexOf(obstacle, d.code) == -1;
                    d.isCar = Array.IndexOf(CARS_Code, d.code) > -1;
                        
                    // 畫地圖
                    DGV_map[i, j].Value = d.code.Substring(0, 3) + "　"+ d.code.Substring(3) + "\n\n";
                    if (!(d.isClear))
                    {
                        DGV_map[i, j].Style.BackColor = Color.Gray;
                        DGV_map[i, j].Style.ForeColor = Color.White;
                    }
                    else if(d.isCar){
                        d.isClear = false;
                        CARS_P[Array.IndexOf(CARS_Code, d.code)] = p(i, j);
                        if (d.code.Equals(AGV_Code))
                        {
                            AGV_Point = p(i, j);
                            DGV_map[i, j].Value += AGV_Name + "\n\n" + AGV_Y;
                            DGV_map[i, j].Style.BackColor = Color.DarkOrange;
                            DGV_map[i, j].Style.ForeColor = Color.White;
                            DGV_map[i, j].Style.Font = new Font("新細明體", 9, FontStyle.Bold);
                        }
                        else
                        {
                            DGV_map[i, j].Value += CARS[Array.IndexOf(CARS_Code, d.code)];
                            DGV_map[i, j].Style.BackColor = Color.DarkSalmon;
                            DGV_map[i, j].Style.ForeColor = Color.White;
                            DGV_map[i, j].Style.Font = new Font("新細明體", 9, FontStyle.Bold);
                        }
                    }
                    // 充電站
                    if (d.code == charger)
                    {
                        d.isClear = true;
                        DGV_map[i, j].Style.BackColor = Color.LightGreen;
                        DGV_map[i, j].Style.ForeColor = Color.HotPink;
                        DGV_map[i, j].Style.Font = new Font("新細明體", 9, FontStyle.Bold);
                        if (AGV_isCharging)
                        {
                            d.isClear = false;
                            DGV_map[i, j].Style.BackColor = Color.YellowGreen;
                            DGV_map[i, j].Style.ForeColor = Color.White;
                        }
                    }
                    // 貨架
                    if (shelves.IndexOf(d.code) > -1)
                    {
                        DGV_map[i, j].Style.BackColor = Color.MediumPurple;
                        DGV_map[i, j].Style.ForeColor = Color.White;
                        if (AGV_isLiftUp && d.code.Equals(AGV_Code))
                        {
                            DGV_map[i, j].Style.BackColor = Color.Purple;
                            lift = d.code;
                        }
                    }
                    // 貨架移動
                    if (AGV_isLiftUp && lift != AGV_Code)
                    {
                        shelves.Remove(lift);
                        shelves.Add(AGV_Code);
                        lift = AGV_Code;
                        ShelvesReload();
                    }
                    else
                    {
                        lift = "";
                    }

                }
            }
            DGV_map.ClearSelection();
        }
        private char Yaw2Str(float r)
        {
            // ±5↑ ↓ ← →
            if ((0 <= r && r <= 5) || (355 <= r && r < 360))
                return '↑';
            else if (85 <= r && r <= 95)
                return '→';
            else if (175 <= r && r <= 185)
                return '↓';
            else if (265 <= r && r <= 275)
                return '←';
            return ' ';
        }
        //更改WebAPI URL
        private void WebAPI_Click(object sender, EventArgs e)
        {
            Urlbox url = new Urlbox();
            url.ShowDialog();
            if (url.DialogResult == DialogResult.OK)
            {
                ip = url.getIP();
                port = url.getPort();
            }
            MessageBox.Show(ip + " : " + port, "IP/Port");
            Log("［" + ip + "：" + port + "］", 0);
            listbox_AGV.ClearSelected();
        }
        // 鎖定馬達
        private void ServoOn()
        {
            Result cmd = SendCmd(AGV_Name, "30100", new int[] { });
            Log("Servo On", cmd.statusCode);
        }
        private void btn_ServoOn_Click(object sender, EventArgs e)
        {
            ServoOn();
        }
        // 解鎖馬達
        private void ServoOff()
        {
            Result cmd = SendCmd(AGV_Name, "30101", new int[] { });
            Log("Servo Off", cmd.statusCode);
        }
        private void btn_ServoOff_Click(object sender, EventArgs e)
        {
            ServoOff();
        }
        // 右轉90
        private void R90()
        {
            Result cmd = SendCmd(AGV_Name, "30108", new int[] { });
            Log("R(90)", cmd.statusCode);
            isMapUpdate = true;
        }
        private void btn_right90_Click(object sender, EventArgs e)
        {
            R90();
        }
        // 右轉180
        private void R180()
        {
            Result cmd = SendCmd(AGV_Name, "30109", new int[] { });
            Log("R(180)", cmd.statusCode);
            isMapUpdate = true;
        }
        private void btn_right180_Click(object sender, EventArgs e)
        {
            R180();
        }
        // 左轉90
        private void L90()
        {
            Result cmd = SendCmd(AGV_Name, "30110", new int[] { });
            Log("L(90)", cmd.statusCode);
            isMapUpdate = true;
        }
        private void btn_left90_Click(object sender, EventArgs e)
        {
            L90();
        }
        // 左轉180
        private void L180()
        {
            Result cmd = SendCmd(AGV_Name, "30111", new int[] { });
            Log("L(180)", cmd.statusCode);
            isMapUpdate = true;
        }
        private void btn_left180_Click(object sender, EventArgs e)
        {
            L180();
        }
        // 右轉90(轉盤不動)
        private void R90s()
        {
            Result cmd = SendCmd(AGV_Name, "30208", new int[] { });
            Log("R(90), Fixed　Table", cmd.statusCode);
            isMapUpdate = true;
        }
        private void btn_right90s_Click(object sender, EventArgs e)
        {
            R90s();
        }
        // 右轉180(轉盤不動)
        private void R180s()
        {
            Result cmd = SendCmd(AGV_Name, "30209", new int[] { });
            Log("R(180), Fixed　Table", cmd.statusCode);
            isMapUpdate = true;
        }
        private void btn_right180s_Click(object sender, EventArgs e)
        {
            R180s();
        }
        // 左轉90(轉盤不動)
        private void L90s()
        {
            Result cmd = SendCmd(AGV_Name, "30210", new int[] { });
            Log("L(90), Fixed　Table", cmd.statusCode);
            isMapUpdate = true;
        }
        private void btn_left90s_Click(object sender, EventArgs e)
        {
            L90s();
        }
        // 左轉180(轉盤不動)
        private void L180s()
        {
            Result cmd = SendCmd(AGV_Name, "30211", new int[] { });
            Log("L(180), Fixed　Table", cmd.statusCode);
            isMapUpdate = true;
        }
        private void btn_left180s_Click(object sender, EventArgs e)
        {
            L180s();
        }
        // 直走
        private void Go(int distance)
        {
            Result cmd = SendCmd(AGV_Name, "30112", new int[] { 1000 * distance});
            Log($"Go　Straight　{distance}", cmd.statusCode);
            isMapUpdate = true;
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            Go(1);
        }
        // 進入充電站
        private void GotoCharger(int x)
        {
            if (AGV_Code.Equals(charger))
            {
                Result cmd = new Result();
                switch (x)
                {
                    case 1:
                        cmd = SendCmd(AGV_Name, "30230", new int[] { 700 });
                        break;
                    case 2:
                        cmd = SendCmd(AGV_Name, "30230", new int[] { 550 });
                        break;
                }
                Log("Go　Charging", cmd.statusCode);
                isMapUpdate = true;
            }
            else
            {
                Log("Go　Charging", 10);
            }
        }
        private void btn_gotoCharger_Click(object sender, EventArgs e)
        {
            GotoCharger(1);
        }
        private void btn_gotoCharger2_Click(object sender, EventArgs e)
        {
            GotoCharger(2);
        }
        // 離開充電站
        private void LeaveCharger(int x)
        {
            if (AGV_isCharging)
            {

                Result cmd = new Result();
                switch (x)
                {
                    case 1:
                        cmd = SendCmd(AGV_Name, "30231", new int[] { 700 });
                        break;
                    case 2:
                        cmd = SendCmd(AGV_Name, "30231", new int[] { 550 });
                        break;
                }
                Log("Leave　Charger", cmd.statusCode);
                isMapUpdate = true;
            }
            else
            {
                Log("Leave　Charger", 10);
            }
        }
        private void btn_leaveCharger_Click(object sender, EventArgs e)
        {
            LeaveCharger(1);
        }
        private void btn_leaveCharger2_Click(object sender, EventArgs e)
        {
            LeaveCharger(2);
        }
        // 緊急停止
        private void STOP()
        {
            Result cmd = SendCmd(AGV_Name, "30310", new int[] { });
            Log("Emergency　Brake", cmd.statusCode);
        }
        private void btn_STOP_Click(object sender, EventArgs e)
        {
            STOP();
        }
        // 圓盤上升
        private void s_up()
        {
            if (AGV_isLiftUp)
            {
                Log("Lift　Up", 10);
            }
            else
            {
                Result cmd = SendCmd(AGV_Name, "30218", new int[] { });
                Log("Lift　Up", cmd.statusCode);
            }
        }
        private void btn_up_Click(object sender, EventArgs e)
        {
            s_up();
        }
        // 圓盤下降
        private void s_down()
        {
            if(!(AGV_isLiftUp))
            {
                Log("Lift　Down", 10);
            }
            else
            {
                Result cmd = SendCmd(AGV_Name, "30219", new int[] { });
                Log("Lower　Down", cmd.statusCode);
            }
            
        }
        private void btn_down_Click(object sender, EventArgs e)
        {
            s_down();
        }
        // 轉盤左轉90
        private void s_L90()
        {
            Result cmd = SendCmd(AGV_Name, "30216", new int[] { });
            Log("Table　L(90)", cmd.statusCode);
        }
        private void btn_sL90_Click(object sender, EventArgs e)
        {
            s_L90();
        }
        // 轉盤左轉180
        private void s_L180()
        {
            Result cmd = SendCmd(AGV_Name, "30217", new int[] { });
            Log("Table　L(180)", cmd.statusCode);
        }
        private void btn_sL180_Click(object sender, EventArgs e)
        {
            s_L180();
        }
        // 轉盤右轉90
        private void s_R90()
        {
            Result cmd = SendCmd(AGV_Name, "30214", new int[] { });
            Log("Table　R(90)", cmd.statusCode);
        }
        private void btn_sR90_Click(object sender, EventArgs e)
        {
            s_R90();
        }
        // 轉盤右轉180
        private void s_R180()
        {
            Result cmd = SendCmd(AGV_Name, "30215", new int[] { });
            Log("Table　R(180)", cmd.statusCode);
        }
        private void btn_sR180_Click(object sender, EventArgs e)
        {
            s_R180();
        }
        // 路線規劃圖
        char[,] r = new char[7, 7];
        int cnt = 0;
        bool isArrived = false;
        List<Point> route = new List<Point> { };
        // 走訪地圖
        private void Visit(Point start, Point end)
        {
            DGV_map[start.col, start.row].Style.BackColor = Color.LightBlue;
            cnt++;
            if (start.col == end.col && start.row == end.row)
            {
                DGV_map[start.col, start.row].Style.BackColor = Color.Blue;
                DGV_map[start.col, start.row].Style.ForeColor = Color.White;
                r[start.row, start.col] = '*';
                route.Add(p(start.col, start.row));
                isArrived = true;
            }
            else {
                r[start.row, start.col] = '+';
                route.Add( p(start.col, start.row) );
                /*
                switch (d)
                {
                    case 1:
                        // 右
                        if ((start.col + 1 < 7) && r[start.row, start.col + 1] == ' ' && !(isArrived))
                            Visit(p(start.col + 1, start.row), end, d);
                        // 下
                        if ((start.row + 1 < 7) && r[start.row + 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row + 1), end, d);
                        // 左
                        if ((start.col - 1 >= 0) && r[start.row, start.col - 1] == ' ' && !(isArrived))
                            Visit(p(start.col - 1, start.row), end, d);
                        // 上
                        if ((start.row - 1 >= 0) && r[start.row - 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row - 1), end, d);
                        break;
                    case 2:
                        // 下
                        if ((start.row + 1 < 7) && r[start.row + 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row + 1), end, d);
                        // 右
                        if ((start.col + 1 < 7) && r[start.row, start.col + 1] == ' ' && !(isArrived))
                            Visit(p(start.col + 1, start.row), end, d);
                        // 上
                        if ((start.row - 1 >= 0) && r[start.row - 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row - 1), end, d);
                        // 左
                        if ((start.col - 1 >= 0) && r[start.row, start.col - 1] == ' ' && !(isArrived))
                            Visit(p(start.col - 1, start.row), end, d);
                        break;
                    case 3:
                        // 右
                        if ((start.col + 1 < 7) && r[start.row, start.col + 1] == ' ' && !(isArrived))
                            Visit(p(start.col + 1, start.row), end, d);
                        // 上
                        if ((start.row - 1 >= 0) && r[start.row - 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row - 1), end, d);
                        // 左
                        if ((start.col - 1 >= 0) && r[start.row, start.col - 1] == ' ' && !(isArrived))
                            Visit(p(start.col - 1, start.row), end, d);
                        // 下
                        if ((start.row + 1 < 7) && r[start.row + 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row + 1), end, d);
                        break;
                    case 4:
                        // 上
                        if ((start.row - 1 >= 0) && r[start.row - 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row - 1), end, d);
                        // 右
                        if ((start.col + 1 < 7) && r[start.row, start.col + 1] == ' ' && !(isArrived))
                            Visit(p(start.col + 1, start.row), end, d);
                        // 下
                        if ((start.row + 1 < 7) && r[start.row + 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row + 1), end, d);
                        // 左
                        if ((start.col - 1 >= 0) && r[start.row, start.col - 1] == ' ' && !(isArrived))
                            Visit(p(start.col - 1, start.row), end, d);
                        break;
                    case 5:
                        // 左
                        if ((start.col - 1 >= 0) && r[start.row, start.col - 1] == ' ' && !(isArrived))
                            Visit(p(start.col - 1, start.row), end, d);
                        // 上
                        if ((start.row - 1 >= 0) && r[start.row - 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row - 1), end, d);
                        // 右
                        if ((start.col + 1 < 7) && r[start.row, start.col + 1] == ' ' && !(isArrived))
                            Visit(p(start.col + 1, start.row), end, d);
                        // 下
                        if ((start.row + 1 < 7) && r[start.row + 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row + 1), end, d);
                        break;
                    case 6:
                        // 上
                        if ((start.row - 1 >= 0) && r[start.row - 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row - 1), end, d);
                        // 左
                        if ((start.col - 1 >= 0) && r[start.row, start.col - 1] == ' ' && !(isArrived))
                            Visit(p(start.col - 1, start.row), end, d);
                        // 下
                        if ((start.row + 1 < 7) && r[start.row + 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row + 1), end, d);
                        // 右
                        if ((start.col + 1 < 7) && r[start.row, start.col + 1] == ' ' && !(isArrived))
                            Visit(p(start.col + 1, start.row), end, d);
                        break;
                    case 7:
                        // 左
                        if ((start.col - 1 >= 0) && r[start.row, start.col - 1] == ' ' && !(isArrived))
                            Visit(p(start.col - 1, start.row), end, d);
                        // 下
                        if ((start.row + 1 < 7) && r[start.row + 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row + 1), end, d);
                        // 右
                        if ((start.col + 1 < 7) && r[start.row, start.col + 1] == ' ' && !(isArrived))
                            Visit(p(start.col + 1, start.row), end, d);
                        // 上
                        if ((start.row - 1 >= 0) && r[start.row - 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row - 1), end, d);
                        break;
                    case 8:
                        // 下
                        if ((start.row + 1 < 7) && r[start.row + 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row + 1), end, d);
                        // 左
                        if ((start.col - 1 >= 0) && r[start.row, start.col - 1] == ' ' && !(isArrived))
                            Visit(p(start.col - 1, start.row), end, d);
                        // 上
                        if ((start.row - 1 >= 0) && r[start.row - 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row - 1), end, d);
                        // 右
                        if ((start.col + 1 < 7) && r[start.row, start.col + 1] == ' ' && !(isArrived))
                            Visit(p(start.col + 1, start.row), end, d);
                        break;
                }
                */
                
                int c_d = end.col - start.col;
                int r_d = end.row - start.row;
                // 往右下方(下)
                if (c_d >= 0 && r_d > 0)
                {
                    // 先右
                    if (c_d > r_d)
                    {
                        // 右
                        if ((start.col + 1 < 7) && r[start.row, start.col + 1] == ' ' && !(isArrived))
                            Visit(p(start.col + 1, start.row), end);
                        // 下
                        if ((start.row + 1 < 7) && r[start.row + 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row + 1), end);
                        // 左
                        if ((start.col - 1 >= 0) && r[start.row, start.col - 1] == ' ' && !(isArrived))
                            Visit(p(start.col - 1, start.row), end);
                        // 上
                        if ((start.row - 1 >= 0) && r[start.row - 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row - 1), end);
                    }
                    // 先下
                    else
                    {
                        // 下
                        if ((start.row + 1 < 7) && r[start.row + 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row + 1), end);
                        // 右
                        if ((start.col + 1 < 7) && r[start.row, start.col + 1] == ' ' && !(isArrived))
                            Visit(p(start.col + 1, start.row), end);
                        // 上
                        if ((start.row - 1 >= 0) && r[start.row - 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row - 1), end);
                        // 左
                        if ((start.col - 1 >= 0) && r[start.row, start.col - 1] == ' ' && !(isArrived))
                            Visit(p(start.col - 1, start.row), end);
                    }
                }
                // 往右上方(右)
                else if (c_d > 0 && r_d <= 0)
                {
                    // 先右
                    if (c_d > Math.Abs(r_d))
                    {
                        // 右
                        if ((start.col + 1 < 7) && r[start.row, start.col + 1] == ' ' && !(isArrived))
                            Visit(p(start.col + 1, start.row), end);
                        // 上
                        if ((start.row - 1 >= 0) && r[start.row - 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row - 1), end);
                        // 左
                        if ((start.col - 1 >= 0) && r[start.row, start.col - 1] == ' ' && !(isArrived))
                            Visit(p(start.col - 1, start.row), end);
                        // 下
                        if ((start.row + 1 < 7) && r[start.row + 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row + 1), end);
                    }
                    // 先上
                    else
                    {
                        // 上
                        if ((start.row - 1 >= 0) && r[start.row - 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row - 1), end);
                        // 右
                        if ((start.col + 1 < 7) && r[start.row, start.col + 1] == ' ' && !(isArrived))
                            Visit(p(start.col + 1, start.row), end);
                        // 下
                        if ((start.row + 1 < 7) && r[start.row + 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row + 1), end);
                        // 左
                        if ((start.col - 1 >= 0) && r[start.row, start.col - 1] == ' ' && !(isArrived))
                            Visit(p(start.col - 1, start.row), end);
                    }
                }
                // 往左上方(上)
                else if (c_d <= 0 && r_d < 0)
                {
                    // 先左
                    if (c_d < r_d)
                    {
                        // 左
                        if ((start.col - 1 >= 0) && r[start.row, start.col - 1] == ' ' && !(isArrived))
                            Visit(p(start.col - 1, start.row), end);
                        // 上
                        if ((start.row - 1 >= 0) && r[start.row - 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row - 1), end);
                        // 右
                        if ((start.col + 1 < 7) && r[start.row, start.col + 1] == ' ' && !(isArrived))
                            Visit(p(start.col + 1, start.row), end);
                        // 下
                        if ((start.row + 1 < 7) && r[start.row + 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row + 1), end);
                    }
                    // 先上
                    else
                    {
                        // 上
                        if ((start.row - 1 >= 0) && r[start.row - 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row - 1), end);
                        // 左
                        if ((start.col - 1 >= 0) && r[start.row, start.col - 1] == ' ' && !(isArrived))
                            Visit(p(start.col - 1, start.row), end);
                        // 下
                        if ((start.row + 1 < 7) && r[start.row + 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row + 1), end);
                        // 右
                        if ((start.col + 1 < 7) && r[start.row, start.col + 1] == ' ' && !(isArrived))
                            Visit(p(start.col + 1, start.row), end);
                    }
                }
                // 往左下方(左)
                else if (c_d < 0 && r_d >= 0)
                {
                    // 先左
                    if (c_d < r_d)
                    {
                        // 左
                        if ((start.col - 1 >= 0) && r[start.row, start.col - 1] == ' ' && !(isArrived))
                            Visit(p(start.col - 1, start.row), end);
                        // 下
                        if ((start.row + 1 < 7) && r[start.row + 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row + 1), end);
                        // 右
                        if ((start.col + 1 < 7) && r[start.row, start.col + 1] == ' ' && !(isArrived))
                            Visit(p(start.col + 1, start.row), end);
                        // 上
                        if ((start.row - 1 >= 0) && r[start.row - 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row - 1), end);
                    }
                    // 先下
                    else
                    {
                        // 下
                        if ((start.row + 1 < 7) && r[start.row + 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row + 1), end);
                        // 左
                        if ((start.col - 1 >= 0) && r[start.row, start.col - 1] == ' ' && !(isArrived))
                            Visit(p(start.col - 1, start.row), end);
                        // 上
                        if ((start.row - 1 >= 0) && r[start.row - 1, start.col] == ' ' && !(isArrived))
                            Visit(p(start.col, start.row - 1), end);
                        // 右
                        if ((start.col + 1 < 7) && r[start.row, start.col + 1] == ' ' && !(isArrived))
                            Visit(p(start.col + 1, start.row), end);
                    }
                }
            }
            if (!isArrived)
            {
                r[start.row, start.col] = ' ';
                route.Remove(p(start.col, start.row));
                DGV_map[start.col, start.row].Style.BackColor = Color.White;
                cnt++;
            }

        }
        // 路線規劃
        private int PlanRoute(Point end)
        {
            isMapUpdate = false;
            // 初始化 [空格 > 可行走] [ 1 > 有障礙]
            r = new char[7, 7]{
            {'1', ' ', ' ', ' ', '1', '1', '1'},
            {'1', '1', ' ', ' ', ' ', ' ', ' '},
            {'1', '1', ' ', ' ', ' ', ' ', ' '},
            {'1', '1', ' ', ' ', ' ', ' ', ' '},
            {'1', ' ', ' ', ' ', ' ', ' ', ' '},
            {'1', ' ', ' ', ' ', ' ', ' ', '1'},
            {'1', ' ', ' ', ' ', ' ', ' ', '1'}};
            for(int i = 0;i < 7; i++)
                for(int j = 0; j < 7; j++)
                {
                    if (map[j, i].isClear)
                        r[i, j] = ' ';
                    else
                        r[i, j] = '1';
                }
            if (AGV_isLiftUp)
            {
                foreach(string s in shelves)
                {//DGV_map[i, j].Value = d.code.Substring(0, 3) + "　"+ d.code.Substring(3) + "\n\n";

                    r[int.Parse(s.Substring(1, 1)), int.Parse(s.Substring(4, 1))] = '1';
                }
            }
            isArrived = false;
            route.Clear();
            MapReload();
            // 路線走訪
            cnt = 0;
            if (r[end.row, end.col] == ' ')
                Visit(AGV_Point, end);
            DGV_map[AGV_Point.col, AGV_Point.row].Style.BackColor = Color.DarkOrange;
            DGV_map[AGV_Point.col, AGV_Point.row].Style.ForeColor = Color.White;
            
            // 印出陣列
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                    Console.Write(r[i, j]);
                Console.Write('\n');
            }
            Console.Write('\n');

            if (isArrived)
                return 0;
            else
            {
                route.Clear();
                return 10;
            }
        }
        private void DGV_map_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Point end = p(e.ColumnIndex, e.RowIndex);
            Log("Route Planning", PlanRoute(end));
        }

        List<string> Script_cmd = new List<string> { };
        List<int> Script_arg = new List<int> { };
        // 更新腳本
        private void ScriptReload()
        {
            DGV_Script.Columns.Clear();
            DGV_Script.Columns.Add("NUM", "NUM");
            DGV_Script.Columns.Add("CMD", "CMD");
            DGV_Script.Columns.Add("Arg", "Arg");
            DGV_Script.Columns[0].Width = 35;
            DGV_Script.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Script.Columns[2].Width = 50;
            for(int i = 0; i < Script_arg.Count(); i++)
                DGV_Script.Rows.Add(i + 1, Script_cmd[i], Script_arg[i]);
            DGV_Script.ClearSelection();
        }
        // 執行腳本
        private void ScriptAction()
        {
            int[] args = Script_arg.ToArray();
            Result cmd = SendCmd(AGV_Name, "30121", args);
            Log("Script　Action", cmd.statusCode);
            isMapUpdate = true;
        }
        private void btn_sActivate_Click(object sender, EventArgs e)
        {
            ScriptAction();
        }
        // 暫停腳本
        private void ScriptPause()
        {
            Result cmd = SendCmd(AGV_Name, "30312", new int[] { });
            Log("Script　Pause", cmd.statusCode);
        }
        private void btn_sPause_Click(object sender, EventArgs e)
        {
            ScriptPause();
        }
        // 繼續腳本
        private void ScriptContinue()
        {
            Result cmd = SendCmd(AGV_Name, "30313", new int[] { });
            Log("Script　Continue", cmd.statusCode);
        }
        private void btn_sContinue_Click(object sender, EventArgs e)
        {
            ScriptContinue();
        }
        // 停止腳本
        private void ScriptStop()
        {
            Result cmd = SendCmd(AGV_Name, "30314", new int[] { });
            Log("Script　Stop", cmd.statusCode);
        }
        private void btn_sStop_Click(object sender, EventArgs e)
        {
            ScriptStop();
        }
        // 腳本左轉90(轉盤不動)
        private void ScriptL90s()
        {
            Script_cmd.Add("左轉90(轉盤不動)");
            Script_arg.Add(170);
            ScriptReload();
        }
        private void btn_sptL90s_Click(object sender, EventArgs e)
        {
            ScriptL90s();
        }
        // 腳本左轉180(轉盤不動)
        private void ScriptL180s()
        {
            Script_cmd.Add("左轉180(轉盤不動");
            Script_arg.Add(180);
            ScriptReload();
        }
        private void btn_sptL180s_Click(object sender, EventArgs e)
        {
            ScriptL180s();
        }
        // 腳本右轉90(轉盤不動)
        private void ScriptR90s()
        {
            Script_cmd.Add("右轉90(轉盤不動)");
            Script_arg.Add(150);
            ScriptReload();
        }
        private void btn_sptR90s_Click(object sender, EventArgs e)
        {
            ScriptR90s();
        }
        // 腳本右轉180(轉盤不動)
        private void ScriptR180s()
        {
            Script_cmd.Add("右轉180(轉盤不動)");
            Script_arg.Add(160);
            ScriptReload();
        }
        private void btn_sptR180s_Click(object sender, EventArgs e)
        {
            ScriptR180s();
        }
        // 腳本左轉90
        private void ScriptL90()
        {
            Script_cmd.Add("左轉90");
            Script_arg.Add(70);
            ScriptReload();
        }
        private void btn_sptL90_Click(object sender, EventArgs e)
        {
            ScriptL90();
        }
        // 腳本左轉180
        private void ScriptL180()
        {
            Script_cmd.Add("左轉180");
            Script_arg.Add(80);
            ScriptReload();
        }
        private void btn_sptL180_Click(object sender, EventArgs e)
        {
            ScriptL180();
        }
        // 腳本右轉90
        private void ScriptR90()
        {
            Script_cmd.Add("右轉90");
            Script_arg.Add(50);
            ScriptReload();
        }
        private void btn_sptR90_Click(object sender, EventArgs e)
        {
            ScriptR90();
        }
        // 腳本右轉180
        private void ScriptR180()
        {
            Script_cmd.Add("右轉180");
            Script_arg.Add(60);
            ScriptReload();
        }
        private void btn_sptR180_Click(object sender, EventArgs e)
        {
            ScriptR180();
        }
        // 腳本頂升貨架
        private void ScriptUp()
        {
            Script_cmd.Add("頂升貨架");
            Script_arg.Add(330);
            ScriptReload();
        }
        private void btn_sptUp_Click(object sender, EventArgs e)
        {
            ScriptUp();
        }
        // 腳本放下貨架
        private void ScriptDown()
        {
            Script_cmd.Add("放下貨架");
            Script_arg.Add(340);
            ScriptReload();
        }
        private void btn_sptDown_Click(object sender, EventArgs e)
        {
            ScriptDown();
        }
        // 腳本轉盤左轉90
        private void ScriptSL90()
        {
            Script_cmd.Add("轉盤左轉90");
            Script_arg.Add(370);
            ScriptReload();
        }
        private void btn_sptSL90_Click(object sender, EventArgs e)
        {
            ScriptSL90();
        }
        // 腳本轉盤右轉90
        private void ScriptSR90()
        {
            Script_cmd.Add("轉盤右轉90");
            Script_arg.Add(350);
            ScriptReload();
        }
        private void btn_sptSR90_Click(object sender, EventArgs e)
        {
            ScriptSR90();
        }
        // 腳本轉盤左轉180
        private void ScriptSL180()
        {
            Script_cmd.Add("轉盤左轉180");
            Script_arg.Add(380);
            ScriptReload();
        }
        private void btn_sptSL180_Click(object sender, EventArgs e)
        {
            ScriptSL180();
        }
        // 腳本轉盤右轉180
        private void ScriptSR180()
        {
            Script_cmd.Add("轉盤右轉180");
            Script_arg.Add(360);
            ScriptReload();
        }
        private void btn_sptSR180_Click(object sender, EventArgs e)
        {
            ScriptSR180();
        }
        // 腳本等待
        private void ScriptWait(int s)
        {
            Script_cmd.Add($"等待 {s} 秒");
            Script_arg.Add(500 + s);
            ScriptReload();
        }
        private void btn_sptWait_Click(object sender, EventArgs e)
        {
            ScriptWait(int.Parse(numUD_sec.Value.ToString()));
        }
        // 腳本直走
        private void ScriptGo(int d)
        {
            Script_cmd.Add($"直走 {d} 格");
            Script_arg.Add(10000 + d * 100);
            ScriptReload();
        }
        private void btn_sptGo_Click(object sender, EventArgs e)
        {
            ScriptGo(int.Parse(numUD_distance.Value.ToString()));
        }
        // 移除腳本命令
        private void ScriptRemove(int idx)
        {
            Script_cmd.RemoveAt(idx);
            Script_arg.RemoveAt(idx);
            ScriptReload();
        }
        private void btn_sptRemove_Click(object sender, EventArgs e)
        {
            try
            {
                ScriptRemove(DGV_Script.SelectedRows[0].Index);
            }
            catch
            {

            }
            
        }
        // 清除腳本命令
        private void ScriptClear()
        {
            Script_cmd.Clear();
            Script_arg.Clear();
            ScriptReload();
        }
        private void btn_sptClear_Click(object sender, EventArgs e)
        {
            ScriptClear();
        }
        // 腳本進入充電站
        private void ScriptGotoCharger(int d)
        {
            switch (d)
            {
                case 1:
                    Script_cmd.Add("進入充電站 [內]");
                    Script_arg.Add(6000 + 700);
                    break;
                case 2:
                    Script_cmd.Add("進入充電站 [外]");
                    Script_arg.Add(6000 + 550);
                    break;
            }
            ScriptReload();
        }
        private void btn_sptGotoCharger_Click(object sender, EventArgs e)
        {
            ScriptGotoCharger(1);
        }
        private void btn_sptGotoCharger2_Click(object sender, EventArgs e)
        {
            ScriptGotoCharger(2);
        }
        // 腳本離開充電站
        private void ScriptLeaveCharger(int d)
        {
            switch (d)
            {
                case 1:
                    Script_cmd.Add("離開充電站 [內]");
                    Script_arg.Add(7000 + 700);
                    break;
                case 2:
                    Script_cmd.Add("離開充電站 [外]");
                    Script_arg.Add(7000 + 550);
                    break;
            }
            ScriptReload();
        }
        private void btn_sptLeaveCharger_Click(object sender, EventArgs e)
        {
            ScriptLeaveCharger(1);
        }
        private void btn_sptLeaveCharger2_Click(object sender, EventArgs e)
        {
            ScriptLeaveCharger(2);
        }
        // 重載腳本選擇器
        private void ScriptSelectorReload()
        {
            comboBox_script.Items.Clear();
            string[] spts = Directory.GetFiles("AGV_Script");
            foreach (string s in spts)
                comboBox_script.Items.Add(s.Replace("AGV_Script\\", "").Replace(".txt", ""));
        }
        // 儲存腳本
        private int ScriptSave()
        {
            string name = comboBox_script.Text;
            if (name == "")
            {
                Inputbox input = new Inputbox("Please enter Script Name.", "Create new Script");
                input.ShowDialog();
                if (input.DialogResult == DialogResult.OK)
                    name = input.GetMsg();
                else
                    return 0;
                comboBox_script.Text = name;
            }
            StreamWriter writer = new StreamWriter("AGV_Script\\" + name + ".txt");
            foreach(string c in Script_cmd)
                writer.Write(c + " ");
            writer.Write("\n");
            foreach (int a in Script_arg)
                writer.Write($"{a} ");
            writer.Flush();
            writer.Close();
            MessageBox.Show(name, "Save Script");
            return 0;
        }
        private void btn_sptSave_Click(object sender, EventArgs e)
        {
            ScriptSave();
            ScriptSelectorReload();
        }
        // 刪除腳本
        private void ScriptDelete()
        {
            string name = comboBox_script.Text;
            File.Delete("AGV_Script\\" + name + ".txt");
            comboBox_script.Text = "";
            MessageBox.Show(name, "Delete Script");
        }
        private void btn_sptDelete_Click(object sender, EventArgs e)
        {
            ScriptDelete();
            ScriptSelectorReload();
        }
        // 選擇腳本
        private void comboBox_script_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comboBox_script.Text;
            StreamReader reader = new StreamReader("AGV_Script\\" + name + ".txt");
            Script_cmd.Clear();
            Script_arg.Clear();
            string[] cmd = reader.ReadLine().Trim().Split(' ');
            string[] arg = reader.ReadLine().Trim().Split(' ');
            reader.Close();
            foreach (string c in cmd)
                Script_cmd.Add(c);
            foreach (string a in arg)
                Script_arg.Add(int.Parse(a));
            ScriptReload();
        }
        // 匯入路線 轉向處理
        char yaw = ' ';
        private bool Turn(char y)
        {
            switch (y)
            {
                case '↑':
                    switch (yaw)
                    {
                        case '→':
                            ScriptL90s();
                            return true;
                        case '↓':
                            ScriptL180s();
                            return true;
                        case '←':
                            ScriptR90s();
                            return true;
                        default:
                            return false;
                    }
                case '→':
                    switch (yaw)
                    {
                        case '↑':
                            ScriptR90s();
                            return true;
                        case '↓':
                            ScriptL90s();
                            return true;
                        case '←':
                            ScriptL180s();
                            return true;
                        default:
                            return false;
                    }
                case '↓':
                    switch (yaw)
                    {
                        case '↑':
                            ScriptL180s();
                            return true;
                        case '→':
                            ScriptR90s();
                            return true;
                        case '←':
                            ScriptL90s();
                            return true;
                        default:
                            return false;
                    }
                case '←':
                    switch (yaw)
                    {
                        case '↑':
                            ScriptL90s();
                            return true;
                        case '→':
                            ScriptL180s();
                            return true;
                        case '↓':
                            ScriptR90s();
                            return true;
                        default:
                            return false;
                    }
                default:
                    return false;
            }
        }
        private void swap()
        {
            int idx = Script_cmd.Count - 1;
            string cmd = Script_cmd[idx];
            int arg = Script_arg[idx];
            Script_cmd[idx] = Script_cmd[idx - 1];
            Script_arg[idx] = Script_arg[idx - 1];
            Script_cmd[idx - 1] = cmd;
            Script_arg[idx - 1] = arg;
            ScriptReload();
        }
        // 匯入路徑至腳本 ↑→↓←
        int c = 0;
        private void ImportRoute()
        {
            ScriptClear();
            int cnt = 0;
            yaw = AGV_Y;
            for (int i = 0; i < route.Count - 1; i++)
            {
                Point cur = route[i];
                Point next = route[i + 1];
                if (cur.col == next.col)
                {
                    // 上
                    if (cur.row > next.row)
                    {
                        if (Turn('↑'))
                        {
                            yaw = '↑';
                            if (cnt == 0)
                                cnt++;
                            else
                            {
                                ScriptGo(cnt);
                                cnt = 1;
                                swap();
                            }
                        }
                        else
                            cnt++;
                    }
                    // 下
                    else
                    {
                        if (Turn('↓'))
                        {
                            yaw = '↓';
                            if (cnt == 0)
                                cnt++;
                            else
                            {
                                ScriptGo(cnt);
                                cnt = 1;
                                swap();
                            }
                        }
                        else
                            cnt++;
                    }
                }
                else if (cur.row == next.row)
                {
                    // 左
                    if (cur.col > next.col)
                    {
                        if (Turn('←'))
                        {
                            yaw = '←';
                            if (cnt == 0)
                                cnt++;
                            else
                            {
                                ScriptGo(cnt);
                                cnt = 1;
                                swap();
                            }
                        }
                        else
                            cnt++;
                    }
                    // 右
                    else
                    {
                        if (Turn('→'))
                        {
                            yaw = '→';
                            if (cnt == 0)
                                cnt++;
                            else
                            {
                                ScriptGo(cnt);
                                cnt = 1;
                                swap();
                            }
                        }
                        else
                            cnt++;
                    }
                }
            }
            if (cnt != 0)
                ScriptGo(cnt);
        }
        private void btn_sptImport_Click(object sender, EventArgs e)
        {
            ImportRoute();
        }
        // 自動更新
        bool isInfoUpdate = false;
        bool isMapUpdate = false;
        private void update_Tick(object sender, EventArgs e)
        {
            if (isInfoUpdate)
                AGV_Info();
            if (isMapUpdate)
                MapReload();
        }
        private void btn_oneCliktoCharger_Click(object sender, EventArgs e)
        {
            Point end = p(int.Parse(charger[4].ToString()), int.Parse(charger[1].ToString()));
            if (Log("Route Planning", PlanRoute(end)))
            {
                ImportRoute();
                Turn('→');
                ScriptGotoCharger(1);
                ScriptAction();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shelves.RemoveAt(listbox_shelves.SelectedIndex);
            ShelvesReload();
            MapReload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inputbox n = new Inputbox("Enter The Code of Shelve.", "Shelve");
            n.ShowDialog();
            if(n.DialogResult == DialogResult.OK)
            {
                shelves.Add(n.GetMsg());
                ShelvesReload();
                MapReload();
            }
            MessageBox.Show("Add：" + n.GetMsg(), "Shelve");
        }
    }
}
