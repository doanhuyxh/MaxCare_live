﻿namespace maxcare
{
	// Token: 0x02000116 RID: 278
	public partial class fHDKetBanGoiY : global::System.Windows.Forms.Form
	{
		// Token: 0x06000C17 RID: 3095 RVA: 0x001B6D9C File Offset: 0x001B4F9C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x001B6DFC File Offset: 0x001B4FFC
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbOnlyAddFriendWithMutualFriends = new System.Windows.Forms.CheckBox();
            this.ckbChiKetBanTenCoDau = new System.Windows.Forms.CheckBox();
            this.nudTimesWarning = new System.Windows.Forms.NumericUpDown();
            this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
            this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
            this.txtTenHanhDong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimesWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongFrom)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Kết bạn gợi ý";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.pnlHeader;
            this.bunifuDragControl2.Vertical = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.button1);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlHeader.Location = new System.Drawing.Point(0, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(359, 31);
            this.pnlHeader.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::MaxCare.Properties.Resources.close_window_25px;
            this.button1.Location = new System.Drawing.Point(328, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 77;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ckbOnlyAddFriendWithMutualFriends);
            this.panel1.Controls.Add(this.ckbChiKetBanTenCoDau);
            this.panel1.Controls.Add(this.nudTimesWarning);
            this.panel1.Controls.Add(this.nudDelayTo);
            this.panel1.Controls.Add(this.nudDelayFrom);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nudSoLuongTo);
            this.panel1.Controls.Add(this.nudSoLuongFrom);
            this.panel1.Controls.Add(this.txtTenHanhDong);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 274);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ckbOnlyAddFriendWithMutualFriends
            // 
            this.ckbOnlyAddFriendWithMutualFriends.AutoSize = true;
            this.ckbOnlyAddFriendWithMutualFriends.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbOnlyAddFriendWithMutualFriends.Location = new System.Drawing.Point(30, 167);
            this.ckbOnlyAddFriendWithMutualFriends.Name = "ckbOnlyAddFriendWithMutualFriends";
            this.ckbOnlyAddFriendWithMutualFriends.Size = new System.Drawing.Size(290, 25);
            this.ckbOnlyAddFriendWithMutualFriends.TabIndex = 47;
            this.ckbOnlyAddFriendWithMutualFriends.Text = "Chỉ kết bạn với người có bạn chung";
            this.ckbOnlyAddFriendWithMutualFriends.UseVisualStyleBackColor = true;
            // 
            // ckbChiKetBanTenCoDau
            // 
            this.ckbChiKetBanTenCoDau.AutoSize = true;
            this.ckbChiKetBanTenCoDau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbChiKetBanTenCoDau.Location = new System.Drawing.Point(30, 141);
            this.ckbChiKetBanTenCoDau.Name = "ckbChiKetBanTenCoDau";
            this.ckbChiKetBanTenCoDau.Size = new System.Drawing.Size(272, 25);
            this.ckbChiKetBanTenCoDau.TabIndex = 47;
            this.ckbChiKetBanTenCoDau.Text = "Chỉ kết bạn với người có tên Việt";
            this.ckbChiKetBanTenCoDau.UseVisualStyleBackColor = true;
            // 
            // nudTimesWarning
            // 
            this.nudTimesWarning.Location = new System.Drawing.Point(253, 193);
            this.nudTimesWarning.Name = "nudTimesWarning";
            this.nudTimesWarning.Size = new System.Drawing.Size(43, 27);
            this.nudTimesWarning.TabIndex = 4;
            // 
            // nudDelayTo
            // 
            this.nudDelayTo.Location = new System.Drawing.Point(229, 112);
            this.nudDelayTo.Name = "nudDelayTo";
            this.nudDelayTo.Size = new System.Drawing.Size(56, 27);
            this.nudDelayTo.TabIndex = 4;
            // 
            // nudDelayFrom
            // 
            this.nudDelayFrom.Location = new System.Drawing.Point(132, 112);
            this.nudDelayFrom.Name = "nudDelayFrom";
            this.nudDelayFrom.Size = new System.Drawing.Size(56, 27);
            this.nudDelayFrom.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 21);
            this.label9.TabIndex = 45;
            this.label9.Text = "lần";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(194, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "đến";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 45;
            this.label6.Text = "giây";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(292, 21);
            this.label8.TabIndex = 44;
            this.label8.Text = "Dừng khi gặp cảnh báo của Facebook:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "Thời gian chờ:";
            // 
            // nudSoLuongTo
            // 
            this.nudSoLuongTo.Location = new System.Drawing.Point(229, 81);
            this.nudSoLuongTo.Name = "nudSoLuongTo";
            this.nudSoLuongTo.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongTo.TabIndex = 2;
            // 
            // nudSoLuongFrom
            // 
            this.nudSoLuongFrom.Location = new System.Drawing.Point(132, 81);
            this.nudSoLuongFrom.Name = "nudSoLuongFrom";
            this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongFrom.TabIndex = 1;
            // 
            // txtTenHanhDong
            // 
            this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
            this.txtTenHanhDong.Name = "txtTenHanhDong";
            this.txtTenHanhDong.Size = new System.Drawing.Size(194, 27);
            this.txtTenHanhDong.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(194, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "đến";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "bạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Số lượng bạn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tên hành động:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(187, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(120)))), ((int)(((byte)(229)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(80, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 29);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
            this.bunifuCards1.Controls.Add(this.pnlHeader);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(359, 37);
            this.bunifuCards1.TabIndex = 28;
            // 
            // fHDKetBanGoiY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 274);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDKetBanGoiY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimesWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongFrom)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x0400137E RID: 4990
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400137F RID: 4991
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04001380 RID: 4992
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04001381 RID: 4993
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04001382 RID: 4994
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x04001383 RID: 4995
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x04001384 RID: 4996
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04001385 RID: 4997
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04001386 RID: 4998
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04001387 RID: 4999
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04001388 RID: 5000
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04001389 RID: 5001
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x0400138A RID: 5002
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x0400138B RID: 5003
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x0400138C RID: 5004
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x0400138D RID: 5005
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400138E RID: 5006
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400138F RID: 5007
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04001390 RID: 5008
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x04001391 RID: 5009
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x04001392 RID: 5010
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04001393 RID: 5011
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04001394 RID: 5012
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04001395 RID: 5013
		private global::System.Windows.Forms.NumericUpDown nudTimesWarning;

		// Token: 0x04001396 RID: 5014
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04001397 RID: 5015
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04001398 RID: 5016
		private global::System.Windows.Forms.CheckBox ckbChiKetBanTenCoDau;

		// Token: 0x04001399 RID: 5017
		private global::System.Windows.Forms.CheckBox ckbOnlyAddFriendWithMutualFriends;
	}
}
