using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser_Project_8
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void cboLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {

                webBrowser1.Navigate(cboLocation.Text);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void BtnFwd_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cboLocation.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = "bluelime - " + webBrowser1.Document.Title;
        }
    }
}
