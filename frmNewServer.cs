using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace rsWoW_Tool
{
	public partial class frmNewServer : Form
	{
		public string strPath = "";
 
		public frmNewServer()
		{
			InitializeComponent();
		}
		
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool bFound = false;
			string strRealmlistTemp = "";
			string strServer = txtServerName.Text;
			string strRealmlist = txtRealmList.Text;
			string strVersion = combVersion.Text;

			if (strServer == "" || strRealmlist == "" || strVersion	== "" || strPath == "")
			{
				MessageBox.Show("Bitte alle Felder ausfüllen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				XmlHandler xmlHanle = new XmlHandler();
				// check if server name is in use
				xmlHanle.getServerSetting(strServer, true, out bFound, out strPath, out strRealmlistTemp, out strVersion);
				if (bFound == true)
				{	
					MessageBox.Show("Der angegebene Server-Name wurde bereits genutzt, bitte anderen Namen nutzen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// add new server to app settings 
				xmlHanle.AddAppSetting(strServer, strRealmlist, strVersion, strPath);
				Close();

				// refresh list with servers
				(Application.OpenForms["frmStart"] as frmStart).FormUpdate();
			}
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			FileDialog WoWFolder = new OpenFileDialog();
			WoWFolder.Filter = "WoW.exe (*.exe) |*.exe";
			if (WoWFolder.ShowDialog() == DialogResult.OK) 
			{
				strPath = WoWFolder.FileName;
				FileInfo WoWExe = new FileInfo(strPath);
				txtPath.Text = strPath;
			}
		}
	}
}
