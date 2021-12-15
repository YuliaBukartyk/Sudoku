using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace SudokuClient.Utils
{
    class Utils
    {
        public static string SendHttpGetRequest(string url)
        {

            string responseText = "";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            using (WebResponse response = httpWebRequest.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    responseText = (new StreamReader(stream)).ReadToEnd();

                }
            }
            return responseText;
        }
    }
}
