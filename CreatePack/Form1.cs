using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Compression;
using System.Windows.Forms;
using Playhub;

namespace CreatePack
{
    public partial class Form1 : Form
    {

        public static List<ProtocolModel.Btn> Buttons = new List<ProtocolModel.Btn>();
        
        public List<ProtocolModel.Question> Questions = new List<ProtocolModel.Question>();
        public List<string> Themes = new List<string>();
        public TableLayoutPanel tl = new TableLayoutPanel();
        public Form1()
        {
            InitializeComponent();
            tl.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tl.Dock = DockStyle.Fill;
            tl.AutoScroll = true;
            panel.Controls.Add(tl);
            Buttons.Add(new ProtocolModel.Btn()
            {
                Text = "?",
                Type = ProtocolModel.ButtonType.Theme,
                Row = 0,
                Column = 0,
                Margin = new Padding(10),
                
            });
            Buttons.Add(new ProtocolModel.Btn()
            {
                Text = "?",
                Type = ProtocolModel.ButtonType.Qest,
                Row = 0,
                Column = 1,
                Margin = new Padding(10),
            });
            Buttons.Add(new ProtocolModel.Btn()
            {
                Text = "+",
                Type = ProtocolModel.ButtonType.Qest,
                Row = 0,
                Column = 2,
                Margin = new Padding(10),
            });
            Buttons.Add(new ProtocolModel.Btn()
            {
                Text = "+",
                Type = ProtocolModel.ButtonType.Theme,
                Row = 1,
                Column = 0,
                Margin = new Padding(10),
            });
            foreach (var b in Buttons)
            {
                b.Click += ButtonOnClick;
                tl.Controls.Add(b,b.Column,b.Row);
            }
            
        }

        public void ButtonOnClick(object sender, EventArgs ev)
        {
            ProtocolModel.Btn b = (ProtocolModel.Btn)sender;
            if (b.Text == "+")
            {
                if (b.Type == ProtocolModel.ButtonType.Theme)
                {
                    b.Text = "?";
                    tl.RowCount = tl.RowCount+1;
                    Buttons.Add(new ProtocolModel.Btn()
                    {
                        
                        Text = "+",
                        Type = ProtocolModel.ButtonType.Theme,
                        Row = b.Row+1,
                        Column = 0,
                        Margin = new Padding(10),
                
                    });
                    var n = Buttons.Last();
                    n.Click += ButtonOnClick;
                    tl.Controls.Add(n,n.Column,n.Row);
                    Buttons.Add(new ProtocolModel.Btn()
                    {
                        
                        Text = "?",
                        Type = ProtocolModel.ButtonType.Qest,
                        Row = b.Row,
                        Column = b.Column+1,
                        Margin = new Padding(10),
                
                    });
                    n = Buttons.Last();
                    n.Click += ButtonOnClick;
                    tl.Controls.Add(n,n.Column,n.Row);
                    Buttons.Add(new ProtocolModel.Btn()
                    {
                        
                        Text = "+",
                        Type = ProtocolModel.ButtonType.Qest,
                        Row = b.Row,
                        Column = b.Column+2,
                        Margin = new Padding(10),
                
                    });
                    n = Buttons.Last();
                    n.Click += ButtonOnClick;
                    tl.Controls.Add(n,n.Column,n.Row);
                    
                }
                else
                {
                    b.Text = "?";
                    Buttons.Add(new ProtocolModel.Btn()
                    {
                        Text = "+",
                        Type = ProtocolModel.ButtonType.Qest,
                        Row = b.Row,
                        Column = b.Column+1,
                        Margin = new Padding(10),
                    });
                    var n = Buttons.Last();
                    n.Click += ButtonOnClick;
                    tl.Controls.Add(n,n.Column,n.Row);
                }
            }else if (b.Text == "?")
            {
                if (b.Type == ProtocolModel.ButtonType.Theme)
                {
                    AddT form = new AddT();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        b.Text = form.returnStr;
                        b.Theme = form.returnStr;
                    }
                }
                else
                {
                    AddQ form = new AddQ();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        b.question = form.question;
                        b.Text = b.question.Points.ToString();
                    }
                }
            }
            else
            {
                if (b.Type == ProtocolModel.ButtonType.Qest)
                {
                    AddQ form = new AddQ(b.question);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        b.question = form.question;
                        b.Text = b.question.Points.ToString();
                    }
                }
                else
                {
                    AddT form = new AddT(b.Text);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        b.Text = form.returnStr;
                        b.Theme = form.returnStr;
                    }
                }
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            Questions.Clear();
            foreach (var b in Buttons)
            {
                if (b.Text == "?")
                {
                    MessageBox.Show("");
                    return;
                }else if (b.Text == "+" || b.Type == ProtocolModel.ButtonType.Theme)
                {
                    continue;
                }
                b.question.Subject = tl.GetControlFromPosition(0, b.Row).Text;
                Questions.Add(b.question);
            }
            string tempFolderPath = Path.Combine(Path.GetTempPath(), "MyTempFolder");
            Directory.CreateDirectory(tempFolderPath);
            //File.Create()
            List<string> lines = new List<string>();
            var groups = Questions.GroupBy(q => q.Subject);
            int i = 0;
            foreach (var group in groups)
            {
                lines.Add(group.First().Subject);
                lines.Add(group.Count().ToString());
                foreach (var quest in group)
                {
                    lines.Add(quest.Type.ToString());
                    if (quest.Type == ProtocolModel.QuestionType.Text)
                    {
                        lines.Add(quest.Text);  
                    }
                    else
                    {
                        string path = Path.Combine(tempFolderPath, i.ToString() + quest.Ext);
                        lines.Add(i.ToString() + quest.Ext);
                        File.WriteAllBytes(path, quest.Picture);
                    }
                    lines.Add(quest.Answer);
                    lines.Add(quest.Points.ToString());
                }
            }
            string path1 = Path.Combine(tempFolderPath, "allQ.txt");
            File.WriteAllLines(path1, lines);
            using (var saveFolderDialog = new SaveFileDialog())
            {
                saveFolderDialog.FileName = "MyFolder";
                saveFolderDialog.Filter = "Папка (*.zip)|*.zip";
    
                if (saveFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    string saveFilePath = saveFolderDialog.FileName;
                    ZipFile.CreateFromDirectory(tempFolderPath, saveFilePath);
                    Directory.Delete(tempFolderPath, true);
                }
            }
        }
    }
}