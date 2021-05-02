namespace Control
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listbox_AGV = new System.Windows.Forms.ListBox();
            this.listbox_AGVinfo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listbox_Log = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DGV_map = new System.Windows.Forms.DataGridView();
            this.WebAPI = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_oneCliktoCharger = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_sL90 = new System.Windows.Forms.Button();
            this.btn_sR90 = new System.Windows.Forms.Button();
            this.btn_sL180 = new System.Windows.Forms.Button();
            this.btn_sR180 = new System.Windows.Forms.Button();
            this.btn_leaveCharger = new System.Windows.Forms.Button();
            this.btn_gotoCharger2 = new System.Windows.Forms.Button();
            this.btn_leaveCharger2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ServoOn = new System.Windows.Forms.Button();
            this.btn_ServoOff = new System.Windows.Forms.Button();
            this.btn_left90s = new System.Windows.Forms.Button();
            this.btn_right180s = new System.Windows.Forms.Button();
            this.btn_right90 = new System.Windows.Forms.Button();
            this.btn_STOP = new System.Windows.Forms.Button();
            this.btn_gotoCharger = new System.Windows.Forms.Button();
            this.btn_right180 = new System.Windows.Forms.Button();
            this.btn_left180 = new System.Windows.Forms.Button();
            this.btn_move = new System.Windows.Forms.Button();
            this.btn_left90 = new System.Windows.Forms.Button();
            this.btn_right90s = new System.Windows.Forms.Button();
            this.btn_left180s = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_sptImport = new System.Windows.Forms.Button();
            this.btn_sptGotoCharger2 = new System.Windows.Forms.Button();
            this.btn_sptLeaveCharger2 = new System.Windows.Forms.Button();
            this.btn_sptLeaveCharger = new System.Windows.Forms.Button();
            this.btn_sptGotoCharger = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_sptUp = new System.Windows.Forms.Button();
            this.btn_sptDown = new System.Windows.Forms.Button();
            this.btn_sptSL90 = new System.Windows.Forms.Button();
            this.btn_sptSR90 = new System.Windows.Forms.Button();
            this.btn_sptSL180 = new System.Windows.Forms.Button();
            this.btn_sptSR180 = new System.Windows.Forms.Button();
            this.btn_sptL90s = new System.Windows.Forms.Button();
            this.btn_sptR180s = new System.Windows.Forms.Button();
            this.btn_sptR90 = new System.Windows.Forms.Button();
            this.btn_sptR180 = new System.Windows.Forms.Button();
            this.btn_sptL180 = new System.Windows.Forms.Button();
            this.btn_sptL90 = new System.Windows.Forms.Button();
            this.btn_sptL180s = new System.Windows.Forms.Button();
            this.btn_sptR90s = new System.Windows.Forms.Button();
            this.btn_sptWait = new System.Windows.Forms.Button();
            this.numUD_sec = new System.Windows.Forms.NumericUpDown();
            this.btn_sptGo = new System.Windows.Forms.Button();
            this.numUD_distance = new System.Windows.Forms.NumericUpDown();
            this.btn_sptClear = new System.Windows.Forms.Button();
            this.btn_sptRemove = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sptDelete = new System.Windows.Forms.Button();
            this.comboBox_script = new System.Windows.Forms.ComboBox();
            this.btn_sptSave = new System.Windows.Forms.Button();
            this.DGV_Script = new System.Windows.Forms.DataGridView();
            this.btn_sptStop = new System.Windows.Forms.Button();
            this.btn_sptContinue = new System.Windows.Forms.Button();
            this.btn_sptPause = new System.Windows.Forms.Button();
            this.btn_sptActivate = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.listbox_shelves = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_map)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_sec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_distance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Script)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listbox_AGV
            // 
            this.listbox_AGV.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listbox_AGV.FormattingEnabled = true;
            this.listbox_AGV.ItemHeight = 20;
            this.listbox_AGV.Location = new System.Drawing.Point(3, 27);
            this.listbox_AGV.Name = "listbox_AGV";
            this.listbox_AGV.Size = new System.Drawing.Size(130, 64);
            this.listbox_AGV.TabIndex = 1;
            this.listbox_AGV.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listbox_AGVinfo
            // 
            this.listbox_AGVinfo.Font = new System.Drawing.Font("新細明體", 9F);
            this.listbox_AGVinfo.FormattingEnabled = true;
            this.listbox_AGVinfo.ItemHeight = 12;
            this.listbox_AGVinfo.Location = new System.Drawing.Point(9, 28);
            this.listbox_AGVinfo.Name = "listbox_AGVinfo";
            this.listbox_AGVinfo.Size = new System.Drawing.Size(226, 412);
            this.listbox_AGVinfo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Info：";
            // 
            // listbox_Log
            // 
            this.listbox_Log.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listbox_Log.FormattingEnabled = true;
            this.listbox_Log.ItemHeight = 16;
            this.listbox_Log.Location = new System.Drawing.Point(12, 37);
            this.listbox_Log.Name = "listbox_Log";
            this.listbox_Log.Size = new System.Drawing.Size(308, 340);
            this.listbox_Log.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(9, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Log：";
            // 
            // DGV_map
            // 
            this.DGV_map.AllowUserToAddRows = false;
            this.DGV_map.AllowUserToDeleteRows = false;
            this.DGV_map.AllowUserToResizeColumns = false;
            this.DGV_map.AllowUserToResizeRows = false;
            this.DGV_map.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_map.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_map.ColumnHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("新細明體", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_map.DefaultCellStyle = dataGridViewCellStyle9;
            this.DGV_map.Location = new System.Drawing.Point(326, 9);
            this.DGV_map.MultiSelect = false;
            this.DGV_map.Name = "DGV_map";
            this.DGV_map.ReadOnly = true;
            this.DGV_map.RowHeadersVisible = false;
            this.DGV_map.RowHeadersWidth = 62;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("新細明體", 9F);
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_map.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DGV_map.RowTemplate.Height = 80;
            this.DGV_map.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGV_map.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_map.Size = new System.Drawing.Size(490, 560);
            this.DGV_map.TabIndex = 9;
            this.DGV_map.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_map_CellClick);
            // 
            // WebAPI
            // 
            this.WebAPI.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WebAPI.Location = new System.Drawing.Point(241, 3);
            this.WebAPI.Name = "WebAPI";
            this.WebAPI.Size = new System.Drawing.Size(123, 64);
            this.WebAPI.TabIndex = 10;
            this.WebAPI.Text = "Web API";
            this.WebAPI.UseVisualStyleBackColor = true;
            this.WebAPI.Click += new System.EventHandler(this.WebAPI_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(822, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 568);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_oneCliktoCharger);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.flowLayoutPanel2);
            this.tabPage2.Controls.Add(this.btn_leaveCharger);
            this.tabPage2.Controls.Add(this.btn_gotoCharger2);
            this.tabPage2.Controls.Add(this.btn_leaveCharger2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btn_ServoOn);
            this.tabPage2.Controls.Add(this.btn_ServoOff);
            this.tabPage2.Controls.Add(this.listbox_AGV);
            this.tabPage2.Controls.Add(this.btn_left90s);
            this.tabPage2.Controls.Add(this.btn_right180s);
            this.tabPage2.Controls.Add(this.btn_right90);
            this.tabPage2.Controls.Add(this.btn_STOP);
            this.tabPage2.Controls.Add(this.btn_gotoCharger);
            this.tabPage2.Controls.Add(this.btn_right180);
            this.tabPage2.Controls.Add(this.btn_left180);
            this.tabPage2.Controls.Add(this.btn_move);
            this.tabPage2.Controls.Add(this.btn_left90);
            this.tabPage2.Controls.Add(this.btn_right90s);
            this.tabPage2.Controls.Add(this.btn_left180s);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(755, 542);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Control";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_oneCliktoCharger
            // 
            this.btn_oneCliktoCharger.BackColor = System.Drawing.Color.SlateGray;
            this.btn_oneCliktoCharger.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_oneCliktoCharger.ForeColor = System.Drawing.Color.Snow;
            this.btn_oneCliktoCharger.Location = new System.Drawing.Point(511, 301);
            this.btn_oneCliktoCharger.Name = "btn_oneCliktoCharger";
            this.btn_oneCliktoCharger.Size = new System.Drawing.Size(234, 52);
            this.btn_oneCliktoCharger.TabIndex = 20;
            this.btn_oneCliktoCharger.Text = "一鍵充電";
            this.btn_oneCliktoCharger.UseVisualStyleBackColor = false;
            this.btn_oneCliktoCharger.Click += new System.EventHandler(this.btn_oneCliktoCharger_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(264, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "[ 圓盤 ]";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Linen;
            this.flowLayoutPanel2.Controls.Add(this.btn_up);
            this.flowLayoutPanel2.Controls.Add(this.btn_down);
            this.flowLayoutPanel2.Controls.Add(this.btn_sL90);
            this.flowLayoutPanel2.Controls.Add(this.btn_sR90);
            this.flowLayoutPanel2.Controls.Add(this.btn_sL180);
            this.flowLayoutPanel2.Controls.Add(this.btn_sR180);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(268, 389);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(480, 147);
            this.flowLayoutPanel2.TabIndex = 18;
            // 
            // btn_up
            // 
            this.btn_up.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_up.Location = new System.Drawing.Point(3, 3);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(234, 58);
            this.btn_up.TabIndex = 14;
            this.btn_up.Text = "頂升貨架";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_down
            // 
            this.btn_down.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_down.Location = new System.Drawing.Point(243, 3);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(234, 58);
            this.btn_down.TabIndex = 15;
            this.btn_down.Text = "放下貨架";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_sL90
            // 
            this.btn_sL90.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sL90.Location = new System.Drawing.Point(3, 67);
            this.btn_sL90.Name = "btn_sL90";
            this.btn_sL90.Size = new System.Drawing.Size(114, 75);
            this.btn_sL90.TabIndex = 17;
            this.btn_sL90.Text = "左 90°";
            this.btn_sL90.UseVisualStyleBackColor = true;
            this.btn_sL90.Click += new System.EventHandler(this.btn_sL90_Click);
            // 
            // btn_sR90
            // 
            this.btn_sR90.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sR90.Location = new System.Drawing.Point(123, 67);
            this.btn_sR90.Name = "btn_sR90";
            this.btn_sR90.Size = new System.Drawing.Size(114, 75);
            this.btn_sR90.TabIndex = 15;
            this.btn_sR90.Text = "右 90°";
            this.btn_sR90.UseVisualStyleBackColor = true;
            this.btn_sR90.Click += new System.EventHandler(this.btn_sR90_Click);
            // 
            // btn_sL180
            // 
            this.btn_sL180.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sL180.Location = new System.Drawing.Point(243, 67);
            this.btn_sL180.Name = "btn_sL180";
            this.btn_sL180.Size = new System.Drawing.Size(114, 77);
            this.btn_sL180.TabIndex = 16;
            this.btn_sL180.Text = "左 180°";
            this.btn_sL180.UseVisualStyleBackColor = true;
            this.btn_sL180.Click += new System.EventHandler(this.btn_sL180_Click);
            // 
            // btn_sR180
            // 
            this.btn_sR180.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sR180.Location = new System.Drawing.Point(363, 67);
            this.btn_sR180.Name = "btn_sR180";
            this.btn_sR180.Size = new System.Drawing.Size(114, 75);
            this.btn_sR180.TabIndex = 14;
            this.btn_sR180.Text = "右 180°";
            this.btn_sR180.UseVisualStyleBackColor = true;
            this.btn_sR180.Click += new System.EventHandler(this.btn_sR180_Click);
            // 
            // btn_leaveCharger
            // 
            this.btn_leaveCharger.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_leaveCharger.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_leaveCharger.Location = new System.Drawing.Point(0, 427);
            this.btn_leaveCharger.Name = "btn_leaveCharger";
            this.btn_leaveCharger.Size = new System.Drawing.Size(259, 52);
            this.btn_leaveCharger.TabIndex = 12;
            this.btn_leaveCharger.Text = "離開充電站 [內]";
            this.btn_leaveCharger.UseVisualStyleBackColor = false;
            this.btn_leaveCharger.Click += new System.EventHandler(this.btn_leaveCharger_Click);
            // 
            // btn_gotoCharger2
            // 
            this.btn_gotoCharger2.BackColor = System.Drawing.Color.Salmon;
            this.btn_gotoCharger2.Enabled = false;
            this.btn_gotoCharger2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_gotoCharger2.Location = new System.Drawing.Point(0, 359);
            this.btn_gotoCharger2.Name = "btn_gotoCharger2";
            this.btn_gotoCharger2.Size = new System.Drawing.Size(259, 52);
            this.btn_gotoCharger2.TabIndex = 19;
            this.btn_gotoCharger2.Text = "進入充電站 [外]";
            this.btn_gotoCharger2.UseVisualStyleBackColor = false;
            this.btn_gotoCharger2.Click += new System.EventHandler(this.btn_gotoCharger2_Click);
            // 
            // btn_leaveCharger2
            // 
            this.btn_leaveCharger2.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_leaveCharger2.Enabled = false;
            this.btn_leaveCharger2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_leaveCharger2.Location = new System.Drawing.Point(0, 485);
            this.btn_leaveCharger2.Name = "btn_leaveCharger2";
            this.btn_leaveCharger2.Size = new System.Drawing.Size(259, 52);
            this.btn_leaveCharger2.TabIndex = 14;
            this.btn_leaveCharger2.Text = "離開充電站 [外]";
            this.btn_leaveCharger2.UseVisualStyleBackColor = false;
            this.btn_leaveCharger2.Click += new System.EventHandler(this.btn_leaveCharger2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "[ AGV ]";
            // 
            // btn_ServoOn
            // 
            this.btn_ServoOn.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_ServoOn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ServoOn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ServoOn.Location = new System.Drawing.Point(268, 27);
            this.btn_ServoOn.Name = "btn_ServoOn";
            this.btn_ServoOn.Size = new System.Drawing.Size(237, 64);
            this.btn_ServoOn.TabIndex = 0;
            this.btn_ServoOn.Text = "Servo On";
            this.btn_ServoOn.UseVisualStyleBackColor = false;
            this.btn_ServoOn.Click += new System.EventHandler(this.btn_ServoOn_Click);
            // 
            // btn_ServoOff
            // 
            this.btn_ServoOff.BackColor = System.Drawing.Color.Red;
            this.btn_ServoOff.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ServoOff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ServoOff.Location = new System.Drawing.Point(511, 27);
            this.btn_ServoOff.Name = "btn_ServoOff";
            this.btn_ServoOff.Size = new System.Drawing.Size(237, 64);
            this.btn_ServoOff.TabIndex = 1;
            this.btn_ServoOff.Text = "Servo Off";
            this.btn_ServoOff.UseVisualStyleBackColor = false;
            this.btn_ServoOff.Click += new System.EventHandler(this.btn_ServoOff_Click);
            // 
            // btn_left90s
            // 
            this.btn_left90s.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_left90s.Location = new System.Drawing.Point(268, 97);
            this.btn_left90s.Name = "btn_left90s";
            this.btn_left90s.Size = new System.Drawing.Size(237, 93);
            this.btn_left90s.TabIndex = 9;
            this.btn_left90s.Text = "左 90°\r\n（轉盤不動）";
            this.btn_left90s.UseVisualStyleBackColor = true;
            this.btn_left90s.Click += new System.EventHandler(this.btn_left90s_Click);
            // 
            // btn_right180s
            // 
            this.btn_right180s.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_right180s.Location = new System.Drawing.Point(511, 196);
            this.btn_right180s.Name = "btn_right180s";
            this.btn_right180s.Size = new System.Drawing.Size(237, 93);
            this.btn_right180s.TabIndex = 6;
            this.btn_right180s.Text = "右 180°\r\n（轉盤不動）\r\n";
            this.btn_right180s.UseVisualStyleBackColor = true;
            this.btn_right180s.Click += new System.EventHandler(this.btn_right180s_Click);
            // 
            // btn_right90
            // 
            this.btn_right90.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_right90.Location = new System.Drawing.Point(133, 97);
            this.btn_right90.Name = "btn_right90";
            this.btn_right90.Size = new System.Drawing.Size(129, 93);
            this.btn_right90.TabIndex = 3;
            this.btn_right90.Text = "右 90°";
            this.btn_right90.UseVisualStyleBackColor = true;
            this.btn_right90.Click += new System.EventHandler(this.btn_right90_Click);
            // 
            // btn_STOP
            // 
            this.btn_STOP.BackColor = System.Drawing.Color.Gold;
            this.btn_STOP.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_STOP.ForeColor = System.Drawing.Color.Red;
            this.btn_STOP.Location = new System.Drawing.Point(139, 27);
            this.btn_STOP.Name = "btn_STOP";
            this.btn_STOP.Size = new System.Drawing.Size(123, 64);
            this.btn_STOP.TabIndex = 13;
            this.btn_STOP.Text = "緊急停止";
            this.btn_STOP.UseVisualStyleBackColor = false;
            this.btn_STOP.Click += new System.EventHandler(this.btn_STOP_Click);
            // 
            // btn_gotoCharger
            // 
            this.btn_gotoCharger.BackColor = System.Drawing.Color.Salmon;
            this.btn_gotoCharger.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_gotoCharger.Location = new System.Drawing.Point(0, 301);
            this.btn_gotoCharger.Name = "btn_gotoCharger";
            this.btn_gotoCharger.Size = new System.Drawing.Size(259, 52);
            this.btn_gotoCharger.TabIndex = 11;
            this.btn_gotoCharger.Text = "進入充電站 [內]";
            this.btn_gotoCharger.UseVisualStyleBackColor = false;
            this.btn_gotoCharger.Click += new System.EventHandler(this.btn_gotoCharger_Click);
            // 
            // btn_right180
            // 
            this.btn_right180.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_right180.Location = new System.Drawing.Point(133, 196);
            this.btn_right180.Name = "btn_right180";
            this.btn_right180.Size = new System.Drawing.Size(129, 93);
            this.btn_right180.TabIndex = 2;
            this.btn_right180.Text = "右 180°";
            this.btn_right180.UseVisualStyleBackColor = true;
            this.btn_right180.Click += new System.EventHandler(this.btn_right180_Click);
            // 
            // btn_left180
            // 
            this.btn_left180.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_left180.Location = new System.Drawing.Point(3, 196);
            this.btn_left180.Name = "btn_left180";
            this.btn_left180.Size = new System.Drawing.Size(129, 93);
            this.btn_left180.TabIndex = 4;
            this.btn_left180.Text = "左 180°";
            this.btn_left180.UseVisualStyleBackColor = true;
            this.btn_left180.Click += new System.EventHandler(this.btn_left180_Click);
            // 
            // btn_move
            // 
            this.btn_move.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_move.Location = new System.Drawing.Point(268, 301);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(237, 52);
            this.btn_move.TabIndex = 10;
            this.btn_move.Text = "直　走";
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // btn_left90
            // 
            this.btn_left90.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_left90.Location = new System.Drawing.Point(3, 97);
            this.btn_left90.Name = "btn_left90";
            this.btn_left90.Size = new System.Drawing.Size(129, 93);
            this.btn_left90.TabIndex = 5;
            this.btn_left90.Text = "左 90°";
            this.btn_left90.UseVisualStyleBackColor = true;
            this.btn_left90.Click += new System.EventHandler(this.btn_left90_Click);
            // 
            // btn_right90s
            // 
            this.btn_right90s.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_right90s.Location = new System.Drawing.Point(511, 97);
            this.btn_right90s.Name = "btn_right90s";
            this.btn_right90s.Size = new System.Drawing.Size(237, 93);
            this.btn_right90s.TabIndex = 7;
            this.btn_right90s.Text = "右 90°\r\n（轉盤不動）\r\n";
            this.btn_right90s.UseVisualStyleBackColor = true;
            this.btn_right90s.Click += new System.EventHandler(this.btn_right90s_Click);
            // 
            // btn_left180s
            // 
            this.btn_left180s.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_left180s.Location = new System.Drawing.Point(268, 196);
            this.btn_left180s.Name = "btn_left180s";
            this.btn_left180s.Size = new System.Drawing.Size(237, 93);
            this.btn_left180s.TabIndex = 8;
            this.btn_left180s.Text = "左 180°\r\n（轉盤不動）\r\n";
            this.btn_left180s.UseVisualStyleBackColor = true;
            this.btn_left180s.Click += new System.EventHandler(this.btn_left180s_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_sptImport);
            this.tabPage1.Controls.Add(this.btn_sptGotoCharger2);
            this.tabPage1.Controls.Add(this.btn_sptLeaveCharger2);
            this.tabPage1.Controls.Add(this.btn_sptLeaveCharger);
            this.tabPage1.Controls.Add(this.btn_sptGotoCharger);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.btn_sptL90s);
            this.tabPage1.Controls.Add(this.btn_sptR180s);
            this.tabPage1.Controls.Add(this.btn_sptR90);
            this.tabPage1.Controls.Add(this.btn_sptR180);
            this.tabPage1.Controls.Add(this.btn_sptL180);
            this.tabPage1.Controls.Add(this.btn_sptL90);
            this.tabPage1.Controls.Add(this.btn_sptL180s);
            this.tabPage1.Controls.Add(this.btn_sptR90s);
            this.tabPage1.Controls.Add(this.btn_sptWait);
            this.tabPage1.Controls.Add(this.numUD_sec);
            this.tabPage1.Controls.Add(this.btn_sptGo);
            this.tabPage1.Controls.Add(this.numUD_distance);
            this.tabPage1.Controls.Add(this.btn_sptClear);
            this.tabPage1.Controls.Add(this.btn_sptRemove);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_sptDelete);
            this.tabPage1.Controls.Add(this.comboBox_script);
            this.tabPage1.Controls.Add(this.btn_sptSave);
            this.tabPage1.Controls.Add(this.DGV_Script);
            this.tabPage1.Controls.Add(this.btn_sptStop);
            this.tabPage1.Controls.Add(this.btn_sptContinue);
            this.tabPage1.Controls.Add(this.btn_sptPause);
            this.tabPage1.Controls.Add(this.btn_sptActivate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(755, 542);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Script";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_sptImport
            // 
            this.btn_sptImport.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptImport.Location = new System.Drawing.Point(6, 490);
            this.btn_sptImport.Name = "btn_sptImport";
            this.btn_sptImport.Size = new System.Drawing.Size(246, 42);
            this.btn_sptImport.TabIndex = 41;
            this.btn_sptImport.Text = "Import Route";
            this.btn_sptImport.UseVisualStyleBackColor = true;
            this.btn_sptImport.Click += new System.EventHandler(this.btn_sptImport_Click);
            // 
            // btn_sptGotoCharger2
            // 
            this.btn_sptGotoCharger2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptGotoCharger2.Location = new System.Drawing.Point(258, 300);
            this.btn_sptGotoCharger2.Name = "btn_sptGotoCharger2";
            this.btn_sptGotoCharger2.Size = new System.Drawing.Size(238, 38);
            this.btn_sptGotoCharger2.TabIndex = 40;
            this.btn_sptGotoCharger2.Text = "進入充電站 [外]";
            this.btn_sptGotoCharger2.UseVisualStyleBackColor = true;
            this.btn_sptGotoCharger2.Click += new System.EventHandler(this.btn_sptGotoCharger2_Click);
            // 
            // btn_sptLeaveCharger2
            // 
            this.btn_sptLeaveCharger2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptLeaveCharger2.Location = new System.Drawing.Point(258, 398);
            this.btn_sptLeaveCharger2.Name = "btn_sptLeaveCharger2";
            this.btn_sptLeaveCharger2.Size = new System.Drawing.Size(237, 38);
            this.btn_sptLeaveCharger2.TabIndex = 39;
            this.btn_sptLeaveCharger2.Text = "離開充電站 [外]";
            this.btn_sptLeaveCharger2.UseVisualStyleBackColor = true;
            this.btn_sptLeaveCharger2.Click += new System.EventHandler(this.btn_sptLeaveCharger2_Click);
            // 
            // btn_sptLeaveCharger
            // 
            this.btn_sptLeaveCharger.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptLeaveCharger.Location = new System.Drawing.Point(258, 354);
            this.btn_sptLeaveCharger.Name = "btn_sptLeaveCharger";
            this.btn_sptLeaveCharger.Size = new System.Drawing.Size(238, 38);
            this.btn_sptLeaveCharger.TabIndex = 38;
            this.btn_sptLeaveCharger.Text = "離開充電站 [內]";
            this.btn_sptLeaveCharger.UseVisualStyleBackColor = true;
            this.btn_sptLeaveCharger.Click += new System.EventHandler(this.btn_sptLeaveCharger_Click);
            // 
            // btn_sptGotoCharger
            // 
            this.btn_sptGotoCharger.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptGotoCharger.Location = new System.Drawing.Point(258, 256);
            this.btn_sptGotoCharger.Name = "btn_sptGotoCharger";
            this.btn_sptGotoCharger.Size = new System.Drawing.Size(238, 38);
            this.btn_sptGotoCharger.TabIndex = 37;
            this.btn_sptGotoCharger.Text = "進入充電站 [內]";
            this.btn_sptGotoCharger.UseVisualStyleBackColor = true;
            this.btn_sptGotoCharger.Click += new System.EventHandler(this.btn_sptGotoCharger_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Linen;
            this.flowLayoutPanel1.Controls.Add(this.btn_sptUp);
            this.flowLayoutPanel1.Controls.Add(this.btn_sptDown);
            this.flowLayoutPanel1.Controls.Add(this.btn_sptSL90);
            this.flowLayoutPanel1.Controls.Add(this.btn_sptSR90);
            this.flowLayoutPanel1.Controls.Add(this.btn_sptSL180);
            this.flowLayoutPanel1.Controls.Add(this.btn_sptSR180);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(502, 255);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(244, 181);
            this.flowLayoutPanel1.TabIndex = 36;
            // 
            // btn_sptUp
            // 
            this.btn_sptUp.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptUp.Location = new System.Drawing.Point(3, 3);
            this.btn_sptUp.Name = "btn_sptUp";
            this.btn_sptUp.Size = new System.Drawing.Size(116, 45);
            this.btn_sptUp.TabIndex = 31;
            this.btn_sptUp.Text = "頂升貨架";
            this.btn_sptUp.UseVisualStyleBackColor = true;
            this.btn_sptUp.Click += new System.EventHandler(this.btn_sptUp_Click);
            // 
            // btn_sptDown
            // 
            this.btn_sptDown.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptDown.Location = new System.Drawing.Point(125, 3);
            this.btn_sptDown.Name = "btn_sptDown";
            this.btn_sptDown.Size = new System.Drawing.Size(116, 45);
            this.btn_sptDown.TabIndex = 33;
            this.btn_sptDown.Text = "放下貨架";
            this.btn_sptDown.UseVisualStyleBackColor = true;
            this.btn_sptDown.Click += new System.EventHandler(this.btn_sptDown_Click);
            // 
            // btn_sptSL90
            // 
            this.btn_sptSL90.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptSL90.Location = new System.Drawing.Point(3, 54);
            this.btn_sptSL90.Name = "btn_sptSL90";
            this.btn_sptSL90.Size = new System.Drawing.Size(116, 58);
            this.btn_sptSL90.TabIndex = 35;
            this.btn_sptSL90.Text = "圓盤\r\n左 90°";
            this.btn_sptSL90.UseVisualStyleBackColor = true;
            this.btn_sptSL90.Click += new System.EventHandler(this.btn_sptSL90_Click);
            // 
            // btn_sptSR90
            // 
            this.btn_sptSR90.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptSR90.Location = new System.Drawing.Point(125, 54);
            this.btn_sptSR90.Name = "btn_sptSR90";
            this.btn_sptSR90.Size = new System.Drawing.Size(116, 58);
            this.btn_sptSR90.TabIndex = 32;
            this.btn_sptSR90.Text = "圓盤\r\n右 90°";
            this.btn_sptSR90.UseVisualStyleBackColor = true;
            this.btn_sptSR90.Click += new System.EventHandler(this.btn_sptSR90_Click);
            // 
            // btn_sptSL180
            // 
            this.btn_sptSL180.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptSL180.Location = new System.Drawing.Point(3, 118);
            this.btn_sptSL180.Name = "btn_sptSL180";
            this.btn_sptSL180.Size = new System.Drawing.Size(116, 58);
            this.btn_sptSL180.TabIndex = 34;
            this.btn_sptSL180.Text = "圓盤\r\n左 180°";
            this.btn_sptSL180.UseVisualStyleBackColor = true;
            this.btn_sptSL180.Click += new System.EventHandler(this.btn_sptSL180_Click);
            // 
            // btn_sptSR180
            // 
            this.btn_sptSR180.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptSR180.Location = new System.Drawing.Point(125, 118);
            this.btn_sptSR180.Name = "btn_sptSR180";
            this.btn_sptSR180.Size = new System.Drawing.Size(116, 58);
            this.btn_sptSR180.TabIndex = 30;
            this.btn_sptSR180.Text = "圓盤\r\n右 180°";
            this.btn_sptSR180.UseVisualStyleBackColor = true;
            this.btn_sptSR180.Click += new System.EventHandler(this.btn_sptSR180_Click);
            // 
            // btn_sptL90s
            // 
            this.btn_sptL90s.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptL90s.Location = new System.Drawing.Point(258, 128);
            this.btn_sptL90s.Name = "btn_sptL90s";
            this.btn_sptL90s.Size = new System.Drawing.Size(116, 58);
            this.btn_sptL90s.TabIndex = 29;
            this.btn_sptL90s.Text = "左 90°\r\n（轉盤不動）";
            this.btn_sptL90s.UseVisualStyleBackColor = true;
            this.btn_sptL90s.Click += new System.EventHandler(this.btn_sptL90s_Click);
            // 
            // btn_sptR180s
            // 
            this.btn_sptR180s.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptR180s.Location = new System.Drawing.Point(380, 192);
            this.btn_sptR180s.Name = "btn_sptR180s";
            this.btn_sptR180s.Size = new System.Drawing.Size(116, 58);
            this.btn_sptR180s.TabIndex = 26;
            this.btn_sptR180s.Text = "右 180°\r\n（轉盤不動）\r\n";
            this.btn_sptR180s.UseVisualStyleBackColor = true;
            this.btn_sptR180s.Click += new System.EventHandler(this.btn_sptR180s_Click);
            // 
            // btn_sptR90
            // 
            this.btn_sptR90.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptR90.Location = new System.Drawing.Point(624, 128);
            this.btn_sptR90.Name = "btn_sptR90";
            this.btn_sptR90.Size = new System.Drawing.Size(116, 58);
            this.btn_sptR90.TabIndex = 23;
            this.btn_sptR90.Text = "右 90°";
            this.btn_sptR90.UseVisualStyleBackColor = true;
            this.btn_sptR90.Click += new System.EventHandler(this.btn_sptR90_Click);
            // 
            // btn_sptR180
            // 
            this.btn_sptR180.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptR180.Location = new System.Drawing.Point(624, 191);
            this.btn_sptR180.Name = "btn_sptR180";
            this.btn_sptR180.Size = new System.Drawing.Size(116, 58);
            this.btn_sptR180.TabIndex = 22;
            this.btn_sptR180.Text = "右 180°";
            this.btn_sptR180.UseVisualStyleBackColor = true;
            this.btn_sptR180.Click += new System.EventHandler(this.btn_sptR180_Click);
            // 
            // btn_sptL180
            // 
            this.btn_sptL180.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptL180.Location = new System.Drawing.Point(502, 192);
            this.btn_sptL180.Name = "btn_sptL180";
            this.btn_sptL180.Size = new System.Drawing.Size(116, 58);
            this.btn_sptL180.TabIndex = 24;
            this.btn_sptL180.Text = "左 180°";
            this.btn_sptL180.UseVisualStyleBackColor = true;
            this.btn_sptL180.Click += new System.EventHandler(this.btn_sptL180_Click);
            // 
            // btn_sptL90
            // 
            this.btn_sptL90.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptL90.Location = new System.Drawing.Point(502, 128);
            this.btn_sptL90.Name = "btn_sptL90";
            this.btn_sptL90.Size = new System.Drawing.Size(116, 58);
            this.btn_sptL90.TabIndex = 25;
            this.btn_sptL90.Text = "左 90°";
            this.btn_sptL90.UseVisualStyleBackColor = true;
            this.btn_sptL90.Click += new System.EventHandler(this.btn_sptL90_Click);
            // 
            // btn_sptL180s
            // 
            this.btn_sptL180s.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptL180s.Location = new System.Drawing.Point(258, 192);
            this.btn_sptL180s.Name = "btn_sptL180s";
            this.btn_sptL180s.Size = new System.Drawing.Size(116, 58);
            this.btn_sptL180s.TabIndex = 28;
            this.btn_sptL180s.Text = "左 180°\r\n（轉盤不動）\r\n";
            this.btn_sptL180s.UseVisualStyleBackColor = true;
            this.btn_sptL180s.Click += new System.EventHandler(this.btn_sptL180s_Click);
            // 
            // btn_sptR90s
            // 
            this.btn_sptR90s.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptR90s.Location = new System.Drawing.Point(380, 128);
            this.btn_sptR90s.Name = "btn_sptR90s";
            this.btn_sptR90s.Size = new System.Drawing.Size(116, 58);
            this.btn_sptR90s.TabIndex = 27;
            this.btn_sptR90s.Text = "右 90°\r\n（轉盤不動）\r\n";
            this.btn_sptR90s.UseVisualStyleBackColor = true;
            this.btn_sptR90s.Click += new System.EventHandler(this.btn_sptR90s_Click);
            // 
            // btn_sptWait
            // 
            this.btn_sptWait.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptWait.Location = new System.Drawing.Point(547, 93);
            this.btn_sptWait.Name = "btn_sptWait";
            this.btn_sptWait.Size = new System.Drawing.Size(193, 29);
            this.btn_sptWait.TabIndex = 21;
            this.btn_sptWait.Text = "Wait";
            this.btn_sptWait.UseVisualStyleBackColor = true;
            this.btn_sptWait.Click += new System.EventHandler(this.btn_sptWait_Click);
            // 
            // numUD_sec
            // 
            this.numUD_sec.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numUD_sec.Location = new System.Drawing.Point(502, 92);
            this.numUD_sec.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numUD_sec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD_sec.Name = "numUD_sec";
            this.numUD_sec.Size = new System.Drawing.Size(39, 29);
            this.numUD_sec.TabIndex = 20;
            this.numUD_sec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUD_sec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_sptGo
            // 
            this.btn_sptGo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptGo.Location = new System.Drawing.Point(303, 93);
            this.btn_sptGo.Name = "btn_sptGo";
            this.btn_sptGo.Size = new System.Drawing.Size(193, 29);
            this.btn_sptGo.TabIndex = 19;
            this.btn_sptGo.Text = "Move";
            this.btn_sptGo.UseVisualStyleBackColor = true;
            this.btn_sptGo.Click += new System.EventHandler(this.btn_sptGo_Click);
            // 
            // numUD_distance
            // 
            this.numUD_distance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numUD_distance.Location = new System.Drawing.Point(258, 92);
            this.numUD_distance.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numUD_distance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD_distance.Name = "numUD_distance";
            this.numUD_distance.Size = new System.Drawing.Size(39, 29);
            this.numUD_distance.TabIndex = 18;
            this.numUD_distance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUD_distance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_sptClear
            // 
            this.btn_sptClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptClear.Location = new System.Drawing.Point(502, 29);
            this.btn_sptClear.Name = "btn_sptClear";
            this.btn_sptClear.Size = new System.Drawing.Size(238, 57);
            this.btn_sptClear.TabIndex = 17;
            this.btn_sptClear.Text = "Clear All";
            this.btn_sptClear.UseVisualStyleBackColor = true;
            this.btn_sptClear.Click += new System.EventHandler(this.btn_sptClear_Click);
            // 
            // btn_sptRemove
            // 
            this.btn_sptRemove.BackColor = System.Drawing.Color.Transparent;
            this.btn_sptRemove.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptRemove.Location = new System.Drawing.Point(258, 29);
            this.btn_sptRemove.Name = "btn_sptRemove";
            this.btn_sptRemove.Size = new System.Drawing.Size(238, 58);
            this.btn_sptRemove.TabIndex = 16;
            this.btn_sptRemove.Text = "Remove";
            this.btn_sptRemove.UseVisualStyleBackColor = false;
            this.btn_sptRemove.Click += new System.EventHandler(this.btn_sptRemove_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(258, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "[ Command ]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "[ Script ]";
            // 
            // btn_sptDelete
            // 
            this.btn_sptDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptDelete.Location = new System.Drawing.Point(183, 33);
            this.btn_sptDelete.Name = "btn_sptDelete";
            this.btn_sptDelete.Size = new System.Drawing.Size(69, 28);
            this.btn_sptDelete.TabIndex = 7;
            this.btn_sptDelete.Text = "Delete";
            this.btn_sptDelete.UseVisualStyleBackColor = true;
            this.btn_sptDelete.Click += new System.EventHandler(this.btn_sptDelete_Click);
            // 
            // comboBox_script
            // 
            this.comboBox_script.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_script.FormattingEnabled = true;
            this.comboBox_script.Location = new System.Drawing.Point(6, 34);
            this.comboBox_script.Name = "comboBox_script";
            this.comboBox_script.Size = new System.Drawing.Size(171, 28);
            this.comboBox_script.TabIndex = 6;
            this.comboBox_script.SelectedIndexChanged += new System.EventHandler(this.comboBox_script_SelectedIndexChanged);
            // 
            // btn_sptSave
            // 
            this.btn_sptSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptSave.Location = new System.Drawing.Point(183, 3);
            this.btn_sptSave.Name = "btn_sptSave";
            this.btn_sptSave.Size = new System.Drawing.Size(69, 25);
            this.btn_sptSave.TabIndex = 5;
            this.btn_sptSave.Text = "Save";
            this.btn_sptSave.UseVisualStyleBackColor = true;
            this.btn_sptSave.Click += new System.EventHandler(this.btn_sptSave_Click);
            // 
            // DGV_Script
            // 
            this.DGV_Script.AllowUserToAddRows = false;
            this.DGV_Script.AllowUserToDeleteRows = false;
            this.DGV_Script.AllowUserToResizeColumns = false;
            this.DGV_Script.AllowUserToResizeRows = false;
            this.DGV_Script.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Script.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Script.Location = new System.Drawing.Point(6, 68);
            this.DGV_Script.MultiSelect = false;
            this.DGV_Script.Name = "DGV_Script";
            this.DGV_Script.ReadOnly = true;
            this.DGV_Script.RowHeadersVisible = false;
            this.DGV_Script.RowHeadersWidth = 62;
            this.DGV_Script.RowTemplate.Height = 24;
            this.DGV_Script.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Script.Size = new System.Drawing.Size(246, 416);
            this.DGV_Script.TabIndex = 4;
            // 
            // btn_sptStop
            // 
            this.btn_sptStop.BackColor = System.Drawing.Color.Tomato;
            this.btn_sptStop.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptStop.Location = new System.Drawing.Point(258, 490);
            this.btn_sptStop.Name = "btn_sptStop";
            this.btn_sptStop.Size = new System.Drawing.Size(362, 42);
            this.btn_sptStop.TabIndex = 3;
            this.btn_sptStop.Text = "Stop";
            this.btn_sptStop.UseVisualStyleBackColor = false;
            this.btn_sptStop.Click += new System.EventHandler(this.btn_sStop_Click);
            // 
            // btn_sptContinue
            // 
            this.btn_sptContinue.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_sptContinue.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptContinue.Location = new System.Drawing.Point(626, 490);
            this.btn_sptContinue.Name = "btn_sptContinue";
            this.btn_sptContinue.Size = new System.Drawing.Size(120, 42);
            this.btn_sptContinue.TabIndex = 2;
            this.btn_sptContinue.Text = "Continue";
            this.btn_sptContinue.UseVisualStyleBackColor = false;
            this.btn_sptContinue.Click += new System.EventHandler(this.btn_sContinue_Click);
            // 
            // btn_sptPause
            // 
            this.btn_sptPause.BackColor = System.Drawing.Color.Gold;
            this.btn_sptPause.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptPause.Location = new System.Drawing.Point(626, 442);
            this.btn_sptPause.Name = "btn_sptPause";
            this.btn_sptPause.Size = new System.Drawing.Size(120, 42);
            this.btn_sptPause.TabIndex = 1;
            this.btn_sptPause.Text = "Pause";
            this.btn_sptPause.UseVisualStyleBackColor = false;
            this.btn_sptPause.Click += new System.EventHandler(this.btn_sPause_Click);
            // 
            // btn_sptActivate
            // 
            this.btn_sptActivate.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_sptActivate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sptActivate.Location = new System.Drawing.Point(258, 442);
            this.btn_sptActivate.Name = "btn_sptActivate";
            this.btn_sptActivate.Size = new System.Drawing.Size(362, 42);
            this.btn_sptActivate.TabIndex = 0;
            this.btn_sptActivate.Text = "Activate";
            this.btn_sptActivate.UseVisualStyleBackColor = false;
            this.btn_sptActivate.Click += new System.EventHandler(this.btn_sActivate_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.listbox_AGVinfo);
            this.tabPage3.Controls.Add(this.WebAPI);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(755, 542);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Info";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Enabled = true;
            this.update.Interval = 2000;
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // listbox_shelves
            // 
            this.listbox_shelves.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listbox_shelves.FormattingEnabled = true;
            this.listbox_shelves.ItemHeight = 20;
            this.listbox_shelves.Location = new System.Drawing.Point(12, 425);
            this.listbox_shelves.Name = "listbox_shelves";
            this.listbox_shelves.Size = new System.Drawing.Size(116, 144);
            this.listbox_shelves.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F);
            this.label6.Location = new System.Drawing.Point(9, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Shelves：";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(230, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 58);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(134, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 58);
            this.button2.TabIndex = 14;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1586, 577);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listbox_shelves);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGV_map);
            this.Controls.Add(this.listbox_Log);
            this.Font = new System.Drawing.Font("新細明體", 9F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_map)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUD_sec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_distance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Script)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listbox_AGV;
        private System.Windows.Forms.ListBox listbox_AGVinfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listbox_Log;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGV_map;
        private System.Windows.Forms.Button WebAPI;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_ServoOn;
        private System.Windows.Forms.Button btn_ServoOff;
        private System.Windows.Forms.Button btn_left90s;
        private System.Windows.Forms.Button btn_left180s;
        private System.Windows.Forms.Button btn_right90s;
        private System.Windows.Forms.Button btn_right180s;
        private System.Windows.Forms.Button btn_left90;
        private System.Windows.Forms.Button btn_left180;
        private System.Windows.Forms.Button btn_right90;
        private System.Windows.Forms.Button btn_right180;
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Button btn_leaveCharger;
        private System.Windows.Forms.Button btn_gotoCharger;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_STOP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_sR90;
        private System.Windows.Forms.Button btn_sR180;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_sL180;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_sL90;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sptDelete;
        private System.Windows.Forms.ComboBox comboBox_script;
        private System.Windows.Forms.Button btn_sptSave;
        private System.Windows.Forms.DataGridView DGV_Script;
        private System.Windows.Forms.Button btn_sptStop;
        private System.Windows.Forms.Button btn_sptContinue;
        private System.Windows.Forms.Button btn_sptPause;
        private System.Windows.Forms.Button btn_sptActivate;
        private System.Windows.Forms.Button btn_sptWait;
        private System.Windows.Forms.NumericUpDown numUD_sec;
        private System.Windows.Forms.Button btn_sptGo;
        private System.Windows.Forms.NumericUpDown numUD_distance;
        private System.Windows.Forms.Button btn_sptClear;
        private System.Windows.Forms.Button btn_sptRemove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_sptSR90;
        private System.Windows.Forms.Button btn_sptSR180;
        private System.Windows.Forms.Button btn_sptDown;
        private System.Windows.Forms.Button btn_sptSL180;
        private System.Windows.Forms.Button btn_sptSL90;
        private System.Windows.Forms.Button btn_sptUp;
        private System.Windows.Forms.Button btn_sptL90s;
        private System.Windows.Forms.Button btn_sptR180s;
        private System.Windows.Forms.Button btn_sptR90;
        private System.Windows.Forms.Button btn_sptR180;
        private System.Windows.Forms.Button btn_sptL180;
        private System.Windows.Forms.Button btn_sptL90;
        private System.Windows.Forms.Button btn_sptL180s;
        private System.Windows.Forms.Button btn_sptR90s;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_leaveCharger2;
        private System.Windows.Forms.Button btn_sptLeaveCharger2;
        private System.Windows.Forms.Button btn_sptLeaveCharger;
        private System.Windows.Forms.Button btn_sptGotoCharger;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btn_gotoCharger2;
        private System.Windows.Forms.Button btn_sptGotoCharger2;
        private System.Windows.Forms.Button btn_sptImport;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_oneCliktoCharger;
        private System.Windows.Forms.ListBox listbox_shelves;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

