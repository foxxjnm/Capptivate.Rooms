using System;

using Xamarin.Forms;

namespace Capptivate.Rooms
{
	public class App : Application
	{
		public App ()
		{
			var settingsBar = new AbsoluteLayout ();
			settingsBar.HorizontalOptions = LayoutOptions.FillAndExpand;
			settingsBar.HeightRequest = 32;
			// allow for iOS status bar
			settingsBar.Padding = new Thickness (0, 20, 0, 0);

			var settingButton = new Button {
				Image = "settings_filled-32.png"
			};

			AbsoluteLayout.SetLayoutFlags (settingButton,
				AbsoluteLayoutFlags.PositionProportional);

			AbsoluteLayout.SetLayoutBounds (settingButton,
				new Rectangle (1f,
					0f, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			settingsBar.Children.Add (settingButton);

			var bottomBar = new AbsoluteLayout ();
			bottomBar.HorizontalOptions = LayoutOptions.FillAndExpand;
			bottomBar.VerticalOptions = LayoutOptions.FillAndExpand;
			bottomBar.Padding = new Thickness (0, 40, 0, 0);

			var createButton = new Button ();
			createButton.Text = "Create Room";

			var inviteButton = new Button ();
			inviteButton.Text = "Use Invite";

			AbsoluteLayout.SetLayoutFlags (createButton, AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutFlags (inviteButton, AbsoluteLayoutFlags.PositionProportional);

			AbsoluteLayout.SetLayoutBounds (createButton,
				new Rectangle (0f,
					1f, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
			AbsoluteLayout.SetLayoutBounds (inviteButton,
				new Rectangle (1f,
					1f, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			bottomBar.Padding = new Thickness (5, 0, 5, 0);
			bottomBar.Children.Add (createButton);
			bottomBar.Children.Add (inviteButton);

			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout
				{
					Children = 
					{
						settingsBar,
						new ScrollView
						{
							Orientation = ScrollOrientation.Horizontal,
							Content = new StackLayout
							{
								Orientation = StackOrientation.Horizontal,
								Children = 
								{
									new BoxView
									{
										WidthRequest = 200,
										HeightRequest=320,
										BackgroundColor = Color.FromHex("6E35EA")
									},
									new BoxView
									{
										WidthRequest = 200,
										HeightRequest=320,
										BackgroundColor = Color.FromHex("D07B2B")
									},
									new BoxView
									{
										WidthRequest = 200,
										HeightRequest=320,
										BackgroundColor = Color.FromHex("3C97C9")
									}
								}
							}
						},
						bottomBar
					}
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

