using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_proj_KMP_serch
{
    public partial class EditTextForm : Form
    {
        const int BORDER_WIDTH = 14;
        const int BORDER_HEIGHT = 39;
        public EditTextForm(string text)
        {
            InitializeComponent();
            richTextBoxEditText.Text = text;
        }

        private void EditTextForm_Load(object sender, EventArgs e)
        {
            richTextBoxEditText.Width = (this.Width - BORDER_WIDTH);
            richTextBoxEditText.Height = (this.Height - BORDER_HEIGHT);
        }
    }
}
