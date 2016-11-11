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
                SetOptionsForm OptionForm1 = new SetOptionsForm();
                OptionForm1.ShowDialog();
            }
            else
            {
                //does nothing
            }

        }

        private void EditPreviousOptions_MouseClick(object sender, MouseEventArgs e)
        {
            //Go to previous
        }
    }
}
