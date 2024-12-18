using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_MediatorAndObserver.UIFramework
{
	public class TextBox:UIControl
	{
		public string _text = "";
		public string GetText() => _text;
		public void SetText(string text)
		{
			Console.WriteLine("From the textbox, I've new text in the editor: " + text);
			_text = text;
			NotifyEventHandler();
		}
	}
}
