//FinalExam_Summer2020_CharacterBuilder
//Created by: Remedios Meneses
//Student No.: 300691712
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            //Start method to begin the Splashscreen
            Timer.Start();
        }

        //Timer's tick event handler
        private void Timer_Tick(object sender, EventArgs e)
        {
            //Stop method to stop the Splashscreen 
            Timer.Stop();

            //Instantiate a new GenerateNameForm object
            GenerateNameForm mf = new GenerateNameForm();

            //A method to show the SplashForm
            mf.Show();

            //A method to hide the SplashForm 
            this.Hide();
        }

        
    }

}
