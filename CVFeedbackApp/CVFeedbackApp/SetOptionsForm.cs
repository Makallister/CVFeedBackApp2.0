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
            OptionSet optionSetInstance = OptionSet.GetOptionSet();
            SectionTitleTextBox.Text = optionSetInstance.GetOptionSetTitle();
        }
        private bool GetErrorResult()
        {
            if (ErrorChecker.nullTextboxErrorCheck("Option Title", OptionTitleTextBox.Text)
                && ErrorChecker.nullTextboxErrorCheck("Option Message", OptionMessageTextBox.Text))
            {
                return true;
            }
            else
                return false;
        }
        private void OptionAddition()
        {
            if (GetErrorResult())
            {
                //Gets/Creates intance of optionSet and Option
                OptionSet OptionSetInstance = OptionSet.GetOptionSet();
                Option OptionInstance = Option.GetOption();

                //populates option from textboxes
                OptionInstance.SetOptionTitle(OptionTitleTextBox.Text);
                OptionInstance.SetOptionMessage(OptionMessageTextBox.Text);

                //Populates OptionSet with new Option
                OptionSetInstance.AddOptionToSet(OptionInstance);

                //Sets Both Instances
                Option.SetOption(OptionInstance);
                OptionSet.SetNewOptionSet(OptionSetInstance);
            }
            else
            {
                //Does nothing
            }
            


        }
        private void AddOptionToSet_MouseClick(object sender, MouseEventArgs e)
        {
            if(GetErrorResult())
            {
                this.Hide();

                //Calls Option addition method

                OptionAddition();


                //Deletes Option for new option to be added
                Option.DeleteOptionInstance();


                //creates new form (loop)
                SetOptionsForm OptionForm2 = new SetOptionsForm();
                OptionForm2.ShowDialog();
            }
            else
            {
                //Does Nothing
            }
            
        }

        private void NewOptionSet_MouseClick(object sender, MouseEventArgs e)
        {
            if (GetErrorResult())
            {
                this.Hide();

                //Calls Option addition method

                OptionAddition();

                //Gets intance of Generic template and OptionSet
                GenericTemplate genericTemplateInstance = GenericTemplate.GetGenericTemplate();
                OptionSet optionSetInstance = OptionSet.GetOptionSet();

                //Feeds OptionSet to Generic Template Instance

                genericTemplateInstance.AddOptionSet(optionSetInstance);

                //Deletes Current OptionSet

                OptionSet.DeleteOptionSet();

                //Creates and displays AddOptionSetForm

                AddOptionSet Optionset2 = new AddOptionSet();
                Optionset2.ShowDialog();
            }
            else
            {
                //Does Nothing
            }
            
        }


        /// <summary>
        /// Save Generic template and return to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishTemplate_MouseClick(object sender, MouseEventArgs e)
        {
            if (GetErrorResult())
            {
                //Creates instance Of Generic Template
                GenericTemplate genericTemplateInstance = GenericTemplate.GetGenericTemplate();

                //Displays Message form asking for confirmation
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult textboxInput;
                textboxInput = MessageBox.Show("Do you want to save this changes into " + genericTemplateInstance.GetTitle() + "?", "Save Progress", buttons);
                if (textboxInput == DialogResult.Yes)
                {
                    //creates instance of DBConnection and calls insertion method
                    DBConnection connectionInstance = DBConnection.getDatabaseConection();
                    connectionInstance.insertToDB();

                    //Deletes GenericTemplate
                    GenericTemplate.DeleteGenericTemplateInstance();


                    this.Hide();
                    FirstMenuForm newFirstMenuForm = new FirstMenuForm();
                    newFirstMenuForm.ShowDialog();
                }
                else
                {
                    //Does nothing
                }
            }
            else
            {
                //Does Nothing
            }

            


        }

        private void EditPreviousOptionSetTitle_MouseClick(object sender, MouseEventArgs e)
        {
            //go to previous Form
        }

    }
}
