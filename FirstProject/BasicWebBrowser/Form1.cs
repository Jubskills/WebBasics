using System;  
using System.Collections.Generic;  
using System.ComponentModel;  
using System.Data;  
using System.Drawing;  
using System.Linq;  
using System.Text;  
using System.Windows.Forms;  
namespace BasicWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("www.google.com");
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
            else
            {
                MessageBox.Show("You cannot go back");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //TabPage tabpage = new TabPage();
            //tabpage.Text = "New File";
            //tabControl1.Controls.Add(tabpage);
            //WebBrowser webbrowser = new WebBrowser();
            ////tabControl1.Parent = tabpage;
            //tabControl1.Dock = DockStyle.Fill;
            //webbrowser.Navigate("www.google.com");
        }
    }
}