using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Microsoft.Win32;
namespace AFK_TIMER
{
    public partial class AFKTIMER : Form
    {
        System.Timers.Timer t;
        int m, s;

        public AFKTIMER()
        {
            InitializeComponent();
        }

       
        private void AFKTIMER_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
                
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
