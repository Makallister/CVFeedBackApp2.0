using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVFeedbackApp
{
    public partial class SetOptionsForm : Form
    {
        public SetOptionsForm()
        {
            InitializeComponent();
        }
        /*int OptionSetNumber;
        protected int AddOptionSet(int OptionCounter)
        {
            OptionSetNumber = OptionCounter ;

            return 1;
            
        }
        */
        private void AddOptiontoSet_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            //store textbox values in temporary strings.
            string optionTitle = OptionTitleTextBox.Text;
            string optionMessage = OptionMessageTextBox.Text;

            //create new Obejct Option
            Option newOption = new Option();

            //Call Option contructors
            newOption.GetOptionTitle(optionTitle);
            newOption.GetOptionMessage(optionMessage);

            //Send Option to OptionSet
            

            //creates new form
            SetOptionsForm OptionForm2 = new SetOptionsForm();
            OptionForm2.ShowDialog(); 
        }

        private void NewOptionSet_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AddOptionSet Optionset2 = new AddOptionSet();
            Optionset2.ShowDialog();
        }

        private void FinishTemplate_MouseClick(object sender, MouseEventArgs e)
        {
            //Save Generic template and return to main menu.
        }

        private void EditPreviousOptionSetTitle_MouseClick(object sender, MouseEventArgs e)
        {
            //go to previous Form
        }
    }
}
