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
        public CreateNewTemplateForm()
        {
            InitializeComponent();
        }

        //TODO Change error handling so that it stops the user until they correct the error
        // instead of just warning them
        //private bool IsTextempty()
        //{
        //    if (string.IsNullOrEmpty(title))
        //        return true;
        
        private void SaveHeaderAndFooter_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            //Creates a new generic tempate
            GenericTemplate newGenericTemplate = new GenericTemplate();

            //Temporary storing strings set by textboxes
            string title = TitleTextBox.Text;
            string header = HeaderTextBox.Text;
            string footer = FooterTextBox.Text;
            
            //Exception Handling for "get" methods
            if (string.IsNullOrEmpty(title))
            {
                //TODO code for handling here
                ErrorForm errorForm = new CVFeedbackApp.ErrorForm();
                errorForm.Show();
            }

            if (string.IsNullOrEmpty(header))
            {
                //TODO code for handling here
                ErrorForm errorForm = new CVFeedbackApp.ErrorForm();
                errorForm.Show();
            }

            if (string.IsNullOrEmpty(footer))
            {
                //TODO code for handling here
                ErrorForm errorForm = new CVFeedbackApp.ErrorForm();
                errorForm.Show();
            }


            //Using contructors from Generic template to store user input;
            newGenericTemplate.GetTemplateTitle(title);
            newGenericTemplate.GetHeader(header);
            newGenericTemplate.GetFooter(footer);


            //Creates AddOptionset Template and displays it
            AddOptionSet Optionset1 = new AddOptionSet();
            Optionset1.ShowDialog();

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
