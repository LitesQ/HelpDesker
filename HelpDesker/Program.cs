﻿using System;
using System.Windows.Forms;

namespace HelpDesker
{
    static class Program
    {
        static System.Threading.Mutex mutex = new System.Threading.Mutex(true, "HelpDesker");//{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("Программа уже запущена");
                return;
            }
        }
    }
}
