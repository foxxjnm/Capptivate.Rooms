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

			// allow for iOS status bar
			settingsBar.Padding = new Thickness (0, 20, 0, 40);

			var settingButton = new Button {
				Image = "settings_filled-32.png",
				WidthRequest = 40
			};

			settingButton.TextColor = Color.Gray;

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
			createButton.TextColor = Color.Gray;

			var inviteButton = new Button ();
			inviteButton.Text = "Use Invite";
			inviteButton.TextColor = Color.Gray;

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
									new Frame
									{
										Padding = new Thickness(10,0,10,0),
										WidthRequest = 200,
										HeightRequest=320,
										BackgroundColor = Color.FromHex("6E35EA"),
										Content = new Label{
											Text = "",
											TextColor = Color.White
										}
									},
									new Frame
									{
										Padding = new Thickness(10,0,10,0),
										WidthRequest = 200,
										HeightRequest=320,
										BackgroundColor = Color.FromHex("D07B2B"),
										Content = new StackLayout
										{
											Children=
											{
												new Label
												{
													VerticalOptions = LayoutOptions.Center,
													Text = "Rooms Tips and Tricks",
													TextColor = Color.White,
													FontAttributes = FontAttributes.Bold
												},
												new Label
												{
													Text = "Get pro tips for how to use Rooms. Moderatred by members of the Rooms team.",
													TextColor = Color.White
												}
											}
										}
									},
									new Frame
									{
										Padding = new Thickness(10,0,10,0),
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

