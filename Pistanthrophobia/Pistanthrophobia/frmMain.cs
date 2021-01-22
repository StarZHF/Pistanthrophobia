using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Pistanthrophobia
{
    public partial class frmMain : Form
    {
        public string saveDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\LocalLow\Kinetic Games\Phasmophobia";
        public string saveFileName = @"saveData.txt";
        public string saveFilePassword = "CHANGE ME TO YOUR OWN RANDOM STRING"; // Literally what the dev used. copypasta++

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MaximumSize = Size;
            MinimumSize = Size;
        }

        private void btnCheat_Click(object sender, EventArgs e)
        {
            lblGhostInfo.Text = getRoute(getGhostType());
        }

        public string getGhostType()
        {
            try
            {
                string tempFilePath = Path.Combine(saveDirectory, saveFileName);

                string data = File.ReadAllText(tempFilePath); 

                StringBuilder text = new StringBuilder();
                for (int i = 0; i < data.Length; i++) // Decode the safe file
                {
                    text.Append((char)(data[i] ^ saveFilePassword[i % saveFilePassword.Length]));
                }

                return System.Text.RegularExpressions.Regex.Match(text.ToString(), @"GhostType\""\,\""Value\""\:\""(\w{3,12})").Groups[1].ToString(); // You could go through the hassle of implementing JSON Parsing
                                                                                                                                                      // for one line, However, I would say RegEx suffices.
            }
            catch (Exception ex)
            {
                return $"Something fucked up.\r\n {ex.Message}"; // Top tier error logging.
            }
        }

        public string getRoute(string ghostType) // Dirty, Works for the small scale project.
        {
            foreach(string json in File.ReadAllLines("ghosts.info"))
            {
                if (!json.Contains(ghostType)) { continue; } // If it isn't our ghost; skip until it is...

                Ghost jsGhost = new Ghost(); // tbh this is just me playing with the new native JSON framework..
                jsGhost = JsonSerializer.Deserialize<Ghost>(json);

                return $"{jsGhost.ghostType}\r\n\r\n{jsGhost.ghostEvidence}"; // And finally return our information.
            }
            return ghostType; // If the ghost isn't in our list, just tell us the type.
        }
        public class Ghost
        {
            public string ghostType { get; set; }

            public string ghostEvidence { get; set; }
        }
    }
}
