using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmod07_kelompok.services
{
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class CourseList { 
        public List<Course> courses { get; set; }
    }

    public class KuliahMahasiswa_103022300144
    {
        public async Task ReadJson()
        {
            string fileName = "tp7_2_103022300144.json";
            using FileStream stream = File.OpenRead(fileName);

            CourseList? courseList = await JsonSerializer.DeserializeAsync<CourseList>(stream);
            Console.WriteLine("Daftar mata kuliah yang diambil:");
            
            if (courseList?.courses != null)
            {
                for (int i = 0; i < courseList?.courses.Count; i++)
                {
                    Console.WriteLine($"MK {i + 1} {courseList?.courses[i].code} - {courseList?.courses[i].name}");
                }
            }
        }
    }
}
