﻿//FinalExam_Summer2020_CharacterBuilder
//Created by: Remedios Meneses
//Student No.: 300691712
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public static class Program
    {
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
            Application.Run(new AbilityGeneratorForm());
        }
    }
}
