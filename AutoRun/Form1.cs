using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AutoRun
{
    public partial class Form1 : Form
    {

       static bool isStart = false;
        static bool isStartGoogle = false;
        public Form1()
        {
            InitializeComponent();
           timers();
        }

        private  void button_start_Click(object sender, EventArgs e)
        {
            startJar(null, null);
        }

        public static void startJar(object sender, EventArgs e)
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

        public static void startJarGoogle(object sender, EventArgs e)
        {
            if (!isStart)
            {
                Process.Start(@"C:\parserGoogle\out\artifacts\parserGoogle_jar\parserGoogle.jar");
                isStartGoogle = true;
            }
            else
            {
                MessageBox.Show("Не так быстро, будь нежнее. Попробуй через пол часа!");
            }

        }

        public static void isStartDef(object sender, EventArgs e)
        {
            isStart = false;

        }

        public static void isStartDefGoogle(object sender, EventArgs e)
        {
            isStartGoogle = false;

        }

        public static void timers()
        {

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(startJar);
            timer.Interval = 1000 * 60 * 60 * 12; // 12 Hours
            timer.Start();
           
            System.Timers.Timer timer2 = new System.Timers.Timer();
            timer2.Elapsed += new System.Timers.ElapsedEventHandler(isStartDef);
            timer2.Interval = 1000 * 30 * 60; // 0.5 Hours
            timer2.Start();

            System.Timers.Timer timerGoogleStarts = new System.Timers.Timer();
            timerGoogleStarts.Elapsed += new System.Timers.ElapsedEventHandler(isStartDefGoogle);
            timerGoogleStarts.Interval = 1000 * 30 * 60; // 0.5 Hours
            timerGoogleStarts.Start();

            System.Timers.Timer timerGoogle = new System.Timers.Timer();
            timerGoogle.Elapsed += new System.Timers.ElapsedEventHandler(startJarGoogle);
            timerGoogle.Interval = 1000 * 60 * 60 * 12; // 12 Hours
            timerGoogle.Start();

        }

        private void button_start_scholar_Click(object sender, EventArgs e)
        {
            startJarGoogle(null, null);
        }
    }
}
