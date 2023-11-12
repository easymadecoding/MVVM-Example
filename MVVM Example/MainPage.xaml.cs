using MVVM_Example.ViewModels;

namespace MVVM_Example;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        BindingContext = new MainViewModel();
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
	}
}

public class Item
{
    public string Name { get; set; }
}