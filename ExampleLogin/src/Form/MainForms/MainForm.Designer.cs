﻿namespace ExampleLogin
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.btnOptionQuanly = new System.Windows.Forms.Button();
            this.btnOptionThongke = new System.Windows.Forms.Button();
            this.btnOptionHanghoa = new System.Windows.Forms.Button();
            this.btnOptionHoadon = new System.Windows.Forms.Button();
            this.btnOptionBanHang = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.titlePanel = new System.Windows.Forms.GroupBox();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.giớiThiệuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(1086, 24);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(1086, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1086, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.exitToolStripMenuItem.Text = "Thoát";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.logOutToolStripMenuItem1});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.accountToolStripMenuItem.Text = "Tài khoản";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.logOutToolStripMenuItem1.Text = "Đăng xuất";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // giớiThiệuToolStripMenuItem
            // 
            this.giớiThiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            this.giớiThiệuToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.giớiThiệuToolStripMenuItem.Text = "Trợ giúp";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.aboutToolStripMenuItem.Text = "Thông tin";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.btnOptionQuanly);
            this.groupBoxOptions.Controls.Add(this.btnOptionThongke);
            this.groupBoxOptions.Controls.Add(this.btnOptionHanghoa);
            this.groupBoxOptions.Controls.Add(this.btnOptionHoadon);
            this.groupBoxOptions.Controls.Add(this.btnOptionBanHang);
            this.groupBoxOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOptions.Location = new System.Drawing.Point(12, 27);
            this.groupBoxOptions.MaximumSize = new System.Drawing.Size(108, 470);
            this.groupBoxOptions.MinimumSize = new System.Drawing.Size(108, 470);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(108, 470);
            this.groupBoxOptions.TabIndex = 1;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Mục";
            // 
            // btnOptionQuanly
            // 
            this.btnOptionQuanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionQuanly.Location = new System.Drawing.Point(6, 230);
            this.btnOptionQuanly.MaximumSize = new System.Drawing.Size(96, 45);
            this.btnOptionQuanly.MinimumSize = new System.Drawing.Size(96, 45);
            this.btnOptionQuanly.Name = "btnOptionQuanly";
            this.btnOptionQuanly.Size = new System.Drawing.Size(96, 45);
            this.btnOptionQuanly.TabIndex = 6;
            this.btnOptionQuanly.Text = "Quản lý";
            this.btnOptionQuanly.UseVisualStyleBackColor = true;
            this.btnOptionQuanly.Click += new System.EventHandler(this.btnOptionQuanly_Click);
            // 
            // btnOptionThongke
            // 
            this.btnOptionThongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionThongke.Location = new System.Drawing.Point(6, 179);
            this.btnOptionThongke.MaximumSize = new System.Drawing.Size(96, 45);
            this.btnOptionThongke.MinimumSize = new System.Drawing.Size(96, 45);
            this.btnOptionThongke.Name = "btnOptionThongke";
            this.btnOptionThongke.Size = new System.Drawing.Size(96, 45);
            this.btnOptionThongke.TabIndex = 3;
            this.btnOptionThongke.Text = "Thống kê";
            this.btnOptionThongke.UseVisualStyleBackColor = true;
            this.btnOptionThongke.Click += new System.EventHandler(this.btnOptionThongke_Click);
            // 
            // btnOptionHanghoa
            // 
            this.btnOptionHanghoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionHanghoa.Location = new System.Drawing.Point(6, 128);
            this.btnOptionHanghoa.MaximumSize = new System.Drawing.Size(96, 45);
            this.btnOptionHanghoa.MinimumSize = new System.Drawing.Size(96, 45);
            this.btnOptionHanghoa.Name = "btnOptionHanghoa";
            this.btnOptionHanghoa.Size = new System.Drawing.Size(96, 45);
            this.btnOptionHanghoa.TabIndex = 2;
            this.btnOptionHanghoa.Text = "Linh kiện";
            this.btnOptionHanghoa.UseVisualStyleBackColor = true;
            this.btnOptionHanghoa.Click += new System.EventHandler(this.btnOptionHanghoa_Click);
            // 
            // btnOptionHoadon
            // 
            this.btnOptionHoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionHoadon.Location = new System.Drawing.Point(6, 77);
            this.btnOptionHoadon.MaximumSize = new System.Drawing.Size(96, 45);
            this.btnOptionHoadon.MinimumSize = new System.Drawing.Size(96, 45);
            this.btnOptionHoadon.Name = "btnOptionHoadon";
            this.btnOptionHoadon.Size = new System.Drawing.Size(96, 45);
            this.btnOptionHoadon.TabIndex = 1;
            this.btnOptionHoadon.Text = "Đơn hàng";
            this.btnOptionHoadon.UseVisualStyleBackColor = true;
            this.btnOptionHoadon.Click += new System.EventHandler(this.btnOptionHoadon_Click);
            // 
            // btnOptionBanHang
            // 
            this.btnOptionBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionBanHang.Location = new System.Drawing.Point(6, 26);
            this.btnOptionBanHang.MaximumSize = new System.Drawing.Size(96, 45);
            this.btnOptionBanHang.MinimumSize = new System.Drawing.Size(96, 45);
            this.btnOptionBanHang.Name = "btnOptionBanHang";
            this.btnOptionBanHang.Size = new System.Drawing.Size(96, 45);
            this.btnOptionBanHang.TabIndex = 0;
            this.btnOptionBanHang.Text = "Bán hàng";
            this.btnOptionBanHang.UseVisualStyleBackColor = true;
            this.btnOptionBanHang.Click += new System.EventHandler(this.btnOptionBanHang_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelVersion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 503);
            this.panel1.MaximumSize = new System.Drawing.Size(1102, 35);
            this.panel1.MinimumSize = new System.Drawing.Size(1102, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 35);
            this.panel1.TabIndex = 2;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(1042, 9);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(31, 13);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "1.0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(999, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Version: ";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(61, 7);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(28, 15);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "root";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account: ";
            // 
            // panelForm
            // 
            this.panelForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelForm.Location = new System.Drawing.Point(3, 19);
            this.panelForm.MaximumSize = new System.Drawing.Size(938, 445);
            this.panelForm.MinimumSize = new System.Drawing.Size(938, 445);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(938, 445);
            this.panelForm.TabIndex = 3;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.panelForm);
            this.titlePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlePanel.Location = new System.Drawing.Point(130, 27);
            this.titlePanel.MaximumSize = new System.Drawing.Size(944, 470);
            this.titlePanel.MinimumSize = new System.Drawing.Size(944, 470);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(944, 470);
            this.titlePanel.TabIndex = 4;
            this.titlePanel.TabStop = false;
            this.titlePanel.Text = "Title";
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lbDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateTime.Location = new System.Drawing.Point(900, 0);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(29, 20);
            this.lbDateTime.TabIndex = 5;
            this.lbDateTime.Text = "     ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 538);
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1102, 577);
            this.MinimumSize = new System.Drawing.Size(1102, 577);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý mua bán linh kiện | Nhóm 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exitToolStripMenuItem_Click);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOptionBanHang;
        private System.Windows.Forms.Button btnOptionQuanly;
        private System.Windows.Forms.Button btnOptionThongke;
        private System.Windows.Forms.Button btnOptionHanghoa;
        private System.Windows.Forms.Button btnOptionHoadon;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.GroupBox titlePanel;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
    }
}