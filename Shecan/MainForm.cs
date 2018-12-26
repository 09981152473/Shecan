using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Shecan
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		// IsServiceActive ==> Shacan State Store
		// If Shecan Enabled = true
		public bool IsServiceActive = false;
		
		// IsServiceActive ==> Shacan State Store
		// If Shecan Enabled = true
		public bool Isdisplayednotify = false;
		
		// Set Google Dns For Null Exceptions
		// Dns Server 1
		public string ShacanSv1 = "8.8.8.8";
		// Dns Server 2
		public string ShacanSv2 = "4.2.2.4";
		
		// Create Notification And Set All Notify To One.
		public NotifyIcon notification = new System.Windows.Forms.NotifyIcon();
		
		// Get Resources And Set To Component Resourc eManager
		public System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
		
		
		
		public MainForm()
		{
			
			// The InitializeComponent() call is required for Windows Forms designer support.
			InitializeComponent();
			
			// Font Managment
			// Add Font from resources To byte array.
			byte[] fontBytes = (Byte[])(resources.GetObject("shabnam.font"));
			
			// Register font bytes to Memmory => why? ==> Need Memmory Point.
			IntPtr fontData = Marshal.AllocCoTaskMem(fontBytes.Length);
			
			// Write to Memmory
			Marshal.Copy(fontBytes, 0, fontData, fontBytes.Length);
			
			// Create FontCollection
			PrivateFontCollection modernFont = new PrivateFontCollection();
			
			// Add From Memmory
			modernFont.AddMemoryFont(fontData, fontBytes.Length);
			
			// Create Font
			Font font = new Font(modernFont.Families[0], 8);
			
			// Set Font 'Shabnam' to 'this MainForm'
			this.Font = font;
			
			// Set Font 'Shabnam' to 'caption label'
			lbl_caption.Font = new Font(modernFont.Families[0], 10);;
			
			// Free Memmory From Font Stack
			Marshal.FreeHGlobal(fontData);
			
			// Setup StartUp Settings
			DnsConfiguration();
			
			// Checking
			// Example: Check Shecan IS Enable or not , and Set Configuration.
			StartUpCheck();
			
			// Start Events
			// Notify Event ==> Run Method When Clicked
			notification.BalloonTipClicked += notification_BalloonTipClicked;
			
			// Network Availability Check Event 1
			NetworkChange.NetworkAvailabilityChanged += AvailabilityChanged;
			
			// Network Availability Check Event 2
			NetworkCheckApp.NetworkStatusObserver ntw = new NetworkCheckApp.NetworkStatusObserver();
			ntw.Start();
			ntw.NetworkChanged += ntw_NetworkChanged;
			
			// Finish Custom Initialize And Do All Changes.
			Application.DoEvents();
			
		}

		//**************************************************************
		// StartUp
		// *************************************************************
		void DnsConfiguration()
		{
			// This Methos Will Work With APi.
			ShacanSv1 = "178.22.122.100";
			ShacanSv2 = "94.232.174.194";
		}
		
		void StartUpCheck()
		{
			if((Dns.DnsTools.IsShecanEnabled()))
			{
				IsServiceActive = true;
				EnableMod();
				Dns.DnsTools.SetDNS(ShacanSv1,ShacanSv2);
				Dns.DnsTools.FlushDns();
			}
			else
			{
				IsServiceActive = false;
				DisableMod();
				Dns.DnsTools.UnsetDNS();
				Dns.DnsTools.FlushDns();
			}
		}
		
		//**************************************************************
		// Mouse Effects
		// *************************************************************
		
		void PictureBoxMouseEnter(object sender, EventArgs e)
		{
			((PictureBox)sender).Height = ((PictureBox)sender).Height + 5;
			((PictureBox)sender).Width = ((PictureBox)sender).Width + 5;
			((PictureBox)sender).Location = new Point(((PictureBox)sender).Location.X - 2, ((PictureBox)sender).Location.Y - 2);
		}
		
		void PictureBoxMouseLeave(object sender, EventArgs e)
		{
			((PictureBox)sender).Height = ((PictureBox)sender).Height - 5;
			((PictureBox)sender).Width = ((PictureBox)sender).Width - 5;
			((PictureBox)sender).Location = new Point(((PictureBox)sender).Location.X + 2, ((PictureBox)sender).Location.Y + 2);
		}
		
		
		//**************************************************************
		// Network Event Handlers
		// *************************************************************
		
		void ntw_NetworkChanged(object sender, EventArgs e)
		{
			ResetService();
		}
		
		void AvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
		{
			ResetService();
		}

		//**************************************************************
		// Notify Tools
		// *************************************************************
		
		void NotifyThreadStart()
		{
			System.Threading.Thread th = new System.Threading.Thread(NotifyConfig);
			th.Start();
		}
		
		void notification_BalloonTipClicked(object sender, EventArgs e)
		{
			ShowForm();
		}
		
		void NotifyConfig()
		{
			if(!Isdisplayednotify)
			{
				Isdisplayednotify = true;
				notification.Visible = true;
				notification.Icon = this.Icon;
				//notification.BalloonTipIcon = this.Icon;
				notification.BalloonTipTitle = "شکن؛ سرویس عبور از تحریم";

				if(IsServiceActive)
				{
					notification.BalloonTipText = "شکن فعال شده است";
				}
				else
				{
					notification.BalloonTipText = "شکن غیرفعال شده است";
				}
				
				notification.ShowBalloonTip(5000);
				System.Threading.Thread.Sleep(5000);
			}
			else
			{
				notification.Visible = false;
				Isdisplayednotify = false;
				NotifyConfig();
			}
			Application.DoEvents();
		}
		
		//**************************************************************
		// Application Form Mods
		// *************************************************************

		void DisableMod()
		{
			px_power.Image =  ((System.Drawing.Image)(resources.GetObject("px_poweroff.Image")));
			cmt_enable_disable.Text = "فعال کردن";
			Application.DoEvents();
		}
		
		void EnableMod()
		{
			px_power.Image =  ((System.Drawing.Image)(resources.GetObject("px_power.Image")));
			cmt_enable_disable.Text = "غیر فعال کردن";
			Application.DoEvents();
		}
		
		//**************************************************************
		// Application Shecan Methods
		// *************************************************************
		
		void ResetService()
		{
			if(IsServiceActive)
			{
				IsServiceActive = true;
				Dns.DnsTools.SetDNS(ShacanSv1, ShacanSv2);
				EnableMod();
				Dns.DnsTools.FlushDns();
				NotifyThreadStart();
				Application.DoEvents();
			}
			else
			{
				IsServiceActive = false;
				Dns.DnsTools.UnsetDNS();
				DisableMod();
				Dns.DnsTools.FlushDns();
				NotifyThreadStart();
				Application.DoEvents();
			}
		}
		
		void ShecanServiceSwitch()
		{
			if(IsServiceActive)
			{
				IsServiceActive = false;
				Dns.DnsTools.UnsetDNS();
				DisableMod();
				Dns.DnsTools.FlushDns();
			}
			else
			{
				IsServiceActive = true;
				Dns.DnsTools.SetDNS(ShacanSv1,ShacanSv2);
				EnableMod();
				Dns.DnsTools.FlushDns();
			}
		}
		
		void ShowForm()
		{
			Application.OpenForms[0].Show();
			Application.OpenForms[0].TopMost = true;
			Application.OpenForms[0].Focus();
			Application.DoEvents();
			Application.OpenForms[0].TopMost = false;
			Application.DoEvents();
		}
		
		
		//**************************************************************
		// Application Events
		// *************************************************************
		// Application Closing Events
		// *************************************************************
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			this.Hide();
			e.Cancel = true;
		}
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			notifyIcon1.Visible = false;
			this.Hide();
			Application.DoEvents();
		}
		
		// *************************************************************
		// Application Click Events
		// *************************************************************
		
		void Px_ip1Click(object sender, EventArgs e)
		{
			Clipboard.SetText("178.22.122.100");
			MessageBox.Show("کپی شد");
		}
		
		void Px_ip2Click(object sender, EventArgs e)
		{
			Clipboard.SetText("94.232.174.194");
			MessageBox.Show("کپی شد");
		}
		
		void Px_shecan_icoClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("http://shecan.ir");
		}
		
		void Px_closeClick(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		void NotifyIcon1Click(object sender, EventArgs e)
		{
			ShowForm();
		}
		
		void Px_powerClick(object sender, EventArgs e)
		{
			ShecanServiceSwitch();
			NotifyThreadStart();
		}
		
		// *************************************************************
		// Application Notify Content Menu Events
		// *************************************************************
		
		void Cmt_showClick(object sender, EventArgs e)
		{
			ShowForm();
		}
		
		void Cmt_enable_disableClick(object sender, EventArgs e)
		{
			ShecanServiceSwitch();
			NotifyThreadStart();
		}
		
		void Cmt_checkClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("http://shecan.ir");
		}
		
		void Cmt_exitClick(object sender, EventArgs e)
		{
			notifyIcon1.Visible = false;
			this.Hide();
			Application.DoEvents();
			Environment.Exit(0);
		}
		

	}
}
