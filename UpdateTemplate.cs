using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFeedbackApp
{
    class UpdateTemplate
    {
        //Useful attributes
        private string templateID;
        private string templateTitle;
        private string header;
        private string footer;
        private static EditTemplateForm TemplateUpdate;

        //Record the edited values to be updated
        //ID
        public void SetID(string gotID)
        {
            templateID = gotID;
        }


        //Title
        public void SetTitle(string gotTitle)
        {
            templateTitle = gotTitle;
        }

        //Header
        public void SetHeader(string gotHeader)
        {
            header = gotHeader;
        }

        //Footer
        public void SetFooter(string gotFooter)
        {
            footer = gotFooter;
        }

        //Update the database
        string sql = UpdateQuery;

        //Clear the values of the update         
        public static void DeleteTemplateUpdate()
        {
            TemplateUpdate = null;
        }
    }
}
