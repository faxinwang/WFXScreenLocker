namespace LockScreen
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
            this.Btn_lock = new System.Windows.Forms.Button();
            this.Btn_set = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // Btn_lock
            // 
            this.Btn_lock.BackColor = System.Drawing.Color.Transparent;
            this.Btn_lock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_lock.ForeColor = System.Drawing.Color.DarkViolet;
            this.Btn_lock.Location = new System.Drawing.Point(12, 227);
            this.Btn_lock.Name = "Btn_lock";
            this.Btn_lock.Size = new System.Drawing.Size(112, 23);
            this.Btn_lock.TabIndex = 1;
            this.Btn_lock.Text = "Lock Screen";
            this.Btn_lock.UseVisualStyleBackColor = false;
            this.Btn_lock.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_set
            // 
            this.Btn_set.BackColor = System.Drawing.Color.Transparent;
            this.Btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_set.ForeColor = System.Drawing.Color.DarkViolet;
            this.Btn_set.Location = new System.Drawing.Point(160, 227);
            this.Btn_set.Name = "Btn_set";
            this.Btn_set.Size = new System.Drawing.Size(112, 23);
            this.Btn_set.TabIndex = 2;
            this.Btn_set.Text = "Setting";
            this.Btn_set.UseVisualStyleBackColor = false;
            this.Btn_set.Click += new System.EventHandler(this.button2_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "WFXScreenLocker, double click to open";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Btn_set);
            this.Controls.Add(this.Btn_lock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WFXScreenLocker";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_lock;
        private System.Windows.Forms.Button Btn_set;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

