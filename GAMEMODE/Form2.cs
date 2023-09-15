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
            #region startfenster unten rechts
            // Startposition auf "Manual" festlegen, um die Position selbst festzulegen.
            this.StartPosition = FormStartPosition.Manual;

            // Bestimmen der Form Position der unteren rechten Ecke des Bildschirms.
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;

            // Unteren rechten Ecke platzieren.
            this.DesktopBounds = new System.Drawing.Rectangle(screenWidth - formWidth, screenHeight - formHeight, formWidth, formHeight);

            // Deaktivieren Verschieben der Form.
            this.TopMost = true;
            #endregion startfenster unten rechts

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
        private string ColorToHexString(Color color)
        {
            return "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
        }
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

            // Display
            if (display == "i")
            {
                checkbox_internaldisplay.Checked = true;
            }
            else
            {
                checkbox_externaldisplay.Checked = true;
            }

            // COLORUI -------------------------------

            //get variable
            string color_main_textcolor = LoadSetting("color_main_textcolor");
            string wallpaperlink = LoadSetting("wallpaper_link");
            string button_hover_color = LoadSetting("button_hover_color");
            string progressbar_color = LoadSetting("progressbar_color");

            // Set Color in Gui
            textbox_textcolor.Text = color_main_textcolor;
            textbox_buttonhover_color.Text = button_hover_color;
            textbox_progressbar_color.Text = progressbar_color;
            textbox_custom_wallpaper.Text = wallpaperlink;
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
            Panel_settigs_main.Visible = true;
            panel_info.Visible = false;
            panel_settings_color.Visible = false;
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
        #region buttons unnd aktionen

        //restart Applikation
        private void button_restart_app_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //colopicker Button
        private void button_settings_color_Click(object sender, EventArgs e)
        {
            panel_settings_color.Visible = true;
            Panel_settigs_main.Visible = false;
            panel_info.Visible = false;



        }

        private void settings_info_button_Click(object sender, EventArgs e)
        {
            panel_settings_color.Visible = false;
            Panel_settigs_main.Visible = false;
            panel_info.Visible = true;
        }
        #region set color 
        private void button_text_color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog1.Color;
                string hexColor = ColorToHexString(selectedColor);

                // ...


                // Verwenden Sie die ausgewählte Farbe in Ihrer Anwendung
                SaveSettings("color_main_textcolor", hexColor);
                textbox_textcolor.Text = hexColor;
                textbox_textcolor.ForeColor = selectedColor;
            }


        }




        private void button_hoverstate_color_Click(object sender, EventArgs e)
        {


            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog1.Color;
                string hexColor = ColorToHexString(selectedColor);

                // ...


                // Verwenden Sie die ausgewählte Farbe in Ihrer Anwendung
                SaveSettings("button_hover_color", hexColor);
                textbox_buttonhover_color.Text = hexColor;
                textbox_buttonhover_color.ForeColor = selectedColor;
            }

        }

        private void button_progressbar_color_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog1.Color;
                string hexColor = ColorToHexString(selectedColor);

                // Verwenden  der ausgewählte Farbe in der Anwendung
                SaveSettings("progressbar_color", hexColor);
                textbox_progressbar_color.Text = hexColor;
                textbox_progressbar_color.ForeColor = selectedColor;
            }

        }
        #endregion set color


        private void textbox_custom_wallpaper_TextChanged(object sender, EventArgs e)
        {
            // Setzen des Wallpapers in den Settings
            // Verwenden  der ausgewählte Farbe in der Anwendung
            SaveSettings("wallpaper_link", textbox_custom_wallpaper.Text);
        }
        #endregion Buttons

        private void butto_restart_app_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
