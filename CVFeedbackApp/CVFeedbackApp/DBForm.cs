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
    public partial class DBForm : Form
    {
        public DBForm()
        {
            InitializeComponent();
        }

        private void DBForm_Load(object sender, EventArgs e)
        {
            //load the data from the DB into the grid view
            updateGridView();

        }

        private void updateGridView()
        {
            // populate the GridView
            DataSet dsGenTemp = DBConnection.getDatabaseConection().getDataSet(Constants.SelectAll);
            //get the only table in the dataset person
            DataTable table = dsGenTemp.Tables[0];

            //set up the data grid view
            DBdgv.DataSource = table;


        }

        
    }
}
