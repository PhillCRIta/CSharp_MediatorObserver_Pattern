using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_MediatorAndObserver.UIFramework
{
	public class Button:UIControl
	{
		public bool _isEnabled;
		public bool IsEnabled()
		{
			return _isEnabled;
		}
		public void SetEnabled(bool enabled)
		{
			Console.WriteLine("******From the button, I have changed my status: " + enabled);
			_isEnabled = enabled;
			NotifyEventHandler();
		}
	}
}
