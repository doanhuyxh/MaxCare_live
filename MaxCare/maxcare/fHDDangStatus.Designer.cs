﻿namespace maxcare
{
	// Token: 0x02000103 RID: 259
	public partial class fHDDangStatus : global::System.Windows.Forms.Form
	{
		// Token: 0x06000AFD RID: 2813 RVA: 0x0017744C File Offset: 0x0017564C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x001774AC File Offset: 0x001756AC
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
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.nudKhoangCachTo = new System.Windows.Forms.NumericUpDown();
            this.nudKhoangCachFrom = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.plTag = new System.Windows.Forms.Panel();
            this.plUidTuNhap = new System.Windows.Forms.Panel();
            this.lbUid = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUidTag = new System.Windows.Forms.RichTextBox();
            this.rbUidTuNhap = new System.Windows.Forms.RadioButton();
            this.rbUidBanBe = new System.Windows.Forms.RadioButton();
            this.nudUidTo = new System.Windows.Forms.NumericUpDown();
            this.nudUidFrom = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.plVanBan = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDown = new MetroFramework.Controls.MetroButton();
            this.button4 = new System.Windows.Forms.Button();
            this.btnUp = new MetroFramework.Controls.MetroButton();
            this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
            this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.plVideo = new System.Windows.Forms.Panel();
            this.nudSoLuongVideoTo = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuongVideoFrom = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPathVideo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.plAnh = new System.Windows.Forms.Panel();
            this.nudSoLuongAnhTo = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuongAnhFrom = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtPathAnh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbVideo = new System.Windows.Forms.CheckBox();
            this.ckbTag = new System.Windows.Forms.CheckBox();
            this.ckbUseBackground = new System.Windows.Forms.CheckBox();
            this.ckbAnh = new System.Windows.Forms.CheckBox();
            this.ckbVanBan = new System.Windows.Forms.CheckBox();
            this.txtTenHanhDong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKhoangCachTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKhoangCachFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongFrom)).BeginInit();
            this.plTag.SuspendLayout();
            this.plUidTuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUidTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUidFrom)).BeginInit();
            this.plVanBan.SuspendLayout();
            this.plVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongVideoTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongVideoFrom)).BeginInit();
            this.plAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongAnhTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongAnhFrom)).BeginInit();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(680, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Đăng status";
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
            this.pnlHeader.Size = new System.Drawing.Size(680, 31);
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
            this.button1.Location = new System.Drawing.Point(649, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 0;
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.nudKhoangCachTo);
            this.panel1.Controls.Add(this.nudKhoangCachFrom);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.nudSoLuongTo);
            this.panel1.Controls.Add(this.nudSoLuongFrom);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.plTag);
            this.panel1.Controls.Add(this.plVanBan);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.plVideo);
            this.panel1.Controls.Add(this.plAnh);
            this.panel1.Controls.Add(this.ckbVideo);
            this.panel1.Controls.Add(this.ckbTag);
            this.panel1.Controls.Add(this.ckbUseBackground);
            this.panel1.Controls.Add(this.ckbAnh);
            this.panel1.Controls.Add(this.ckbVanBan);
            this.panel1.Controls.Add(this.txtTenHanhDong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 591);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(291, 108);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 21);
            this.label19.TabIndex = 43;
            this.label19.Text = "giây";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(205, 108);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 16);
            this.label20.TabIndex = 42;
            this.label20.Text = "đến";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudKhoangCachTo
            // 
            this.nudKhoangCachTo.Location = new System.Drawing.Point(236, 106);
            this.nudKhoangCachTo.Name = "nudKhoangCachTo";
            this.nudKhoangCachTo.Size = new System.Drawing.Size(51, 27);
            this.nudKhoangCachTo.TabIndex = 41;
            // 
            // nudKhoangCachFrom
            // 
            this.nudKhoangCachFrom.Location = new System.Drawing.Point(151, 106);
            this.nudKhoangCachFrom.Name = "nudKhoangCachFrom";
            this.nudKhoangCachFrom.Size = new System.Drawing.Size(51, 27);
            this.nudKhoangCachFrom.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(291, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 21);
            this.label18.TabIndex = 39;
            this.label18.Text = "bài";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(205, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 16);
            this.label17.TabIndex = 38;
            this.label17.Text = "đến";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudSoLuongTo
            // 
            this.nudSoLuongTo.Location = new System.Drawing.Point(236, 78);
            this.nudSoLuongTo.Name = "nudSoLuongTo";
            this.nudSoLuongTo.Size = new System.Drawing.Size(51, 27);
            this.nudSoLuongTo.TabIndex = 37;
            // 
            // nudSoLuongFrom
            // 
            this.nudSoLuongFrom.Location = new System.Drawing.Point(151, 78);
            this.nudSoLuongFrom.Name = "nudSoLuongFrom";
            this.nudSoLuongFrom.Size = new System.Drawing.Size(51, 27);
            this.nudSoLuongFrom.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 21);
            this.label16.TabIndex = 35;
            this.label16.Text = "Khoảng cách đăng:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 21);
            this.label15.TabIndex = 34;
            this.label15.Text = "Số lượng bài viết:";
            // 
            // plTag
            // 
            this.plTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plTag.Controls.Add(this.plUidTuNhap);
            this.plTag.Controls.Add(this.rbUidTuNhap);
            this.plTag.Controls.Add(this.rbUidBanBe);
            this.plTag.Controls.Add(this.nudUidTo);
            this.plTag.Controls.Add(this.nudUidFrom);
            this.plTag.Controls.Add(this.label12);
            this.plTag.Controls.Add(this.label10);
            this.plTag.Controls.Add(this.label13);
            this.plTag.Controls.Add(this.label14);
            this.plTag.Enabled = false;
            this.plTag.Location = new System.Drawing.Point(369, 266);
            this.plTag.Name = "plTag";
            this.plTag.Size = new System.Drawing.Size(278, 255);
            this.plTag.TabIndex = 33;
            // 
            // plUidTuNhap
            // 
            this.plUidTuNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plUidTuNhap.Controls.Add(this.lbUid);
            this.plUidTuNhap.Controls.Add(this.label11);
            this.plUidTuNhap.Controls.Add(this.txtUidTag);
            this.plUidTuNhap.Location = new System.Drawing.Point(17, 97);
            this.plUidTuNhap.Name = "plUidTuNhap";
            this.plUidTuNhap.Size = new System.Drawing.Size(248, 151);
            this.plUidTuNhap.TabIndex = 34;
            // 
            // lbUid
            // 
            this.lbUid.AutoSize = true;
            this.lbUid.Location = new System.Drawing.Point(3, 3);
            this.lbUid.Name = "lbUid";
            this.lbUid.Size = new System.Drawing.Size(151, 21);
            this.lbUid.TabIndex = 0;
            this.lbUid.Text = "Danh sách Uid (0):";
            this.lbUid.Click += new System.EventHandler(this.lbUid_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "(Mỗi nội dung 1 dòng)";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtUidTag
            // 
            this.txtUidTag.Location = new System.Drawing.Point(7, 22);
            this.txtUidTag.Name = "txtUidTag";
            this.txtUidTag.Size = new System.Drawing.Size(236, 102);
            this.txtUidTag.TabIndex = 34;
            this.txtUidTag.Text = "";
            this.txtUidTag.WordWrap = false;
            this.txtUidTag.TextChanged += new System.EventHandler(this.txtUid_TextChanged);
            // 
            // rbUidTuNhap
            // 
            this.rbUidTuNhap.AutoSize = true;
            this.rbUidTuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbUidTuNhap.Location = new System.Drawing.Point(17, 73);
            this.rbUidTuNhap.Name = "rbUidTuNhap";
            this.rbUidTuNhap.Size = new System.Drawing.Size(239, 25);
            this.rbUidTuNhap.TabIndex = 42;
            this.rbUidTuNhap.Text = "Theo danh sách Uid tự nhập";
            this.rbUidTuNhap.UseVisualStyleBackColor = true;
            this.rbUidTuNhap.CheckedChanged += new System.EventHandler(this.rbUidTuNhap_CheckedChanged);
            // 
            // rbUidBanBe
            // 
            this.rbUidBanBe.AutoSize = true;
            this.rbUidBanBe.Checked = true;
            this.rbUidBanBe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbUidBanBe.Location = new System.Drawing.Point(17, 50);
            this.rbUidBanBe.Name = "rbUidBanBe";
            this.rbUidBanBe.Size = new System.Drawing.Size(249, 25);
            this.rbUidBanBe.TabIndex = 42;
            this.rbUidBanBe.TabStop = true;
            this.rbUidBanBe.Text = "Ngẫu nhiên danh sách bạn bè";
            this.rbUidBanBe.UseVisualStyleBackColor = true;
            // 
            // nudUidTo
            // 
            this.nudUidTo.Location = new System.Drawing.Point(208, 4);
            this.nudUidTo.Name = "nudUidTo";
            this.nudUidTo.Size = new System.Drawing.Size(36, 27);
            this.nudUidTo.TabIndex = 39;
            // 
            // nudUidFrom
            // 
            this.nudUidFrom.Location = new System.Drawing.Point(137, 4);
            this.nudUidFrom.Name = "nudUidFrom";
            this.nudUidFrom.Size = new System.Drawing.Size(36, 27);
            this.nudUidFrom.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tùy chọn Uid để tag:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Số Uid cần tag/bài:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(176, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 16);
            this.label13.TabIndex = 41;
            this.label13.Text = "đến";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(244, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 21);
            this.label14.TabIndex = 40;
            this.label14.Text = "Uid";
            // 
            // plVanBan
            // 
            this.plVanBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plVanBan.Controls.Add(this.linkLabel1);
            this.plVanBan.Controls.Add(this.button3);
            this.plVanBan.Controls.Add(this.button2);
            this.plVanBan.Controls.Add(this.btnDown);
            this.plVanBan.Controls.Add(this.button4);
            this.plVanBan.Controls.Add(this.btnUp);
            this.plVanBan.Controls.Add(this.rbNganCachKyTu);
            this.plVanBan.Controls.Add(this.rbNganCachMoiDong);
            this.plVanBan.Controls.Add(this.label9);
            this.plVanBan.Controls.Add(this.txtNoiDung);
            this.plVanBan.Controls.Add(this.label8);
            this.plVanBan.Controls.Add(this.lblStatus);
            this.plVanBan.Location = new System.Drawing.Point(47, 159);
            this.plVanBan.Name = "plVanBan";
            this.plVanBan.Size = new System.Drawing.Size(278, 276);
            this.plVanBan.TabIndex = 33;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(165, 252);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(106, 21);
            this.linkLabel1.TabIndex = 111;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Random icon";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Help;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(225, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 23);
            this.button3.TabIndex = 96;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Help;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(247, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 95;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnDown
            // 
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.Location = new System.Drawing.Point(221, -1);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(25, 25);
            this.btnDown.TabIndex = 38;
            this.btnDown.UseSelectable = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Help;
            this.button4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(225, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 23);
            this.button4.TabIndex = 97;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUp
            // 
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.Location = new System.Drawing.Point(252, -1);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(25, 25);
            this.btnUp.TabIndex = 39;
            this.btnUp.UseSelectable = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // rbNganCachKyTu
            // 
            this.rbNganCachKyTu.AutoSize = true;
            this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNganCachKyTu.Location = new System.Drawing.Point(69, 298);
            this.rbNganCachKyTu.Name = "rbNganCachKyTu";
            this.rbNganCachKyTu.Size = new System.Drawing.Size(204, 25);
            this.rbNganCachKyTu.TabIndex = 37;
            this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
            this.rbNganCachKyTu.UseVisualStyleBackColor = true;
            this.rbNganCachKyTu.CheckedChanged += new System.EventHandler(this.rbNganCachKyTu_CheckedChanged);
            // 
            // rbNganCachMoiDong
            // 
            this.rbNganCachMoiDong.AutoSize = true;
            this.rbNganCachMoiDong.Checked = true;
            this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNganCachMoiDong.Location = new System.Drawing.Point(69, 277);
            this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
            this.rbNganCachMoiDong.Size = new System.Drawing.Size(199, 25);
            this.rbNganCachMoiDong.TabIndex = 36;
            this.rbNganCachMoiDong.TabStop = true;
            this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
            this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
            this.rbNganCachMoiDong.CheckedChanged += new System.EventHandler(this.rbNganCachMoiDong_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 21);
            this.label9.TabIndex = 35;
            this.label9.Text = "Tùy chọn:";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(7, 24);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(263, 225);
            this.txtNoiDung.TabIndex = 34;
            this.txtNoiDung.Text = "";
            this.txtNoiDung.WordWrap = false;
            this.txtNoiDung.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "(Spin nội dung {a|b|c})";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(3, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(190, 21);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Danh sách nội dung (0):";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(120)))), ((int)(((byte)(229)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(245, 544);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // plVideo
            // 
            this.plVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plVideo.Controls.Add(this.nudSoLuongVideoTo);
            this.plVideo.Controls.Add(this.nudSoLuongVideoFrom);
            this.plVideo.Controls.Add(this.label5);
            this.plVideo.Controls.Add(this.label6);
            this.plVideo.Controls.Add(this.label22);
            this.plVideo.Controls.Add(this.txtPathVideo);
            this.plVideo.Controls.Add(this.label7);
            this.plVideo.Location = new System.Drawing.Point(369, 181);
            this.plVideo.Name = "plVideo";
            this.plVideo.Size = new System.Drawing.Size(278, 58);
            this.plVideo.TabIndex = 33;
            // 
            // nudSoLuongVideoTo
            // 
            this.nudSoLuongVideoTo.Location = new System.Drawing.Point(196, 30);
            this.nudSoLuongVideoTo.Name = "nudSoLuongVideoTo";
            this.nudSoLuongVideoTo.Size = new System.Drawing.Size(45, 27);
            this.nudSoLuongVideoTo.TabIndex = 12;
            // 
            // nudSoLuongVideoFrom
            // 
            this.nudSoLuongVideoFrom.Location = new System.Drawing.Point(119, 30);
            this.nudSoLuongVideoFrom.Name = "nudSoLuongVideoFrom";
            this.nudSoLuongVideoFrom.Size = new System.Drawing.Size(45, 27);
            this.nudSoLuongVideoFrom.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(165, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "đến";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "video";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 32);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(153, 21);
            this.label22.TabIndex = 11;
            this.label22.Text = "Số lượng video/bài:";
            // 
            // txtPathVideo
            // 
            this.txtPathVideo.Location = new System.Drawing.Point(148, 2);
            this.txtPathVideo.Name = "txtPathVideo";
            this.txtPathVideo.Size = new System.Drawing.Size(126, 27);
            this.txtPathVideo.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đường dẫn folder video:";
            // 
            // plAnh
            // 
            this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plAnh.Controls.Add(this.nudSoLuongAnhTo);
            this.plAnh.Controls.Add(this.nudSoLuongAnhFrom);
            this.plAnh.Controls.Add(this.label2);
            this.plAnh.Controls.Add(this.label4);
            this.plAnh.Controls.Add(this.label21);
            this.plAnh.Controls.Add(this.txtPathAnh);
            this.plAnh.Controls.Add(this.label3);
            this.plAnh.Location = new System.Drawing.Point(47, 463);
            this.plAnh.Name = "plAnh";
            this.plAnh.Size = new System.Drawing.Size(278, 58);
            this.plAnh.TabIndex = 33;
            // 
            // nudSoLuongAnhTo
            // 
            this.nudSoLuongAnhTo.Location = new System.Drawing.Point(196, 29);
            this.nudSoLuongAnhTo.Name = "nudSoLuongAnhTo";
            this.nudSoLuongAnhTo.Size = new System.Drawing.Size(45, 27);
            this.nudSoLuongAnhTo.TabIndex = 7;
            // 
            // nudSoLuongAnhFrom
            // 
            this.nudSoLuongAnhFrom.Location = new System.Drawing.Point(119, 29);
            this.nudSoLuongAnhFrom.Name = "nudSoLuongAnhFrom";
            this.nudSoLuongAnhFrom.Size = new System.Drawing.Size(45, 27);
            this.nudSoLuongAnhFrom.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(167, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "đến";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "ảnh";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(141, 21);
            this.label21.TabIndex = 6;
            this.label21.Text = "Số lượng ảnh/bài:";
            // 
            // txtPathAnh
            // 
            this.txtPathAnh.Location = new System.Drawing.Point(136, 2);
            this.txtPathAnh.Name = "txtPathAnh";
            this.txtPathAnh.Size = new System.Drawing.Size(138, 27);
            this.txtPathAnh.TabIndex = 1;
            this.txtPathAnh.TextChanged += new System.EventHandler(this.txtPathAnh_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đường dẫn folder ảnh:";
            // 
            // ckbVideo
            // 
            this.ckbVideo.AutoSize = true;
            this.ckbVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbVideo.Location = new System.Drawing.Point(355, 159);
            this.ckbVideo.Name = "ckbVideo";
            this.ckbVideo.Size = new System.Drawing.Size(73, 25);
            this.ckbVideo.TabIndex = 32;
            this.ckbVideo.Text = "Video";
            this.ckbVideo.UseVisualStyleBackColor = true;
            this.ckbVideo.CheckedChanged += new System.EventHandler(this.ckbVideo_CheckedChanged);
            // 
            // ckbTag
            // 
            this.ckbTag.AutoSize = true;
            this.ckbTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTag.Location = new System.Drawing.Point(355, 242);
            this.ckbTag.Name = "ckbTag";
            this.ckbTag.Size = new System.Drawing.Size(179, 25);
            this.ckbTag.TabIndex = 32;
            this.ckbTag.Text = "Tag Uid vào bài viết";
            this.ckbTag.UseVisualStyleBackColor = true;
            this.ckbTag.CheckedChanged += new System.EventHandler(this.ckbTag_CheckedChanged);
            // 
            // ckbUseBackground
            // 
            this.ckbUseBackground.AutoSize = true;
            this.ckbUseBackground.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbUseBackground.Location = new System.Drawing.Point(355, 135);
            this.ckbUseBackground.Name = "ckbUseBackground";
            this.ckbUseBackground.Size = new System.Drawing.Size(183, 25);
            this.ckbUseBackground.TabIndex = 32;
            this.ckbUseBackground.Text = "Sử dụng Background";
            this.ckbUseBackground.UseVisualStyleBackColor = true;
            this.ckbUseBackground.CheckedChanged += new System.EventHandler(this.ckbUseBackground_CheckedChanged);
            // 
            // ckbAnh
            // 
            this.ckbAnh.AutoSize = true;
            this.ckbAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbAnh.Location = new System.Drawing.Point(33, 441);
            this.ckbAnh.Name = "ckbAnh";
            this.ckbAnh.Size = new System.Drawing.Size(61, 25);
            this.ckbAnh.TabIndex = 32;
            this.ckbAnh.Text = "Ảnh";
            this.ckbAnh.UseVisualStyleBackColor = true;
            this.ckbAnh.CheckedChanged += new System.EventHandler(this.ckbAnh_CheckedChanged);
            // 
            // ckbVanBan
            // 
            this.ckbVanBan.AutoSize = true;
            this.ckbVanBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbVanBan.Location = new System.Drawing.Point(33, 135);
            this.ckbVanBan.Name = "ckbVanBan";
            this.ckbVanBan.Size = new System.Drawing.Size(92, 25);
            this.ckbVanBan.TabIndex = 32;
            this.ckbVanBan.Text = "Văn bản";
            this.ckbVanBan.UseVisualStyleBackColor = true;
            this.ckbVanBan.CheckedChanged += new System.EventHandler(this.ckbVanBan_CheckedChanged);
            // 
            // txtTenHanhDong
            // 
            this.txtTenHanhDong.Location = new System.Drawing.Point(151, 49);
            this.txtTenHanhDong.Name = "txtTenHanhDong";
            this.txtTenHanhDong.Size = new System.Drawing.Size(174, 27);
            this.txtTenHanhDong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tên hành động:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(344, 544);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.bunifuCards1.Size = new System.Drawing.Size(680, 37);
            this.bunifuCards1.TabIndex = 28;
            // 
            // fHDDangStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 591);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDDangStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKhoangCachTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKhoangCachFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongFrom)).EndInit();
            this.plTag.ResumeLayout(false);
            this.plTag.PerformLayout();
            this.plUidTuNhap.ResumeLayout(false);
            this.plUidTuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUidTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUidFrom)).EndInit();
            this.plVanBan.ResumeLayout(false);
            this.plVanBan.PerformLayout();
            this.plVideo.ResumeLayout(false);
            this.plVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongVideoTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongVideoFrom)).EndInit();
            this.plAnh.ResumeLayout(false);
            this.plAnh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongAnhTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongAnhFrom)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x0400104D RID: 4173
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400104E RID: 4174
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x0400104F RID: 4175
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04001050 RID: 4176
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04001051 RID: 4177
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04001052 RID: 4178
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04001053 RID: 4179
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04001054 RID: 4180
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04001055 RID: 4181
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04001056 RID: 4182
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04001057 RID: 4183
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04001058 RID: 4184
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04001059 RID: 4185
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x0400105A RID: 4186
		private global::System.Windows.Forms.CheckBox ckbAnh;

		// Token: 0x0400105B RID: 4187
		private global::System.Windows.Forms.CheckBox ckbVanBan;

		// Token: 0x0400105C RID: 4188
		private global::System.Windows.Forms.Panel plVanBan;

		// Token: 0x0400105D RID: 4189
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400105E RID: 4190
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x0400105F RID: 4191
		private global::System.Windows.Forms.Panel plAnh;

		// Token: 0x04001060 RID: 4192
		private global::System.Windows.Forms.TextBox txtPathAnh;

		// Token: 0x04001061 RID: 4193
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04001062 RID: 4194
		private global::System.Windows.Forms.Panel plVideo;

		// Token: 0x04001063 RID: 4195
		private global::System.Windows.Forms.TextBox txtPathVideo;

		// Token: 0x04001064 RID: 4196
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04001065 RID: 4197
		private global::System.Windows.Forms.CheckBox ckbVideo;

		// Token: 0x04001066 RID: 4198
		private global::System.Windows.Forms.RichTextBox txtNoiDung;

		// Token: 0x04001067 RID: 4199
		private global::System.Windows.Forms.RadioButton rbNganCachKyTu;

		// Token: 0x04001068 RID: 4200
		private global::System.Windows.Forms.RadioButton rbNganCachMoiDong;

		// Token: 0x04001069 RID: 4201
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400106A RID: 4202
		private global::MetroFramework.Controls.MetroButton btnDown;

		// Token: 0x0400106B RID: 4203
		private global::MetroFramework.Controls.MetroButton btnUp;

		// Token: 0x0400106C RID: 4204
		private global::System.Windows.Forms.CheckBox ckbUseBackground;

		// Token: 0x0400106D RID: 4205
		private global::System.Windows.Forms.Panel plTag;

		// Token: 0x0400106E RID: 4206
		private global::System.Windows.Forms.RichTextBox txtUidTag;

		// Token: 0x0400106F RID: 4207
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04001070 RID: 4208
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04001071 RID: 4209
		private global::System.Windows.Forms.Label lbUid;

		// Token: 0x04001072 RID: 4210
		private global::System.Windows.Forms.CheckBox ckbTag;

		// Token: 0x04001073 RID: 4211
		private global::System.Windows.Forms.NumericUpDown nudUidTo;

		// Token: 0x04001074 RID: 4212
		private global::System.Windows.Forms.NumericUpDown nudUidFrom;

		// Token: 0x04001075 RID: 4213
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04001076 RID: 4214
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04001077 RID: 4215
		private global::System.Windows.Forms.RadioButton rbUidTuNhap;

		// Token: 0x04001078 RID: 4216
		private global::System.Windows.Forms.RadioButton rbUidBanBe;

		// Token: 0x04001079 RID: 4217
		private global::System.Windows.Forms.Label label12;

		// Token: 0x0400107A RID: 4218
		private global::System.Windows.Forms.Panel plUidTuNhap;

		// Token: 0x0400107B RID: 4219
		private global::System.Windows.Forms.Label label19;

		// Token: 0x0400107C RID: 4220
		private global::System.Windows.Forms.Label label20;

		// Token: 0x0400107D RID: 4221
		private global::System.Windows.Forms.NumericUpDown nudKhoangCachTo;

		// Token: 0x0400107E RID: 4222
		private global::System.Windows.Forms.NumericUpDown nudKhoangCachFrom;

		// Token: 0x0400107F RID: 4223
		private global::System.Windows.Forms.Label label18;

		// Token: 0x04001080 RID: 4224
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04001081 RID: 4225
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x04001082 RID: 4226
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x04001083 RID: 4227
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04001084 RID: 4228
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04001085 RID: 4229
		private global::System.Windows.Forms.NumericUpDown nudSoLuongVideoTo;

		// Token: 0x04001086 RID: 4230
		private global::System.Windows.Forms.NumericUpDown nudSoLuongVideoFrom;

		// Token: 0x04001087 RID: 4231
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04001088 RID: 4232
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04001089 RID: 4233
		private global::System.Windows.Forms.Label label22;

		// Token: 0x0400108A RID: 4234
		private global::System.Windows.Forms.NumericUpDown nudSoLuongAnhTo;

		// Token: 0x0400108B RID: 4235
		private global::System.Windows.Forms.NumericUpDown nudSoLuongAnhFrom;

		// Token: 0x0400108C RID: 4236
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400108D RID: 4237
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400108E RID: 4238
		private global::System.Windows.Forms.Label label21;

		// Token: 0x0400108F RID: 4239
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04001090 RID: 4240
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04001091 RID: 4241
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04001092 RID: 4242
		private global::System.Windows.Forms.LinkLabel linkLabel1;
	}
}
