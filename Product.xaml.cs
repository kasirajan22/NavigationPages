namespace NavigationPages;

public partial class Product : ContentPage
{
	public Product()
	{
		InitializeComponent();
	}

	private void goToProductDetails_Click(object sender, EventArgs e){
		Navigation.PushAsync(new ProductDetails());
	}
}