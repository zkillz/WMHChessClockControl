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
    public partial class scenario : Form
    {
        public scenario()
        {
            InitializeComponent();
        }

        internal void readPoints(string points)
        {
            this.scenarioPoints.Text = points;
        }
    }
}
