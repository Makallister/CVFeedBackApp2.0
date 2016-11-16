using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVFeedbackApp
{
    
    class ErrorChecker
    {
        static private string errorCaption = "Error detected";
        static public bool nullTextboxErrorCheck (string textboxName , string textboxContent)
        {
            if (textboxContent == "")
            {
                string message = "You did not enter any text in " + textboxName;
                string caption = errorCaption;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

                return false;
            }
            else
            {
                return true;
            }
        }
        static public bool GenericTemplateTitleIdenticalCheck (string userNewGTTitle)
        {
            //Gets DBConnection Instance
            DBConnection connectionInstance = DBConnection.getDatabaseConection();

            //Creates List and sets populates it with database
            List<string> allTheGTTitles = connectionInstance.LoadAllGTTiles();

            //Creates bool to return test result
            bool identicalNames = false;
            do
            {
                for (int i = 0; i < allTheGTTitles.Count; i++)
                {
                    if (allTheGTTitles[i] == userNewGTTitle)
                    {
                        identicalNames = true;
                    }
                    else
                    {
                        identicalNames = false;
                    }
                } 
            } while (identicalNames == false);

            if (identicalNames == true)
            {
                string message = userNewGTTitle + " is already taken as a title, please type another title or go to edit template on main menu";
                string caption = errorCaption;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);
            }

            return identicalNames;
        }
    }
}
