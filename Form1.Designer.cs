namespace BingDunDun
{
    partial class Form1
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
            this.buttonClose = new System.Windows.Forms.PictureBox();
            this.imageBanner = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageDundunLeft = new System.Windows.Forms.PictureBox();
            this.imageDundunRight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDundunLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDundunRight)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Image = global::BingDunDun.Properties.Resources.close;
            this.buttonClose.Location = new System.Drawing.Point(1435, 1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(127, 108);
            this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonClose.TabIndex = 0;
            this.buttonClose.TabStop = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // imageBanner
            // 
            this.imageBanner.Image = global::BingDunDun.Properties.Resources.banner;
            this.imageBanner.Location = new System.Drawing.Point(287, 1);
            this.imageBanner.Name = "imageBanner";
            this.imageBanner.Size = new System.Drawing.Size(1057, 207);
            this.imageBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBanner.TabIndex = 2;
            this.imageBanner.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageDundunLeft
            // 
            this.imageDundunLeft.Image = global::BingDunDun.Properties.Resources.dundun_left;
            this.imageDundunLeft.Location = new System.Drawing.Point(220, 235);
            this.imageDundunLeft.Name = "imageDundunLeft";
            this.imageDundunLeft.Size = new System.Drawing.Size(583, 696);
            this.imageDundunLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageDundunLeft.TabIndex = 3;
            this.imageDundunLeft.TabStop = false;
            this.imageDundunLeft.Visible = false;
            // 
            // imageDundunRight
            // 
            this.imageDundunRight.Image = global::BingDunDun.Properties.Resources.dundun_right1;
            this.imageDundunRight.Location = new System.Drawing.Point(220, 235);
            this.imageDundunRight.Name = "imageDundunRight";
            this.imageDundunRight.Size = new System.Drawing.Size(595, 733);
            this.imageDundunRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageDundunRight.TabIndex = 4;
            this.imageDundunRight.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BingDunDun.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1574, 929);
            this.Controls.Add(this.imageDundunRight);
            this.Controls.Add(this.imageDundunLeft);
            this.Controls.Add(this.imageBanner);
            this.Controls.Add(this.buttonClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDundunLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDundunRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox buttonClose;
        private System.Windows.Forms.PictureBox imageBanner;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox imageDundunLeft;
        private System.Windows.Forms.PictureBox imageDundunRight;
    }
}

