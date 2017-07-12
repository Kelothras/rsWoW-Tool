using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace rsWoW_Tool
{
	public partial class frmStart : Form
	{
		[DllImport("user32.dll")]
		private static extern
			bool SetForegroundWindow(IntPtr hWnd);

		public frmStart()
		{
			InitializeComponent();
		}

		private void frmStart_Load(object sender, EventArgs e)
		{
			notifiyIconTaskbar.Visible = false;
			notifiyIconTaskbar.ContextMenu = new ContextMenu();
			notifiyIconTaskbar.ContextMenu.Name = "WoW-Startup Tool";
			FormUpdate();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Form frmAddServer = new frmNewServer();
			frmAddServer.ShowInTaskbar = false;
			frmAddServer.Show();
		}
		
		private void btnStart_Click(object sender, EventArgs e)
		{
			Utility Program = new Utility();
			XmlHandler xmlHandle = new XmlHandler();
			ListView.SelectedListViewItemCollection SelectedServer = listServerlist.SelectedItems;
			foreach (ListViewItem Server in SelectedServer)
			{
				Program.StartProcess(Server.Text);
				break;
			}
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			try
			{
				ListView.SelectedListViewItemCollection SelectedServer = listServerlist.SelectedItems;
				ListViewItem Server = SelectedServer[0];
				XmlHandler xmlHandle = new XmlHandler();
				xmlHandle.DeleteAppSetting(Server.Text);
				FormUpdate();
			}
			catch (Exception ex)
			{
				return;
			}
		}

		private void frmStart_Resize(object sender, EventArgs e)
		{
			if (FormWindowState.Minimized == WindowState)
			{
				this.Hide();
				notifiyIconTaskbar.Visible = true;
			}
			else if (FormWindowState.Normal == WindowState)
			{
				notifiyIconTaskbar.Visible = false;
			}
		}

		private void Exit_Handle(object sender,EventArgs e)
		{
			Application.Exit();
		}
		 
		private void Start_Handle(object sender, EventArgs e ) 
		{
			Utility Program = new Utility();
			MenuItem mnItem = (MenuItem)sender;
			Program.StartProcess(mnItem.Text);
		}

		public void FormUpdate()
		{
			notifiyIconTaskbar.ContextMenu.MenuItems.Clear();
			listServerlist.Items.Clear();
			XmlHandler xmlHandle = new XmlHandler();

			XmlNodeList xmlServers = xmlHandle.ReadAppSetting();
			foreach (XmlNode xmlServer in xmlServers)
			{
				ListViewItem listItem = new ListViewItem(xmlServer.InnerText);
				foreach (XmlAttribute xmlAttr in xmlServer.Attributes)
				{
					if (xmlAttr.Name != "path")
					{
						ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(listItem, xmlAttr.InnerText);
						listItem.SubItems.Add(subItem);
					}
				}
				listServerlist.Items.Add(listItem);
				string strMenuItem = xmlServer.InnerText;
				notifiyIconTaskbar.ContextMenu.MenuItems.Add(strMenuItem, new EventHandler(Start_Handle));


			}
			notifiyIconTaskbar.ContextMenu.MenuItems.Add("Anzeigen", new EventHandler(notifiyIconTaskbar_DoubleClick));
			notifiyIconTaskbar.ContextMenu.MenuItems.Add("Beenden", new EventHandler(Exit_Handle));
		}

		private void notifiyIconTaskbar_DoubleClick(object sender, EventArgs e)
		{
			this.Show();
			SetForegroundWindow(this.Handle);
		}

	}
}
