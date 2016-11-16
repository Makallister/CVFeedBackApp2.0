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

        //Holds an int value for the optionSet to identify each member
        private int optionSetTrackingNumber;

        //Holds an int value for the option to identify each member
        private int optionTrackingNumber;

        static private Tracker trackerSingleton;
        

        //Setters


        public void SetMenuSelection (int gotselection)
        {
            gotselection = firstMenuSelection;
        }
        public void SetFromwichForm (string gotFromWhichForm)
        {
            gotFromWhichForm = fromWhichForm;
        }
        public void SetOptionSetTrackingNumber(int gotNumber)
        {
            optionSetTrackingNumber = gotNumber;
        }
        public void SetOptionTrackingNumber(int gotNumber)
        {
            optionTrackingNumber = gotNumber;
        }
        static public void SetTracker (Tracker gotTracker)
        {
            trackerSingleton = gotTracker;
        }



        //Getters


        public int GetFirstMenuSelection()
        {
            return trackerSingleton.firstMenuSelection;
        }
        public string GetFromWhichForm()
        {
            return trackerSingleton.fromWhichForm;
        }
        public int GetOptionSetCounter()
        {

            return trackerSingleton.optionSetTrackingNumber;
        }
        public int GetOptionCounter()
        {
            return trackerSingleton.optionTrackingNumber;
        }
        public static Tracker GetTracker()
        {
            if (trackerSingleton == null)
            {
                Tracker trackerinit = new Tracker();
                trackerSingleton = trackerinit;
                return trackerSingleton;
            }
            else
            {
                return trackerSingleton;
            }
        }

        //Methods


    }
}
