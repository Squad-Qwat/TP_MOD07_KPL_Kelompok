using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static tpmod07_kelompok.DataMahasiswa103022300121;
using static tpmod07_kelompok.KuliahMahasiswa103022300121;

namespace tpmod07_kelompok
{
    class KuliahMahasiswa103022300121
    {
        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class CourseList
        {
            public List<Course> courses { get; set; }
        }

        public void ReadJSON(string filePath)
        {
            string json = File.ReadAllText(filePath);
            CourseList data = JsonSerializer.Deserialize<CourseList>(json);

            int i = 1;
            foreach (var course in data.courses)
            {
                Console.WriteLine("MK " + i + " " + course.code + " - " + course.name);
                i++;
            }
        }

    }
}
