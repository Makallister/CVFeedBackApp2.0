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
    public partial class AddOptionSet : Form
    {
        
        public AddOptionSet()
        {
            InitializeComponent();


            //initializes Tracker instance
            Tracker trackerInstance = Tracker.GetTracker();

            //Checks for selection in first menu
            int firstMenuDecision = trackerInstance.GetFirstMenuSelection();

            if (firstMenuDecision == 1)
            {
                //Gets Generic Template Instance
                GenericTemplate genericTemplateInstance = GenericTemplate.GetGenericTemplate();

                int optionSetListCount = trackerInstance.GetOptionSetCounter();
                
                //Checks if member of list is in range
                if (optionSetListCount <= genericTemplateInstance.GetOptionSetList().Count)
                {
                    this.SaveOtionCategory.Text = "Submit changes";
                    //Access list of optionset from generic template
                    //Selects a member based on the count
                    //Calls the method get title from OptionSetObject
                    //Sets textbox to results
                    OptionSetTitleTextbox.Text = genericTemplateInstance.GetOptionSetList()[optionSetListCount].GetOptionSetTitle();

                    optionSetListCount++;

                    //adds new value to the tracker
                    trackerInstance.SetOptionSetTrackingNumber(optionSetListCount);

                    //sets changes to singleton pattern
                    Tracker.SetTracker(trackerInstance);

                }

            }

        }

        private void SaveOptionCategory_MouseClick(object sender, MouseEventArgs e)
        {
            if (ErrorChecker.nullTextboxErrorCheck("Option Set Title", OptionSetTitleTextbox.Text))
            {
                this.Hide();
                
                //Creates an instance of OptionSet and generic template
                OptionSet OptionSetInstance = OptionSet.GetOptionSet();


                //Populates OptionSetInstance with texbox content
                OptionSetInstance.SetOptionSetTitle(OptionSetTitleTextbox.Text);

   
                //Sets the new value for OptionSet tilte to singleton
                OptionSet.SetNewOptionSet(OptionSetInstance);

                //Creates and displays new OptionForm
                SetOptionsForm OptionForm = new SetOptionsForm();
                OptionForm.ShowDialog();
            }

        }

        private void EditPreviousOptions_MouseClick(object sender, MouseEventArgs e)
        {
            //Go to previous
        }
    }
}
