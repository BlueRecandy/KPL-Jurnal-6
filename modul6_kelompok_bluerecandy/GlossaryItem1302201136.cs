using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul6_kelompok_bluerecandy
{
	internal class GlossaryItem1302201136
	{
		private string GetJsonPath => Path.GetFullPath(Directory.GetCurrentDirectory() + "/../../../jurnal6_3_1302201136.json");


		public void ReadJSON()
		{
			var file = File.OpenText(GetJsonPath);
			JsonElement json = JsonSerializer.Deserialize<JsonElement>(file.ReadToEnd());

			JsonElement entry = json.GetProperty("glossary").GetProperty("GlossDiv").GetProperty("GlossList").GetProperty("GlossEntry");

			Console.WriteLine($"{entry.GetProperty("ID")} - {entry.GetProperty("SortAs")}");
			Console.WriteLine($"{entry.GetProperty("GlossTerm")}");
			Console.WriteLine($"{entry.GetProperty("Acronym")} - {entry.GetProperty("Abbrev")}");

			Console.WriteLine(" ");
			JsonElement glossDef = entry.GetProperty("GlossDef");
			Console.WriteLine("Gloss Def: ");
			Console.WriteLine($"{glossDef.GetProperty("para")}");
			foreach (var item in glossDef.GetProperty("GlossSeeAlso").EnumerateArray())
			{
				Console.WriteLine($"{item}");
			}
			Console.WriteLine(" ");

			Console.WriteLine(entry.GetProperty("GlossSee"));
		}
	}
}
