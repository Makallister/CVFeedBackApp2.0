using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFeedbackApp
{
    class GenericTemplate
    {
        //atributes
        private string templateTitle;
        private string header;
        private string footer;
        private static GenericTemplate newGenericTemplate;
        private List<OptionSet> OptionSetList;

        //constructors

            /// <summary>
            /// Sets the Template Title into newGenericTemplate
            /// </summary>
            /// <param name="gotTitle"></param>
        public void SetTemplateTitle(string gotTitle)
        {
            gotTitle = templateTitle;
        }



        /// <summary>
        /// Sets the Template Header into newGenericTemplate
        /// </summary>
        /// <param name="gotHeader"></param>
        public void SetHeader(string gotHeader)
        {
            gotHeader = header;
        }
        
        
        
        /// <summary>
        /// Sets the Template Footer into newGenericTemplate
        /// </summary>
        /// <param name="gotFooter"></param>
        public void SetFooter(string gotFooter)
        {
            gotFooter = footer;
        }

        
        
        /// <summary>
        /// Returns newGenericTemplate, if not existen creates it.
        /// </summary>
        /// <returns>newGenericTemplate</returns>
        public static GenericTemplate GetGenericTemplate()
        {
            if(newGenericTemplate == null)
            {
                GenericTemplate createdNewGenericTemplate = new GenericTemplate();
                createdNewGenericTemplate = newGenericTemplate;
                return newGenericTemplate;
                    
            }
            else
            {
                return newGenericTemplate;
            }
        }

        
        
        /// <summary>
        /// Adds optionSet Object
        /// </summary>
        /// <param name="addedOption"></param>
        public void AddOption (OptionSet addedOption)
        {
            OptionSetList.Add(addedOption);
        }
        
        
        
        /// <summary>
        /// Returns newGenericTemplate.templateTitle
        /// </summary>
        /// <returns>newGenericTemplate.templateTitle</returns>
        public string GetTitle()
        {
            return newGenericTemplate.templateTitle;
        }

        
        
        /// <summary>
        /// Returns newGenericTemplate.header
        /// </summary>
        /// <returns>newGenericTemplate.header</returns>
        public string GetHeader()
        {
            return newGenericTemplate.header;
        }

        
        
        /// <summary>
        /// Returns newGenericTemplate.footer
        /// </summary>
        /// <returns>newGenericTemplate.footer</returns>
        public string GetFooter()
        {
            return newGenericTemplate.footer;
        }
        
        
        
        /// <summary>
        /// Returns all OptionSets from newGenericTemplate.OptionSetList
        /// </summary>
        /// <returns>newGenericTemplate.OptionSetList[i];</returns>
        public OptionSet GetAllOptions()
        {
            for (int i = 0; i <= OptionSetList.Count; i++)
                return newGenericTemplate.OptionSetList[i];
            return null;          
        }

   
    }

}