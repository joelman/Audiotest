using AudioManager;
using Xamarin.Forms;

namespace Audiotest
{
	public partial class AudiotestPage : ContentPage
	{
		void Handle_Clicked(object sender, System.EventArgs e)
		{
			// it would be nice if this threw an exception instead of failing silently
			// Audio.Manager.PlaySound("nonexistent.mp3");

			// doesn't play when first clicked on Android
			Audio.Manager.PlaySound("tada.mp3");
		}

		public AudiotestPage()
		{
			InitializeComponent();
		}
	}
}
