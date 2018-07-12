using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace URLopener
{
    class URLmanager
    {
        public void addComboboxValues(System.Windows.Forms.ComboBox comboBox)
        {
            comboBox.Items.Add("GoogleChrome");
            //comboBox1.Items.Add("Opera");
            comboBox.Items.Add("InternetExplorer");
            comboBox.SelectedIndex = 0;
        }

        public void openURL(List<String> URLs, String browser)
        {
            foreach (String URL in URLs)
            {
                openURL(URL, browser);
            }
        }

        private void openURL(String URL, String browser)
        {
            switch (browser)
            {
                case "GoogleChrome":
                    Process.Start("chrome.exe", URL);
                    break;
                /*case "Opera":
                    Process.Start("opera.exe", URL);
                    break;*/
                default:
                    Process.Start(URL);
                    break;
            }
        }

        public void screenURL(List<String> URLs)
        {
            if (URLs.Count == 0)
            {
                return;
            }
            DateTime localDate = DateTime.Now;
            String date = localDate.ToString();
            String path = Regex.Replace(date, "[-.?!)(,:]", "");
            DirectoryInfo di = Directory.CreateDirectory(path);

            String imgPath = "";
            foreach (String URL in URLs)
            {
                List<String> parseUrl = new List<String>(URL.Split(' '));
                parseUrl.Remove("");
                // Load the webpage into a WebBrowser control
                WebBrowser wb = new WebBrowser();
                wb.ScrollBarsEnabled = false;
                wb.ScriptErrorsSuppressed = true;
                wb.Navigate(parseUrl[1]);
                while (wb.ReadyState != WebBrowserReadyState.Complete) { Application.DoEvents(); }
                // Take Screenshot of the web pages full width
                wb.Width = wb.Document.Body.ScrollRectangle.Width;
                wb.Height = wb.Document.Body.ScrollRectangle.Height;

                // Get a Bitmap representation of the webpage as it's rendered in the WebBrowser control
                Bitmap bitmap = new Bitmap(wb.Width, wb.Height);
                wb.DrawToBitmap(bitmap, new Rectangle(0, 0, wb.Width, wb.Height));
                wb.Dispose();
                imgPath = path + "/" + parseUrl[0] + ".jpg";
                bitmap.Save(imgPath); ;
            }
            
        }       


    }
}
