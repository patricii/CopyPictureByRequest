using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CopyLogByRequest
{
    public partial class FormMain : Form
    {
        
        string errorMessageDriver = "Pasta origem não existe ou não foi possivel mapear o driver de rede!";
        string errorMessageFolder = "Pasta destino não existe!!!";
        string statusMsg = "Running";
        string ledMsg = "Running...Green Light means Copying Pictures";
        string destinationDir = string.Empty;
        private System.Threading.Timer timer;
        int nStatus = -1;

        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxTo.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            string sourceDir = textBoxFrom.Text;
            destinationDir = textBoxTo.Text;
            if (!Directory.Exists(sourceDir))
            {
                MessageBox.Show(errorMessageDriver);
                labelStatus.Text = "Offline";
                buttonLed.BackColor = Color.Red;
            }
            else if (!Directory.Exists(destinationDir))
            {
                MessageBox.Show(errorMessageFolder);
            }
            else
            {
                buttonCopy.Text = statusMsg;
                labelStatus.Text = ledMsg;
                var startTimeSpan = TimeSpan.Zero;
                var periodTimeSpan = TimeSpan.FromSeconds(20); 
                timer = new System.Threading.Timer((obj) =>
                {
                    nStatus = CopyFunction();

                }, null, startTimeSpan, periodTimeSpan);
            }
        }
        private int CopyFunction()
        {
            string sourceDir = textBoxFrom.Text;
            destinationDir = textBoxTo.Text;
            buttonLed.BackColor = Color.Green;
            buttonCopy.BackColor = Color.LightGreen;
            string extensionFile = "picture";
            string trackid = "";
            FileInfo fileInfo;
            FileInfo fileInfoMQS;
            int count = 0;
            string measTemp = string.Empty;

            try
            {

                foreach (string file_name in Directory.GetFiles(destinationDir, "*" + extensionFile + "*", SearchOption.AllDirectories)) //get picturefile from FLEX server
                {
                    fileInfo = new FileInfo(file_name);
                    trackid = file_name.Replace(".picture", "");
                    trackid = trackid.Replace(destinationDir,"");
                    if (fileInfo.Exists)
                    {
                        foreach (string log_name in Directory.GetFiles(sourceDir, "*" + trackid + "*", SearchOption.AllDirectories)) //get pictures from V and send to FLEX driver
                        {
                            measTemp = log_name;
                            measTemp = measTemp.Replace(sourceDir, "");
                            measTemp = measTemp.Replace("\\", "");
                            if (measTemp.Contains(".png") || measTemp.Contains(".jpeg") || measTemp.Contains(".jpg") || measTemp.Contains(".RAW10")) //file extension allowed
                            {
                                fileInfoMQS = new FileInfo(log_name);
                                if (!IsFileLocked(fileInfoMQS))
                                {
                                    count++;
                                    File.Copy(log_name, destinationDir + "\\" + trackid + "_" + count.ToString() + measTemp, true);
                                    fileInfo.Delete();
                                }
                            }
                        }
                        try
                        {
                            fileInfo.Delete();
                        }
                        catch
                        {
                            //do nothing
                        }
                    }
                }
                buttonLed.BackColor = Color.Red;
                count = 0;
                measTemp = "";
            }
            catch (IOException)
            {
                return 1;
            }

            return 0;
        }
        protected virtual bool IsFileLocked(FileInfo file)
        {
            try
            {
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                return true;
            }
            //file is not locked
            return false;
        }
    }
}
