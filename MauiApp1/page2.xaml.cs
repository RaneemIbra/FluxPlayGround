namespace MauiApp1;

public partial class page2 : ContentPage
{
	private int clicked = 0;
	public page2()
	{
		InitializeComponent();
	}

	private void Button2_OnClicked(object sender, EventArgs e)
	{
		clicked++;
		if (clicked == 2)
		{
			label1.IsVisible = true;
		}
	}
}