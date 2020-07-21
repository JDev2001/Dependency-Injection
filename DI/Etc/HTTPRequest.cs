using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DI
{
    static class HTTPRequest
    {
        public static string SimpleHTTPGetRequest(string url)
        {
            return File.OpenText(@"C:\Users\jonas\source\repos\DI\DI\Students.json").ReadToEnd(); 
        }
    }
}
