using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows;

namespace SudokuClient.Utils
{
    public class Utils
    {
        public static string SendHttpGetRequest(string url)
        {

            string responseText = "";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            try 
            {
                using (WebResponse response = httpWebRequest.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        responseText = (new StreamReader(stream)).ReadToEnd();

                    }
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show(Application.Current.MainWindow, "Temporery server error, please try to reopen the game", "Server error", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.Cancel);
            }
            return responseText;
        }
    }
}
