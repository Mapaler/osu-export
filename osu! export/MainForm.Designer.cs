namespace osu__export
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnBrowserOsu = new System.Windows.Forms.Button();
            this.btmBrowserExport = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpMusic = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.trkVBRQuality = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimeLimit = new System.Windows.Forms.TextBox();
            this.chkSkipShort = new System.Windows.Forms.CheckBox();
            this.chkConvertToMp3 = new System.Windows.Forms.CheckBox();
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbResizeMode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaxHeight = new System.Windows.Forms.TextBox();
            this.txtMaxWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkResize = new System.Windows.Forms.CheckBox();
            this.chkCovertToJpg = new System.Windows.Forms.CheckBox();
            this.pgsBrate = new System.Windows.Forms.ProgressBar();
            this.txtSongs = new System.Windows.Forms.TextBox();
            this.txtExport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbID3Mode = new System.Windows.Forms.ComboBox();
            this.chkRewriteImg = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.chkCoverImg = new System.Windows.Forms.CheckBox();
            this.chkID3v2 = new System.Windows.Forms.CheckBox();
            this.chkID3v1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.chkUnicode = new System.Windows.Forms.CheckBox();
            this.chkNoID = new System.Windows.Forms.CheckBox();
            this.chkMulty = new System.Windows.Forms.CheckBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSkipExsist = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVBRQuality)).BeginInit();
            this.grpImage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowserOsu
            // 
            this.btnBrowserOsu.Location = new System.Drawing.Point(291, 27);
            this.btnBrowserOsu.Name = "btnBrowserOsu";
            this.btnBrowserOsu.Size = new System.Drawing.Size(75, 23);
            this.btnBrowserOsu.TabIndex = 0;
            this.btnBrowserOsu.Text = "浏览";
            this.btnBrowserOsu.UseVisualStyleBackColor = true;
            this.btnBrowserOsu.Click += new System.EventHandler(this.btnBrowserOsu_Click);
            // 
            // btmBrowserExport
            // 
            this.btmBrowserExport.Location = new System.Drawing.Point(291, 69);
            this.btmBrowserExport.Name = "btmBrowserExport";
            this.btmBrowserExport.Size = new System.Drawing.Size(75, 23);
            this.btmBrowserExport.TabIndex = 1;
            this.btmBrowserExport.Text = "浏览";
            this.btmBrowserExport.UseVisualStyleBackColor = true;
            this.btmBrowserExport.Click += new System.EventHandler(this.btmBrowserExport_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(372, 387);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(170, 36);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpMusic
            // 
            this.grpMusic.Controls.Add(this.label13);
            this.grpMusic.Controls.Add(this.label11);
            this.grpMusic.Controls.Add(this.label12);
            this.grpMusic.Controls.Add(this.trkVBRQuality);
            this.grpMusic.Controls.Add(this.label4);
            this.grpMusic.Controls.Add(this.txtTimeLimit);
            this.grpMusic.Controls.Add(this.chkSkipShort);
            this.grpMusic.Controls.Add(this.chkConvertToMp3);
            this.grpMusic.Location = new System.Drawing.Point(9, 277);
            this.grpMusic.Name = "grpMusic";
            this.grpMusic.Size = new System.Drawing.Size(168, 152);
            this.grpMusic.TabIndex = 3;
            this.grpMusic.TabStop = false;
            this.grpMusic.Text = "音频处理选项";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(133, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 18;
            this.label13.Text = "最差";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "VBR质量";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 17;
            this.label12.Text = "最好";
            // 
            // trkVBRQuality
            // 
            this.trkVBRQuality.Location = new System.Drawing.Point(65, 37);
            this.trkVBRQuality.Name = "trkVBRQuality";
            this.trkVBRQuality.Size = new System.Drawing.Size(98, 45);
            this.trkVBRQuality.TabIndex = 4;
            this.trkVBRQuality.Value = 2;
            this.trkVBRQuality.Scroll += new System.EventHandler(this.trkVBRQuality_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "秒";
            // 
            // txtTimeLimit
            // 
            this.txtTimeLimit.Enabled = false;
            this.txtTimeLimit.Location = new System.Drawing.Point(61, 113);
            this.txtTimeLimit.Name = "txtTimeLimit";
            this.txtTimeLimit.Size = new System.Drawing.Size(49, 21);
            this.txtTimeLimit.TabIndex = 2;
            this.txtTimeLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimeLimit_KeyPress);
            // 
            // chkSkipShort
            // 
            this.chkSkipShort.AutoSize = true;
            this.chkSkipShort.Location = new System.Drawing.Point(6, 91);
            this.chkSkipShort.Name = "chkSkipShort";
            this.chkSkipShort.Size = new System.Drawing.Size(144, 16);
            this.chkSkipShort.TabIndex = 1;
            this.chkSkipShort.Text = "跳过小于此长度的音频";
            this.chkSkipShort.UseVisualStyleBackColor = true;
            this.chkSkipShort.CheckedChanged += new System.EventHandler(this.chkSkipShort_CheckedChanged);
            // 
            // chkConvertToMp3
            // 
            this.chkConvertToMp3.AutoSize = true;
            this.chkConvertToMp3.Checked = true;
            this.chkConvertToMp3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConvertToMp3.Location = new System.Drawing.Point(6, 20);
            this.chkConvertToMp3.Name = "chkConvertToMp3";
            this.chkConvertToMp3.Size = new System.Drawing.Size(102, 16);
            this.chkConvertToMp3.TabIndex = 0;
            this.chkConvertToMp3.Text = "转换为mp3格式";
            this.chkConvertToMp3.UseVisualStyleBackColor = true;
            this.chkConvertToMp3.CheckedChanged += new System.EventHandler(this.chkConvertToMp3_CheckedChanged);
            // 
            // grpImage
            // 
            this.grpImage.Controls.Add(this.label9);
            this.grpImage.Controls.Add(this.cmbResizeMode);
            this.grpImage.Controls.Add(this.label8);
            this.grpImage.Controls.Add(this.label7);
            this.grpImage.Controls.Add(this.txtMaxHeight);
            this.grpImage.Controls.Add(this.txtMaxWidth);
            this.grpImage.Controls.Add(this.label6);
            this.grpImage.Controls.Add(this.label5);
            this.grpImage.Controls.Add(this.chkResize);
            this.grpImage.Controls.Add(this.chkCovertToJpg);
            this.grpImage.Location = new System.Drawing.Point(183, 277);
            this.grpImage.Name = "grpImage";
            this.grpImage.Size = new System.Drawing.Size(168, 152);
            this.grpImage.TabIndex = 4;
            this.grpImage.TabStop = false;
            this.grpImage.Text = "图片处理选项";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "缩放模式";
            // 
            // cmbResizeMode
            // 
            this.cmbResizeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResizeMode.Enabled = false;
            this.cmbResizeMode.FormattingEnabled = true;
            this.cmbResizeMode.Items.AddRange(new object[] {
            "填充",
            "适应",
            "拉伸"});
            this.cmbResizeMode.Location = new System.Drawing.Point(89, 110);
            this.cmbResizeMode.Name = "cmbResizeMode";
            this.cmbResizeMode.Size = new System.Drawing.Size(66, 20);
            this.cmbResizeMode.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "像素";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "像素";
            // 
            // txtMaxHeight
            // 
            this.txtMaxHeight.Enabled = false;
            this.txtMaxHeight.Location = new System.Drawing.Point(53, 86);
            this.txtMaxHeight.Name = "txtMaxHeight";
            this.txtMaxHeight.Size = new System.Drawing.Size(49, 21);
            this.txtMaxHeight.TabIndex = 5;
            this.txtMaxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxHeight_KeyPress);
            // 
            // txtMaxWidth
            // 
            this.txtMaxWidth.Enabled = false;
            this.txtMaxWidth.Location = new System.Drawing.Point(53, 61);
            this.txtMaxWidth.Name = "txtMaxWidth";
            this.txtMaxWidth.Size = new System.Drawing.Size(49, 21);
            this.txtMaxWidth.TabIndex = 4;
            this.txtMaxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxWidth_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "高";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "宽";
            // 
            // chkResize
            // 
            this.chkResize.AutoSize = true;
            this.chkResize.Location = new System.Drawing.Point(6, 42);
            this.chkResize.Name = "chkResize";
            this.chkResize.Size = new System.Drawing.Size(72, 16);
            this.chkResize.TabIndex = 1;
            this.chkResize.Text = "限制大小";
            this.chkResize.UseVisualStyleBackColor = true;
            this.chkResize.CheckedChanged += new System.EventHandler(this.chkResize_CheckedChanged);
            // 
            // chkCovertToJpg
            // 
            this.chkCovertToJpg.AutoSize = true;
            this.chkCovertToJpg.Checked = true;
            this.chkCovertToJpg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCovertToJpg.Location = new System.Drawing.Point(6, 20);
            this.chkCovertToJpg.Name = "chkCovertToJpg";
            this.chkCovertToJpg.Size = new System.Drawing.Size(102, 16);
            this.chkCovertToJpg.TabIndex = 0;
            this.chkCovertToJpg.Text = "转换为jpg格式";
            this.chkCovertToJpg.UseVisualStyleBackColor = true;
            // 
            // pgsBrate
            // 
            this.pgsBrate.Location = new System.Drawing.Point(372, 24);
            this.pgsBrate.Name = "pgsBrate";
            this.pgsBrate.Size = new System.Drawing.Size(606, 23);
            this.pgsBrate.TabIndex = 5;
            // 
            // txtSongs
            // 
            this.txtSongs.Location = new System.Drawing.Point(12, 29);
            this.txtSongs.Name = "txtSongs";
            this.txtSongs.Size = new System.Drawing.Size(273, 21);
            this.txtSongs.TabIndex = 7;
            // 
            // txtExport
            // 
            this.txtExport.Location = new System.Drawing.Point(12, 71);
            this.txtExport.Name = "txtExport";
            this.txtExport.Size = new System.Drawing.Size(273, 21);
            this.txtExport.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "osu!曲库目录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "导出目录";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "进度";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbID3Mode);
            this.groupBox3.Controls.Add(this.chkRewriteImg);
            this.groupBox3.Controls.Add(this.checkBox11);
            this.groupBox3.Controls.Add(this.chkCoverImg);
            this.groupBox3.Controls.Add(this.chkID3v2);
            this.groupBox3.Controls.Add(this.chkID3v1);
            this.groupBox3.Location = new System.Drawing.Point(183, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 173);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "mp3 ID3选项";
            // 
            // cmbID3Mode
            // 
            this.cmbID3Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbID3Mode.FormattingEnabled = true;
            this.cmbID3Mode.Items.AddRange(new object[] {
            "覆盖所有信息",
            "不覆盖非英文信息",
            "不覆盖已存在信息"});
            this.cmbID3Mode.Location = new System.Drawing.Point(6, 62);
            this.cmbID3Mode.Name = "cmbID3Mode";
            this.cmbID3Mode.Size = new System.Drawing.Size(156, 20);
            this.cmbID3Mode.TabIndex = 8;
            // 
            // chkRewriteImg
            // 
            this.chkRewriteImg.AutoSize = true;
            this.chkRewriteImg.Checked = true;
            this.chkRewriteImg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRewriteImg.Location = new System.Drawing.Point(29, 110);
            this.chkRewriteImg.Name = "chkRewriteImg";
            this.chkRewriteImg.Size = new System.Drawing.Size(108, 16);
            this.chkRewriteImg.TabIndex = 6;
            this.chkRewriteImg.Text = "覆盖已存在图片";
            this.chkRewriteImg.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(6, 132);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(108, 28);
            this.checkBox11.TabIndex = 4;
            this.checkBox11.Text = "判断已存在数据\r\n是否为日文乱码";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.Visible = false;
            // 
            // chkCoverImg
            // 
            this.chkCoverImg.AutoSize = true;
            this.chkCoverImg.Checked = true;
            this.chkCoverImg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCoverImg.Location = new System.Drawing.Point(6, 88);
            this.chkCoverImg.Name = "chkCoverImg";
            this.chkCoverImg.Size = new System.Drawing.Size(120, 16);
            this.chkCoverImg.TabIndex = 2;
            this.chkCoverImg.Text = "加入专辑封面图片";
            this.chkCoverImg.UseVisualStyleBackColor = true;
            this.chkCoverImg.CheckedChanged += new System.EventHandler(this.chkCoverImg_CheckedChanged);
            // 
            // chkID3v2
            // 
            this.chkID3v2.AutoSize = true;
            this.chkID3v2.Checked = true;
            this.chkID3v2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkID3v2.Location = new System.Drawing.Point(6, 40);
            this.chkID3v2.Name = "chkID3v2";
            this.chkID3v2.Size = new System.Drawing.Size(90, 16);
            this.chkID3v2.TabIndex = 1;
            this.chkID3v2.Text = "加入ID3v2.3";
            this.chkID3v2.UseVisualStyleBackColor = true;
            // 
            // chkID3v1
            // 
            this.chkID3v1.AutoSize = true;
            this.chkID3v1.Checked = true;
            this.chkID3v1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkID3v1.Location = new System.Drawing.Point(6, 18);
            this.chkID3v1.Name = "chkID3v1";
            this.chkID3v1.Size = new System.Drawing.Size(78, 16);
            this.chkID3v1.TabIndex = 0;
            this.chkID3v1.Text = "加入ID3v1";
            this.chkID3v1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox15);
            this.groupBox4.Controls.Add(this.chkUnicode);
            this.groupBox4.Controls.Add(this.chkNoID);
            this.groupBox4.Controls.Add(this.chkMulty);
            this.groupBox4.Location = new System.Drawing.Point(9, 152);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 119);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "曲谱选项";
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Enabled = false;
            this.checkBox15.Location = new System.Drawing.Point(6, 85);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(144, 28);
            this.checkBox15.TabIndex = 7;
            this.checkBox15.Text = "未找到图片时自动使用\r\n文件夹下尺寸最大图片";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // chkUnicode
            // 
            this.chkUnicode.AutoSize = true;
            this.chkUnicode.Checked = true;
            this.chkUnicode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUnicode.Location = new System.Drawing.Point(6, 63);
            this.chkUnicode.Name = "chkUnicode";
            this.chkUnicode.Size = new System.Drawing.Size(108, 16);
            this.chkUnicode.TabIndex = 5;
            this.chkUnicode.Text = "使用原语言信息";
            this.chkUnicode.UseVisualStyleBackColor = true;
            // 
            // chkNoID
            // 
            this.chkNoID.AutoSize = true;
            this.chkNoID.Checked = true;
            this.chkNoID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNoID.Location = new System.Drawing.Point(6, 20);
            this.chkNoID.Name = "chkNoID";
            this.chkNoID.Size = new System.Drawing.Size(132, 16);
            this.chkNoID.TabIndex = 2;
            this.chkNoID.Text = "导出无编号信息图谱";
            this.chkNoID.UseVisualStyleBackColor = true;
            // 
            // chkMulty
            // 
            this.chkMulty.AutoSize = true;
            this.chkMulty.Enabled = false;
            this.chkMulty.Location = new System.Drawing.Point(6, 41);
            this.chkMulty.Name = "chkMulty";
            this.chkMulty.Size = new System.Drawing.Size(144, 16);
            this.chkMulty.TabIndex = 0;
            this.chkMulty.Text = "有多个音乐时导出多个";
            this.chkMulty.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(374, 71);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(604, 281);
            this.txtLog.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(374, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "临时的日志窗";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSkipExsist);
            this.groupBox1.Location = new System.Drawing.Point(9, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 47);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "一般选项";
            // 
            // chkSkipExsist
            // 
            this.chkSkipExsist.AutoSize = true;
            this.chkSkipExsist.Location = new System.Drawing.Point(8, 20);
            this.chkSkipExsist.Name = "chkSkipExsist";
            this.chkSkipExsist.Size = new System.Drawing.Size(108, 16);
            this.chkSkipExsist.TabIndex = 17;
            this.chkSkipExsist.Text = "跳过已导出音乐";
            this.chkSkipExsist.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 435);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExport);
            this.Controls.Add(this.txtSongs);
            this.Controls.Add(this.pgsBrate);
            this.Controls.Add(this.grpMusic);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btmBrowserExport);
            this.Controls.Add(this.btnBrowserOsu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "osu!曲库导出车载音乐工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMusic.ResumeLayout(false);
            this.grpMusic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVBRQuality)).EndInit();
            this.grpImage.ResumeLayout(false);
            this.grpImage.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowserOsu;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpMusic;
        private System.Windows.Forms.GroupBox grpImage;
        private System.Windows.Forms.ProgressBar pgsBrate;
        private System.Windows.Forms.Button btmBrowserExport;
        private System.Windows.Forms.TextBox txtExport;
        private System.Windows.Forms.TextBox txtSongs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimeLimit;
        private System.Windows.Forms.CheckBox chkSkipShort;
        private System.Windows.Forms.CheckBox chkConvertToMp3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkResize;
        private System.Windows.Forms.CheckBox chkCovertToJpg;
        private System.Windows.Forms.TextBox txtMaxWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaxHeight;
        private System.Windows.Forms.ComboBox cmbResizeMode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkID3v2;
        private System.Windows.Forms.CheckBox chkID3v1;
        private System.Windows.Forms.CheckBox chkCoverImg;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkMulty;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.CheckBox chkNoID;
        private System.Windows.Forms.CheckBox chkUnicode;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox chkRewriteImg;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.ComboBox cmbID3Mode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trkVBRQuality;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSkipExsist;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

