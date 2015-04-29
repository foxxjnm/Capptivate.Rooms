using System;

using Xamarin.Forms;

namespace Capptivate.Rooms
{
	public class TipsTricks : ContentPage
	{
		public TipsTricks ()
		{
			BackgroundColor = Color.Yellow;
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


