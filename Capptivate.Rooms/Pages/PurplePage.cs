using System;

using Xamarin.Forms;

namespace Capptivate.Rooms
{
	public class PurplePage : ContentPage
	{
		public PurplePage ()
		{
			BackgroundColor = Color.Purple;
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


