 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFeedbackApp
{
    class OptionSet
    {
        private string OptionSetTitle;
        private List<Option> OptionsInThisSet;

        public void GetOptionSetTitle(string gotOptionSetTitle)
        {
            //sets OptionSetTitle
            gotOptionSetTitle = OptionSetTitle;
        }
        public void AddOptionToSet (Option addedOption)
        {
            //adds new option to set
            OptionsInThisSet.Add(addedOption);
        }
    }
}
