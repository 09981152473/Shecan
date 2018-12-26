using System;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;

namespace Shecan.Dns
{
	/// <summary>
	/// Description of DnsTools.
	/// </summary>
	public static class DnsTools
	{
		
		public static NetworkInterface GetActiveEthernetOrWifiNetworkInterface()
		{
			var Nic = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(
				a => a.OperationalStatus == OperationalStatus.Up &&
				(a.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || a.NetworkInterfaceType == NetworkInterfaceType.Ethernet) &&
				a.GetIPProperties().GatewayAddresses.Any(g => g.Address.AddressFamily.ToString() == "InterNetwork"));

			return Nic;
		}
		
		public static void SetDNS(string DnsString1, string DnsString2)
		{
			string[] Dns = { DnsString1,DnsString2 };
			var CurrentInterface = GetActiveEthernetOrWifiNetworkInterface();
			if (CurrentInterface == null) return;

			ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
			ManagementObjectCollection objMOC = objMC.GetInstances();
			foreach (ManagementObject objMO in objMOC)
			{
				if ((bool)objMO["IPEnabled"])
				{
					if (objMO["Caption"].ToString().Contains(CurrentInterface.Description))
					{
						ManagementBaseObject objdns = objMO.GetMethodParameters("SetDNSServerSearchOrder");
						if (objdns != null)
						{
							objdns["DNSServerSearchOrder"] = Dns;
							objMO.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
						}
					}
				}
			}
		}
		
		public static void UnsetDNS()
		{
			var CurrentInterface = GetActiveEthernetOrWifiNetworkInterface();
			if (CurrentInterface == null) return;

			ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
			ManagementObjectCollection objMOC = objMC.GetInstances();
			foreach (ManagementObject objMO in objMOC)
			{
				if ((bool)objMO["IPEnabled"])
				{
					if (objMO["Caption"].ToString().Contains(CurrentInterface.Description))
					{
						ManagementBaseObject objdns = objMO.GetMethodParameters("SetDNSServerSearchOrder");
						if (objdns != null)
						{
							objdns["DNSServerSearchOrder"] = null;
							objMO.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
						}
					}
				}
			}
		}
		
		public static bool IsShecanEnabled()
		{
			string dump = "";
			NetworkInterface[] adapters  = NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface adapter in adapters)
			{
				if(adapter.Name == GetActiveEthernetOrWifiNetworkInterface().Name)
				{
					IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
					IPAddressCollection dnsServers = adapterProperties.DnsAddresses;
					if (dnsServers.Count > 0)
					{
						foreach (System.Net.IPAddress dns in dnsServers)
						{
							dump += dns.ToString();
						}
					}
				}
			}
			if(dump.Contains("178.22.122.100") || dump.Contains("94.232.174.194"))
			{
				return true;
			}
			return false;
		}
		
		public static void FlushDns()
		{
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = Environment.GetFolderPath( Environment.SpecialFolder.Windows ) + @"\system32\cmd.exe";
			startInfo.Arguments = "/C ipconfig /flushdns";
			process.StartInfo = startInfo;
			process.Start();
		}
		
	}
}
