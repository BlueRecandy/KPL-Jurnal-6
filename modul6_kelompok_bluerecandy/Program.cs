using System;

namespace modul6_kelompok_bluerecandy
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataMahasiswa_1302204066 data = new DataMahasiswa_1302204066();
			data.ReadJSON();
			TeamMembers_1302204066 data2 = new TeamMembers_1302204066();
			data2.ReadJSON();
			GlossaryItem_1302204066 data3 = new GlossaryItem_1302204066();
			data3.ReadJSON();
		}
	}
}
