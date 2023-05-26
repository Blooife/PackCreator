using System;
using System.Windows.Forms;

namespace CreatePack
{
    public partial class AddT : Form
    {
        public AddT()
        {
            InitializeComponent();
        }
        
        public AddT(string s)
        {
            InitializeComponent();
            tTheme.Text = s;
        }

        public string returnStr;

        private void bOk_Click(object sender, EventArgs e)
        {
            returnStr = tTheme.Text;
        }
    }
}