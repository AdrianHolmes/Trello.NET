using System.Collections.Generic;

namespace TrelloNet
{
	public class Checklist : IChecklistId
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string IdBoard { get; set; }

		public List<�tem> CheckItems { get; set; }

		public class �tem
		{
			public string Id { get; set; }
			public string Name { get; set; }
		}

		public override string ToString()
		{
			return Name;
		}

		public string GetChecklistId()
		{
			return Id;
		}
	}
}