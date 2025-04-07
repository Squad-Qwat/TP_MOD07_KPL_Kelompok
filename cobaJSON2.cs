using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace cobaJSON2
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

    public class KuliahMahasiswa_103022300082
    {

        public static void ReadJSON(string fileName)
        {
            try
            {
                string jsonString = File.ReadAllText(fileName);
                CourseList kuliahMahasiswa = JsonSerializer.Deserialize<CourseList>(jsonString)!;

                Console.WriteLine("Daftar mata kuliah yang diambil:");
                for (int i = 0; i < kuliahMahasiswa.courses.Count; i++)
                {
                    Console.WriteLine($"MK {i + 1} {kuliahMahasiswa.courses[i].code} - {kuliahMahasiswa.courses[i].name}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}