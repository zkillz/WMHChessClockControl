using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockTest
{
    public partial class clock1 : Form
    {
        public clock1()
        {
            InitializeComponent();
        }

        internal void readTime(string time)
        {
            this.clockText.Text = time;
        }
    }
}
