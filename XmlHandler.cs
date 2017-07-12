using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace rsWoW_Tool
{
	class XmlHandler
	{
		public void AddAppSetting(string strServer, string strRealmlist, string strVersion, string strPath)
		{
			// load config xml
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load("Config.xml");

			// get root element
			XmlNode xmlRoot = xmlDoc.DocumentElement;

			// add new child to root element
			XmlNode xmlElement = xmlDoc.CreateElement("server");
			xmlElement.InnerText = strServer;

			// add attributes to child
			XmlAttribute xmlAttrRealmlist = xmlDoc.CreateAttribute("realmlist");
			xmlAttrRealmlist.InnerText = strRealmlist;
			xmlElement.Attributes.Append(xmlAttrRealmlist);

			XmlAttribute xmlAttrVersion = xmlDoc.CreateAttribute("version");
			xmlAttrVersion.InnerText = strVersion;
			xmlElement.Attributes.Append(xmlAttrVersion);

			XmlAttribute xmlAttrPath = xmlDoc.CreateAttribute("path");
			xmlAttrPath.InnerText = strPath;
			xmlElement.Attributes.Append(xmlAttrPath);

			// add child to root
			xmlRoot.AppendChild(xmlElement);

			// save xml
			xmlDoc.Save("Config.xml");
		}

		public XmlNodeList ReadAppSetting()
		{	
			// load config xml
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load("Config.xml");

			// get root element
			XmlNode xmlRoot = xmlDoc.DocumentElement;

			// get nodes
			XmlNodeList xmlServers = xmlRoot.SelectNodes("server");
			return xmlServers;
		}

		public void getServerSetting(string strServer, bool bSearchOnly, out bool bFound, out string strPath, out string strRealmlist, out string strVersion)
		{
			// return parameter initial value
			bFound = false;
			strPath = "";
			strRealmlist = "";
			strVersion = "";

			// load config xml
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load("Config.xml");

			// get root element
			XmlNode xmlRoot = xmlDoc.DocumentElement;
			foreach (XmlNode xmlItem in xmlRoot.ChildNodes)
			{
				if (xmlItem.InnerText == strServer)
				{
					// get attributes
					XmlAttributeCollection ServerSettings = xmlItem.Attributes;
					XmlNode Path = ServerSettings.GetNamedItem("path");
					XmlNode Realmlist = ServerSettings.GetNamedItem("realmlist");
					XmlNode Version = ServerSettings.GetNamedItem("version");
					if (Path != null && Realmlist != null && Version != null)
					{
						strPath = Path.InnerText;
						strRealmlist = Realmlist.InnerText;
						strVersion = Version.InnerText;
						bFound = true;
						return;
					}
					else
					{
						if (bSearchOnly == false)
						{
							MessageBox.Show("Es wurde kein Pfad zur WoW.exe gefunden oder die Realmlist wurde nicht angegeben", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						return;
					}
				}
			}
			
		}

		public void DeleteAppSetting(string strServer)
		{
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load("Config.xml");

			XmlNode xmlRoot = xmlDoc.DocumentElement;
			foreach (XmlNode xmlItem in xmlRoot)
			{
				if (xmlItem.InnerText == strServer)
				{
					xmlRoot.RemoveChild(xmlItem);
					xmlDoc.Save("Config.xml");
					break;
				}
			} 
		}
	}
}
