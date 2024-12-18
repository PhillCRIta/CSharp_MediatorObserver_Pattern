using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_MediatorAndObserver.UIFramework
{
	public class UIControl
	{
		//manmage our event handler
		//keep a list of event handlers used for update all UI Component
		private List<EventHandler> _eventHandlers = new List<EventHandler>();
		public void AddEventHandler(EventHandler eventHandler)
		{
			_eventHandlers.Add(eventHandler);
		}
		public void NotifyEventHandler()
		{
			foreach (EventHandler handler in _eventHandlers)
			{
				//every handler is a method, passed like a delegate (a method passed like a object)
				handler();
			}
		}
	}
}
