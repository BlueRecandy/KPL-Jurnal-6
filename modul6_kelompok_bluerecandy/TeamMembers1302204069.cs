using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul6_kelompok_bluerecandy
{
    internal class TeamMembers1302204069
    {

		private string GetJsonPath => Path.GetFullPath(Directory.GetCurrentDirectory() + "/../../../jurnal6_2_1302204069.json");

		public void ReadJSON()
		{
			var file = File.OpenText(GetJsonPath);
			JsonElement json = JsonSerializer.Deserialize<JsonElement>(file.ReadToEnd());

			Console.WriteLine("Team member list:");
			JsonElement members = json.GetProperty("members");

			foreach (JsonElement member in members.EnumerateArray())
			{
				Console.WriteLine($"{member.GetProperty("nim")} {member.GetProperty("firstName")} {member.GetProperty("lastName")} ({member.GetProperty("age")}, {member.GetProperty("gender")})");
			}

		}

	}
}
