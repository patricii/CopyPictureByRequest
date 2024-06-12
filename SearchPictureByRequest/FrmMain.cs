using System;
using System.IO;
using System.Windows.Forms;

namespace SearchPictureByRequest
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }   
        private void buttonRequest_Click(object sender, EventArgs e)
        {
            createRequest();
        }
        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxCopyTo.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void createRequest()
        {
            if (textBoxTrackId.Text.Length != 10)
            {
                MessageBox.Show("Track-ID inválido!!! o TrackId deve conter 10 caracteres!!");
                textBoxTrackId.Text = "";
            }
            else
            {
                string fileName = textBoxCopyTo.Text + "\\" + textBoxTrackId.Text + ".picture";
                try
                {
                    using (StreamWriter sw = File.CreateText(fileName))
                    {
                        sw.Write("OK");
                    }
                    MessageBox.Show("*Imagens requisitadas com sucesso!!! \n *As imagens podem demorar alguns segundos para serem copiadas*");
                    textBoxTrackId.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao criar o arquivo request: " + Ex);
                }
            }
        }
    }
}
