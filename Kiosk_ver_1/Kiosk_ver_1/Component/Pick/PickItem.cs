using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_ver_1.Component.Pick
{
    public partial class PickItem : UserControl
    {
        public PickItem()
        {
            InitializeComponent();
        }

        public string Title { get => lblTitle.Text; set => lblTitle.Text=value.Trim(); }
        public string Count { get=>lblCount.Text; set => lblCount.Text=value; }
        public Image Image { get=>pictureBox1.Image; set => pictureBox1.Image=value; }
    }
}
