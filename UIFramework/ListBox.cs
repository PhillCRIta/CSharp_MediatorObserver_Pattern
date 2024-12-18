using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_MediatorAndObserver.UIFramework
{
	public class ListBox : UIControl
	{

		private string _selection = "";
		 
		public string GetSelection()
		{
			return _selection;
		}
		public void SetSelection(string selection)
		{
			Console.WriteLine("From the list, I have new selection: " + selection);
			_selection = selection;
			NotifyEventHandler();
		}
	}
}
