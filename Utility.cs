using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace rsWoW_Tool
{
	class Utility
	{
		public void ChangeRealmlist(string strDirectory, string strVersion, string strRealmlist)
		{
			string strRealmlistPath = "";
			try
			{
				DirectoryInfo RealmlistDir = new DirectoryInfo(strDirectory);
				switch (strVersion)
				{
					case "3.3.5a":
						strRealmlistPath = strDirectory + "\\Data\\deDE\\realmlist.wtf";
						break;
					case "4.3.4":
						strRealmlistPath = strDirectory + "\\Data\\deDE\\realmlist.wtf";
						break;
					default:
						break;
				}

				FileInfo RealmlistFile = new FileInfo(strRealmlistPath);
				if (RealmlistFile.Exists == true)
				{
					RealmlistFile.Delete();
				}
				StreamWriter RealmlistWriter = RealmlistFile.CreateText();
				RealmlistWriter.WriteLine(strRealmlist);
				RealmlistWriter.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		public void StartProcess(string strServer)
		{
			bool bFound = false;
			string strPath, strRealmlist, strVersion;
			XmlHandler xmlHandle = new XmlHandler();

			xmlHandle.getServerSetting(strServer, false, out bFound, out strPath, out strRealmlist, out strVersion);
			if (bFound == true)
			{
				FileInfo WoWFile = new FileInfo(strPath);
				if (WoWFile.Exists == true)
				{
					ChangeRealmlist(WoWFile.Directory.ToString(), strVersion, strRealmlist);
					Process Thread = new Process();
					Thread.StartInfo.FileName = strPath;
					Thread.Start();
				}
				else
				{
					MessageBox.Show("Die angegebene Datei wurde nicht gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
		}

		public void DeleteCache(string strServer){
			
			XmlHandler xmlHandle = new XmlHandler();
			bool bFound = false;
			string strPath, strRealmlist, strVersion;

			xmlHandle.getServerSetting(strServer, false, out bFound, out strPath, out strRealmlist, out strVersion);
			DirectoryInfo WoWDir = new DirectoryInfo(strPath);
		}

	}
}
