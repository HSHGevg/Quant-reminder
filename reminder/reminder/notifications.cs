using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reminder
{
    public partial class notifications : Form
    {
        public notifications()
        {
            InitializeComponent();
        }

        public void notifications_Load(object sender, EventArgs e)
        {

        }
        public void SetLabelText(string text)
        {
            label1.Text = text;
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
