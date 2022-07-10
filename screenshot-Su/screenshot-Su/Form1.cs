using HongliangSoft.Utilities.Gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screenshot_Su
{
    public partial class Form1 : Form
    {
        int ScreenShotX;
        int ScreenShotY;
        int RangeWidth, RangeHeight;
        //改良時に利用予定

        bool CaptureLock = false;

        DateTime nowTime;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// マウス座標を書き込むだけの処理
        /// 30msの間隔で更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mouse_position_Tick(object sender, EventArgs e)
        {
            label2.Text = string.Format("マウス座標：{0:d},{1:d}", Cursor.Position.X, Cursor.Position.Y);
            ScreenShotX = Cursor.Position.X;
            ScreenShotY = Cursor.Position.Y;
        }  

        public void WHupdata()
        {
            label9.Text = string.Format("X={0},Y={1}", RangeWidth, RangeHeight);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryCheck();

            RangeHeight = 128;
            RangeWidth = 128;
            label9.Text = string.Format("X={0},Y={1}", RangeWidth, RangeHeight);

        }

        /// <summary>
        /// ディレクトリチェック
        /// 注意！Captchaフォルダー以外は監視対象外
        /// </summary>
        public void DirectoryCheck()
        {
            try
            {
                if (Directory.Exists(@"Capture") == false)
                    Directory.CreateDirectory("Capture");
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// マウス用のグローバルフック
        /// 右クリックはキャプチャ停止/再開
        /// 左クリックはキャプチャ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mouseHook1_MouseHooked(object sender, HongliangSoft.Utilities.Gui.MouseHookedEventArgs e)
        {
            

        }

        /// <summary>
        /// 1秒毎に時間を持ってきている
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataTimer_Tick(object sender, EventArgs e)
        {
            nowTime = DateTime.Now;
            label5.Text = nowTime.ToString("yyyy-MM-dd|HH:mm:ss");
        }

        /// <summary>
        /// 右・左クリックの検知後のリセット用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Debug_timer1_Tick(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        /// <summary>
        /// スクリーンショットを実際に取るクラス
        /// Bmp→Pngに変換している(アルファチャンネルについては未確認)
        /// </summary>
        public void ScreenCapture()
        {
            string saveimage;
            try
            {
                //Bitmap bmp = new Bitmap(128,128);
                int left, top, width, hight;
                left = ScreenShotX;
                top = ScreenShotY;
                width = RangeWidth;
                hight = RangeHeight;


                /*ここらへんに範囲でスクリーンショットを取る部分を実装予定*/
                Rectangle rect = new Rectangle(left, top, width, hight);
                using (var bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb))
                {
                    using (var g = Graphics.FromImage(bmp))
                    {
                        g.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size, CopyPixelOperation.SourceCopy);
                    }
                    saveimage = nowTime.ToString("yyyy-MM-dd-HH-mm-ss");
                    //PNG形式で保存する
                    bmp.Save(string.Format(@"Capture/Capture{0}.png", saveimage, ImageFormat.Png));
                    bmp.Dispose();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void keyboardHook1_KeyboardHooked(object sender, KeyboardHookedEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.KeyCode:
                    break;
                case Keys.ShiftKey:
                    break;
                case Keys.ControlKey:
                    break;
                case Keys.Escape:
                    break;
                case Keys.End:
                    break;
                case Keys.Home:
                    break;
                case Keys.Left:
                    RangeWidth--;
                    WHupdata();
                    break;
                case Keys.Up:
                    RangeHeight++;
                    WHupdata();
                    break;
                case Keys.Right:
                    RangeWidth++;
                    WHupdata();
                    break;
                case Keys.Down:
                    RangeHeight--;
                    WHupdata();
                    break;
                case Keys.D0:
                    break;
                case Keys.D1:
                    break;
                case Keys.D2:
                    break;
                case Keys.D3:
                    break;
                case Keys.D4:
                    break;
                case Keys.D5:
                    break;
                case Keys.D6:
                    break;
                case Keys.D7:
                    break;
                case Keys.D8:
                    break;
                case Keys.D9:
                    break;
                case Keys.NumPad0:
                    break;
                case Keys.NumPad1:
                    break;
                case Keys.NumPad2:
                    break;
                case Keys.NumPad3:
                    break;
                case Keys.NumPad4:
                    break;
                case Keys.NumPad5:
                    break;
                case Keys.NumPad6:
                    break;
                case Keys.NumPad7:
                    break;
                case Keys.NumPad8:
                    break;
                case Keys.NumPad9:
                    break;
                case Keys.F1:
                    DownKey.Text = "F1";
                    break;
                case Keys.F2:
                    DownKey.Text = "F2";
                    break;
                case Keys.F3:
                    DownKey.Text = "F3";
                    break;
                case Keys.F4:
                    DownKey.Text = "F4";
                    break;
                case Keys.F5:
                    DownKey.Text = "F5";
                    break;
                case Keys.F6:
                    DownKey.Text = "F6";
                    break;
                case Keys.F7:
                    DownKey.Text = "F7";
                    break;
                case Keys.F8:
                    DownKey.Text = "F8";
                    break;
                case Keys.F9:
                    DownKey.Text = "F9";
                    break;
                case Keys.F10:
                    DownKey.Text = "F10";
                    break;
                case Keys.F11:
                    DownKey.Text = "F11";
                    break;
                case Keys.F12:
                    DownKey.Text = "F12";
                    break;
                    break;
                case Keys.Shift:
                    DownKey.Text = "Shift";
                    break;
                case Keys.Control:
                    DownKey.Text = "Ctrl";
                    break;
                case Keys.Alt:
                    DownKey.Text = "Alt";
                    break;
                default:
                    break;
            }


        }

        public void KeyandMOuseHook(object sender, MouseHookedEventArgs m, KeyboardHookedEventArgs k)
        {
            if (k.UpDown == HongliangSoft.Utilities.Gui.KeyboardUpDown.Down)
            {

                


            }
        }


        private void mouseHook1_MouseHooked_1(object sender, MouseHookedEventArgs e)
        {
            if (e.Message == HongliangSoft.Utilities.Gui.MouseMessage.LDown && CaptureLock == false)
            {
                label3.ForeColor = Color.Cyan;
                ScreenCapture();
            }
            if (e.Message == HongliangSoft.Utilities.Gui.MouseMessage.RDown)
            {
                label3.ForeColor = Color.Magenta;
                switch (CaptureLock)
                {
                    case true:
                        CaptureLock = false;
                        label4.Text = "--";
                        break;

                    case false:
                        CaptureLock = true;
                        label4.Text = "スクリーンショットがロック中";
                        break;


                    default:
                        break;
                }
            }
        }
    }
}

