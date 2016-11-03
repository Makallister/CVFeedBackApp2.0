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
        //private List<OptionSet> OptionSet1;

        //constructors

        public void GetTemplateTitle(string gotTitle)
        {
            templateTitle = gotTitle;
        }
        public void GetHeader(string gotHeader)
        {
            header = gotHeader;
        }
        public void GetFooter(string gotFooter)
        {
            footer = gotFooter;
        }
        //public void AddOption (OptionSet AddedOption)
        //{

        //}
    }

}