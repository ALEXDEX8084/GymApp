namespace GymApp.Pages;

public partial class StepOnePage : ContentPage
{
	public StepOnePage()
	{
		InitializeComponent();
	}

    private void weightloss_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new StepTwoPage());
    }


}