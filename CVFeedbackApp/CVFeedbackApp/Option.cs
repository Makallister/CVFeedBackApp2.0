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
            
            gotTitle = optionTitle;
        }

        /// <summary>
        /// Sets the message for the option
        /// </summary>
        /// <param name="gotMessage"></param>
        public void SetOptionMessage (string gotMessage)
        {
            gotMessage = optionMessage;
            
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
                createdOption = newOption;
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

    }
}
