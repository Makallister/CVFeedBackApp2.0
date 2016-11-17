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
    public partial class CreateNewTemplateForm : Form
    {
        ErrorChecker ErrorCheck = new ErrorChecker();
        
        
        
        public CreateNewTemplateForm()
        {
            InitializeComponent();

            Tracker trackerInstance = Tracker.GetTracker();
            //Checks if user has selected Edit existing Template

            int firstMenuDecision = trackerInstance.GetFirstMenuSelection();

            if (firstMenuDecision == 1)
            {
                //Gets instance of Generic Template
                GenericTemplate genericTemplateInstance = GenericTemplate.GetGenericTemplate();

                //Populates textboxes with contents from instance
                TitleTextBox.Text = genericTemplateInstance.GetTitle();
                HeaderTextBox.Text = genericTemplateInstance.GetHeader();
                FooterTextBox.Text = genericTemplateInstance.GetFooter(); 
            }
            
            
        }

        private void SaveHeaderAndFooter_MouseClick(object sender, MouseEventArgs e)
        {
            //Checks for input in textboxes if all != null returns true
            if (ErrorChecker.nullTextboxErrorCheck("Template Title", TitleTextBox.Text) && ErrorChecker.nullTextboxErrorCheck("Header", HeaderTextBox.Text) 
                && ErrorChecker.nullTextboxErrorCheck("Footer", FooterTextBox.Text))
            { 
                if (!ErrorChecker.GenericTemplateTitleIdenticalCheck(TitleTextBox.Text))
                {
                    this.Hide();

                    //Creates instance of Generic template
                    GenericTemplate genericTemplateInstance = GenericTemplate.GetGenericTemplate();

                    //Populates genericTemplateInstance with contents from texboxes
                    genericTemplateInstance.SetTemplateTitle(TitleTextBox.Text);
                    genericTemplateInstance.SetHeader(HeaderTextBox.Text);
                    genericTemplateInstance.SetFooter(FooterTextBox.Text);

                    //Sets instance of generic template
                    GenericTemplate.SetGenericTemplateInstance(genericTemplateInstance);


                    //Creates AddOptionset Template and displays it
                    AddOptionSet Optionset1 = new AddOptionSet();
                    Optionset1.ShowDialog();
                }
  
            }

        }

        private void LoadTemplate_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();


            //creates LoadForm and displays it
            LoadForm newLoadForm = new LoadForm();
            newLoadForm.ShowDialog();
        }

        private void PreviewCurrentTemplate_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();

            //creates Preview Form and displays it
            PreviewForm newPreviewForm = new PreviewForm();
            newPreviewForm.ShowDialog();
        }
    }
}
