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
        //int ScreenShotX, ScreenShotY;
        //int RangeWidth, RangeHeight;
        //改良時に利用予定

        bool CaptureLock=false;
        
        DateTime nowTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void mouse_position_Tick(object sender, EventArgs e)
        {
            label2.Text = string.Format("マウス座標：{0:d},{1:d}", Cursor.Position.X, Cursor.Position.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryCheck();
        }

        public void DirectoryCheck()
        {
            try
            {
                if (Directory.Exists(@"Capture") == false)
                    Directory.CreateDirectory("Capture");
            }
            catch (Exception)
            {
                throw ;
            }
            
        }

        private void mouseHook1_MouseHooked(object sender, HongliangSoft.Utilities.Gui.MouseHookedEventArgs e)
        {
            if (e.Message==HongliangSoft.Utilities.Gui.MouseMessage.LDown && CaptureLock==false)
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

        private void DataTimer_Tick(object sender, EventArgs e)
        {
            nowTime = DateTime.Now;
            label5.Text = nowTime.ToString("yyyy-MM-dd|HH:mm:ss");
        }

        private void Debug_timer1_Tick(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
            //Debug_timer1.Enabled = false;
        }

        public void ScreenCapture()
        {
            string saveimage;
            try
            {
                //Bitmap bmp = new Bitmap(128,128);
                int left, top, width, hight;
                left = Cursor.Position.X;
                top = Cursor.Position.Y;
                width = 128;
                hight = 128;


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

    }



}
