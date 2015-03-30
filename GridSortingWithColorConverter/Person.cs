using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GridSortingWithColorConverter
{
	public class NotifyPropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

	public class Person : NotifyPropertyChanged
	{
		private string _name;
		private int _age;

		public string Name
		{
			get { return _name; }
			set { _name = value;
			OnPropertyChanged();
			}
		}

		public int Age
		{
			get { return _age; }
			set { _age = value; 
			OnPropertyChanged();
			}
		}
	}
}
