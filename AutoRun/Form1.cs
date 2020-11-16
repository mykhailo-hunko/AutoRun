using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRun
{
    public partial class Form1 : Form
    {

        bool isStart = false;
        public Form1()
        {
            InitializeComponent();
            Program.timers();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            startJar(null);
        }

        public void startJar(object y)
        {
            if (!isStart)
            {
                Process.Start(@"C:\parcer\out\artifacts\parcer_jar\parcer.jar");
                isStart = true;
            }
            else
            {
                MessageBox.Show("Не так быстро, будь нежнее. Попробуй через пол часа!");
            }
            
        }

        public void isStartDef(object y)
        {
            isStart = false;

        }

      
    }
}
