using Behavioral_MediatorAndObserver.UIFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_MediatorAndObserver
{
	internal class PostDialogBox
	{
		//this class now is a Mediator
		//contains the business logic for how ui should interact with each other ui
		//this class is also a Observer, wich recive notice whenever one UI Component changes
		private ListBox _postListBox;
		private TextBox _titleTextBox;
		private Button _saveButton;

		public PostDialogBox()
		{
			_postListBox = new ListBox();
			_titleTextBox = new TextBox();
			_saveButton = new Button();

			//add the necessary listener on every part of mediator pattern, with observer tecnique
			//every method is passed like a delegate
			//event handler parameter is a delegate
			//delegate is a way to pass a method like a ojbect
			_postListBox.AddEventHandler(handlePostChanged);
			_titleTextBox.AddEventHandler(handleTitleChange);
		}


		public void SimulateUserInteraction()
		{
			Console.WriteLine("I'm simulating post selection.");
			_postListBox.SetSelection("Post 2");
			HowsSituation();
			Console.WriteLine("---------------------------------------------I'm deleting title");
			_titleTextBox.SetText("");
			HowsSituation();
			Console.WriteLine("---------------------------------------------I've inserted new title");
			_titleTextBox.SetText("Hello Spank");
			HowsSituation();
		}
		private void HowsSituation()
		{
			Console.WriteLine("Title text box text: " + _titleTextBox.GetText());
			Console.WriteLine("Button enabled: " + _saveButton.IsEnabled());
		}

		private void handlePostChanged()
		{
			Console.WriteLine("##### chiamo list post change");
			_titleTextBox.SetText(_postListBox.GetSelection());
			_saveButton.SetEnabled(false);
		}
		private void handleTitleChange()
		{
			Console.WriteLine("##### chiamo title change");
			bool isTitleEmpty = String.IsNullOrEmpty(_titleTextBox.GetText());
			_saveButton.SetEnabled(!isTitleEmpty);
		}


	}
}
