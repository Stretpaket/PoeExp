using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json;

namespace poexp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        FileInfo fileInfo;
        DateTime prevZoneTime;
        Series lineSeries;

        long lastZoneExp;
        String currentZone = "Start Zone";
        CharacterHandler ch;
        

        private void checkIfEntered()
        {
            try
            {
                String line = "";
                using (FileStream stream = File.Open(Form1.clientPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        
                        while (!reader.EndOfStream)
                        {
                            line = reader.ReadLine();
                        }
                    }
                }
                if (line.Contains("You have entered")) 
                {
                    var charInfo = ch.getCharacterInfo();
                    label1.Text = formatCharacterString(charInfo);
                    
                    long currxp = long.Parse(charInfo["xp"]);

                    var diffSeconds = (DateTime.Now - prevZoneTime).TotalSeconds;
                    var expDiff = currxp - lastZoneExp;

                    if (!currentZone.Contains("Hideout"))
                    {                     
                        lineSeries.Points.AddXY(currentZone, (double)expDiff / (double)(diffSeconds / 60));
                    }
                    
                    currentZone = line.Split(new string[] { "You have entered " }, StringSplitOptions.None)[1].TrimEnd('.');
                    label2.Text = "Currently in " + currentZone;
                    lastZoneExp = currxp;
                    prevZoneTime = DateTime.Now;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Watch for changes in client path
            fileInfo = new FileInfo(Form1.clientPath);
            prevZoneTime = DateTime.Now;
            timer1.Start();

            //Configure charts
            chart1.Series.Clear();           
            lineSeries = chart1.Series.Add("Exp per minute");
            lineSeries.Color = Color.SteelBlue;
            lineSeries.BorderWidth = 5;
            lineSeries.ChartType = SeriesChartType.Line;

            //Populate character data
            ch = new CharacterHandler(Form1.accountName, Form1.characterName);
            var charInfo = ch.getCharacterInfo();

            //init xp vars
            long cxp = long.Parse(charInfo["xp"]);
            lastZoneExp = cxp;
            label1.Text = formatCharacterString(charInfo);
        }

        private string formatCharacterString(Dictionary<string,string> charInfo)
        {
            return charInfo["name"] + " Lv" + charInfo["level"] + " " + charInfo["class"];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fileInfo.Refresh();
            DateTime time = fileInfo.LastWriteTime;
            if (time > prevZoneTime)
            {
                checkIfEntered();              
            }          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
        }
    }
}
