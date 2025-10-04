using Login;

namespace PrivateContacts
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void SubmitBtn(object? sender, EventArgs e)
		{
			ProtonLogin login = new ProtonLogin();
			login.Login(usernameEntry.Text, passwordEntry.Text, twofaEntry.Text);
		}
	}
}
