using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul6_kelompok_bluerecandy
{
    internal class DataMahasiswa_1302204066
    {
        private string GetJsonPath => Path.GetFullPath(Directory.GetCurrentDirectory() + "/../../../jurnal6_1_1302204066.json");
        public void ReadJSON()
        {
            var jsonFile = File.OpenText(GetJsonPath);
            Dictionary<string, dynamic> json = JsonSerializer.Deserialize
                <Dictionary<string, dynamic>>(jsonFile.ReadToEnd(), new JsonSerializerOptions()
                {
                    WriteIndented = true,
                });
            Console.WriteLine($"Name\t: {json["firstName"]} {json["lastName"]}");
            Console.WriteLine($"Gender\t: {json["gender"]}");
            Console.WriteLine($"Age\t: {json["age"]}");
            JsonElement address = json["address"];
            Console.WriteLine($"Address\t: " +
                $"{address.GetProperty("streetAddress")}, {address.GetProperty("city")}, {address.GetProperty("state")}");
            Console.WriteLine("Courses\t: ");
            JsonElement courses = json["courses"];
            int count = 1;
            foreach (var item in courses.EnumerateArray())
            {
                JsonElement course = item;
                Console.WriteLine($".\tKode: {course.GetProperty("code")}");
                Console.WriteLine($"\tMata Kuliah: {course.GetProperty("name")}");
                count++;
            }
        }
    }
}
