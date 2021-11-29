using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DiscoSaveEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string saveFilesFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\LocalLow\\ZAUM Studio\\Disco Elysium\\SaveGames\\";

        public void OpenMethod()
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string discoSaveZip = openFileDialog1.FileName;
                openFileName.Text = discoSaveZip;
                try
                {
                    string fileText = File.ReadAllText(discoSaveZip);
                    size = fileText.Length;                    
                    using (FileStream file = File.OpenRead(discoSaveZip))
                    {
                        using (ZipArchive zip = new ZipArchive(file, ZipArchiveMode.Read))
                        {
                            foreach (ZipArchiveEntry entry in zip.Entries)
                            {
                                if (entry.FullName.EndsWith("2nd.ntwtf.json", StringComparison.OrdinalIgnoreCase))
                                    {
                                    openJsonName.Text = entry.FullName.ToString();
                                    using (StreamReader sr = new StreamReader(entry.Open()))
                                    {
                                        string rawJson = sr.ReadToEnd();
                                        jsonRawTxt.Text = rawJson;
                                        JObject parsedJson = JObject.Parse(rawJson);
                                        int skillPoints = (int)parsedJson["playerCharacter"]["SkillPoints"];
                                        int money = (int)parsedJson["playerCharacter"]["Money"];
                                        decimal dispMoney = (decimal)money / 100;
                                        int healthpots = (int)parsedJson["playerCharacter"]["healingPools"]["ENDURANCE"];
                                        int psychpots = (int)parsedJson["playerCharacter"]["healingPools"]["VOLITION"];
                                        sPnumUpDown.Value = skillPoints;
                                        moneyNumUpDown.Value = dispMoney;
                                        hPotsUpDown.Value = healthpots;
                                        pPotUpDown.Value = psychpots;
                                    }
                                }
                            }
                        }
                    }
                }
                catch (IOException)
                {
                }
            }
        }

        public void ExitMethod()
        {
            Close();
        }

        public void SaveMethod()
        {
            string rawJsontxt = jsonRawTxt.Text;
            JObject parsedJson = JObject.Parse(rawJsontxt);
            parsedJson["playerCharacter"]["SkillPoints"] = ((int)sPnumUpDown.Value);
            parsedJson["playerCharacter"]["Money"] = ((decimal)moneyNumUpDown.Value) * 100;
            parsedJson["playerCharacter"]["healingPools"]["ENDURANCE"] = ((int)hPotsUpDown.Value);
            parsedJson["playerCharacter"]["healingPools"]["VOLITION"] = ((int)pPotUpDown.Value);
            int spNotZero = (int)sPnumUpDown.Value;
            if (spNotZero > 0)
            {
                parsedJson["playerCharacter"]["NewPointsToSpend"] = true;
            }
            else
            {
                parsedJson["playerCharacter"]["NewPointsToSpend"] = false;
            }
            newJsonTxt.Text = parsedJson.ToString();
            string discoSaveZip = openFileName.Text;
            string discoSaveJson = openJsonName.Text;
            using (FileStream zipToOpen = new FileStream(discoSaveZip, FileMode.Open))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                    ZipArchiveEntry entry = archive.GetEntry(discoSaveJson);
                    if (entry != null)
                    {
                        entry.Delete();
                    }
                    ZipArchiveEntry newSaveEntry = archive.CreateEntry(discoSaveJson);
                    using (StreamWriter writer = new StreamWriter(newSaveEntry.Open()))
                    {
                        writer.Write(newJsonTxt.Text);
                    }
                }
            }
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to exit?",
                                                 "Confirm",
                                                 MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                ExitMethod();
            }
            else
            {
                
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to exit?",
                                                 "Confirm",
                                                 MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                ExitMethod();
            }
            else
            {

            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenMethod();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMethod();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to save? This will overwite the current save.",
                                                 "Confirm",
                                                 MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                SaveMethod();
            }
            else
            {

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to save? This will overwite the current save.",
                                                 "Confirm",
                                                 MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                SaveMethod();
            }
            else
            {

            }
        }
    }
}
