using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;
using DI;

namespace DIContainer
{
   
    class StudentDataSoureTest : IStudentDataSoure
    {
        public List<Student> Read()
        {
            return new List<Student>
            {
                new Student() {Id = "001", Name = "testName1", Course = "testCourse1", Age = "18"},
                new Student() {Id = "002", Name = "testName2", Course = "testCourse2", Age = "19"}
            };
        }

    }
}
