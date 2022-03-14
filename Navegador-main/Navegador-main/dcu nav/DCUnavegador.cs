using EasyTabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;


namespace Mondongo_Browser
{
    public partial class DCUnavegador : Form
    {
        public DCUnavegador()
        {
            InitializeComponent();
            var appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + "exe";
            using (var Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true))
                Key.SetValue(appName, 99999, RegistryValueKind.DWord);

            webBrowser1.Navigate("https://www.google.com.");
        }
        protected TitleBarTabs ParentTabs
        {
            get
            {
                return ParentForm as TitleBarTabs;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack) webBrowser1.GoBack();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward) webBrowser1.GoForward();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/");
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            btnRefresh.Image = imgSpinner.Image;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            btnRefresh.Image = imgRefresh.Image;
            txtSearch.Text = webBrowser1.Url.AbsoluteUri;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && txtSearch.Text.Trim().Length > 0)
            {
                if(txtSearch.Text.Contains("."))
                {
                    webBrowser1.Navigate(txtSearch.Text.Trim());
                }
                else
                {
                    webBrowser1.Navigate("https://www.google.com/search?client=opera&q=" + txtSearch.Text.Trim().Replace(" ", "+") + "&sourceid=opera&ie=UTF-8&oe=UFT-8");
                }
            }
        }
    }
}
