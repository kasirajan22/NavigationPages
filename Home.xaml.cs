namespace NavigationPages;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

	private void goToProduct_Click(object sender, EventArgs e){
		Navigation.PushAsync(new Product());
	}
}