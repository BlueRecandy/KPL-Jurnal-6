using System;

namespace modul6_kelompok_bluerecandy
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataMahasiswa1302204090 d = new DataMahasiswa1302204090();
			d.ReadJSON();
			
			TeamMembers1302204090 t = new TeamMembers1302204090();
			t.ReadJSON(); 

			GlossaryItem1302204090 g = new GlossaryItem1302204090();
			g.ReadJSON();
		}
	}
}
