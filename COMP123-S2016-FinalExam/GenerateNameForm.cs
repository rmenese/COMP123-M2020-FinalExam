//FinalExam_Summer2020_CharacterBuilder
//Created by: Remedios Meneses
//Student No.: 300691712
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        public void GenerateNames()
        {
            //Generate a random integer from 0 to FirstNameListBox.Items.Count
            var random = new Random();
            int index = random.Next(FirstNameListBox.Items.Count);
            int i = random.Next(0, FirstNameListBox.Items.Count);
            FirstNameTextBox.Text = FirstNameListBox.Items[index].ToString();
            int i2 = random.Next(0, LastNameListBox.Items.Count);
            LastNameTextBox.Text = LastNameListBox.Items[index].ToString();
        }

        private void FirstNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Transfer the name from the SelectedItem.ToString() to FirstNameTextBox.Text
            Debug.WriteLine(FirstNameListBox.SelectedItem.ToString());
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            //Call the GenerateName method
            GenerateNames();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            //Call the GenerateName method
            GenerateNames();

            // Transfer FirstNameTextBox.Text to Program.character.FirstName
            Program.character.FirstName = FirstNameTextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;

            // Use the random number as the SelectedIndex
            FirstNameListBox.SelectedIndex = 30;
            LastNameListBox.SelectedIndex = 27;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //Instantiate a new AbilityGeneratorForm object
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();

            //Call the show method of AbilityGeneratorForm object
            abilityGeneratorForm.Show();
            
            //Call the Hide method of the GenerateNameForm
            this.Hide();
        }

        

    }
}
