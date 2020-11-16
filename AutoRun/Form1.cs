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

       static bool isStart = false;
        public Form1()
        {
            InitializeComponent();
           timers();
        }

        private  void button_start_Click(object sender, EventArgs e)
        {
            startJar(null);
        }

        public static void startJar(object y)
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

        public static void isStartDef(object y)
        {
            isStart = false;

        }

        public static void timers()
        {

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(startJar);
            timer.Interval = 1000 * 60 * 60 * 24; // 24 Hours
            timer.Start();
            TimerCallback tm = new TimerCallback(startJar);
            // создаем таймер
            System.Threading.Timer timer = new System.Threading.Timer(tm, null, 0, 1000 * 30 * 60);

            TimerCallback tm2 = new TimerCallback(isStartDef);
            // создаем таймер
            System.Threading.Timer timer2 = new System.Threading.Timer(tm2, null, 30 * 1000, 1000 * 12 * 60 * 60);
        }



    }
}
