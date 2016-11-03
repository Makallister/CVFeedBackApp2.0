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
        private void OptionAddition ()
        {
            //Creates intance of optionSet and Option
            OptionSet OptionSetInstance = OptionSet.GetOptionSet();
            Option OptionInstance = Option.GetOption();

            //populates option from textboxes
            OptionInstance.SetOptionTitle(OptionTitleTextBox.Text);
            OptionInstance.SetOptionMessage(OptionMessageTextBox.Text);

            //Populates OptionSet with new Option
            OptionSetInstance.AddOptionToSet(OptionInstance);
        }
        private void AddOptiontoSet_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();

            //Calls Option addition method

            OptionAddition();


            //creates new form
            SetOptionsForm OptionForm2 = new SetOptionsForm();
            OptionForm2.ShowDialog(); 
        }

        private void NewOptionSet_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();

            //Calls Option addition method

            OptionAddition();


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
