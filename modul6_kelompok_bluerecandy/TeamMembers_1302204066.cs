using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul6_kelompok_bluerecandy
{
    internal class TeamMembers_1302204066
    {
        private string GetJsonPath => Path.GetFullPath(Directory.GetCurrentDirectory() + "/../../../jurnal6_2_1302204066.json");
        public void ReadJSON()
        {
            var file = File.OpenText(GetJsonPath);
            JsonElement json = JsonSerializer.Deserialize<JsonElement>(file.ReadToEnd());

            Console.WriteLine("\nTeam member:");
            JsonElement members = json.GetProperty("members");

            foreach (JsonElement member in members.EnumerateArray())
            {
                
                Console.WriteLine($"Name\t: {member.GetProperty("firstName")} {member.GetProperty("lastName")} ");
                Console.WriteLine($"Nim\t: {member.GetProperty("nim")} ");
                Console.WriteLine($"Gender\t: {member.GetProperty("gender")} ");
                Console.WriteLine($"Age\t: {member.GetProperty("age")}\n");
            }
        }
    }
}
