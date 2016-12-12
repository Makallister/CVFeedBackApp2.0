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
    public partial class FirstMenuForm : Form
    {
        //int to register user decision to be send to trackker
        //0 = CreateNewTemplate
        //1 = EditExisitingTemplate
        //2 = Make Reply
        int selectionDecision;
        public FirstMenuForm()
        {
            InitializeComponent();
             
        }
        //Initializes and displays the form to create a new Template
        private void NewTemplateButton_MouseClick(object sender, MouseEventArgs e)
        {
            //Creates/Gets Tracker instance
            Tracker trackerInstance = Tracker.GetTracker();

            //Set decision and return tracker
            selectionDecision = 0;
            trackerInstance.SetMenuSelection(selectionDecision);
            Tracker.SetTracker(trackerInstance);

            //Creates and displays new form
            this.Hide();
            CreateNewTemplateForm NewCreateNewTemplateForm = new CreateNewTemplateForm();
            NewCreateNewTemplateForm.ShowDialog();
            
        }
        //Initializes and displays the form to Edit a new Template
        private void EditButton_MouseClick(object sender, MouseEventArgs e)
        {
            //Creates/Gets Tracker instance
            Tracker trackerInstance = Tracker.GetTracker();

            //Set decision and return tracker
            selectionDecision = 1;
            trackerInstance.SetMenuSelection(selectionDecision);
            Tracker.SetTracker(trackerInstance);

            //Creates and displays new form
            this.Hide();
            EditTemplateForm newEditTemplateForm = new EditTemplateForm();
            newEditTemplateForm.ShowDialog();
        }
        //Initializes and displays the form for making replies
        private void MakeReplyButton_MouseClick(object sender, MouseEventArgs e)
        {
            //Creates/Gets Tracker instance
            Tracker trackerInstance = Tracker.GetTracker();

            //Set decision and return tracker
            selectionDecision = 2;
            trackerInstance.SetMenuSelection(selectionDecision);
            Tracker.SetTracker(trackerInstance);

            //Creates and displays new form
            this.Hide();
            ReplyForm NewReplyForm = new ReplyForm();
            NewReplyForm.ShowDialog();
        }

        private void DBButton1_Click(object sender, EventArgs e)
        {
            //Creates and displays new form
            this.Hide();
            DBForm NewDBForm = new DBForm();
            NewDBForm.ShowDialog();
        }
    }
}
