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

    }
}
