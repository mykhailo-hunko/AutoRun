using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRun
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
       static Form1 form;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1();
            Application.Run(form);
        }
       public static void timers()
        {
            TimerCallback tm = new TimerCallback(form.startJar);
            // создаем таймер
            System.Threading.Timer timer = new System.Threading.Timer(tm, null, 0, 1000*30*60);

            TimerCallback tm2 = new TimerCallback(form.isStartDef);
            // создаем таймер
            System.Threading.Timer timer2 = new System.Threading.Timer(tm2, null, 30*1000, 1000*12*60*60);
        }

    }
}
