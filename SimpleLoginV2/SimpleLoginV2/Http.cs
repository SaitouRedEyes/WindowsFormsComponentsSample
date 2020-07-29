﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLoginV2
{
    class Http
    {
        private static Http instance;

        public enum Services
        {
            LOGIN = 1
        }

        private Http()
        { }

        public static Http GetInstance
        {
            get
            {
                if (instance == null) instance = new Http();

                return instance;
            }
        }

        public string SendToServer(Dictionary<string, string> parameters)
        {
            string outputData = "";

            try
            {
                // Create a new HttpWebRequest object.
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost/php_mysql_samples/4oBi_ex2_requests_login.php");
                myHttpWebRequest.Method = "POST";
                myHttpWebRequest.KeepAlive = false;
                myHttpWebRequest.ContentType = "application/x-www-form-urlencoded";

                //building the parameters string.
                StringBuilder builder = new StringBuilder();

                foreach (KeyValuePair<string, string> kvp in parameters)
                {
                    builder.Append(kvp.Key + "=" + kvp.Value + "&");
                }

                byte[] bytes = Encoding.ASCII.GetBytes(builder.ToString());

                myHttpWebRequest.ContentLength = bytes.Length;

                Stream os = myHttpWebRequest.GetRequestStream();
                os.Write(bytes, 0, bytes.Length);
                os.Close();

                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

                if (myHttpWebResponse != null)
                {
                    Stream streamResponse = myHttpWebResponse.GetResponseStream();
                    StreamReader streamRead = new StreamReader(streamResponse, Encoding.Default);

                    outputData = streamRead.ReadToEnd();

                    streamResponse.Close();
                    streamRead.Close();
                    myHttpWebResponse.Close();
                }

                return outputData.Trim();
            }
            catch (Exception e)
            {
                Console.WriteLine("Source :{0} ", e.Source);
                Console.WriteLine("Message :{0} ", e.Message);
                return "";
            }
        }
    }
}
