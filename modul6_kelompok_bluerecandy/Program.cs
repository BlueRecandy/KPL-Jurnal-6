using System;

namespace modul6_kelompok_bluerecandy
{
	internal class Program
	{
		static void Main(string[] args)
		{

			static void Main(string[] args)
			{
				DataMahasiswa1302204069 d = new DataMahasiswa1302204069();
				d.ReadJSON();

				TeamMembers1302204069 t = new TeamMembers1302204069();
				t.ReadJSON();

				GlossaryItem1302204069 g = new GlossaryItem1302204069();
				g.ReadJSON();
			}
		}
	}
}
