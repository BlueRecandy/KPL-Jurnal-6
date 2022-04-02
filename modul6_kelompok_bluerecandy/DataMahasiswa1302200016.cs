using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul6_kelompok_bluerecandy
{
    internal class DataMahasiswa1302200016
    {
		private string GetJsonPath => Path.GetFullPath(Directory.GetCurrentDirectory() + "/../../../jurnal6_1_1302200016.json");

		public void ReadJSON()
		{

			var file = File.OpenText(GetJsonPath);

			Dictionary<string, dynamic> json = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(file.ReadToEnd(), new JsonSerializerOptions()
			{
				WriteIndented = true,
			});

			Console.WriteLine($"Nama: {json["firstName"]} {json["lastName"]}");
			Console.WriteLine($"Jenis Kelamin: {json["gender"]}");
			Console.WriteLine($"Umur: {json["age"]}");


			JsonElement address = json["address"];
			Console.WriteLine($"Alamat: {address.GetProperty("streetAddress")}, {address.GetProperty("state")}, {address.GetProperty("city")}");

			Console.WriteLine("Courses: ");
			JsonElement courses = json["courses"];

			int count = 1;
			foreach (var item in courses.EnumerateArray())
			{
				JsonElement course = item;

				Console.WriteLine($"{count}.\tKode Matkul: {course.GetProperty("code")}");
				Console.WriteLine($"\tNama Matkul: {course.GetProperty("name")}");
				count++;
			}
		}
	}
}
