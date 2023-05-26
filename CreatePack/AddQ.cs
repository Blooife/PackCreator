using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Playhub;

namespace CreatePack
{
    public partial class AddQ : Form
    {
        public AddQ()
        {
            InitializeComponent();
        }
        
        public AddQ(ProtocolModel.Question quest)
        {
            InitializeComponent();
            rtAnswer.Text = quest.Answer;
            nPoints.Text = quest.Points.ToString();
            if (quest.Type == ProtocolModel.QuestionType.Picture)
            {
                ext = quest.Ext;
                pictArr = quest.Picture;
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    memoryStream.Write(pictArr, 0, pictArr.Length);
                    Image image = Image.FromStream(memoryStream);
                    pBox.Image = image;
                }
                rbPicture_Enter(null,null);
            }
            else
            {
                rtQuestion.Text = quest.Text;
                rbText_Enter(null, null);
            }
        }

        public ProtocolModel.Question question;
        private byte[] pictArr;
        public string ext;
        private void bOk_Click(object sender, EventArgs e)
        {
            if (rbPicture.Checked)
            {
                question = new ProtocolModel.Question()
                {
                    Type = ProtocolModel.QuestionType.Picture,
                    Picture = pictArr,
                    Ext = ext,
                    Answer = rtAnswer.Text,
                    Points = int.Parse(nPoints.Text),
                };
            }
            else
            {
                question = new ProtocolModel.Question()
                {
                    Type = ProtocolModel.QuestionType.Text,
                    Text = rtQuestion.Text,
                    Answer = rtAnswer.Text,
                    Points = int.Parse(nPoints.Text),
                }; 
            }
        }

        private void rbText_Enter(object sender, EventArgs e)
        {
            rbText.Checked = true;
            rbPicture.Checked = false;
            rtQuestion.Visible = true;
            bOpen.Visible = false;
            pBox.Visible = false;
            label1.Visible = true;
        }

        private void rbPicture_Enter(object sender, EventArgs e)
        {
            rbText.Checked = false;
            rbPicture.Checked = true;
            rtQuestion.Visible = false;
            bOpen.Visible = true;
            pBox.Visible = true;
            label1.Visible = false;
        }

        public void ReadFile(string filePath)
        {
            ext = Path.GetExtension(filePath); 
            pictArr = File.ReadAllBytes(filePath);
            using (MemoryStream memoryStream = new MemoryStream())
            {
                memoryStream.Write(pictArr, 0, pictArr.Length);
                Image image = Image.FromStream(memoryStream);
                pBox.Image = image;
            }
        }
        private void bOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                string filePath = openFileDialog.FileName;
                ReadFile(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}