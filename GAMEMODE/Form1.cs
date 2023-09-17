using static Guna.UI2.WinForms.Helpers.GraphicsHelper;
using System.Text.RegularExpressions;
using System.Xml;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using TaskScheduler;
using IWshRuntimeLibrary;
using Microsoft.Win32;
using System.Xml.Linq;

namespace GAMEMODE
{
    public partial class Main_Form : Form
    {



        #region Notwendige Variable
        private int countdownSeconds;
        private string settingsFilePath;
        private volatile int pausebutton = 0;
        #endregion Notwendige Variable
        #region Form Load
        public Main_Form()
        {
            InitializeComponent();
            // Initialisieren Sie den Timer.
            timer.Interval = 1000; // Timer wird jede Sekunde ausgelöst
            timer.Tick += Timer_TickAsync;

            // Starten Sie den Timer, wenn die Form geladen wird.
            timer.Start();
            #endregion Timer initial
            #region Pfad zum APPDATA Ordner ermitteln
            // Pfad zum AppData-Ordner des aktuellen Benutzers
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // Pfad zum Ordner für deine Anwendung innerhalb des AppData-Ordners erstellen
            string gamemodeFolder = Path.Combine(appDataFolder, "gamemode");
            Directory.CreateDirectory(gamemodeFolder); // Ordner erstellen, wenn nicht vorhanden

            // Pfad zur XML-Datei im gamemode-Ordner erstellen
            settingsFilePath = Path.Combine(gamemodeFolder, "settings.xml");
            #endregion Pfad zum APPDATA Ordner ermitteln
            #region set first Start
            if (System.IO.File.Exists(settingsFilePath))
            {

            }
            else
            {
                SaveSettings("launcherart", "steam");
                SaveSettings("time", "30");
                SaveSettings("display", "e");
                SaveSettings("launcherart", "steam");
            }


            #endregion first start

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Prüfen ob die App auf Autostart läuft
            autostart();
            // Autostart prüfen us Appllikation hinnzfüge
            setui();

        }



        #region Methoden

        private async void autostart()
        {
            string firstautostart = LoadSetting("firstautostart");
            if (firstautostart == "activated")
            {

            }
            else
            {
                try
                {
                    string appName = "GAMEMODE"; // Der Name der Anwendung

                    // Pfad zur ausführbaren Datei der aktuellen Anwendung (diese EXE)
                    string appPath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;

                    // Öffne den Registry-Schlüssel für den aktuellen Benutzer-Autostart
                    RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                    if (key != null)
                    {
                        // Überprüfe, ob die Anwendung bereits im Autostart vorhanden ist
                        if (key.GetValue(appName) == null)
                        {
                            // Füge deine Anwendung zum Autostart hinzu
                            key.SetValue(appName, appPath);
                            key.Close();
                            // Konfiguriere die Benachrichtigungseinstellungen
                            SaveSettings("autostart", "activated");
                            SaveSettings("firstautostart", "activated");
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private async void Timer_TickAsync(object sender, EventArgs e)
        {
            label_activated.Visible = true;

            if (countdownSeconds > 0)
            {
                // Hier können Sie den Code ausführen, der während des Timerticks ausgeführt werden soll
                // Überprüfen Sie die Bedingung, ob pausiert werden soll
                // Überprüfen Sie die Bedingung, ob pausiert werden soll
                while (pausebutton == 1)
                {
                    if (pausebutton == 1)
                    {
                        // Warten Sie hier, bis die Bedingung aufgehoben ist
                        await Task.Delay(100); // Warten Sie 100 Millisekunden und überprüfen Sie erneut
                        timer.Enabled = false;
                    }
                    else
                    {

                    }
                }
                // Timer wieder aktivieren
                if (timer.Enabled == false)
                {
                    timer.Enabled = true;
                }

                // Aktualisieren  Label mit der verbleibenden Zeit.
                label_activated.Text = countdownSeconds.ToString() + " Seconds";

                // Aktualisieren der ProgressBar.
                guna2ProgressBardesktop_mode.Value = countdownSeconds;

                countdownSeconds--;

            }
            else
            {
                // Der Countdown ist abgelaufen. Sie können hier entsprechende Aktionen ausführen.
                // Zum Stoppen des Timers können Sie timer.Stop() aufrufen.

                timer.Stop();
                start_gamemode();
            }
        }

        public void SaveSettings(string key, string value)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root;

            if (System.IO.File.Exists(settingsFilePath))
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
            if (System.IO.File.Exists(settingsFilePath))
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

        private void loadbackimage(string link)
        {
            // Pfad zur Bilddatei festlegen
            string bildPfad = link; // Passe den Pfad entsprechend an



            // Überprüfe, ob die Bilddatei vorhanden ist
            if (System.IO.File.Exists(bildPfad))
            {
                // Bild laden und als Hintergrundbild für das Formular festlegen
                this.BackgroundImage = Image.FromFile(bildPfad);

                // Optional: Die Größe des Hintergrundbilds an das Formular anpassen
                this.BackgroundImageLayout = ImageLayout.Stretch; // Oder ein anderes Layout je nach Bedarf
            }
            else
            {
                // Zeige eine Fehlermeldung, wenn die Bilddatei nicht gefunden wurde
                MessageBox.Show("Hintergrundbild nicht gefunden.");
            }

        }


        private void setui()
        {

            // Ermitteln der aktuellen Version Ihrer Anwendung
            Version currentVersion = Assembly.GetExecutingAssembly().GetName().Version;

            // Anzeigen der aktuellen Version in einem Label
            label_version.Text = "v." + currentVersion.ToString();

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
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            //set settings
            string timeString = LoadSetting("time");
            int time = int.Parse(timeString);
            countdownSeconds = time;
            guna2ProgressBardesktop_mode.Maximum = countdownSeconds;

            //Set Colorpalette
            // For TEXT
            string color_main_textcolor = LoadSetting("color_main_textcolor");
            string hexColor = color_main_textcolor; // Beispiel-Hex-Farbe
            System.Drawing.Color colortextcolor = System.Drawing.ColorTranslator.FromHtml(hexColor);
            label_activated.ForeColor = colortextcolor;
            button_gamingmode.ForeColor = colortextcolor;
            button_desktopmode.ForeColor = colortextcolor;

            //For Progressbar
            string progressbar_color = LoadSetting("progressbar_color");
            string hexColorprogressbar = progressbar_color; // Beispiel-Hex-Farbe

            if (progressbar_color == null)
            {

            }
            else
            {
                System.Drawing.Color colorprogressbar = System.Drawing.ColorTranslator.FromHtml(hexColorprogressbar);
                guna2ProgressBardesktop_mode.ProgressColor = colorprogressbar;
                guna2ProgressBardesktop_mode.ProgressColor2 = colorprogressbar;
            }

            //For Hover
            string button_hover_color = LoadSetting("button_hover_color");
            string hexColorhover = button_hover_color; // Beispiel-Hex-Farbe
            System.Drawing.Color colorhover = System.Drawing.ColorTranslator.FromHtml(hexColorhover);
            button_desktopmode.HoverState.FillColor = colorhover;
            button_gamingmode.HoverState.FillColor = colorhover;



            //Wallpaper wenn vorhanden

            string wallpaperlink = LoadSetting("wallpaper_link");

            if (System.IO.File.Exists(wallpaperlink))
            {
                loadbackimage(wallpaperlink);
            }
            else
            {

            }
        }

        private void start_gamemode()
        {
            //Einstellungen laden und  Daten vorbereiten

            //Lancher auswahl laden
            string launcherart = LoadSetting("launcherart");
            string launcherlink = LoadSetting("launcherstart");


            // start with code

            // Display Setting
            System.Diagnostics.Process.Start("displayswitch.exe", "/external");
            // Minimize all
            // Noch keine Option hierfür

            // Warte 3 Sekunden
            Thread.Sleep(1000);

            //Launcher Start
            if (launcherart == "steam")
            {
                // code für steam Big
                string steamProtocol = "steam://open/bigpicture";
                Process.Start(new ProcessStartInfo
                {
                    FileName = steamProtocol,
                    UseShellExecute = true
                });
            }
            else
            {
                // code für custom Launcher
            }

            // Schließe die Anwendung
            System.Windows.Forms.Application.Exit();




        }

        #endregion Methoden
        #region Button Events
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();

        }


        private void button_app_close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }



        private void button_desktopmode_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void button_gamingmode_Click(object sender, EventArgs e)
        {
            start_gamemode();
        }


        private void button_pause_Click(object sender, EventArgs e)
        {
            if (pausebutton == 0)
            {
                button_pause.BackgroundImage = imageList1.Images[0];
                //Aktiviert
                pausebutton = 1;
            }
            else if (pausebutton == 1)
            {

                button_pause.BackgroundImage = imageList1.Images[1];
                //Pausiert
                pausebutton = 0;
            }
        }
        #endregion Button Events
    }
}