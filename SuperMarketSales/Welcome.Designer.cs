namespace SuperMarketSales
{
    partial class Welcome
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.ll_Login = new System.Windows.Forms.LinkLabel();
            this.ll_Exit = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ll_Login
            // 
            this.ll_Login.AutoSize = true;
            this.ll_Login.BackColor = System.Drawing.Color.Transparent;
            this.ll_Login.Font = new System.Drawing.Font("微软雅黑", 15.73109F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ll_Login.Location = new System.Drawing.Point(309, 353);
            this.ll_Login.Name = "ll_Login";
            this.ll_Login.Size = new System.Drawing.Size(123, 35);
            this.ll_Login.TabIndex = 1;
            this.ll_Login.TabStop = true;
            this.ll_Login.Text = "用户登录";
            this.ll_Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_Login_LinkClicked);
            // 
            // ll_Exit
            // 
            this.ll_Exit.AutoSize = true;
            this.ll_Exit.BackColor = System.Drawing.Color.Transparent;
            this.ll_Exit.Font = new System.Drawing.Font("微软雅黑", 15.73109F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ll_Exit.Location = new System.Drawing.Point(508, 353);
            this.ll_Exit.Name = "ll_Exit";
            this.ll_Exit.Size = new System.Drawing.Size(69, 35);
            this.ll_Exit.TabIndex = 2;
            this.ll_Exit.TabStop = true;
            this.ll_Exit.Text = "退出";
            this.ll_Exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_Exit_LinkClicked);
            // 
            // Welcome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(940, 522);
            this.Controls.Add(this.ll_Exit);
            this.Controls.Add(this.ll_Login);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智慧社区商超收银系统";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ll_Login;
        private System.Windows.Forms.LinkLabel ll_Exit;
    }
}

