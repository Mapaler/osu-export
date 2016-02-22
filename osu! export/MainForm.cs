using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;

using IdSharp.AudioInfo;
using IdSharp.Tagging.ID3v1;
using IdSharp.Tagging.ID3v2;
using IdSharp.Tagging.ID3v2.Frames;
using IdSharp.Tagging.APEv2;

namespace osu__export
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrowserOsu_Click(object sender, EventArgs e)
        {
            var fsd = new FolderSelectDialog();
            //fsd.Title = "What to select";
            //fsd.InitialDirectory = @"c:\";
            if (fsd.ShowDialog(this.Handle))
            {
                this.txtSongs.Text = fsd.FileName;
            }
        }

        private void btmBrowserExport_Click(object sender, EventArgs e)
        {
            var fsd = new FolderSelectDialog();
            //fsd.Title = "What to select";
            //fsd.InitialDirectory = @"c:\";
            if (fsd.ShowDialog(this.Handle))
            {
                this.txtExport.Text = fsd.FileName;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
#if DEBUG
            this.txtSongs.Text = @"D:\CTFX\Documents\Visual Studio 2015\Projects\osu! export\export\";
            this.txtExport.Text = @"D:\CTFX\Documents\Visual Studio 2015\Projects\osu! export\export\debug";
#else

            //读注册表
            RegistryKey hkcr = Registry.ClassesRoot;

            RegistryKey osukey = hkcr.OpenSubKey(@"osu!");
            if (osukey == null) //如果该子键不存在
            {
                MessageBox.Show("未发现osu!安装文件夹");
                return;
            }
            RegistryKey commandkey = osukey.OpenSubKey("shell\\open\\command");

            string registData;
            //获取键值（默认键值，名留空）
            registData = (string)commandkey.GetValue("");
            
            //正则表达式取出目录地址
            Regex reg = new Regex("^\"([^\"]+\\\\)osu!\\.exe\".+");
            Match match = reg.Match(registData);
            string value = match.Groups[1].Value;
            this.txtSongs.Text = value + "Songs\\";
#endif
            this.Text += " v" + 
                Application.ProductVersion[0].ToString() + 
                Application.ProductVersion[1].ToString() +
                Application.ProductVersion[2].ToString() +
                Application.ProductVersion[3].ToString() +
                Application.ProductVersion[4].ToString();
            this.cmbResizeMode.SelectedIndex = 0;
            this.cmbID3Mode.SelectedIndex = 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string osuFolder = this.txtSongs.Text;
            string expFolder = this.txtExport.Text;

            if (!Directory.Exists(expFolder))
            {
                // 目录不存在，建立目录
                Directory.CreateDirectory(expFolder);
            }

            DirectoryInfo theFolder = new DirectoryInfo(osuFolder);
            DirectoryInfo[] dirInfo = theFolder.GetDirectories();

            int di =0;
            this.pgsBrate.Maximum = dirInfo.Length; //进度条总数
            string lblRateTxt;
            lblRateTxt = lblRate.Text;
            //遍历文件夹
            foreach (DirectoryInfo NextFolder in dirInfo)
            {
                di++;
                //if (di > 5) break;
                this.pgsBrate.Value = (di);
                Regex regID = new Regex("^\\d+ .+");
                if (this.chkNoID.Checked == false) //如果没选中导出无ID图谱
                {
                    if (!regID.IsMatch(NextFolder.Name)) //碰到不匹配数字开头的图谱
                    {
                        continue; //跳过本次循环
                    }
                }

                this.txtLog.AppendText("正在处理：" + di + "/" + dirInfo.Length + " - " + NextFolder.Name + "\r\n");

                lblRate.Text = lblRateTxt + " " + di + "/" + dirInfo.Length;
                FileInfo[] fileInfo = NextFolder.GetFiles();
                foreach (FileInfo NextFile in fileInfo)  //遍历文件
                {
                    if (NextFile.Extension == ".osu")
                    {
                        //读取地图信息数据
                        string mapTxt = File.ReadAllText(NextFile.FullName, Encoding.UTF8);

                        //获取音乐文件名，不知道为什么匹配行尾需要在前面加上\r
                        Regex regAudioFilename = new Regex("^\\[General\\][\\r\\n]+(?:^[^\\[].*$\\n)*^AudioFilename: *([^\\r\\n]+)", RegexOptions.Multiline);
                        Match matchAudioFilename = regAudioFilename.Match(mapTxt);
                        string valueAudioFilename = matchAudioFilename.Groups[1].Value;

                        FileInfo srcMusic = new FileInfo(NextFolder.FullName + "\\" + valueAudioFilename); //原始音乐文件
                        if (!srcMusic.Exists) //如果音乐文件不存在则跳过
                        {
                            this.txtLog.AppendText("错误：未发现音乐文件 " + NextFolder.Name + "\\" + NextFile.Name + "\r\n");
                            continue;
                        }

                        IAudioFile audioFile = AudioFile.Create(srcMusic.FullName, true);
                        string sTimeLimit;
                        int TimeLimit;
                        sTimeLimit = Regex.Replace(this.txtTimeLimit.Text, "\\D", "");
                        TimeLimit = sTimeLimit.Length > 0 ? Convert.ToInt32(sTimeLimit) : 0;
                        if (audioFile.TotalSeconds < TimeLimit) continue; //跳过短的

                        string trgExt;//目标音乐的扩展名
                        if (this.chkConvertToMp3.Checked)
                            trgExt = ".mp3";
                        else
                            trgExt = srcMusic.Extension;
                        FileInfo trgMusic = new FileInfo(expFolder + "\\" + NextFolder.Name + trgExt); //获取目标文件
                        if (this.chkSkipExsist.Checked && trgMusic.Exists) continue; //如果已存在则跳过

                        //转换根据选择或者复制
                        if (this.chkConvertToMp3.Checked && audioFile.FileType != AudioFileType.Mpeg)
                        {
                            this.txtLog.AppendText("正在转换格式 " + srcMusic.Name + " 到mp3\r\n");
                            ExcuteProcess("ffmpeg.exe", "-i \"" + srcMusic.FullName + "\" -q " + trkVBRQuality.Value + " -y \"" + trgMusic.FullName + "\"");
                        }
                        else
                            File.Copy(srcMusic.FullName, trgMusic.FullName, true);

                        //获取音乐背景图片
                        Regex regBackground = new Regex("^\\[Events\\][\\r\\n]+(?:^[^\\[].*$\\n)*^ *0 *, *\\d+ *, *\"([^\\r\\n]+)\"", RegexOptions.Multiline);
                        Match matchBackground = regBackground.Match(mapTxt);
                        string valueBackground = matchBackground.Groups[1].Value;
                        
                        FileInfo srcBgPic = new FileInfo(NextFolder.FullName + "\\" + valueBackground); //原始图片文件
                        if (!srcBgPic.Exists) //如果音乐文件不存在则跳过
                        {
                            this.txtLog.AppendText("错误：未发现背景图片文件 " + NextFolder.Name + "\\" + NextFile.Name +  "\r\n");
                        }

                        //获取标题
                        Regex regTitle = new Regex("^\\[Metadata\\][\\r\\n]+(?:^[^\\[].*$\\n)*^Title: *([^\\r\\n]*)", RegexOptions.Multiline);
                        Match matchTitle = regTitle.Match(mapTxt);
                        string valueTitle = matchTitle.Groups[1].Value;
                        //获取原标题
                        Regex regTitleUnicode = new Regex("^\\[Metadata\\][\\r\\n]+(?:^[^\\[].*$\\n)*^TitleUnicode: *([^\\r\\n]*)", RegexOptions.Multiline);
                        Match matchTitleUnicode = regTitleUnicode.Match(mapTxt);
                        string valueTitleUnicode = matchTitleUnicode.Groups[1].Value;
                        //获取艺术家
                        Regex regArtist = new Regex("^\\[Metadata\\][\\r\\n]+(?:^[^\\[].*$\\n)*^Artist: *([^\\r\\n]*)", RegexOptions.Multiline);
                        Match matchArtist = regArtist.Match(mapTxt);
                        string valueArtist = matchArtist.Groups[1].Value;
                        //获取原艺术家
                        Regex regArtistUnicode = new Regex("^\\[Metadata\\][\\r\\n]+(?:^[^\\[].*$\\n)*^ArtistUnicode: *([^\\r\\n]*)", RegexOptions.Multiline);
                        Match matchArtistUnicode = regArtistUnicode.Match(mapTxt);
                        string valueArtistUnicode = matchArtistUnicode.Groups[1].Value;
                        //获取来源
                        Regex regSource = new Regex("^\\[Metadata\\][\\r\\n]+(?:^[^\\[].*$\\n)*^Source: *([^\\r\\n]*)", RegexOptions.Multiline);
                        Match matchSource = regSource.Match(mapTxt);
                        string valueSource = matchSource.Groups[1].Value;

                        //开始读取TAG
                        //替换ID3v1
                        if (this.chkID3v1.Checked)
                        {
                            IID3v1Tag _id3v1;
                            _id3v1 = new ID3v1Tag(srcMusic.FullName);
                            _id3v1.TagVersion = ID3v1TagVersion.ID3v11;
                            if (this.cmbID3Mode.SelectedIndex == 0 || //全覆盖
                                _id3v1.Title == null || //数据为空时
                                (this.cmbID3Mode.SelectedIndex == 1 && (Regex.Replace(_id3v1.Title, "[\\x01-\\xFF]", "").Length < 1 || (valueTitleUnicode.Length > 1 && this.chkUnicode.Checked))) || //覆盖非英文
                                (this.cmbID3Mode.SelectedIndex == 2 && Regex.Replace(_id3v1.Title, "\\s", "").Length > 0)//不覆盖
                                )
                                _id3v1.Title = this.chkUnicode.Checked && valueTitleUnicode.Length > 1 ? valueTitleUnicode : valueTitle;
                            if (this.cmbID3Mode.SelectedIndex == 0 || //全覆盖
                                _id3v1.Artist == null || //数据为空时
                                (this.cmbID3Mode.SelectedIndex == 1 && (Regex.Replace(_id3v1.Artist, "[\\x01-\\xFF]", "").Length < 1 || (valueArtistUnicode.Length > 1 && this.chkUnicode.Checked))) || //覆盖非英文
                                (this.cmbID3Mode.SelectedIndex == 2 && Regex.Replace(_id3v1.Artist, "\\s", "").Length < 1)//不覆盖
                                )
                                _id3v1.Artist = this.chkUnicode.Checked && valueArtistUnicode.Length > 1 ? valueArtistUnicode : valueArtist;
                            if (this.cmbID3Mode.SelectedIndex == 0 || //全覆盖
                                _id3v1.Album == null || //数据为空时
                                (this.cmbID3Mode.SelectedIndex == 1 && Regex.Replace(_id3v1.Album, "[\\x01-\\xFF]", "").Length < 1) || //覆盖非英文
                                (this.cmbID3Mode.SelectedIndex == 2 && Regex.Replace(_id3v1.Album, "\\s", "").Length < 1)//不覆盖
                                )
                                _id3v1.Album = valueSource;

                            _id3v1.Save(trgMusic.FullName);
                        }
                        //替换ID3v2
                        if (this.chkID3v2.Checked)
                        {
                            IID3v2Tag _id3v2;
                            _id3v2 = new ID3v2Tag(srcMusic.FullName);
                            //文本
                            if (_id3v2.Header.TagVersion< ID3v2TagVersion.ID3v23)
                                _id3v2.Header.TagVersion = ID3v2TagVersion.ID3v23;
                            if (this.cmbID3Mode.SelectedIndex == 0 || //全覆盖
                                _id3v2.Title == null || //数据为空时
                                (this.cmbID3Mode.SelectedIndex == 1 && (Regex.Replace(_id3v2.Title, "[\\x01-\\xFF]", "").Length < 1 || (valueTitleUnicode.Length > 1 && this.chkUnicode.Checked))) || //覆盖非英文
                                (this.cmbID3Mode.SelectedIndex == 2 && Regex.Replace(_id3v2.Title, "\\s", "").Length < 1)//不覆盖
                                )
                                _id3v2.Title = this.chkUnicode.Checked && valueTitleUnicode.Length > 1 ? valueTitleUnicode : valueTitle;
                            if (this.cmbID3Mode.SelectedIndex == 0 || //全覆盖
                                _id3v2.Artist == null || //数据为空时
                                (this.cmbID3Mode.SelectedIndex == 1 && (Regex.Replace(_id3v2.Artist, "[\\x01-\\xFF]", "").Length < 1 || (valueArtistUnicode.Length > 1 && this.chkUnicode.Checked))) || //覆盖非英文
                                (this.cmbID3Mode.SelectedIndex == 2 && Regex.Replace(_id3v2.Artist, "\\s", "").Length < 1)//不覆盖
                                )
                                _id3v2.Artist = this.chkUnicode.Checked && valueArtistUnicode.Length > 1 ? valueArtistUnicode : valueArtist;
                            if (this.cmbID3Mode.SelectedIndex == 0 || //全覆盖
                                _id3v2.Album == null || //数据为空时
                                (this.cmbID3Mode.SelectedIndex == 1 && Regex.Replace(_id3v2.Album, "[\\x01-\\xFF]", "").Length < 1) || //覆盖非英文
                                (this.cmbID3Mode.SelectedIndex == 2 && Regex.Replace(_id3v2.Album, "\\s", "").Length < 1)//不覆盖
                                )
                                _id3v2.Album = valueSource;
                            //添加图片
                            if (this.chkCoverImg.Checked && srcBgPic.Exists)
                            {
                                //构建一个数据容器
                                BindingSource bindingSource = new BindingSource();
                                bindingSource.DataSource = _id3v2.PictureList;
                                
                                if (this.chkRewriteImg.Checked)
                                {
                                    bindingSource.Clear(); //清空留存的
                                    bindingSource.AddNew();
                                    IAttachedPicture attachedPicture = bindingSource.Current as IAttachedPicture;
                                    attachedPicture.PictureType = PictureType.CoverFront;//修改封面类型

                                    Image image = Image.FromFile(srcBgPic.FullName);
                                    ImageFormat imageForma = image.RawFormat;
                                    if (chkResize.Checked)
                                    {
                                        string sMaxWidth;
                                        string sMaxHeight;
                                        int MaxWidth;
                                        int MaxHeight;
                                        sMaxWidth = Regex.Replace(txtMaxWidth.Text, "\\D", "");
                                        MaxWidth = sMaxWidth.Length > 0 ? Convert.ToInt32(sMaxWidth) : 0;
                                        sMaxHeight = Regex.Replace(txtMaxHeight.Text, "\\D", "");
                                        MaxHeight = sMaxHeight.Length > 0 ? Convert.ToInt32(sMaxHeight) : 0;
                                        image = ChangeImageSize(image, MaxWidth, MaxHeight, cmbResizeMode.SelectedIndex);
                                    }
                                    //内存中重新保存一遍
                                    MemoryStream ms = new MemoryStream();
                                    if (chkCovertToJpg.Checked)
                                        image.Save(ms, ImageFormat.Jpeg);
                                    else
                                        image.Save(ms, imageForma);
                                    image = Image.FromStream(ms);

                                    attachedPicture.Picture = image;
                                }
                            }
                            _id3v2.Save(trgMusic.FullName);
                        }

                        /*
                        //替换APEv2
                        if (this.chkAPEv2.Checked)
                        {
                            IAPEv2Tag _apev2;
                            _apev2 = new APEv2Tag(srcMusic.FullName);
                            //文本
                            if (this.cmbID3Mode.SelectedIndex == 0 || //全覆盖
                                _apev2.Title == null || //数据为空时
                                (this.cmbID3Mode.SelectedIndex == 1 && Regex.Replace(_apev2.Title, "[\\x01-\\xFF]", "").Length < 1) || //覆盖非英文
                                (this.cmbID3Mode.SelectedIndex == 2 && Regex.Replace(_apev2.Title, "\\s", "").Length < 1)//不覆盖
                                )
                                _apev2.Title = this.chkUnicode.Checked && valueTitleUnicode.Length > 1 ? valueTitleUnicode : valueTitle;
                            if (this.cmbID3Mode.SelectedIndex == 0 || //全覆盖
                                _apev2.Artist == null || //数据为空时
                                (this.cmbID3Mode.SelectedIndex == 1 && Regex.Replace(_apev2.Artist, "[\\x01-\\xFF]", "").Length < 1) || //覆盖非英文
                                (this.cmbID3Mode.SelectedIndex == 2 && Regex.Replace(_apev2.Artist, "\\s", "").Length < 1)//不覆盖
                                )
                                _apev2.Artist = this.chkUnicode.Checked && valueArtistUnicode.Length > 1 ? valueArtistUnicode : valueArtist;
                            if (this.cmbID3Mode.SelectedIndex == 0 || //全覆盖
                                _apev2.Album == null || //数据为空时
                                (this.cmbID3Mode.SelectedIndex == 1 && Regex.Replace(_apev2.Album, "[\\x01-\\xFF]", "").Length < 1) || //覆盖非英文
                                (this.cmbID3Mode.SelectedIndex == 2 && Regex.Replace(_apev2.Album, "\\s", "").Length < 1)//不覆盖
                                )
                                _apev2.Album = valueSource;


                            _apev2.Save(trgMusic.FullName);
                        }
                        */
                        break;
                    }
                }
            }
            this.txtLog.AppendText("执行完成\r\n");
            lblRate.Text = lblRateTxt;
        }
        //按宽度比例缩小图片
        public static Image ChangeImageSize(Image imgSource, int MAX_WIDTH, int MAX_HEIGHT, int ResizeType)
        {
            if (MAX_WIDTH < 1 && MAX_HEIGHT < 1) return imgSource;

            Image imgOutput = imgSource;

            Size size = new Size(imgSource.Width, imgSource.Height);
            //if (imgSource.Width <= 3 || imgSource.Height <= 3) return imgSource; //3X3大小的图片不转换

            if (imgSource.Width > MAX_WIDTH || imgSource.Height > MAX_HEIGHT)
            {
                double rateWidth;
                double rateHeight;
                double rate;
                rateWidth = MAX_WIDTH > 0 ? MAX_WIDTH / (double)imgSource.Width : 1;
                rateHeight = MAX_HEIGHT > 0 ? MAX_HEIGHT / (double)imgSource.Height : 1;
                switch (ResizeType)
                {
                    case 0: //填充
                        rate = rateWidth > rateHeight ? rateWidth : rateHeight;
                        size.Width = Convert.ToInt32(imgSource.Width * rate);
                        size.Height = Convert.ToInt32(imgSource.Height * rate);
                        break;
                    case 1: //适应
                        rate = rateWidth > rateHeight ? rateHeight : rateWidth;
                        rate = MAX_WIDTH / (double)imgSource.Width;
                        if (imgSource.Height * rate > MAX_WIDTH)
                            rate = MAX_WIDTH / (double)imgSource.Height;
                        size.Width = Convert.ToInt32(imgSource.Width * rate);
                        size.Height = Convert.ToInt32(imgSource.Height * rate);
                        break;
                    case 2: //拉伸
                        size.Width = imgSource.Width>MAX_WIDTH && MAX_WIDTH >0 ? MAX_WIDTH : imgSource.Width;
                        size.Height = imgSource.Height > MAX_HEIGHT && MAX_HEIGHT > 0 ? MAX_HEIGHT : imgSource.Height;
                        break;
                }
                imgOutput = imgSource.GetThumbnailImage(size.Width, size.Height, null, IntPtr.Zero);
            }
            
            return imgOutput;
        }
        /// <summary>
        /// 执行外部程序函数
        /// </summary>
        /// <param name="exe">ffmpeg程序</param>
        /// <param name="arg">执行参数</param>     
        public static void ExcuteProcess(string exe, string arg)
        {
            using (var p = new Process())
            {
                p.StartInfo.FileName = exe;
                p.StartInfo.Arguments = arg;
                p.StartInfo.UseShellExecute = false;    //输出信息重定向
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.Start();                    //启动线程
                p.BeginOutputReadLine();
                p.BeginErrorReadLine();
                p.WaitForExit();//等待进程结束                                      
            }
        }
        private void txtMaxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtMaxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtTimeLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void chkResize_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkResize.Checked)
            {
                this.pnlResize.Enabled = true;
            }
            else
            {
                this.pnlResize.Enabled = false;
            }
        }

        private void trkVBRQuality_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.trkVBRQuality, this.trkVBRQuality.Value.ToString());
        }

        private void chkSkipShort_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkSkipShort.Checked)
            {
                this.pnlSkipShort.Enabled = true;
            }
            else
            {
                this.pnlSkipShort.Enabled = false;
            }
        }

        private void chkConvertToMp3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkConvertToMp3.Checked)
            {
                this.pnlVBRQuality.Enabled = true;
            }
            else
            {
                this.pnlVBRQuality.Enabled = false;
            }
        }

        private void chkCoverImg_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkCoverImg.Checked)
            {
                this.chkRewriteImg.Enabled = true;
                this.grpImage.Enabled = true;
            }
            else
            {
                this.chkRewriteImg.Enabled = false;
                this.grpImage.Enabled = false;
            }
        }

        private void chkID3v2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkID3v2.Checked)
            {
                this.pnlID3v2.Enabled = true;
                this.grpImage.Enabled = this.chkCoverImg.Checked;
            }
            else
            {
                this.pnlID3v2.Enabled = false;
                this.grpImage.Enabled = false;
            }
        }

        private void cmbResizeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbResizeMode.SelectedIndex == 0)
            {
                this.chkCut.Enabled = true;
            }
            else
            {
                this.chkCut.Enabled = false;
            }
        }
    }
}
