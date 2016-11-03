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

        public void GetOptionTitle(string gotTitle)
        {
            //gets option title
            gotTitle = optionTitle;
        }
        public void GetOptionMessage (string gotMessage)
        {
            gotMessage = optionMessage;
            //gets option message
        }

    }
}
