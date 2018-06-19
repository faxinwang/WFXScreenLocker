namespace LockScreen
{
    partial class SettingForm
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
            this.TabPage_SetPwd = new System.Windows.Forms.TabPage();
            this.tab1_btn_cancel = new System.Windows.Forms.Button();
            this.Btn_modify = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBox_pwd3 = new System.Windows.Forms.TextBox();
            this.TBox_pwd2 = new System.Windows.Forms.TextBox();
            this.TBox_pwd1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage_SetColor = new System.Windows.Forms.TabPage();
            this.tab2_btn_cancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.OldColor = new System.Windows.Forms.Label();
            this.Panel_newColor = new System.Windows.Forms.Panel();
            this.Panel_oldColor = new System.Windows.Forms.Panel();
            this.Lb_B = new System.Windows.Forms.Label();
            this.Lb_G = new System.Windows.Forms.Label();
            this.Lb_R = new System.Windows.Forms.Label();
            this.TrackBar_B = new System.Windows.Forms.TrackBar();
            this.TrackBar_G = new System.Windows.Forms.TrackBar();
            this.TrackBar_R = new System.Windows.Forms.TrackBar();
            this.Btn_SetColor = new System.Windows.Forms.Button();
            this.TabPage_setOpacity = new System.Windows.Forms.TabPage();
            this.tab3_btn_cancel = new System.Windows.Forms.Button();
            this.tab3_btn_ok = new System.Windows.Forms.Button();
            this.lab_maxOpac = new System.Windows.Forms.Label();
            this.lab_minOpac = new System.Windows.Forms.Label();
            this.trackBar_maxOpac = new System.Windows.Forms.TrackBar();
            this.trackBar_minOpac = new System.Windows.Forms.TrackBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tab4_btn_cancel = new System.Windows.Forms.Button();
            this.tab4_btn_ok = new System.Windows.Forms.Button();
            this.tab4_cbox_openRun = new System.Windows.Forms.CheckBox();
            this.TabPage_SetPwd.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabPage_SetColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_R)).BeginInit();
            this.TabPage_setOpacity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_maxOpac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_minOpac)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPage_SetPwd
            // 
            this.TabPage_SetPwd.BackColor = System.Drawing.Color.LightGray;
            this.TabPage_SetPwd.Controls.Add(this.tab1_btn_cancel);
            this.TabPage_SetPwd.Controls.Add(this.Btn_modify);
            this.TabPage_SetPwd.Controls.Add(this.groupBox2);
            this.TabPage_SetPwd.Location = new System.Drawing.Point(4, 22);
            this.TabPage_SetPwd.Name = "TabPage_SetPwd";
            this.TabPage_SetPwd.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_SetPwd.Size = new System.Drawing.Size(507, 355);
            this.TabPage_SetPwd.TabIndex = 1;
            this.TabPage_SetPwd.Text = "修改密码";
            // 
            // tab1_btn_cancel
            // 
            this.tab1_btn_cancel.Location = new System.Drawing.Point(257, 308);
            this.tab1_btn_cancel.Name = "tab1_btn_cancel";
            this.tab1_btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.tab1_btn_cancel.TabIndex = 5;
            this.tab1_btn_cancel.Text = "取消";
            this.tab1_btn_cancel.UseVisualStyleBackColor = true;
            // 
            // Btn_modify
            // 
            this.Btn_modify.Location = new System.Drawing.Point(145, 308);
            this.Btn_modify.Name = "Btn_modify";
            this.Btn_modify.Size = new System.Drawing.Size(75, 23);
            this.Btn_modify.TabIndex = 4;
            this.Btn_modify.Text = "修改";
            this.Btn_modify.UseVisualStyleBackColor = true;
            this.Btn_modify.Click += new System.EventHandler(this.Btn_modify_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TBox_pwd3);
            this.groupBox2.Controls.Add(this.TBox_pwd2);
            this.groupBox2.Controls.Add(this.TBox_pwd1);
            this.groupBox2.Location = new System.Drawing.Point(63, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(376, 218);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "新密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "原密码";
            // 
            // TBox_pwd3
            // 
            this.TBox_pwd3.Location = new System.Drawing.Point(95, 142);
            this.TBox_pwd3.Name = "TBox_pwd3";
            this.TBox_pwd3.PasswordChar = '码';
            this.TBox_pwd3.Size = new System.Drawing.Size(228, 21);
            this.TBox_pwd3.TabIndex = 3;
            // 
            // TBox_pwd2
            // 
            this.TBox_pwd2.Location = new System.Drawing.Point(95, 82);
            this.TBox_pwd2.Name = "TBox_pwd2";
            this.TBox_pwd2.PasswordChar = '密';
            this.TBox_pwd2.Size = new System.Drawing.Size(228, 21);
            this.TBox_pwd2.TabIndex = 2;
            // 
            // TBox_pwd1
            // 
            this.TBox_pwd1.Location = new System.Drawing.Point(95, 30);
            this.TBox_pwd1.Name = "TBox_pwd1";
            this.TBox_pwd1.PasswordChar = '*';
            this.TBox_pwd1.Size = new System.Drawing.Size(228, 21);
            this.TBox_pwd1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPage_SetPwd);
            this.tabControl1.Controls.Add(this.TabPage_SetColor);
            this.tabControl1.Controls.Add(this.TabPage_setOpacity);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(515, 381);
            this.tabControl1.TabIndex = 2;
            // 
            // TabPage_SetColor
            // 
            this.TabPage_SetColor.BackColor = System.Drawing.Color.LightGray;
            this.TabPage_SetColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabPage_SetColor.Controls.Add(this.tab2_btn_cancel);
            this.TabPage_SetColor.Controls.Add(this.label7);
            this.TabPage_SetColor.Controls.Add(this.OldColor);
            this.TabPage_SetColor.Controls.Add(this.Panel_newColor);
            this.TabPage_SetColor.Controls.Add(this.Panel_oldColor);
            this.TabPage_SetColor.Controls.Add(this.Lb_B);
            this.TabPage_SetColor.Controls.Add(this.Lb_G);
            this.TabPage_SetColor.Controls.Add(this.Lb_R);
            this.TabPage_SetColor.Controls.Add(this.TrackBar_B);
            this.TabPage_SetColor.Controls.Add(this.TrackBar_G);
            this.TabPage_SetColor.Controls.Add(this.TrackBar_R);
            this.TabPage_SetColor.Controls.Add(this.Btn_SetColor);
            this.TabPage_SetColor.Location = new System.Drawing.Point(4, 22);
            this.TabPage_SetColor.Name = "TabPage_SetColor";
            this.TabPage_SetColor.Size = new System.Drawing.Size(507, 355);
            this.TabPage_SetColor.TabIndex = 2;
            this.TabPage_SetColor.Text = "设置锁屏颜色";
            // 
            // tab2_btn_cancel
            // 
            this.tab2_btn_cancel.Location = new System.Drawing.Point(418, 320);
            this.tab2_btn_cancel.Name = "tab2_btn_cancel";
            this.tab2_btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.tab2_btn_cancel.TabIndex = 2;
            this.tab2_btn_cancel.Text = "取消";
            this.tab2_btn_cancel.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "New Color";
            // 
            // OldColor
            // 
            this.OldColor.AutoSize = true;
            this.OldColor.Location = new System.Drawing.Point(90, 304);
            this.OldColor.Name = "OldColor";
            this.OldColor.Size = new System.Drawing.Size(59, 12);
            this.OldColor.TabIndex = 4;
            this.OldColor.Text = "Old Color";
            // 
            // Panel_newColor
            // 
            this.Panel_newColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_newColor.Location = new System.Drawing.Point(218, 180);
            this.Panel_newColor.Name = "Panel_newColor";
            this.Panel_newColor.Size = new System.Drawing.Size(110, 110);
            this.Panel_newColor.TabIndex = 3;
            // 
            // Panel_oldColor
            // 
            this.Panel_oldColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_oldColor.Location = new System.Drawing.Point(72, 180);
            this.Panel_oldColor.Name = "Panel_oldColor";
            this.Panel_oldColor.Size = new System.Drawing.Size(110, 110);
            this.Panel_oldColor.TabIndex = 3;
            // 
            // Lb_B
            // 
            this.Lb_B.AutoSize = true;
            this.Lb_B.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_B.ForeColor = System.Drawing.Color.Blue;
            this.Lb_B.Location = new System.Drawing.Point(21, 140);
            this.Lb_B.Name = "Lb_B";
            this.Lb_B.Size = new System.Drawing.Size(31, 19);
            this.Lb_B.TabIndex = 2;
            this.Lb_B.Text = "B:";
            // 
            // Lb_G
            // 
            this.Lb_G.AutoSize = true;
            this.Lb_G.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_G.ForeColor = System.Drawing.Color.Lime;
            this.Lb_G.Location = new System.Drawing.Point(21, 89);
            this.Lb_G.Name = "Lb_G";
            this.Lb_G.Size = new System.Drawing.Size(31, 19);
            this.Lb_G.TabIndex = 2;
            this.Lb_G.Text = "G:";
            // 
            // Lb_R
            // 
            this.Lb_R.AutoSize = true;
            this.Lb_R.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_R.ForeColor = System.Drawing.Color.Red;
            this.Lb_R.Location = new System.Drawing.Point(21, 38);
            this.Lb_R.Name = "Lb_R";
            this.Lb_R.Size = new System.Drawing.Size(31, 19);
            this.Lb_R.TabIndex = 2;
            this.Lb_R.Text = "R:";
            // 
            // TrackBar_B
            // 
            this.TrackBar_B.Location = new System.Drawing.Point(62, 140);
            this.TrackBar_B.Maximum = 255;
            this.TrackBar_B.Name = "TrackBar_B";
            this.TrackBar_B.Size = new System.Drawing.Size(431, 45);
            this.TrackBar_B.TabIndex = 10;
            // 
            // TrackBar_G
            // 
            this.TrackBar_G.Location = new System.Drawing.Point(62, 89);
            this.TrackBar_G.Maximum = 255;
            this.TrackBar_G.Name = "TrackBar_G";
            this.TrackBar_G.Size = new System.Drawing.Size(431, 45);
            this.TrackBar_G.TabIndex = 10;
            // 
            // TrackBar_R
            // 
            this.TrackBar_R.Location = new System.Drawing.Point(62, 38);
            this.TrackBar_R.Maximum = 255;
            this.TrackBar_R.Name = "TrackBar_R";
            this.TrackBar_R.Size = new System.Drawing.Size(431, 45);
            this.TrackBar_R.TabIndex = 10;
            this.TrackBar_R.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // Btn_SetColor
            // 
            this.Btn_SetColor.Location = new System.Drawing.Point(337, 320);
            this.Btn_SetColor.Name = "Btn_SetColor";
            this.Btn_SetColor.Size = new System.Drawing.Size(75, 23);
            this.Btn_SetColor.TabIndex = 1;
            this.Btn_SetColor.Text = "确定";
            this.Btn_SetColor.UseVisualStyleBackColor = true;
            this.Btn_SetColor.Click += new System.EventHandler(this.Btn_SetColor_Click);
            // 
            // TabPage_setOpacity
            // 
            this.TabPage_setOpacity.BackColor = System.Drawing.Color.LightGray;
            this.TabPage_setOpacity.Controls.Add(this.tab3_btn_cancel);
            this.TabPage_setOpacity.Controls.Add(this.tab3_btn_ok);
            this.TabPage_setOpacity.Controls.Add(this.lab_maxOpac);
            this.TabPage_setOpacity.Controls.Add(this.lab_minOpac);
            this.TabPage_setOpacity.Controls.Add(this.trackBar_maxOpac);
            this.TabPage_setOpacity.Controls.Add(this.trackBar_minOpac);
            this.TabPage_setOpacity.Location = new System.Drawing.Point(4, 22);
            this.TabPage_setOpacity.Name = "TabPage_setOpacity";
            this.TabPage_setOpacity.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_setOpacity.Size = new System.Drawing.Size(507, 355);
            this.TabPage_setOpacity.TabIndex = 3;
            this.TabPage_setOpacity.Text = "设置不透明度";
            // 
            // tab3_btn_cancel
            // 
            this.tab3_btn_cancel.Location = new System.Drawing.Point(423, 321);
            this.tab3_btn_cancel.Name = "tab3_btn_cancel";
            this.tab3_btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.tab3_btn_cancel.TabIndex = 5;
            this.tab3_btn_cancel.Text = "取消";
            this.tab3_btn_cancel.UseVisualStyleBackColor = true;
            // 
            // tab3_btn_ok
            // 
            this.tab3_btn_ok.Location = new System.Drawing.Point(342, 321);
            this.tab3_btn_ok.Name = "tab3_btn_ok";
            this.tab3_btn_ok.Size = new System.Drawing.Size(75, 23);
            this.tab3_btn_ok.TabIndex = 4;
            this.tab3_btn_ok.Text = "确定";
            this.tab3_btn_ok.UseVisualStyleBackColor = true;
            this.tab3_btn_ok.Click += new System.EventHandler(this.tab3_btn_ok_Click);
            // 
            // lab_maxOpac
            // 
            this.lab_maxOpac.AutoSize = true;
            this.lab_maxOpac.Location = new System.Drawing.Point(38, 95);
            this.lab_maxOpac.Name = "lab_maxOpac";
            this.lab_maxOpac.Size = new System.Drawing.Size(0, 12);
            this.lab_maxOpac.TabIndex = 3;
            // 
            // lab_minOpac
            // 
            this.lab_minOpac.AutoSize = true;
            this.lab_minOpac.Location = new System.Drawing.Point(36, 29);
            this.lab_minOpac.Name = "lab_minOpac";
            this.lab_minOpac.Size = new System.Drawing.Size(0, 12);
            this.lab_minOpac.TabIndex = 2;
            // 
            // trackBar_maxOpac
            // 
            this.trackBar_maxOpac.Location = new System.Drawing.Point(26, 113);
            this.trackBar_maxOpac.Maximum = 100;
            this.trackBar_maxOpac.Minimum = 10;
            this.trackBar_maxOpac.Name = "trackBar_maxOpac";
            this.trackBar_maxOpac.Size = new System.Drawing.Size(452, 45);
            this.trackBar_maxOpac.TabIndex = 1;
            this.trackBar_maxOpac.Value = 10;
            // 
            // trackBar_minOpac
            // 
            this.trackBar_minOpac.Location = new System.Drawing.Point(26, 49);
            this.trackBar_minOpac.Maximum = 100;
            this.trackBar_minOpac.Minimum = 10;
            this.trackBar_minOpac.Name = "trackBar_minOpac";
            this.trackBar_minOpac.Size = new System.Drawing.Size(452, 45);
            this.trackBar_minOpac.TabIndex = 0;
            this.trackBar_minOpac.Value = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.tab4_btn_cancel);
            this.tabPage1.Controls.Add(this.tab4_btn_ok);
            this.tabPage1.Controls.Add(this.tab4_cbox_openRun);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(507, 355);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "其他";
            // 
            // tab4_btn_cancel
            // 
            this.tab4_btn_cancel.Location = new System.Drawing.Point(422, 321);
            this.tab4_btn_cancel.Name = "tab4_btn_cancel";
            this.tab4_btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.tab4_btn_cancel.TabIndex = 1;
            this.tab4_btn_cancel.Text = "取消";
            this.tab4_btn_cancel.UseVisualStyleBackColor = true;
            // 
            // tab4_btn_ok
            // 
            this.tab4_btn_ok.Location = new System.Drawing.Point(341, 321);
            this.tab4_btn_ok.Name = "tab4_btn_ok";
            this.tab4_btn_ok.Size = new System.Drawing.Size(75, 23);
            this.tab4_btn_ok.TabIndex = 1;
            this.tab4_btn_ok.Text = "确定";
            this.tab4_btn_ok.UseVisualStyleBackColor = true;
            this.tab4_btn_ok.Click += new System.EventHandler(this.tab4_btn_ok_Click);
            // 
            // tab4_cbox_openRun
            // 
            this.tab4_cbox_openRun.AutoSize = true;
            this.tab4_cbox_openRun.Location = new System.Drawing.Point(10, 32);
            this.tab4_cbox_openRun.Name = "tab4_cbox_openRun";
            this.tab4_cbox_openRun.Size = new System.Drawing.Size(120, 16);
            this.tab4_cbox_openRun.TabIndex = 0;
            this.tab4_cbox_openRun.Text = "将程序设为自启动";
            this.tab4_cbox_openRun.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 378);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.TabPage_SetPwd.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabPage_SetColor.ResumeLayout(false);
            this.TabPage_SetColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_R)).EndInit();
            this.TabPage_setOpacity.ResumeLayout(false);
            this.TabPage_setOpacity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_maxOpac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_minOpac)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage TabPage_SetPwd;
        private System.Windows.Forms.Button tab1_btn_cancel;
        private System.Windows.Forms.Button Btn_modify;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBox_pwd3;
        private System.Windows.Forms.TextBox TBox_pwd2;
        private System.Windows.Forms.TextBox TBox_pwd1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPage_SetColor;
        private System.Windows.Forms.Button Btn_SetColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label OldColor;
        private System.Windows.Forms.Panel Panel_newColor;
        private System.Windows.Forms.Panel Panel_oldColor;
        private System.Windows.Forms.Label Lb_B;
        private System.Windows.Forms.Label Lb_G;
        private System.Windows.Forms.Label Lb_R;
        private System.Windows.Forms.TrackBar TrackBar_B;
        private System.Windows.Forms.TrackBar TrackBar_G;
        private System.Windows.Forms.TrackBar TrackBar_R;
        private System.Windows.Forms.Button tab2_btn_cancel;
        private System.Windows.Forms.TabPage TabPage_setOpacity;
        private System.Windows.Forms.Button tab3_btn_cancel;
        private System.Windows.Forms.Button tab3_btn_ok;
        private System.Windows.Forms.Label lab_maxOpac;
        private System.Windows.Forms.Label lab_minOpac;
        private System.Windows.Forms.TrackBar trackBar_maxOpac;
        private System.Windows.Forms.TrackBar trackBar_minOpac;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox tab4_cbox_openRun;
        private System.Windows.Forms.Button tab4_btn_cancel;
        private System.Windows.Forms.Button tab4_btn_ok;
    }
}