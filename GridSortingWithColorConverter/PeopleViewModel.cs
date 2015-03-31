using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridSortingWithColorConverter
{
	public class PeopleViewModel
	{
		public ObservableCollection<Person> People { get; set; }

		public PeopleViewModel()
		{
			People = new ObservableCollection<Person>(
				new List<Person>
					{
						new Person() {Age = 5, Name = "Dan"},
						new Person() {Age = 25, Name = "Ana"},
						new Person() {Age = 65, Name = "Mike"}
					}
				);
		}
	}
}
