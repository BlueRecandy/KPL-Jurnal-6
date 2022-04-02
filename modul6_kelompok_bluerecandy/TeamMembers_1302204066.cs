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
            var jsonFile = File.OpenText(GetJsonPath);
            var json = JsonSerializer.Deserialize<IEnumerable<Dictionary<string, dynamic>>>(jsonFile.ReadToEnd(), new JsonSerializerOptions()
            {
                WriteIndented = true,
            });

            int count = 1;
            Console.WriteLine("Daftar mata kuliah yang diambil:");
            foreach (var mk in json)
            {
                Console.WriteLine($"MK{count} {mk["kode_mk"]} - {mk["nama_mk"]}");
                count++;
            }
        }
    }
}
