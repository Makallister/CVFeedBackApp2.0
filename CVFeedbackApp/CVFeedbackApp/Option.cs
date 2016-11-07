using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFeedbackApp
{
    class Option
    {
        private string optionTitle;
        private string optionMessage;
        private static Option newOption;

        /// <summary>
        /// Sets Option Title
        /// </summary>
        /// <param name="gotTitle"></param>
        public void SetOptionTitle(string gotTitle)
        {

            optionTitle = gotTitle;
        }

        /// <summary>
        /// Sets the message for the option
        /// </summary>
        /// <param name="gotMessage"></param>
        public void SetOptionMessage (string gotMessage)
        {
            optionMessage = gotMessage;
            
        }


        /// <summary>
        /// Sets Instance of Object
        /// </summary>
        /// <param name="gotOption"></param>
        static public void SetOption (Option gotOption)
        {
            newOption = gotOption;
        }

        /// <summary>
        /// Returns newOption, if it dosen't exist creates it
        /// </summary>
        /// <returns>newOption</returns>
        public static Option GetOption()
        {
            if (newOption == null)
            {
                Option createdOption = new CVFeedbackApp.Option();
                newOption = createdOption;
                return newOption;
            }
            else
            {
                return newOption;
            }
        }

        /// <summary>
        /// Returns string optiontitle
        /// </summary>
        /// <returns>optionTitle</returns>
        public string GetTitle()
        {
            return optionTitle;
        }
        /// <summary>
        /// returns string getmessage
        /// </summary>
        /// <returns>optionMessage</returns>
        public string GetMessage()
        {
            return optionMessage;
        }

        /// <summary>
        /// Sets newOption to null, so diferent instances can be created afterwards
        /// </summary>
        static public void DeleteOptionInstance()
        {
            newOption = null;
        }

    }
}
