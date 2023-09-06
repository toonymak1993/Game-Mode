using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GAMEMODE
{
    public partial class Form2 : Form
    {

        #region Variable

        private string settingsFilePath;
        #endregion Variable
        #region Form
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            #region Pfad zum APPDATA Ordner ermitteln
            // Pfad zum AppData-Ordner des aktuellen Benutzers
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // Pfad zum Ordner für deine Anwendung innerhalb des AppData-Ordners erstellen
            string gamemodeFolder = Path.Combine(appDataFolder, "gamemode");
            Directory.CreateDirectory(gamemodeFolder); // Ordner erstellen, wenn nicht vorhanden

            // Pfad zur XML-Datei im gamemode-Ordner erstellen
            settingsFilePath = Path.Combine(gamemodeFolder, "settings.xml");
            #endregion Pfad zum APPDATA Ordner ermitteln

            setui();



        }

        #endregion Form
        #region Methoden
        public void SaveSettings(string key, string value)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root;

            if (File.Exists(settingsFilePath))
            {
                xmlDoc.Load(settingsFilePath);
                root = xmlDoc.DocumentElement;
            }
            else
            {
                // Erstelle eine neue XML-Datei
                xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null));
                root = xmlDoc.CreateElement("Settings");
                xmlDoc.AppendChild(root);
            }

            // Überprüfe, ob das Element bereits existiert, und aktualisiere es oder füge es hinzu
            XmlNode settingNode = root.SelectSingleNode(key);
            if (settingNode != null)
            {
                settingNode.InnerText = value;
            }
            else
            {
                settingNode = xmlDoc.CreateElement(key);
                settingNode.InnerText = value;
                root.AppendChild(settingNode);
            }

            // XML-Datei speichern
            xmlDoc.Save(settingsFilePath);
        }

        private string LoadSetting(string key)
        {
            if (File.Exists(settingsFilePath))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(settingsFilePath);
                XmlNode settingNode = xmlDoc.DocumentElement.SelectSingleNode(key);
                if (settingNode != null)
                {
                    return settingNode.InnerText;
                }
            }

            return null; // Einstellung nicht gefunden
        }

        private void setui()
        {
            // Get Variable from Settings
            string launcherlink = LoadSetting("launcherstart");
            string launcherart = LoadSetting("launcherart");
            string time = LoadSetting("time");
            string display = LoadSetting("display");

            // Use Variable for set at start

            //Launcher

            launcher_textbox.Text = launcherlink;
            if (launcherart == "steam")
            {
                checkbox_steam.Checked = true;
            }
            else
            {

                checkbox_custom.Checked = true;
                launcher_textbox.Visible = true;
            }

            //Timebar
            trackbar_time.Value = int.Parse(time);
            label_showsecods.Text = time.ToString();
        }


        #endregion Methoden
        #region aktionen

        private void launcher_textbox_TextChanged(object sender, EventArgs e)
        {
            string launcherlink = launcher_textbox.Text;
            SaveSettings("launcherstart", launcherlink);
        }
        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label_showsecods.Text = trackbar_time.Value.ToString() + " Seconds";
            SaveSettings("time", trackbar_time.Value.ToString());
        }

        private void guna2CustomCheckBox3_Click(object sender, EventArgs e)
        {
            SaveSettings("launcherart", "steam");
            checkbox_custom.Checked = false;
            launcher_textbox.Visible = false;
        }

        private void guna2CustomCheckBox4_Click(object sender, EventArgs e)
        {
            SaveSettings("launcherart", "custom");
            checkbox_steam.Checked = false;
            launcher_textbox.Visible = true;
        }

        //Display Checkbox setzen
        private void checkbox_internaldisplay_Click(object sender, EventArgs e)
        {
            SaveSettings("display", "i");
            checkbox_externaldisplay.Checked = false;
        }

        private void checkbox_externaldisplay_Click(object sender, EventArgs e)
        {
            SaveSettings("display", "e");
            checkbox_internaldisplay.Checked = false;
        }
        #endregion aktionen
    }
}
