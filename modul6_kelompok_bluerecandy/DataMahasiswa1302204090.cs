using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul6_kelompok_bluerecandy
{
	internal class DataMahasiswa1302204090
	{

		private string GetJsonPath => Path.GetFullPath(Directory.GetCurrentDirectory() + "/../../../jurnal6_1_1302204090.json");

		public void ReadJSON()
		{

			var file = File.OpenText(GetJsonPath);

			Dictionary<string, dynamic> json = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(file.ReadToEnd(), new JsonSerializerOptions()
			{
				WriteIndented = true,
			});

			Console.WriteLine($"Name: {json["firstName"]} {json["lastName"]}");
			Console.WriteLine($"Gender: {json["gender"]}");
			Console.WriteLine($"Age: {json["age"]}");


			JsonElement address = json["address"];
			Console.WriteLine($"Address: {address.GetProperty("state")}, {address.GetProperty("city")}, {address.GetProperty("streetAddress")}");
			
			Console.WriteLine("Courses: ");
			JsonElement courses = json["courses"];

			int count = 1;
			foreach (var item in courses.EnumerateArray())
			{
				JsonElement course = item;

				Console.WriteLine($"{count}.\tKode: {course.GetProperty("code")}");
				Console.WriteLine($"\tMata Kuliah: {course.GetProperty("name")}");
				count++;
			}

		}

	}
}
