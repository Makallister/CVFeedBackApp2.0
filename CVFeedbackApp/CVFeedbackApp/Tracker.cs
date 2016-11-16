using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFeedbackApp
{
    class Tracker
    {
        //atributes

        //int to diferentiate if user has selected (Create New Template) or (Edit Existing Template)
        // 0 is CreateNewTemplate, 1 is Edit new Template, 2 is Make reply
        private int firstMenuSelection;

        //String holding from which form user is coming from
        private string fromWhichForm;

        static private Tracker trackersingleton;
        

        //Setters


        public void SetMenuSelection (int gotselection)
        {
            gotselection = firstMenuSelection;
        }
        public void SetFromwichForm (string gotFromWhichForm)
        {
            gotFromWhichForm = fromWhichForm;
        }
        public void SetTracker (Tracker gotTracker)
        {
            gotTracker = trackersingleton;
        }



        //Getters


        public int GetFirstMenuSelection()
        {
            return firstMenuSelection;
        }
        public string GetFromWhichForm()
        {
            return fromWhichForm;
        }
        public static Tracker GetTracker()
        {
            if (trackersingleton == null)
            {
                Tracker trackerinit = new Tracker();
                trackersingleton = trackerinit;
                return trackersingleton;
            }
            else
            {
                return trackersingleton;
            }
        }

    }
}
