using System;

using Xamarin.Forms;

namespace Capptivate.Rooms
{
	public class MainPage : CarouselPage
	{
		public MainPage ()
		{
			Children.Add (new PurplePage ());
			Children.Add (new TipsTricks ());
			Children.Add (new BluePage ());
		}
	}
}


