﻿namespace maxcare
{
	// Token: 0x0200011F RID: 287
	public partial class fHDXemStory : global::System.Windows.Forms.Form
	{
		// Token: 0x06000CB0 RID: 3248 RVA: 0x001D40FC File Offset: 0x001D22FC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x001D415C File Offset: 0x001D235C
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
            this.plComment = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.plInteract = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.ckbGian = new System.Windows.Forms.CheckBox();
            this.ckbBuon = new System.Windows.Forms.CheckBox();
            this.ckbWow = new System.Windows.Forms.CheckBox();
            this.ckbHaha = new System.Windows.Forms.CheckBox();
            this.ckbThuong = new System.Windows.Forms.CheckBox();
            this.ckbTym = new System.Windows.Forms.CheckBox();
            this.ckbLike = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.ckbComment = new System.Windows.Forms.CheckBox();
            this.ckbInteract = new System.Windows.Forms.CheckBox();
            this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
            this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
            this.txtTenHanhDong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.plComment.SuspendLayout();
            this.plInteract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).BeginInit();
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
            this.bunifuCustomLabel1.Text = "Cấu hình Xem Story";
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
            this.panel1.Controls.Add(this.plComment);
            this.panel1.Controls.Add(this.plInteract);
            this.panel1.Controls.Add(this.ckbComment);
            this.panel1.Controls.Add(this.ckbInteract);
            this.panel1.Controls.Add(this.nudDelayTo);
            this.panel1.Controls.Add(this.nudSoLuongTo);
            this.panel1.Controls.Add(this.nudDelayFrom);
            this.panel1.Controls.Add(this.nudSoLuongFrom);
            this.panel1.Controls.Add(this.txtTenHanhDong);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 447);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // plComment
            // 
            this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plComment.Controls.Add(this.button2);
            this.plComment.Controls.Add(this.label8);
            this.plComment.Controls.Add(this.txtComment);
            this.plComment.Controls.Add(this.lblStatus);
            this.plComment.Location = new System.Drawing.Point(48, 234);
            this.plComment.Name = "plComment";
            this.plComment.Size = new System.Drawing.Size(278, 164);
            this.plComment.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Help;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(246, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(342, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(7, 27);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComment.Size = new System.Drawing.Size(261, 111);
            this.txtComment.TabIndex = 1;
            this.txtComment.WordWrap = false;
            this.txtComment.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(3, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(181, 21);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Nội dung bình luận (0):";
            // 
            // plInteract
            // 
            this.plInteract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plInteract.Controls.Add(this.label25);
            this.plInteract.Controls.Add(this.label26);
            this.plInteract.Controls.Add(this.label27);
            this.plInteract.Controls.Add(this.label28);
            this.plInteract.Controls.Add(this.label29);
            this.plInteract.Controls.Add(this.label30);
            this.plInteract.Controls.Add(this.ckbGian);
            this.plInteract.Controls.Add(this.ckbBuon);
            this.plInteract.Controls.Add(this.ckbWow);
            this.plInteract.Controls.Add(this.ckbHaha);
            this.plInteract.Controls.Add(this.ckbThuong);
            this.plInteract.Controls.Add(this.ckbTym);
            this.plInteract.Controls.Add(this.ckbLike);
            this.plInteract.Controls.Add(this.label32);
            this.plInteract.Location = new System.Drawing.Point(48, 165);
            this.plInteract.Name = "plInteract";
            this.plInteract.Size = new System.Drawing.Size(278, 40);
            this.plInteract.TabIndex = 6;
            // 
            // label25
            // 
            this.label25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label25.Location = new System.Drawing.Point(4, 1);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(30, 16);
            this.label25.TabIndex = 0;
            this.label25.Text = "Like";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // label26
            // 
            this.label26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label26.Location = new System.Drawing.Point(40, 1);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(33, 16);
            this.label26.TabIndex = 2;
            this.label26.Text = "Tym";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // label27
            // 
            this.label27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label27.Location = new System.Drawing.Point(75, 1);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 16);
            this.label27.TabIndex = 4;
            this.label27.Text = "Thương";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // label28
            // 
            this.label28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label28.Location = new System.Drawing.Point(128, 1);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(37, 16);
            this.label28.TabIndex = 6;
            this.label28.Text = "Haha";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label28.Click += new System.EventHandler(this.label28_Click);
            // 
            // label29
            // 
            this.label29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label29.Location = new System.Drawing.Point(167, 1);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(37, 16);
            this.label29.TabIndex = 8;
            this.label29.Text = "Wow";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // label30
            // 
            this.label30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label30.Location = new System.Drawing.Point(206, 1);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(36, 16);
            this.label30.TabIndex = 10;
            this.label30.Text = "Buồn";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label30.Click += new System.EventHandler(this.label30_Click);
            // 
            // ckbGian
            // 
            this.ckbGian.AutoSize = true;
            this.ckbGian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbGian.Location = new System.Drawing.Point(252, 20);
            this.ckbGian.Name = "ckbGian";
            this.ckbGian.Size = new System.Drawing.Size(18, 17);
            this.ckbGian.TabIndex = 13;
            this.ckbGian.UseVisualStyleBackColor = true;
            // 
            // ckbBuon
            // 
            this.ckbBuon.AutoSize = true;
            this.ckbBuon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbBuon.Location = new System.Drawing.Point(218, 20);
            this.ckbBuon.Name = "ckbBuon";
            this.ckbBuon.Size = new System.Drawing.Size(18, 17);
            this.ckbBuon.TabIndex = 11;
            this.ckbBuon.UseVisualStyleBackColor = true;
            // 
            // ckbWow
            // 
            this.ckbWow.AutoSize = true;
            this.ckbWow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbWow.Location = new System.Drawing.Point(179, 20);
            this.ckbWow.Name = "ckbWow";
            this.ckbWow.Size = new System.Drawing.Size(18, 17);
            this.ckbWow.TabIndex = 9;
            this.ckbWow.UseVisualStyleBackColor = true;
            // 
            // ckbHaha
            // 
            this.ckbHaha.AutoSize = true;
            this.ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbHaha.Location = new System.Drawing.Point(139, 20);
            this.ckbHaha.Name = "ckbHaha";
            this.ckbHaha.Size = new System.Drawing.Size(18, 17);
            this.ckbHaha.TabIndex = 7;
            this.ckbHaha.UseVisualStyleBackColor = true;
            // 
            // ckbThuong
            // 
            this.ckbThuong.AutoSize = true;
            this.ckbThuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbThuong.Location = new System.Drawing.Point(94, 20);
            this.ckbThuong.Name = "ckbThuong";
            this.ckbThuong.Size = new System.Drawing.Size(18, 17);
            this.ckbThuong.TabIndex = 5;
            this.ckbThuong.UseVisualStyleBackColor = true;
            // 
            // ckbTym
            // 
            this.ckbTym.AutoSize = true;
            this.ckbTym.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTym.Location = new System.Drawing.Point(48, 20);
            this.ckbTym.Name = "ckbTym";
            this.ckbTym.Size = new System.Drawing.Size(18, 17);
            this.ckbTym.TabIndex = 3;
            this.ckbTym.UseVisualStyleBackColor = true;
            // 
            // ckbLike
            // 
            this.ckbLike.AutoSize = true;
            this.ckbLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbLike.Location = new System.Drawing.Point(11, 20);
            this.ckbLike.Name = "ckbLike";
            this.ckbLike.Size = new System.Drawing.Size(18, 17);
            this.ckbLike.TabIndex = 1;
            this.ckbLike.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label32.Location = new System.Drawing.Point(242, 1);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(33, 16);
            this.label32.TabIndex = 12;
            this.label32.Text = "Giận";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label32.Click += new System.EventHandler(this.label32_Click);
            // 
            // ckbComment
            // 
            this.ckbComment.AutoSize = true;
            this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbComment.Location = new System.Drawing.Point(30, 209);
            this.ckbComment.Name = "ckbComment";
            this.ckbComment.Size = new System.Drawing.Size(166, 25);
            this.ckbComment.TabIndex = 7;
            this.ckbComment.Text = "Tự động bình luận";
            this.ckbComment.UseVisualStyleBackColor = true;
            this.ckbComment.CheckedChanged += new System.EventHandler(this.ckbComment_CheckedChanged);
            // 
            // ckbInteract
            // 
            this.ckbInteract.AutoSize = true;
            this.ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbInteract.Location = new System.Drawing.Point(30, 141);
            this.ckbInteract.Name = "ckbInteract";
            this.ckbInteract.Size = new System.Drawing.Size(145, 25);
            this.ckbInteract.TabIndex = 5;
            this.ckbInteract.Text = "Bày tỏ cảm xúc";
            this.ckbInteract.UseVisualStyleBackColor = true;
            this.ckbInteract.CheckedChanged += new System.EventHandler(this.ckbInteract_CheckedChanged);
            // 
            // nudDelayTo
            // 
            this.nudDelayTo.Location = new System.Drawing.Point(229, 111);
            this.nudDelayTo.Name = "nudDelayTo";
            this.nudDelayTo.Size = new System.Drawing.Size(56, 27);
            this.nudDelayTo.TabIndex = 4;
            // 
            // nudSoLuongTo
            // 
            this.nudSoLuongTo.Location = new System.Drawing.Point(229, 80);
            this.nudSoLuongTo.Name = "nudSoLuongTo";
            this.nudSoLuongTo.Size = new System.Drawing.Size(56, 27);
            this.nudSoLuongTo.TabIndex = 2;
            // 
            // nudDelayFrom
            // 
            this.nudDelayFrom.Location = new System.Drawing.Point(132, 111);
            this.nudDelayFrom.Name = "nudDelayFrom";
            this.nudDelayFrom.Size = new System.Drawing.Size(56, 27);
            this.nudDelayFrom.TabIndex = 3;
            // 
            // nudSoLuongFrom
            // 
            this.nudSoLuongFrom.Location = new System.Drawing.Point(132, 80);
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
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(194, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "đến";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(194, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "đến";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "giây";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "story";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Thời gian chờ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Số lượng story:";
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
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(189, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(120)))), ((int)(((byte)(229)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(82, 406);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 29);
            this.btnAdd.TabIndex = 9;
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
            // fHDXemStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 447);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDXemStory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plComment.ResumeLayout(false);
            this.plComment.PerformLayout();
            this.plInteract.ResumeLayout(false);
            this.plInteract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongFrom)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x040014F1 RID: 5361
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040014F2 RID: 5362
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040014F3 RID: 5363
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x040014F4 RID: 5364
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040014F5 RID: 5365
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x040014F6 RID: 5366
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x040014F7 RID: 5367
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x040014F8 RID: 5368
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x040014F9 RID: 5369
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x040014FA RID: 5370
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040014FB RID: 5371
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040014FC RID: 5372
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040014FD RID: 5373
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040014FE RID: 5374
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040014FF RID: 5375
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04001500 RID: 5376
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04001501 RID: 5377
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04001502 RID: 5378
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04001503 RID: 5379
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04001504 RID: 5380
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04001505 RID: 5381
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04001506 RID: 5382
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04001507 RID: 5383
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04001508 RID: 5384
		private global::System.Windows.Forms.Panel plComment;

		// Token: 0x04001509 RID: 5385
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x0400150A RID: 5386
		private global::System.Windows.Forms.Panel plInteract;

		// Token: 0x0400150B RID: 5387
		private global::System.Windows.Forms.Label label25;

		// Token: 0x0400150C RID: 5388
		private global::System.Windows.Forms.Label label26;

		// Token: 0x0400150D RID: 5389
		private global::System.Windows.Forms.Label label27;

		// Token: 0x0400150E RID: 5390
		private global::System.Windows.Forms.Label label28;

		// Token: 0x0400150F RID: 5391
		private global::System.Windows.Forms.Label label29;

		// Token: 0x04001510 RID: 5392
		private global::System.Windows.Forms.Label label30;

		// Token: 0x04001511 RID: 5393
		private global::System.Windows.Forms.CheckBox ckbGian;

		// Token: 0x04001512 RID: 5394
		private global::System.Windows.Forms.CheckBox ckbBuon;

		// Token: 0x04001513 RID: 5395
		private global::System.Windows.Forms.CheckBox ckbWow;

		// Token: 0x04001514 RID: 5396
		private global::System.Windows.Forms.CheckBox ckbHaha;

		// Token: 0x04001515 RID: 5397
		private global::System.Windows.Forms.CheckBox ckbThuong;

		// Token: 0x04001516 RID: 5398
		private global::System.Windows.Forms.CheckBox ckbTym;

		// Token: 0x04001517 RID: 5399
		private global::System.Windows.Forms.CheckBox ckbLike;

		// Token: 0x04001518 RID: 5400
		private global::System.Windows.Forms.Label label32;

		// Token: 0x04001519 RID: 5401
		private global::System.Windows.Forms.CheckBox ckbComment;

		// Token: 0x0400151A RID: 5402
		private global::System.Windows.Forms.CheckBox ckbInteract;

		// Token: 0x0400151B RID: 5403
		private global::System.Windows.Forms.TextBox txtComment;

		// Token: 0x0400151C RID: 5404
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400151D RID: 5405
		private global::System.Windows.Forms.Label label8;
	}
}
