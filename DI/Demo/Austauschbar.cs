using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;
using DI;

namespace DIContainer
{
   
    class StudentDataSoureNew : IStudentDataSoure
    {
        public List<Student> Read()
        {
            string data = HTTPRequest.SimpleHTTPGetRequest("http://185.248.140.135/students_hss.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
            return (List<Student>)serializer.Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(data)));
        }
    }
}
