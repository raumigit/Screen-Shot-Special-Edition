namespace screenshot_Su
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mouse_position = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Debug_timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.DataTimer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DownKey = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.keyboardHook1 = new HongliangSoft.Utilities.Gui.KeyboardHook();
            this.mouseHook1 = new HongliangSoft.Utilities.Gui.MouseHook();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Not Data";
            // 
            // mouse_position
            // 
            this.mouse_position.Enabled = true;
            this.mouse_position.Interval = 30;
            this.mouse_position.Tick += new System.EventHandler(this.mouse_position_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "クリック検知";
            // 
            // Debug_timer1
            // 
            this.Debug_timer1.Enabled = true;
            this.Debug_timer1.Interval = 1000;
            this.Debug_timer1.Tick += new System.EventHandler(this.Debug_timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "--";
            // 
            // DataTimer
            // 
            this.DataTimer.Enabled = true;
            this.DataTimer.Interval = 1000;
            this.DataTimer.Tick += new System.EventHandler(this.DataTimer_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "DataTime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "Key";
            // 
            // DownKey
            // 
            this.DownKey.AutoSize = true;
            this.DownKey.Location = new System.Drawing.Point(78, 95);
            this.DownKey.Name = "DownKey";
            this.DownKey.Size = new System.Drawing.Size(31, 12);
            this.DownKey.TabIndex = 7;
            this.DownKey.Text = "None";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "Size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "XY=None";
            // 
            // keyboardHook1
            // 
            this.keyboardHook1.KeyboardHooked += new HongliangSoft.Utilities.Gui.KeyboardHookedEventHandler(this.keyboardHook1_KeyboardHooked);
            // 
            // mouseHook1
            // 
            this.mouseHook1.MouseHooked += new HongliangSoft.Utilities.Gui.MouseHookedEventHandler(this.mouseHook1_MouseHooked_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 192);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DownKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Screen Shot Special Edition(沙花又フォントプロジェクト)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer mouse_position;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer Debug_timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer DataTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label DownKey;
        private HongliangSoft.Utilities.Gui.KeyboardHook keyboardHook1;
        private HongliangSoft.Utilities.Gui.MouseHook mouseHook1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

