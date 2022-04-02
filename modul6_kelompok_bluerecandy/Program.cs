using System;

namespace modul6_kelompok_bluerecandy
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataMahasiswa1302200016 dataMahasiswa = new DataMahasiswa1302200016();
			dataMahasiswa.ReadJSON();

			TeamMembers1302200016 teamMembers = new TeamMembers1302200016();
			teamMembers.ReadJSON();

			GlossaryItem1302200016 glossaryItem = new GlossaryItem1302200016();
			glossaryItem.ReadJSON();
		}
	}
}
