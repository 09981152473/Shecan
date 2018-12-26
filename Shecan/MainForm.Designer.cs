namespace Shecan
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox px_close;
		private System.Windows.Forms.PictureBox bg_blue;
		private System.Windows.Forms.PictureBox px_shecan_ico;
		private System.Windows.Forms.PictureBox bg_green;
		private System.Windows.Forms.PictureBox px_ip1;
		private System.Windows.Forms.PictureBox px_ip2;
		private System.Windows.Forms.PictureBox px_power;
		private System.Windows.Forms.Label lbl_caption;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip notify_cmt1;
		private System.Windows.Forms.ToolStripMenuItem cmt_show;
		private System.Windows.Forms.ToolStripMenuItem cmt_enable_disable;
		private System.Windows.Forms.ToolStripMenuItem cmt_check;
		private System.Windows.Forms.ToolStripMenuItem cmt_exit;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.px_close = new System.Windows.Forms.PictureBox();
			this.bg_blue = new System.Windows.Forms.PictureBox();
			this.px_shecan_ico = new System.Windows.Forms.PictureBox();
			this.bg_green = new System.Windows.Forms.PictureBox();
			this.px_ip1 = new System.Windows.Forms.PictureBox();
			this.px_ip2 = new System.Windows.Forms.PictureBox();
			this.px_power = new System.Windows.Forms.PictureBox();
			this.lbl_caption = new System.Windows.Forms.Label();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.notify_cmt1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmt_show = new System.Windows.Forms.ToolStripMenuItem();
			this.cmt_enable_disable = new System.Windows.Forms.ToolStripMenuItem();
			this.cmt_check = new System.Windows.Forms.ToolStripMenuItem();
			this.cmt_exit = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.px_close)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bg_blue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.px_shecan_ico)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bg_green)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.px_ip1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.px_ip2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.px_power)).BeginInit();
			this.notify_cmt1.SuspendLayout();
			this.SuspendLayout();
			// 
			// px_close
			// 
			this.px_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(158)))), ((int)(((byte)(85)))));
			this.px_close.Image = ((System.Drawing.Image)(resources.GetObject("px_close.Image")));
			this.px_close.Location = new System.Drawing.Point(344, 5);
			this.px_close.Name = "px_close";
			this.px_close.Size = new System.Drawing.Size(27, 27);
			this.px_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.px_close.TabIndex = 0;
			this.px_close.TabStop = false;
			this.px_close.Click += new System.EventHandler(this.Px_closeClick);
			this.px_close.MouseEnter += new System.EventHandler(this.PictureBoxMouseEnter);
			this.px_close.MouseLeave += new System.EventHandler(this.PictureBoxMouseLeave);
			// 
			// bg_blue
			// 
			this.bg_blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(171)))), ((int)(((byte)(184)))));
			this.bg_blue.Location = new System.Drawing.Point(0, 0);
			this.bg_blue.Name = "bg_blue";
			this.bg_blue.Size = new System.Drawing.Size(380, 169);
			this.bg_blue.TabIndex = 1;
			this.bg_blue.TabStop = false;
			// 
			// px_shecan_ico
			// 
			this.px_shecan_ico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(171)))), ((int)(((byte)(184)))));
			this.px_shecan_ico.Image = ((System.Drawing.Image)(resources.GetObject("px_shecan_ico.Image")));
			this.px_shecan_ico.Location = new System.Drawing.Point(134, 94);
			this.px_shecan_ico.Name = "px_shecan_ico";
			this.px_shecan_ico.Size = new System.Drawing.Size(228, 62);
			this.px_shecan_ico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.px_shecan_ico.TabIndex = 2;
			this.px_shecan_ico.TabStop = false;
			this.px_shecan_ico.Click += new System.EventHandler(this.Px_shecan_icoClick);
			this.px_shecan_ico.MouseEnter += new System.EventHandler(this.PictureBoxMouseEnter);
			this.px_shecan_ico.MouseLeave += new System.EventHandler(this.PictureBoxMouseLeave);
			// 
			// bg_green
			// 
			this.bg_green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(158)))), ((int)(((byte)(85)))));
			this.bg_green.Location = new System.Drawing.Point(0, 0);
			this.bg_green.Name = "bg_green";
			this.bg_green.Size = new System.Drawing.Size(382, 40);
			this.bg_green.TabIndex = 3;
			this.bg_green.TabStop = false;
			// 
			// px_ip1
			// 
			this.px_ip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(171)))), ((int)(((byte)(184)))));
			this.px_ip1.Image = ((System.Drawing.Image)(resources.GetObject("px_ip1.Image")));
			this.px_ip1.Location = new System.Drawing.Point(21, 46);
			this.px_ip1.Name = "px_ip1";
			this.px_ip1.Size = new System.Drawing.Size(153, 40);
			this.px_ip1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.px_ip1.TabIndex = 4;
			this.px_ip1.TabStop = false;
			this.px_ip1.Click += new System.EventHandler(this.Px_ip1Click);
			this.px_ip1.MouseEnter += new System.EventHandler(this.PictureBoxMouseEnter);
			this.px_ip1.MouseLeave += new System.EventHandler(this.PictureBoxMouseLeave);
			// 
			// px_ip2
			// 
			this.px_ip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(171)))), ((int)(((byte)(184)))));
			this.px_ip2.Image = ((System.Drawing.Image)(resources.GetObject("px_ip2.Image")));
			this.px_ip2.Location = new System.Drawing.Point(198, 46);
			this.px_ip2.Name = "px_ip2";
			this.px_ip2.Size = new System.Drawing.Size(153, 40);
			this.px_ip2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.px_ip2.TabIndex = 5;
			this.px_ip2.TabStop = false;
			this.px_ip2.Click += new System.EventHandler(this.Px_ip2Click);
			this.px_ip2.MouseEnter += new System.EventHandler(this.PictureBoxMouseEnter);
			this.px_ip2.MouseLeave += new System.EventHandler(this.PictureBoxMouseLeave);
			// 
			// px_power
			// 
			this.px_power.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(171)))), ((int)(((byte)(184)))));
			this.px_power.Image = ((System.Drawing.Image)(resources.GetObject("px_power.Image")));
			this.px_power.Location = new System.Drawing.Point(38, 94);
			this.px_power.Name = "px_power";
			this.px_power.Size = new System.Drawing.Size(60, 60);
			this.px_power.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.px_power.TabIndex = 6;
			this.px_power.TabStop = false;
			this.px_power.Click += new System.EventHandler(this.Px_powerClick);
			this.px_power.MouseEnter += new System.EventHandler(this.PictureBoxMouseEnter);
			this.px_power.MouseLeave += new System.EventHandler(this.PictureBoxMouseLeave);
			// 
			// lbl_caption
			// 
			this.lbl_caption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(158)))), ((int)(((byte)(85)))));
			this.lbl_caption.Location = new System.Drawing.Point(21, 8);
			this.lbl_caption.Name = "lbl_caption";
			this.lbl_caption.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbl_caption.Size = new System.Drawing.Size(317, 23);
			this.lbl_caption.TabIndex = 7;
			this.lbl_caption.Text = "برای رونوشت بر روی آی پی کلیک نمایید";
			this.lbl_caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.notify_cmt1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "شکن";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1Click);
			// 
			// notify_cmt1
			// 
			this.notify_cmt1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.cmt_show,
			this.cmt_enable_disable,
			this.cmt_check,
			this.cmt_exit});
			this.notify_cmt1.Name = "notify_cmt1";
			this.notify_cmt1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.notify_cmt1.Size = new System.Drawing.Size(167, 92);
			// 
			// cmt_show
			// 
			this.cmt_show.Name = "cmt_show";
			this.cmt_show.Size = new System.Drawing.Size(166, 22);
			this.cmt_show.Text = "نمایش پنجره برنامه";
			this.cmt_show.Click += new System.EventHandler(this.Cmt_showClick);
			// 
			// cmt_enable_disable
			// 
			this.cmt_enable_disable.Name = "cmt_enable_disable";
			this.cmt_enable_disable.Size = new System.Drawing.Size(166, 22);
			this.cmt_enable_disable.Text = "فعال کردن سرویس";
			this.cmt_enable_disable.Click += new System.EventHandler(this.Cmt_enable_disableClick);
			// 
			// cmt_check
			// 
			this.cmt_check.Name = "cmt_check";
			this.cmt_check.Size = new System.Drawing.Size(166, 22);
			this.cmt_check.Text = "بررسی لینک";
			this.cmt_check.Click += new System.EventHandler(this.Cmt_checkClick);
			// 
			// cmt_exit
			// 
			this.cmt_exit.Name = "cmt_exit";
			this.cmt_exit.Size = new System.Drawing.Size(166, 22);
			this.cmt_exit.Text = "خروج";
			this.cmt_exit.Click += new System.EventHandler(this.Cmt_exitClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(379, 167);
			this.ControlBox = false;
			this.Controls.Add(this.lbl_caption);
			this.Controls.Add(this.px_power);
			this.Controls.Add(this.px_ip2);
			this.Controls.Add(this.px_ip1);
			this.Controls.Add(this.px_close);
			this.Controls.Add(this.bg_green);
			this.Controls.Add(this.px_shecan_ico);
			this.Controls.Add(this.bg_blue);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Opacity = 0.88D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Shecan";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			((System.ComponentModel.ISupportInitialize)(this.px_close)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bg_blue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.px_shecan_ico)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bg_green)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.px_ip1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.px_ip2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.px_power)).EndInit();
			this.notify_cmt1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
