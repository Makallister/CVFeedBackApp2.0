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
        
        private void SaveHeaderAndFooter_MouseClick(object sender, MouseEventArgs e)
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
