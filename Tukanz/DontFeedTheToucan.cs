using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace Tukanz
{
    public partial class DontFeedTheToucan : Form
    {
        public DontFeedTheToucan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want really feed the toucan? Because its forbidden, you better don`t do it!", "Feed the Toucan?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("shutdown", "/s /f /t 300 /c \"Toucan infected your PC with a Bird Virus because you feeded him, Now your PC will explode in 10 Seconds...i think...\"");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
