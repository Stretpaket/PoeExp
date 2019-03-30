using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poexp
{
    public partial class Form1 : Form
    {

        public static string clientPath;
        public static string characterName;
        public static string accountName;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            clientPath = tbClientPath.Text;
            characterName = tbCharacterName.Text;
            accountName = tbAccountName.Text;
            Properties.Settings.Default.Save();
            Form2 chartForm = new Form2();
            chartForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                tbClientPath.Text = openFileDialog1.FileName;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
