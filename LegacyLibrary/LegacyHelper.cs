using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LegacyLibrary
{
    public class LegacyHelper
    {
        public string GetApiData(string url)
        {
            try
            {
                // Create a WebRequest to the specified URL
                WebRequest request = WebRequest.Create(url);

                // Get the response from the request
                using (WebResponse response = request.GetResponse())
                {
                    // Read the response stream
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(dataStream))
                        {
                            // Read the response content and return it as a string
                            return reader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
                return null;
            }
        }
    }
}
