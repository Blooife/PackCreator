using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Playhub
{
    public class ProtocolModel
    {

        public class Question
        {
            public int Index { get; set; }
            public string Text { get; set; }
            public QuestionType Type { get; set; }
            public  int Points { get; set; }
            public string Answer { get; set; }
            public string Subject { get; set; }
            public byte[] Picture { get; set; }
            public string Ext{ get; set; }
        }

        public enum QuestionType
        {
            Text,
            Picture
        }

        public enum ButtonType
        {
            Theme,
            Qest,
        }
        
        public class Btn:Button
        {
            public Question question{ get; set; }
            public int Index{ get; set; }
            public ButtonType Type;
            public int Row{ get; set; }
            public int Column{ get; set; }
            public string Theme{ get; set; }

            public Btn()
            {
                Width = 80;
                Height = 30;
            }

        }
    }
}
