﻿namespace maxcare
{
	// Token: 0x0200008F RID: 143
	public partial class fChiTietBaiViet : global::System.Windows.Forms.Form
	{
		// Token: 0x0600055B RID: 1371 RVA: 0x00075130 File Offset: 0x00073330
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00075190 File Offset: 0x00073390
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNanh = new System.Windows.Forms.Label();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvPic = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtChuDe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPic)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(36, 47);
            this.bunifuCards1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblNanh);
            this.panel1.Controls.Add(this.bunifuCards2);
            this.panel1.Controls.Add(this.dgvPic);
            this.panel1.Controls.Add(this.txtChuDe);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtConten);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 342);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblNanh
            // 
            this.lblNanh.AutoSize = true;
            this.lblNanh.Location = new System.Drawing.Point(6, 100);
            this.lblNanh.Name = "lblNanh";
            this.lblNanh.Size = new System.Drawing.Size(73, 21);
            this.lblNanh.TabIndex = 50;
            this.lblNanh.Text = "Ảnh (0):";
            this.lblNanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 0;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.SaddleBrown;
            this.bunifuCards2.Controls.Add(this.pnlHeader);
            this.bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(363, 37);
            this.bunifuCards2.TabIndex = 43;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.button2);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlHeader.Location = new System.Drawing.Point(0, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(363, 31);
            this.pnlHeader.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::MaxCare.Properties.Resources.close_window_25px;
            this.button2.Location = new System.Drawing.Point(332, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 77;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(899, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(363, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Chi tiết bài viết";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPic
            // 
            this.dgvPic.AllowUserToAddRows = false;
            this.dgvPic.AllowUserToDeleteRows = false;
            this.dgvPic.AllowUserToResizeColumns = false;
            this.dgvPic.AllowUserToResizeRows = false;
            this.dgvPic.BackgroundColor = System.Drawing.Color.White;
            this.dgvPic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPic.ColumnHeadersVisible = false;
            this.dgvPic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.dgvPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPic.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPic.Location = new System.Drawing.Point(85, 97);
            this.dgvPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPic.Name = "dgvPic";
            this.dgvPic.RowHeadersVisible = false;
            this.dgvPic.RowHeadersWidth = 51;
            this.dgvPic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPic.Size = new System.Drawing.Size(270, 76);
            this.dgvPic.TabIndex = 42;
            this.dgvPic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPic_CellContentClick);
            this.dgvPic.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPic_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Day";
            this.dataGridViewTextBoxColumn4.FillWeight = 57.38708F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Đường dẫn";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // txtChuDe
            // 
            this.txtChuDe.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuDe.Location = new System.Drawing.Point(85, 41);
            this.txtChuDe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChuDe.Name = "txtChuDe";
            this.txtChuDe.ReadOnly = true;
            this.txtChuDe.Size = new System.Drawing.Size(270, 27);
            this.txtChuDe.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "Tiêu đề:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtConten
            // 
            this.txtConten.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConten.Location = new System.Drawing.Point(85, 181);
            this.txtConten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConten.Multiline = true;
            this.txtConten.Name = "txtConten";
            this.txtConten.ReadOnly = true;
            this.txtConten.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConten.Size = new System.Drawing.Size(270, 149);
            this.txtConten.TabIndex = 48;
            this.txtConten.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 43;
            this.label4.Text = "Chủ đề:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nội dung:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(85, 69);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(270, 27);
            this.txtName.TabIndex = 47;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMớiToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 76);
            // 
            // thêmMớiToolStripMenuItem
            // 
            this.thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            this.thêmMớiToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.thêmMớiToolStripMenuItem.Text = "Thêm chủ đề";
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.sửaToolStripMenuItem.Text = "Sửa tên chủ đề";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.xóaToolStripMenuItem.Text = "Xóa chủ đề";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 40;
            // 
            // fChiTietBaiViet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 342);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fChiTietBaiViet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình chung";
            this.Load += new System.EventHandler(this.FConfigGenneral_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPic)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x0400047B RID: 1147
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400047C RID: 1148
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x0400047D RID: 1149
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400047E RID: 1150
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x0400047F RID: 1151
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04000480 RID: 1152
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards2;

		// Token: 0x04000481 RID: 1153
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000482 RID: 1154
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000483 RID: 1155
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000484 RID: 1156
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000485 RID: 1157
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000486 RID: 1158
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x04000487 RID: 1159
		private global::System.Windows.Forms.ToolStripMenuItem thêmMớiToolStripMenuItem;

		// Token: 0x04000488 RID: 1160
		private global::System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;

		// Token: 0x04000489 RID: 1161
		private global::System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;

		// Token: 0x0400048A RID: 1162
		private global::System.Windows.Forms.Label lblNanh;

		// Token: 0x0400048B RID: 1163
		private global::System.Windows.Forms.DataGridView dgvPic;

		// Token: 0x0400048C RID: 1164
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

		// Token: 0x0400048D RID: 1165
		private global::System.Windows.Forms.TextBox txtChuDe;

		// Token: 0x0400048E RID: 1166
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400048F RID: 1167
		private global::System.Windows.Forms.TextBox txtConten;

		// Token: 0x04000490 RID: 1168
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000491 RID: 1169
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000492 RID: 1170
		private global::System.Windows.Forms.TextBox txtName;
	}
}
