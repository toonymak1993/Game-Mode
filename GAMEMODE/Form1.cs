using static Guna.UI2.WinForms.Helpers.GraphicsHelper;
using System.Text.RegularExpressions;
using System.Xml;

namespace GAMEMODE
{
    public partial class Form1 : Form
    {
        #region Notwendige Variable
        private int countdownSeconds = 30;
        private string settingsFilePath;
        #endregion otwendige Variable
        #region Form Load
        public Form1()
        {
            InitializeComponent();
            #region Timer initial
            // Initialisieren Sie den Timer.
            timer.Interval = 1000; // Timer wird jede Sekunde ausgelöst
            timer.Tick += Timer_Tick;

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



        }

        private void Form1_Load(object sender, EventArgs e)
        {
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



        }
        #endregion Form Load
        #region Methoden
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (countdownSeconds > 0)
            {
                // Aktualisieren  Label mit der verbleibenden Zeit.
                label_activated.Text = "Start in: " + countdownSeconds.ToString() + " Seconds";

                // Aktualisieren der ProgressBar.
                guna2ProgressBardesktop_mode.Value = countdownSeconds;

                countdownSeconds--;
            }
            else
            {
                // Der Countdown ist abgelaufen. Sie können hier entsprechende Aktionen ausführen.
                // Zum Stoppen des Timers können Sie timer.Stop() aufrufen.
                System.Diagnostics.Process.Start("displayswitch.exe", "/internal");
                timer.Stop();
            }
        }


        // Methode zum Speichern von Einstellungen in einer XML-Datei

        #endregion Methoden
        #region Button Events
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();

        }
        #endregion Button Events
    }
}