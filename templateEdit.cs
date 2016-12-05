using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFeedbackApp
{
    class templateEdit
    {
        //atributes
        private string templateTitle;
        private string header;
        private string footer;
        private string templateID;
        private int useID;
        private static templateEdit templateToEdit;
        private List<OptionSet> OptionSetList;

        //constructors



        /// <summary>
        /// Set the Instance of template to edit
        /// </summary>
        /// <param name="gotTemplateInstance"></param>
        public static void SetTemplateInstance(templateEdit gotTemplateInstance)
        {
            templateToEdit = gotTemplateInstance;
        }
        /// <summary>
        /// Sets the new Template Title into the relevant attribute
        /// </summary>
        /// <param name="gotTitle"></param>
        public void SetTemplateTitle(string gotTitle)
        {

            templateTitle = gotTitle;

        }



        /// <summary>
        /// Sets the Template Header into the relevant attribute
        /// </summary>
        /// <param name="gotHeader"></param>
        public void SetHeader(string gotHeader)
        {
            header = gotHeader;
        }



        /// <summary>
        /// Sets the Template Footer the relevant attribute
        /// </summary>
        /// <param name="gotFooter"></param>
        public void SetFooter(string gotFooter)
        {
            footer = gotFooter;
        }

        /// <summary>
        /// Sets the Template ID the relevant attribute
        /// </summary>
        /// <param name="gotID"></param>
        public void SetID(string gotID)
        {
            templateID = gotID;
        }

        /// <summary>
        /// Returns templateToEdit, if it does not exist then it creates it.
        /// </summary>
        /// <returns>templateToEdit</returns>
        public static templateEdit GetTemplate()
        {
            if (templateToEdit == null)
            {

                templateEdit createdtemplateToEdit = new templateEdit();
                templateToEdit = createdtemplateToEdit;
                return templateToEdit;

            }
            else
            {
                return templateToEdit;
            }
        }



        /// <summary>
        /// Adds optionSet Object
        /// </summary>
        /// <param name="addedOption"></param>
        public void AddOptionSet(OptionSet addedOption)
        {
            OptionSetList.Add(addedOption);
        }



        /// <summary>
        /// Returns templateToEdit.templateTitle
        /// </summary>
        /// <returns>templateToEdit.templateTitle</returns>
        public string GetTitle()
        {
            return templateToEdit.templateTitle;
        }



        /// <summary>
        /// Returns templateToEdit.header
        /// </summary>
        /// <returns>templateToEdit.header</returns>
        public string GetHeader()
        {
            return templateToEdit.header;
        }



        /// <summary>
        /// Returns templateToEdit.footer
        /// </summary>
        /// <returns>templateToEdit.footer</returns>
        public string GetFooter()
        {
            return templateToEdit.footer;
        }

        /// <summary>
        /// Returns templateToEdit.ID
        /// </summary>
        /// <returns>templateToEdit.ID</returns>
        public string GetID()
        {
            return templateToEdit.templateID;
        }


        /// <summary>
        /// Returns the relevant template from templateToEdit.OptionSetList
        /// </summary>
        /// <returns>templateToEdit.OptionSetList[i];</returns>
        public OptionSet GetAllOptions()
        {
            useID = Convert.ToInt32(templateID);
            for (useID = OptionSetList.Count; ;) 
                return templateToEdit.OptionSetList[useID];
        }

        public List<OptionSet> GetOptionSetList()
        {
            return OptionSetList;
        }

        /// <summary>
        /// Deletes the edit
        /// </summary>
        public static void DeleteEditInstance()
        {
            templateToEdit = null;
        }


    }

}
