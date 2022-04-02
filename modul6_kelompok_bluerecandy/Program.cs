using System;

namespace modul6_kelompok_bluerecandy
{
	internal class Program
	{
		static void Main(string[] args)
		{

      DataMahasiswa1302204069 dm = new DataMahasiswa1302204069();
      dm.ReadJSON();

      TeamMembers1302204069 tm = new TeamMembers1302204069();
      tm.ReadJSON();

      GlossaryItem1302204069 gi = new GlossaryItem1302204069();
      gi.ReadJSON();

			DataMahasiswa_1302204066 data = new DataMahasiswa_1302204066();
			data.ReadJSON();
			TeamMembers_1302204066 data2 = new TeamMembers_1302204066();
			data2.ReadJSON();
			GlossaryItem_1302204066 data3 = new GlossaryItem_1302204066();
			data3.ReadJSON();

			DataMahasiswa1302204090 d = new DataMahasiswa1302204090();
			d.ReadJSON();
			
			TeamMembers1302204090 t = new TeamMembers1302204090();
			t.ReadJSON(); 

			GlossaryItem1302204090 g = new GlossaryItem1302204090();
			g.ReadJSON();
      
		}
	}
}
