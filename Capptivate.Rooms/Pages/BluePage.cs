using System;

using Xamarin.Forms;

namespace Capptivate.Rooms
{
	public class BluePage : ContentPage
	{
		public BluePage ()
		{
			BackgroundColor = Color.Blue;
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


