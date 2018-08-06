namespace LockScreen
{
    partial class ScreenLocker
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
            this.TBox_pwd = new System.Windows.Forms.TextBox();
            this.Btn_enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBox_pwd
            // 
            this.TBox_pwd.BackColor = System.Drawing.Color.SandyBrown;
            this.TBox_pwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBox_pwd.ForeColor = System.Drawing.Color.DarkViolet;
            this.TBox_pwd.Location = new System.Drawing.Point(104, 29);
            this.TBox_pwd.Name = "TBox_pwd";
            this.TBox_pwd.PasswordChar = '♥';
            this.TBox_pwd.Size = new System.Drawing.Size(212, 14);
            this.TBox_pwd.TabIndex = 0;
            this.TBox_pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBox_pwd_KeyDown);
            // 
            // Btn_enter
            // 
            this.Btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_enter.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Btn_enter.Location = new System.Drawing.Point(322, 27);
            this.Btn_enter.Name = "Btn_enter";
            this.Btn_enter.Size = new System.Drawing.Size(75, 18);
            this.Btn_enter.TabIndex = 1;
            this.Btn_enter.Text = "Enter";
            this.Btn_enter.UseVisualStyleBackColor = true;
            this.Btn_enter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_enter_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Btn_enter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TBox_pwd);
            this.panel1.Location = new System.Drawing.Point(326, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 107);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 3;
            // 
            // ScreenLocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1006, 512);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DarkViolet;
            this.Name = "ScreenLocker";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.Text = "LockScreen";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TBox_pwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_enter;
    }
}