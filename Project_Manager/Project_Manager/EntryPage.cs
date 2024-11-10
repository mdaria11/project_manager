using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Manager
{
    public partial class EntryPage : Form
    {
        public EntryPage()
        {
            InitializeComponent();
        }

        private void clickmebutton_Click(object sender, EventArgs e)
        {
            //make button invisible
            clickmebutton.Visible = false;
            //instance of the main page form
            Form main_page = new MainPage();
            //top level is false since we're displayin it through a panel in the entry page form
            main_page.TopLevel = false;
            //fill the whole panel
            main_page.Dock = DockStyle.Fill;
            //we need to add the form in the panel controls
            main_panel.Controls.Add(main_page);
            //giving the main page form's data to the panel 
            main_panel.Tag = main_page;
            //show the form in the panel
            main_page.Show();
        }
    }
}
