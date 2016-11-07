 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFeedbackApp
{
    class OptionSet
    {
        //Atributes of optionSet
        private string optionSetTitle;
        private List<Option> optionsInThisSet;
        static private OptionSet newOptionSet;


        //Constructors

        
        /// <summary>
        /// Sets instance of newOptionSet
        /// </summary>
        /// <param name="gotOptionSet"></param>
        static public void SetNewOptionSet (OptionSet gotOptionSet)
        {
             newOptionSet = gotOptionSet;
        }
        
        
        
        /// <summary>
        /// Sets the Optionset Title
        /// </summary>
        /// <param name="gotOptionSetTitle"></param>
        public void SetOptionSetTitle(string gotOptionSetTitle)
        {

            optionSetTitle = gotOptionSetTitle;
        }

        /// <summary>
        /// Adds option to set
        /// </summary>
        /// <param name="addedOption"></param>
        public void AddOptionToSet (Option addedOption)
        {
            
            optionsInThisSet.Add(addedOption);
        }

        /// <summary>
        /// Gets newOptionSet, if null creates new one
        /// Singleton pattern
        /// </summary>
        /// <returns>newOptionSet</returns>
        public static OptionSet GetOptionSet()
        {
            if(newOptionSet == null)
            {
                OptionSet createdOptionSet = new OptionSet();
                newOptionSet = createdOptionSet;
                newOptionSet.optionsInThisSet = new List<Option>();
                return newOptionSet;
            }
            else
            {
                return newOptionSet;
            }
        }

        /// <summary>
        /// Gets title of optionset
        /// </summary>
        /// <returns>newOptionSet.optionSetTitle</returns>
        public string GetOptionSetTitle()
        {
            return newOptionSet.optionSetTitle;
        }

        /// <summary>
        /// Gets all Options in Option Set
        /// </summary>
        /// <returns>newOptionSet.optionsInThisSet[i]</returns>
        public Option GetOptionList()
        {
            for (int i = 0; i <= optionsInThisSet.Count; i++)
                return newOptionSet.optionsInThisSet[i];
            return null;
        }


        /// <summary>
        /// Sets newOptionSet to null, so diferent instances can be created afterwards
        /// </summary>
        static public void DeleteOptionSet()
        {
            newOptionSet = null;
        }
    }
}
