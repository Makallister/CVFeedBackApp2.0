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
    public partial class EditTemplateForm : Form
    {
        ErrorChecker ErrorCheck = new ErrorChecker();



        public EditTemplateForm()
        {
            InitializeComponent();

            Tracker trackerInstance = Tracker.GetTracker();
            //Checks if user has selected Edit existing Template

            int firstMenuDecision = trackerInstance.GetFirstMenuSelection();

            if (firstMenuDecision == 1)
            {
                //Gets instance of Generic Template
                templateEdit Templateinstance = templateEdit.GetTemplate();

                //Populates textboxes with contents from instance
                TitleTextBox.Text = Templateinstance.GetTitle();
                HeaderTextBox.Text = Templateinstance.GetHeader();
                FooterTextBox.Text = Templateinstance.GetFooter();
                IDTextBox.Text = Templateinstance.GetID();
            }


        }

        private void SaveHeaderAndFooter_Click(object sender, EventArgs e)
        {
            //Checks for input in textboxes if all != null returns true
            if (ErrorChecker.nullTextboxErrorCheck("Template Title", TitleTextBox.Text) && ErrorChecker.nullTextboxErrorCheck("Header", HeaderTextBox.Text)
                && ErrorChecker.nullTextboxErrorCheck("Footer", FooterTextBox.Text))
            {
                if (!ErrorChecker.GenericTemplateTitleIdenticalCheck(TitleTextBox.Text))
                {
                    this.Hide();

                    //Creates instance of the edit
                    templateEdit templateEditInstance = templateEdit.GetTemplate();

                    //Populates the edit with contents from texboxes
                    templateEditInstance.SetTemplateTitle(TitleTextBox.Text);
                    templateEditInstance.SetHeader(HeaderTextBox.Text);
                    templateEditInstance.SetFooter(FooterTextBox.Text);


                    {
                        //Creates instance Of Generic Template
                        //templateEdit TemplateInstance = templateEdit.SetTemplateInstance();

                        //Displays Message form asking for confirmation
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult textboxInput;
                        textboxInput = MessageBox.Show("Do you want to save this changes into " + templateEditInstance.GetTitle() + "?", "Save Progress", buttons);
                        if (textboxInput == DialogResult.Yes)
                        {
                            //creates instance of DBConnection and calls insertion method
                            DBConnection connectionInstance = DBConnection.getDatabaseConection();
                            connectionInstance.dBEdit();

                            //Deletes GenericTemplate
                            templateEdit.DeleteEditInstance();


                            this.Hide();
                            FirstMenuForm newFirstMenuForm = new FirstMenuForm();
                            newFirstMenuForm.ShowDialog();
                        }
                    }

                }

            }
        }

        private void LoadTemplate_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoadForm newLoadForm = new LoadForm();
            newLoadForm.ShowDialog();
        }

        private void ReturnToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            //creates Preview Form and displays it
            FirstMenuForm newFirstMenuForm = new FirstMenuForm();
            newFirstMenuForm.ShowDialog();
        }

    }
}
