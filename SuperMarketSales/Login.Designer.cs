namespace SuperMarketSales
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Pwd = new System.Windows.Forms.TextBox();
            this.rb_Oper = new System.Windows.Forms.RadioButton();
            this.rb_Admin = new System.Windows.Forms.RadioButton();
            this.bt_Login = new System.Windows.Forms.Button();
            this.bt_Eixt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(78, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // tb_User
            // 
            this.tb_User.Font = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_User.Location = new System.Drawing.Point(171, 63);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(144, 27);
            this.tb_User.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(90, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码";
            // 
            // tb_Pwd
            // 
            this.tb_Pwd.Font = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Pwd.Location = new System.Drawing.Point(171, 121);
            this.tb_Pwd.Name = "tb_Pwd";
            this.tb_Pwd.PasswordChar = '*';
            this.tb_Pwd.Size = new System.Drawing.Size(144, 27);
            this.tb_Pwd.TabIndex = 1;
            // 
            // rb_Oper
            // 
            this.rb_Oper.AutoSize = true;
            this.rb_Oper.Checked = true;
            this.rb_Oper.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rb_Oper.Location = new System.Drawing.Point(98, 187);
            this.rb_Oper.Name = "rb_Oper";
            this.rb_Oper.Size = new System.Drawing.Size(79, 27);
            this.rb_Oper.TabIndex = 2;
            this.rb_Oper.TabStop = true;
            this.rb_Oper.Text = "收银员";
            this.rb_Oper.UseVisualStyleBackColor = true;
            // 
            // rb_Admin
            // 
            this.rb_Admin.AutoSize = true;
            this.rb_Admin.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rb_Admin.Location = new System.Drawing.Point(240, 187);
            this.rb_Admin.Name = "rb_Admin";
            this.rb_Admin.Size = new System.Drawing.Size(79, 27);
            this.rb_Admin.TabIndex = 3;
            this.rb_Admin.TabStop = true;
            this.rb_Admin.Text = "库管员";
            this.rb_Admin.UseVisualStyleBackColor = true;
            // 
            // bt_Login
            // 
            this.bt_Login.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Login.Location = new System.Drawing.Point(82, 246);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(86, 34);
            this.bt_Login.TabIndex = 4;
            this.bt_Login.Text = "登录";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // bt_Eixt
            // 
            this.bt_Eixt.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Eixt.Location = new System.Drawing.Point(235, 246);
            this.bt_Eixt.Name = "bt_Eixt";
            this.bt_Eixt.Size = new System.Drawing.Size(84, 34);
            this.bt_Eixt.TabIndex = 5;
            this.bt_Eixt.Text = "退出";
            this.bt_Eixt.UseVisualStyleBackColor = true;
            this.bt_Eixt.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 328);
            this.Controls.Add(this.bt_Eixt);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.rb_Admin);
            this.Controls.Add(this.rb_Oper);
            this.Controls.Add(this.tb_Pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_User);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Pwd;
        private System.Windows.Forms.RadioButton rb_Oper;
        private System.Windows.Forms.RadioButton rb_Admin;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Button bt_Eixt;
    }
}