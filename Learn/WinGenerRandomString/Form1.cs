using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinGenerRandomString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            //todo:validate()

            bool hasUpperChar = chkUpperChar.Checked;
            bool hasLowerChar = chkLowerChar.Checked;
            bool hasNumber = chkNumber.Checked;
            bool hasSpecialChar = chkSpecialChar.Checked;
            bool hasChineseChar = chkChineseChar.Checked;

            bool hasSameChar = !chkHasNotSameChar.Checked;
            int length = int.Parse(txtLength.Text.Trim());
            int amount = int.Parse(txtAmout.Text.Trim());

            RandomHelper helper = new RandomHelper(hasLowerChar,hasUpperChar,hasNumber,hasSpecialChar,hasChineseChar,hasSameChar,length);
            Stopwatch sw = new Stopwatch();
            sw.Start();

            string path = BuildFilePath();
            StreamWriter writer = new StreamWriter(path, true);
            for (int i = 0; i < amount; i++)
            {
                writer.WriteLine(helper.GetRandomString());
            }

            sw.Stop();
            lblElapsed.Text = sw.Elapsed.TotalSeconds.ToString();
            writer.Dispose();

            Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }

        private string BuildFilePath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), BuildFileName()); 
        }

        private string BuildFileName()
        {
            return DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
        }
    }
}
