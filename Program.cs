﻿using System;
using System.Windows.Forms;

namespace Final_Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MenuForm());

            }
            catch (Exception)
            {

                
            }


            
            /*
            

            ScheduleBlock sb = ScheduleBlock.getFromDB(101);
            Evaluator.evaluate(sb);

            */
            
        }
    }
}
